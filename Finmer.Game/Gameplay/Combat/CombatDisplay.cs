﻿/*
 * FINMER - Interactive Text Adventure
 * Copyright (C) 2019-2021 Nuntis the Wolf.
 *
 * Licensed under the GNU General Public License v3.0 (GPL3). See LICENSE.md for details.
 * SPDX-License-Identifier: GPL-3.0-only
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Finmer.Models;
using Finmer.Utility;
using Finmer.ViewModels;

namespace Finmer.Gameplay.Combat
{

    /// <summary>
    /// Utilities for displaying combat state to the user.
    /// </summary>
    /// <remarks>
    /// All functions in this class are blocking, meaning they are expected to run from another thread than the UI thread, and will block
    /// execution on this subthread until relevant animations and display logic has finished playing.
    /// </remarks>
    public static class CombatDisplay
    {

        /// <summary>
        /// Describes the type of resolve animation to show.
        /// </summary>
        public enum EResolveType
        {
            Attack,
            Grapple,
            Vore
        }

        /// <summary>
        /// Represents a single round of dice rolls.
        /// </summary>
        public struct ResolveRound
        {

            /// <summary>
            /// The total dice value rolled by the action instigator.
            /// </summary>
            public int OffenseTotal { get; set; }

            /// <summary>
            /// The total dice value rolled by the action target.
            /// </summary>
            public int DefenseTotal { get; set; }

            /// <summary>
            /// The number of previous rounds that have been won by the action instigator.
            /// </summary>
            public int OffenseRoundsWon { get; set; }

            /// <summary>
            /// The number of previous rounds that have been won by the action target.
            /// </summary>
            public int DefenseRoundsWon { get; set; }

            /// <summary>
            /// The specific collection of dice that have been rolled by the action instigator.
            /// </summary>
            public List<EDieFace> OffenseDice { get; set; }

            /// <summary>
            /// The specific collection of dice that have been rolled by the action target.
            /// </summary>
            public List<EDieFace> DefenseDice { get; set; }

        }

        /// <summary>
        /// Contains settings for the combat resolve display.
        /// </summary>
        public struct ResolveInfo
        {

            /// <summary>
            /// The character on the left.
            /// </summary>
            public Participant Instigator { get; set; }

            /// <summary>
            /// The character on the right.
            /// </summary>
            public Participant Target { get; set; }

            /// <summary>
            /// The type of combat action that is being performed. Determines which words are shown on the UI.
            /// </summary>
            public EResolveType Action { get; set; }

            /// <summary>
            /// Collection of individual groups of rolled dice to display.
            /// </summary>
            public List<ResolveRound> Rounds { get; set; }

            /// <summary>
            /// The string table key to resolve and log to the game window.
            /// </summary>
            public string LogKey { get; set; }

        }

        /// <summary>
        /// Show UI for the combat system.
        /// </summary>
        /// <param name="session">The combat session to be displayed in UI.</param>
        public static void OpenCombatUI(CombatSession session)
        {
            // Prepare a new viewmodel that encapsulates combat state
            var vm = new CombatStateViewModel();
            foreach (var participant in session.Participants)
                vm.Participants.Add(new CombatParticipantViewModel(participant));

            Debug.Assert(GameUI.Instance.CombatStateViewModel == null);
            GameUI.Instance.CombatStateViewModel = vm;
            GameUI.Instance.IsInCombat = true;
        }

        /// <summary>
        /// Hide UI for the combat system.
        /// </summary>
        public static void CloseCombatUI()
        {
            // Close the combat UI
            GameUI.Instance.IsInCombat = false;

            // Wait for the closing animation to finish playing
            // Keep duration in sync with exit animation begin time + duration (in CombatantPanelView.xaml).
            Thread.Sleep(1650);

            // Delete the combat state viewmodel, which will also release the participant viewmodels etc.
            // This must be done after the animation finishes because otherwise the participant list is wiped while on-screen, which looks bad.
            GameUI.Instance.CombatStateViewModel = null;
        }

        /// <summary>
        /// Animates two sets of rolled dice.
        /// </summary>
        public static void ShowRoundResolve(ResolveInfo settings)
        {
            // Prepare the contents of the viewmodel
            CombatResolveViewModel vm = new CombatResolveViewModel();
            GameUI.Instance.CombatStateViewModel.CombatResolveViewModel = vm;

            for (int i = 0; i < settings.Rounds.Count; i++)
            {
                // Display this round
                vm.SetRound(settings, i);

                // Wait for dice animation, then fade out
                int sleep_time = settings.Rounds.Count > 1 ? 2000 : 2500;
                Thread.Sleep(sleep_time);
            }

            // Print text to game log
            WriteCombatLog(settings.LogKey, settings.Instigator, settings.Target);

            // Wait for fade-out animation
            vm.AnimationState = CombatResolveViewModel.EPanelState.FadeOut;
            Thread.Sleep(500);
            GameUI.Instance.CombatStateViewModel.CombatResolveViewModel = null;
        }

        /// <summary>
        /// Animates a simple message.
        /// </summary>
        public static void ShowSimpleMessage(string logKey, Participant instigator)
        {
            // Print the requested text
            WriteCombatLog(logKey, instigator);

            // Wait a bit since this text simulates an action of some sort
            Thread.Sleep(500);
        }

        /// <summary>
        /// Animates a simple message.
        /// </summary>
        public static void ShowSimpleMessage(string logKey, Participant instigator, Participant target)
        {
            // Print the requested text
            WriteCombatLog(logKey, instigator, target);

            // Wait a bit since this text simulates an action of some sort
            Thread.Sleep(500);
        }

        private static void WriteCombatLog(string key, Participant instigator, Participant target)
        {
            TextParser.SetContext("attacker", instigator.Character, false);
            TextParser.SetContext("predator", instigator.Character, false);
            TextParser.SetContext("defender", target.Character, false);
            TextParser.SetContext("prey", target.Character, false);

            string text = instigator.Character.GetRandomString(key, target.Character);
            GameUI.Instance.Log(text, Theme.LogColorDefault);
        }

        private static void WriteCombatLog(string key, Participant instigator)
        {
            TextParser.SetContext("instigator", instigator.Character, false);

            string text = instigator.Character.GetRandomString(key, instigator.Character);
            GameUI.Instance.Log(text, Theme.LogColorDefault);
        }

    }

}
