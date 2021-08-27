﻿/*
 * FINMER - Interactive Text Adventure
 * Copyright (C) 2019-2021 Nuntis the Wolf.
 *
 * Licensed under the GNU General Public License v3.0 (GPL3). See LICENSE.md for details.
 * SPDX-License-Identifier: GPL-3.0-only
 */

using System;
using System.Diagnostics;
using static Finmer.Gameplay.Scripting.LuaApi;

namespace Finmer.Gameplay.Scripting
{

    /// <summary>
    /// Manages a collection of callbacks to user code. Callbacks can be supplied by script, and then invoked from C# code by name.
    /// </summary>
    public class ScriptCallbackTable
    {

        private const string k_CallbackTable = "ScriptCallbackTables";

        private readonly ScriptContext m_Context;
        private readonly int m_TableRef;

        public ScriptCallbackTable(ScriptContext context)
        {
            m_Context = context;

            // Generate an empty table where we can store the callbacks
            // TODO: This table is never unref'd and therefore will never be collected. This class must have a finalizer of some kind.
            IntPtr state = m_Context.LuaState;
            luaL_newmetatable(state, k_CallbackTable);
            lua_newtable(state);
            m_TableRef = luaL_ref(state, -2);
            lua_pop(state, 1);
        }

        /// <summary>
        /// Pop and attach the function at the top of the input Lua stack to the specified name.
        /// </summary>
        public void Bind(IntPtr stack, string name)
        {
            Debug.Assert(lua_gettop(stack) > 0, "Stack is empty");
            Debug.Assert(lua_isfunction(stack, -1), "Stack top must be a function");

            // Push the callback table below the function object
            PushCallbackTable(stack);
            lua_insert(stack, -2);

            // Bind the name to the function
            lua_setfield(stack, -2, name);

            // Cleanup
            lua_pop(stack, 1);
        }

        /// <summary>
        /// Remove the binding from the specified name to any function it may have been referencing.
        /// </summary>
        public void Unbind(string name)
        {
            IntPtr stack = m_Context.LuaState;

            // Assign nil to the name, so the function can be GC'd
            PushCallbackTable(stack);
            lua_pushnil(stack);
            lua_setfield(stack, -2, name);

            // Cleanup
            lua_pop(stack, 1);
        }

        /// <summary>
        /// Find the callback associated with the specified name. Returns true if available, false if not.
        /// </summary>
        public bool PrepareCall(IntPtr stack, string name)
        {
            // Retrieve the function from the callback table
            PushCallbackTable(stack);
            lua_getfield(stack, -1, name);
            lua_remove(stack, -2); // pop global table

            // If it's not a function (probably nil / unassigned), pop the bad value
            if (lua_type(stack, -1) != ELuaType.Function)
            {
                lua_pop(stack, 1);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Invokes a function prepared by PrepareCall(), passing the specified number of user arguments to the function.
        /// </summary>
        public void Call(IntPtr stack, int numArgs)
        {
            Debug.Assert(lua_type(stack, -1 - numArgs) == ELuaType.Function, "Call PrepareCall first, and check that it returned 'true'");

            // The stack has already been prepared, so perform the call
            m_Context.RunProtectedCall(stack, numArgs, 0);
        }

        /// <summary>
        /// Helper for retrieving the local callback table from the registry.
        /// </summary>
        private void PushCallbackTable(IntPtr stack)
        {
            luaL_newmetatable(stack, k_CallbackTable);
            lua_rawgeti(stack, -1, m_TableRef);
            lua_remove(stack, -2);
        }

    }

}
