﻿/*
 * FINMER - Interactive Text Adventure
 * Copyright (C) 2019-2022 Nuntis the Wolf.
 *
 * Licensed under the GNU General Public License v3.0 (GPL3). See LICENSE.md for details.
 * SPDX-License-Identifier: GPL-3.0-only
 */

using System.Text;

namespace Finmer.Core.VisualScripting.Nodes
{

    /// <summary>
    /// Script value that returns the player character name.
    /// </summary>
    public sealed class ValuePlayerName : ScriptValue
    {

        public override string GetEditorDescription()
        {
            return "Player Name";
        }

        public override void EmitLua(StringBuilder output)
        {
            output.Append("Player.Name");
        }

    }

}
