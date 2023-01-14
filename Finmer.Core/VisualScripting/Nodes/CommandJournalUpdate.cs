﻿/*
 * FINMER - Interactive Text Adventure
 * Copyright (C) 2019-2023 Nuntis the Wolf.
 *
 * Licensed under the GNU General Public License v3.0 (GPL3). See LICENSE.md for details.
 * SPDX-License-Identifier: GPL-3.0-only
 */

using System;
using System.Globalization;
using System.Text;
using Finmer.Core.Assets;
using Finmer.Core.Serialization;

namespace Finmer.Core.VisualScripting.Nodes
{

    /// <summary>
    /// Command that adds or updates a quest in the journal.
    /// </summary>
    public sealed class CommandJournalUpdate : ScriptCommand
    {

        /// <summary>
        /// Describes the journal group to modify.
        /// </summary>
        public Guid JournalGuid { get; set; } = Guid.Empty;

        /// <summary>
        /// The stage number to set the journal to.
        /// </summary>
        public int Stage { get; set; }

        public override string GetEditorDescription(IContentStore content)
        {
            // Resolve the journal UUID to obtain its name. Note that the link may be unresolved.
            AssetJournal journal = content.GetAssetByID<AssetJournal>(JournalGuid);
            string journal_name = journal?.Name ?? JournalGuid.ToString();

            return $"Update Quest '{journal_name}' to Stage {Stage}";
        }

        public override EColor GetEditorColor()
        {
            return EColor.Journal;
        }

        public override void EmitLua(StringBuilder output, IContentStore content)
        {
            // Resolve the journal asset GUID
            var journal = content.GetAssetByID<AssetJournal>(JournalGuid);
            if (journal == null)
                throw new InvalidScriptNodeException($"Could not find Journal asset with ID {JournalGuid}");

            // Emit command
            output.AppendFormat(CultureInfo.InvariantCulture, "Journal.Update(\"{0}\", {1})", journal.Name, Stage);
            output.AppendLine();
        }

        public override void Serialize(IFurballContentWriter outstream)
        {
            outstream.WriteGuidProperty(nameof(JournalGuid), JournalGuid);
            outstream.WriteInt32Property(nameof(Stage), Stage);
        }


        public override void Deserialize(IFurballContentReader instream, int version)
        {
            JournalGuid = instream.ReadGuidProperty(nameof(JournalGuid));
            Stage = instream.ReadInt32Property(nameof(Stage));
        }

    }

}
