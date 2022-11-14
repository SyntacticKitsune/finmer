﻿namespace Finmer.Editor
{
	partial class FormDocumentScene
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblNodeTooltip;
            System.Windows.Forms.Label lblNodeTitle;
            System.Windows.Forms.Label lblInjectTargetNode;
            System.Windows.Forms.Label lblInjectTargetScene;
            System.Windows.Forms.Label lblRootInfo;
            System.Windows.Forms.Label lblNodeKey;
            System.Windows.Forms.Label lblLinkTarget;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocumentScene));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbAddNode = new System.Windows.Forms.ToolStripButton();
            this.tsbAddLink = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveNode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScriptCustom = new System.Windows.Forms.ToolStripButton();
            this.tsbScriptEnter = new System.Windows.Forms.ToolStripButton();
            this.tsbScriptLeave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExpand = new System.Windows.Forms.ToolStripButton();
            this.tsbCollapse = new System.Windows.Forms.ToolStripButton();
            this.splitNodeList = new System.Windows.Forms.SplitContainer();
            this.trvNodes = new System.Windows.Forms.TreeView();
            this.imlNodeIcons = new System.Windows.Forms.ImageList(this.components);
            this.splitNodeSettings = new System.Windows.Forms.SplitContainer();
            this.tbcNode = new System.Windows.Forms.TabControl();
            this.tbpNodeRoot = new System.Windows.Forms.TabPage();
            this.pnlInjectionSettings = new System.Windows.Forms.Panel();
            this.assetInjectTargetScene = new Finmer.Editor.AssetPickerControl();
            this.cmbInjectTargetMode = new System.Windows.Forms.ComboBox();
            this.cmbInjectTargetNode = new System.Windows.Forms.ComboBox();
            this.chkRootInject = new System.Windows.Forms.CheckBox();
            this.tbpNodeState = new System.Windows.Forms.TabPage();
            this.txtNodeStateKey = new System.Windows.Forms.TextBox();
            this.tbpNodeChoice = new System.Windows.Forms.TabPage();
            this.nudChoiceCustomWidth = new System.Windows.Forms.NumericUpDown();
            this.chkChoiceHighlight = new System.Windows.Forms.CheckBox();
            this.chkChoiceCustomWidth = new System.Windows.Forms.CheckBox();
            this.txtNodeChoiceKey = new System.Windows.Forms.TextBox();
            this.txtNodeChoiceTitle = new System.Windows.Forms.TextBox();
            this.txtNodeChoiceTooltip = new System.Windows.Forms.TextBox();
            this.tbpNodeLink = new System.Windows.Forms.TabPage();
            this.cmbLinkTarget = new System.Windows.Forms.ComboBox();
            this.tbpNodeCompass = new System.Windows.Forms.TabPage();
            this.tbcScripts = new System.Windows.Forms.TabControl();
            this.tbpScriptAction = new System.Windows.Forms.TabPage();
            this.scriptAction = new Finmer.Editor.ScriptEditorHost();
            this.tbpScriptAppear = new System.Windows.Forms.TabPage();
            this.scriptAppear = new Finmer.Editor.ScriptEditorHost();
            lblNodeTooltip = new System.Windows.Forms.Label();
            lblNodeTitle = new System.Windows.Forms.Label();
            lblInjectTargetNode = new System.Windows.Forms.Label();
            lblInjectTargetScene = new System.Windows.Forms.Label();
            lblRootInfo = new System.Windows.Forms.Label();
            lblNodeKey = new System.Windows.Forms.Label();
            lblLinkTarget = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitNodeList)).BeginInit();
            this.splitNodeList.Panel1.SuspendLayout();
            this.splitNodeList.Panel2.SuspendLayout();
            this.splitNodeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitNodeSettings)).BeginInit();
            this.splitNodeSettings.Panel1.SuspendLayout();
            this.splitNodeSettings.Panel2.SuspendLayout();
            this.splitNodeSettings.SuspendLayout();
            this.tbcNode.SuspendLayout();
            this.tbpNodeRoot.SuspendLayout();
            this.pnlInjectionSettings.SuspendLayout();
            this.tbpNodeState.SuspendLayout();
            this.tbpNodeChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChoiceCustomWidth)).BeginInit();
            this.tbpNodeLink.SuspendLayout();
            this.tbcScripts.SuspendLayout();
            this.tbpScriptAction.SuspendLayout();
            this.tbpScriptAppear.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNodeTooltip
            // 
            lblNodeTooltip.AutoSize = true;
            lblNodeTooltip.Location = new System.Drawing.Point(8, 104);
            lblNodeTooltip.Name = "lblNodeTooltip";
            lblNodeTooltip.Size = new System.Drawing.Size(42, 13);
            lblNodeTooltip.TabIndex = 5;
            lblNodeTooltip.Text = "Tooltip:";
            // 
            // lblNodeTitle
            // 
            lblNodeTitle.AutoSize = true;
            lblNodeTitle.Location = new System.Drawing.Point(8, 56);
            lblNodeTitle.Name = "lblNodeTitle";
            lblNodeTitle.Size = new System.Drawing.Size(65, 13);
            lblNodeTitle.TabIndex = 8;
            lblNodeTitle.Text = "Button Text:";
            // 
            // lblInjectTargetNode
            // 
            lblInjectTargetNode.AutoSize = true;
            lblInjectTargetNode.Location = new System.Drawing.Point(0, 56);
            lblInjectTargetNode.Name = "lblInjectTargetNode";
            lblInjectTargetNode.Size = new System.Drawing.Size(77, 13);
            lblInjectTargetNode.TabIndex = 4;
            lblInjectTargetNode.Text = "Injection Point:";
            // 
            // lblInjectTargetScene
            // 
            lblInjectTargetScene.AutoSize = true;
            lblInjectTargetScene.Location = new System.Drawing.Point(0, 8);
            lblInjectTargetScene.Name = "lblInjectTargetScene";
            lblInjectTargetScene.Size = new System.Drawing.Size(75, 13);
            lblInjectTargetScene.TabIndex = 2;
            lblInjectTargetScene.Text = "Target Scene:";
            // 
            // lblRootInfo
            // 
            lblRootInfo.Enabled = false;
            lblRootInfo.Location = new System.Drawing.Point(8, 8);
            lblRootInfo.Name = "lblRootInfo";
            lblRootInfo.Size = new System.Drawing.Size(192, 32);
            lblRootInfo.TabIndex = 4;
            lblRootInfo.Text = "The Root node is the starting point of the scene and can\'t be edited directly.";
            // 
            // lblNodeKey
            // 
            lblNodeKey.AutoSize = true;
            lblNodeKey.Location = new System.Drawing.Point(8, 8);
            lblNodeKey.Name = "lblNodeKey";
            lblNodeKey.Size = new System.Drawing.Size(65, 13);
            lblNodeKey.TabIndex = 7;
            lblNodeKey.Text = "Unique Key:";
            // 
            // lblLinkTarget
            // 
            lblLinkTarget.AutoSize = true;
            lblLinkTarget.Location = new System.Drawing.Point(8, 8);
            lblLinkTarget.Name = "lblLinkTarget";
            lblLinkTarget.Size = new System.Drawing.Size(93, 13);
            lblLinkTarget.TabIndex = 2;
            lblLinkTarget.Text = "Link Target Node:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 13);
            label1.TabIndex = 9;
            label1.Text = "Unique Key:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNode,
            this.tsbAddLink,
            this.tsbRemoveNode,
            this.toolStripSeparator1,
            this.tsbMoveUp,
            this.tsbMoveDown,
            this.toolStripSeparator3,
            this.tsbScriptCustom,
            this.tsbScriptEnter,
            this.tsbScriptLeave,
            this.toolStripSeparator2,
            this.tsbExpand,
            this.tsbCollapse});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(688, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbAddNode
            // 
            this.tsbAddNode.Image = global::Finmer.Editor.Properties.Resources.plus;
            this.tsbAddNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNode.Name = "tsbAddNode";
            this.tsbAddNode.Size = new System.Drawing.Size(81, 22);
            this.tsbAddNode.Text = "Add Node";
            this.tsbAddNode.Click += new System.EventHandler(this.tsbAddNode_Click);
            // 
            // tsbAddLink
            // 
            this.tsbAddLink.Image = global::Finmer.Editor.Properties.Resources.chain;
            this.tsbAddLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddLink.Name = "tsbAddLink";
            this.tsbAddLink.Size = new System.Drawing.Size(74, 22);
            this.tsbAddLink.Text = "Add Link";
            this.tsbAddLink.Click += new System.EventHandler(this.tsbAddLink_Click);
            // 
            // tsbRemoveNode
            // 
            this.tsbRemoveNode.Image = global::Finmer.Editor.Properties.Resources.minus;
            this.tsbRemoveNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveNode.Name = "tsbRemoveNode";
            this.tsbRemoveNode.Size = new System.Drawing.Size(102, 22);
            this.tsbRemoveNode.Text = "Remove Node";
            this.tsbRemoveNode.Click += new System.EventHandler(this.tsbRemoveNode_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbMoveUp
            // 
            this.tsbMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveUp.Image = global::Finmer.Editor.Properties.Resources.arrow_090;
            this.tsbMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveUp.Name = "tsbMoveUp";
            this.tsbMoveUp.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveUp.Text = "Move Up";
            this.tsbMoveUp.Click += new System.EventHandler(this.tsbMoveUp_Click);
            // 
            // tsbMoveDown
            // 
            this.tsbMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveDown.Image = global::Finmer.Editor.Properties.Resources.arrow_270;
            this.tsbMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveDown.Name = "tsbMoveDown";
            this.tsbMoveDown.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveDown.Text = "Move Down";
            this.tsbMoveDown.Click += new System.EventHandler(this.tsbMoveDown_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbScriptCustom
            // 
            this.tsbScriptCustom.AutoToolTip = false;
            this.tsbScriptCustom.Image = global::Finmer.Editor.Properties.Resources.script_code;
            this.tsbScriptCustom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScriptCustom.Name = "tsbScriptCustom";
            this.tsbScriptCustom.Size = new System.Drawing.Size(102, 22);
            this.tsbScriptCustom.Text = "Custom Script";
            this.tsbScriptCustom.ToolTipText = "Edit Custom Scene Script Header";
            this.tsbScriptCustom.Click += new System.EventHandler(this.tsbScriptCustom_Click);
            // 
            // tsbScriptEnter
            // 
            this.tsbScriptEnter.AutoToolTip = false;
            this.tsbScriptEnter.Image = global::Finmer.Editor.Properties.Resources.script_code;
            this.tsbScriptEnter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScriptEnter.Name = "tsbScriptEnter";
            this.tsbScriptEnter.Size = new System.Drawing.Size(87, 22);
            this.tsbScriptEnter.Text = "Enter Script";
            this.tsbScriptEnter.ToolTipText = "Edit Scene Enter Script";
            this.tsbScriptEnter.Click += new System.EventHandler(this.tsbScriptEnter_Click);
            // 
            // tsbScriptLeave
            // 
            this.tsbScriptLeave.AutoToolTip = false;
            this.tsbScriptLeave.Image = global::Finmer.Editor.Properties.Resources.script_code;
            this.tsbScriptLeave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScriptLeave.Name = "tsbScriptLeave";
            this.tsbScriptLeave.Size = new System.Drawing.Size(90, 22);
            this.tsbScriptLeave.Text = "Leave Script";
            this.tsbScriptLeave.ToolTipText = "Edit Scene Leave Script";
            this.tsbScriptLeave.Click += new System.EventHandler(this.tsbScriptLeave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExpand
            // 
            this.tsbExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExpand.Image = global::Finmer.Editor.Properties.Resources.arrow_out;
            this.tsbExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExpand.Name = "tsbExpand";
            this.tsbExpand.Size = new System.Drawing.Size(23, 22);
            this.tsbExpand.Text = "Expand All";
            this.tsbExpand.Click += new System.EventHandler(this.tsbExpand_Click);
            // 
            // tsbCollapse
            // 
            this.tsbCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCollapse.Image = global::Finmer.Editor.Properties.Resources.arrow_in;
            this.tsbCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCollapse.Name = "tsbCollapse";
            this.tsbCollapse.Size = new System.Drawing.Size(23, 22);
            this.tsbCollapse.Text = "Collapse All";
            this.tsbCollapse.Click += new System.EventHandler(this.tsbCollapse_Click);
            // 
            // splitNodeList
            // 
            this.splitNodeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitNodeList.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitNodeList.Location = new System.Drawing.Point(0, 25);
            this.splitNodeList.Name = "splitNodeList";
            this.splitNodeList.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitNodeList.Panel1
            // 
            this.splitNodeList.Panel1.Controls.Add(this.trvNodes);
            // 
            // splitNodeList.Panel2
            // 
            this.splitNodeList.Panel2.Controls.Add(this.splitNodeSettings);
            this.splitNodeList.Size = new System.Drawing.Size(688, 526);
            this.splitNodeList.SplitterDistance = 254;
            this.splitNodeList.TabIndex = 1;
            // 
            // trvNodes
            // 
            this.trvNodes.AllowDrop = true;
            this.trvNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvNodes.HideSelection = false;
            this.trvNodes.ImageIndex = 0;
            this.trvNodes.ImageList = this.imlNodeIcons;
            this.trvNodes.Location = new System.Drawing.Point(0, 0);
            this.trvNodes.Name = "trvNodes";
            this.trvNodes.SelectedImageIndex = 0;
            this.trvNodes.Size = new System.Drawing.Size(688, 254);
            this.trvNodes.TabIndex = 0;
            this.trvNodes.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvNodes_ItemDrag);
            this.trvNodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvNodes_AfterSelect);
            this.trvNodes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvNodes_NodeMouseDoubleClick);
            this.trvNodes.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvNodes_DragDrop);
            this.trvNodes.DragOver += new System.Windows.Forms.DragEventHandler(this.trvNodes_DragOver);
            // 
            // imlNodeIcons
            // 
            this.imlNodeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlNodeIcons.ImageStream")));
            this.imlNodeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlNodeIcons.Images.SetKeyName(0, "node-link");
            this.imlNodeIcons.Images.SetKeyName(1, "node-option");
            this.imlNodeIcons.Images.SetKeyName(2, "node-option-alt");
            this.imlNodeIcons.Images.SetKeyName(3, "node-root");
            this.imlNodeIcons.Images.SetKeyName(4, "node-state");
            this.imlNodeIcons.Images.SetKeyName(5, "node-state-alt");
            // 
            // splitNodeSettings
            // 
            this.splitNodeSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitNodeSettings.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitNodeSettings.IsSplitterFixed = true;
            this.splitNodeSettings.Location = new System.Drawing.Point(0, 0);
            this.splitNodeSettings.Name = "splitNodeSettings";
            // 
            // splitNodeSettings.Panel1
            // 
            this.splitNodeSettings.Panel1.Controls.Add(this.tbcNode);
            // 
            // splitNodeSettings.Panel2
            // 
            this.splitNodeSettings.Panel2.Controls.Add(this.tbcScripts);
            this.splitNodeSettings.Size = new System.Drawing.Size(688, 268);
            this.splitNodeSettings.SplitterDistance = 218;
            this.splitNodeSettings.TabIndex = 0;
            this.splitNodeSettings.Visible = false;
            // 
            // tbcNode
            // 
            this.tbcNode.Controls.Add(this.tbpNodeRoot);
            this.tbcNode.Controls.Add(this.tbpNodeState);
            this.tbcNode.Controls.Add(this.tbpNodeChoice);
            this.tbcNode.Controls.Add(this.tbpNodeLink);
            this.tbcNode.Controls.Add(this.tbpNodeCompass);
            this.tbcNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcNode.Location = new System.Drawing.Point(0, 0);
            this.tbcNode.Name = "tbcNode";
            this.tbcNode.SelectedIndex = 0;
            this.tbcNode.Size = new System.Drawing.Size(218, 268);
            this.tbcNode.TabIndex = 1;
            // 
            // tbpNodeRoot
            // 
            this.tbpNodeRoot.Controls.Add(this.pnlInjectionSettings);
            this.tbpNodeRoot.Controls.Add(this.chkRootInject);
            this.tbpNodeRoot.Controls.Add(lblRootInfo);
            this.tbpNodeRoot.Location = new System.Drawing.Point(4, 22);
            this.tbpNodeRoot.Name = "tbpNodeRoot";
            this.tbpNodeRoot.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNodeRoot.Size = new System.Drawing.Size(210, 242);
            this.tbpNodeRoot.TabIndex = 0;
            this.tbpNodeRoot.Text = "Root Node";
            this.tbpNodeRoot.UseVisualStyleBackColor = true;
            // 
            // pnlInjectionSettings
            // 
            this.pnlInjectionSettings.Controls.Add(this.assetInjectTargetScene);
            this.pnlInjectionSettings.Controls.Add(this.cmbInjectTargetMode);
            this.pnlInjectionSettings.Controls.Add(this.cmbInjectTargetNode);
            this.pnlInjectionSettings.Controls.Add(lblInjectTargetNode);
            this.pnlInjectionSettings.Controls.Add(lblInjectTargetScene);
            this.pnlInjectionSettings.Location = new System.Drawing.Point(8, 72);
            this.pnlInjectionSettings.Name = "pnlInjectionSettings";
            this.pnlInjectionSettings.Size = new System.Drawing.Size(184, 152);
            this.pnlInjectionSettings.TabIndex = 6;
            this.pnlInjectionSettings.Visible = false;
            // 
            // assetInjectTargetScene
            // 
            this.assetInjectTargetScene.AssetType = Finmer.Editor.AssetPickerControl.EPickerType.Scene;
            this.assetInjectTargetScene.Location = new System.Drawing.Point(0, 24);
            this.assetInjectTargetScene.Name = "assetInjectTargetScene";
            this.assetInjectTargetScene.SelectedGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.assetInjectTargetScene.Size = new System.Drawing.Size(184, 24);
            this.assetInjectTargetScene.TabIndex = 3;
            this.assetInjectTargetScene.SelectedAssetChanged += new System.EventHandler(this.assetInjectTargetScene_SelectedAssetChanged);
            // 
            // cmbInjectTargetMode
            // 
            this.cmbInjectTargetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInjectTargetMode.FormattingEnabled = true;
            this.cmbInjectTargetMode.Items.AddRange(new object[] {
            "before (as States)",
            "after (as States)",
            "inside, at the start (as Choices)",
            "inside, at the end (as Choices)"});
            this.cmbInjectTargetMode.Location = new System.Drawing.Point(0, 72);
            this.cmbInjectTargetMode.Name = "cmbInjectTargetMode";
            this.cmbInjectTargetMode.Size = new System.Drawing.Size(184, 21);
            this.cmbInjectTargetMode.TabIndex = 4;
            this.cmbInjectTargetMode.SelectedIndexChanged += new System.EventHandler(this.cmbInjectTargetMode_SelectedIndexChanged);
            // 
            // cmbInjectTargetNode
            // 
            this.cmbInjectTargetNode.FormattingEnabled = true;
            this.cmbInjectTargetNode.Location = new System.Drawing.Point(0, 96);
            this.cmbInjectTargetNode.Name = "cmbInjectTargetNode";
            this.cmbInjectTargetNode.Size = new System.Drawing.Size(184, 21);
            this.cmbInjectTargetNode.TabIndex = 5;
            this.cmbInjectTargetNode.TextChanged += new System.EventHandler(this.cmbInjectTargetNode_TextChanged);
            // 
            // chkRootInject
            // 
            this.chkRootInject.AutoSize = true;
            this.chkRootInject.Location = new System.Drawing.Point(8, 48);
            this.chkRootInject.Name = "chkRootInject";
            this.chkRootInject.Size = new System.Drawing.Size(65, 17);
            this.chkRootInject.TabIndex = 5;
            this.chkRootInject.Text = "Is Patch";
            this.chkRootInject.UseVisualStyleBackColor = true;
            this.chkRootInject.CheckedChanged += new System.EventHandler(this.chkRootInject_CheckedChanged);
            // 
            // tbpNodeState
            // 
            this.tbpNodeState.Controls.Add(lblNodeKey);
            this.tbpNodeState.Controls.Add(this.txtNodeStateKey);
            this.tbpNodeState.Location = new System.Drawing.Point(4, 22);
            this.tbpNodeState.Name = "tbpNodeState";
            this.tbpNodeState.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNodeState.Size = new System.Drawing.Size(210, 242);
            this.tbpNodeState.TabIndex = 1;
            this.tbpNodeState.Text = "State Node";
            this.tbpNodeState.UseVisualStyleBackColor = true;
            // 
            // txtNodeStateKey
            // 
            this.txtNodeStateKey.Location = new System.Drawing.Point(8, 24);
            this.txtNodeStateKey.MaxLength = 20;
            this.txtNodeStateKey.Name = "txtNodeStateKey";
            this.txtNodeStateKey.Size = new System.Drawing.Size(192, 20);
            this.txtNodeStateKey.TabIndex = 2;
            this.txtNodeStateKey.TextChanged += new System.EventHandler(this.txtNodeKey_TextChanged);
            this.txtNodeStateKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNodeKey_KeyPress);
            // 
            // tbpNodeChoice
            // 
            this.tbpNodeChoice.Controls.Add(this.nudChoiceCustomWidth);
            this.tbpNodeChoice.Controls.Add(this.chkChoiceHighlight);
            this.tbpNodeChoice.Controls.Add(label1);
            this.tbpNodeChoice.Controls.Add(this.chkChoiceCustomWidth);
            this.tbpNodeChoice.Controls.Add(this.txtNodeChoiceKey);
            this.tbpNodeChoice.Controls.Add(this.txtNodeChoiceTitle);
            this.tbpNodeChoice.Controls.Add(lblNodeTitle);
            this.tbpNodeChoice.Controls.Add(lblNodeTooltip);
            this.tbpNodeChoice.Controls.Add(this.txtNodeChoiceTooltip);
            this.tbpNodeChoice.Location = new System.Drawing.Point(4, 22);
            this.tbpNodeChoice.Name = "tbpNodeChoice";
            this.tbpNodeChoice.Size = new System.Drawing.Size(210, 242);
            this.tbpNodeChoice.TabIndex = 2;
            this.tbpNodeChoice.Text = "Choice Node";
            this.tbpNodeChoice.UseVisualStyleBackColor = true;
            // 
            // nudChoiceCustomWidth
            // 
            this.nudChoiceCustomWidth.DecimalPlaces = 2;
            this.nudChoiceCustomWidth.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudChoiceCustomWidth.Location = new System.Drawing.Point(104, 184);
            this.nudChoiceCustomWidth.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.nudChoiceCustomWidth.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudChoiceCustomWidth.Name = "nudChoiceCustomWidth";
            this.nudChoiceCustomWidth.Size = new System.Drawing.Size(72, 20);
            this.nudChoiceCustomWidth.TabIndex = 11;
            this.nudChoiceCustomWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudChoiceCustomWidth.Visible = false;
            this.nudChoiceCustomWidth.ValueChanged += new System.EventHandler(this.nudCustomWidth_ValueChanged);
            // 
            // chkChoiceHighlight
            // 
            this.chkChoiceHighlight.AutoSize = true;
            this.chkChoiceHighlight.Location = new System.Drawing.Point(8, 160);
            this.chkChoiceHighlight.Name = "chkChoiceHighlight";
            this.chkChoiceHighlight.Size = new System.Drawing.Size(67, 17);
            this.chkChoiceHighlight.TabIndex = 9;
            this.chkChoiceHighlight.Text = "Highlight";
            this.chkChoiceHighlight.UseVisualStyleBackColor = true;
            this.chkChoiceHighlight.CheckedChanged += new System.EventHandler(this.chkChoiceHighlight_CheckedChanged);
            // 
            // chkChoiceCustomWidth
            // 
            this.chkChoiceCustomWidth.AutoSize = true;
            this.chkChoiceCustomWidth.Location = new System.Drawing.Point(8, 184);
            this.chkChoiceCustomWidth.Name = "chkChoiceCustomWidth";
            this.chkChoiceCustomWidth.Size = new System.Drawing.Size(92, 17);
            this.chkChoiceCustomWidth.TabIndex = 10;
            this.chkChoiceCustomWidth.Text = "Custom Width";
            this.chkChoiceCustomWidth.UseVisualStyleBackColor = true;
            this.chkChoiceCustomWidth.CheckedChanged += new System.EventHandler(this.chkCustomWidth_CheckedChanged);
            // 
            // txtNodeChoiceKey
            // 
            this.txtNodeChoiceKey.Location = new System.Drawing.Point(8, 24);
            this.txtNodeChoiceKey.MaxLength = 20;
            this.txtNodeChoiceKey.Name = "txtNodeChoiceKey";
            this.txtNodeChoiceKey.Size = new System.Drawing.Size(192, 20);
            this.txtNodeChoiceKey.TabIndex = 8;
            this.txtNodeChoiceKey.TextChanged += new System.EventHandler(this.txtNodeKey_TextChanged);
            this.txtNodeChoiceKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNodeKey_KeyPress);
            // 
            // txtNodeChoiceTitle
            // 
            this.txtNodeChoiceTitle.Location = new System.Drawing.Point(8, 72);
            this.txtNodeChoiceTitle.MaxLength = 50;
            this.txtNodeChoiceTitle.Name = "txtNodeChoiceTitle";
            this.txtNodeChoiceTitle.Size = new System.Drawing.Size(192, 20);
            this.txtNodeChoiceTitle.TabIndex = 3;
            this.txtNodeChoiceTitle.TextChanged += new System.EventHandler(this.txtNodeTitle_TextChanged);
            // 
            // txtNodeChoiceTooltip
            // 
            this.txtNodeChoiceTooltip.Location = new System.Drawing.Point(8, 120);
            this.txtNodeChoiceTooltip.MaxLength = 200;
            this.txtNodeChoiceTooltip.Name = "txtNodeChoiceTooltip";
            this.txtNodeChoiceTooltip.Size = new System.Drawing.Size(192, 20);
            this.txtNodeChoiceTooltip.TabIndex = 4;
            this.txtNodeChoiceTooltip.TextChanged += new System.EventHandler(this.txtNodeTooltip_TextChanged);
            // 
            // tbpNodeLink
            // 
            this.tbpNodeLink.Controls.Add(lblLinkTarget);
            this.tbpNodeLink.Controls.Add(this.cmbLinkTarget);
            this.tbpNodeLink.Location = new System.Drawing.Point(4, 22);
            this.tbpNodeLink.Name = "tbpNodeLink";
            this.tbpNodeLink.Size = new System.Drawing.Size(210, 242);
            this.tbpNodeLink.TabIndex = 3;
            this.tbpNodeLink.Text = "Link Node";
            this.tbpNodeLink.UseVisualStyleBackColor = true;
            // 
            // cmbLinkTarget
            // 
            this.cmbLinkTarget.FormattingEnabled = true;
            this.cmbLinkTarget.Location = new System.Drawing.Point(8, 24);
            this.cmbLinkTarget.Name = "cmbLinkTarget";
            this.cmbLinkTarget.Size = new System.Drawing.Size(192, 21);
            this.cmbLinkTarget.TabIndex = 2;
            this.cmbLinkTarget.TextChanged += new System.EventHandler(this.cmbLinkTarget_TextChanged);
            // 
            // tbpNodeCompass
            // 
            this.tbpNodeCompass.Location = new System.Drawing.Point(4, 22);
            this.tbpNodeCompass.Name = "tbpNodeCompass";
            this.tbpNodeCompass.Size = new System.Drawing.Size(210, 242);
            this.tbpNodeCompass.TabIndex = 4;
            this.tbpNodeCompass.Text = "Compass Node";
            this.tbpNodeCompass.UseVisualStyleBackColor = true;
            // 
            // tbcScripts
            // 
            this.tbcScripts.Controls.Add(this.tbpScriptAction);
            this.tbcScripts.Controls.Add(this.tbpScriptAppear);
            this.tbcScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcScripts.Location = new System.Drawing.Point(0, 0);
            this.tbcScripts.Name = "tbcScripts";
            this.tbcScripts.SelectedIndex = 0;
            this.tbcScripts.Size = new System.Drawing.Size(466, 268);
            this.tbcScripts.TabIndex = 0;
            // 
            // tbpScriptAction
            // 
            this.tbpScriptAction.Controls.Add(this.scriptAction);
            this.tbpScriptAction.Location = new System.Drawing.Point(4, 22);
            this.tbpScriptAction.Name = "tbpScriptAction";
            this.tbpScriptAction.Padding = new System.Windows.Forms.Padding(3);
            this.tbpScriptAction.Size = new System.Drawing.Size(458, 242);
            this.tbpScriptAction.TabIndex = 0;
            this.tbpScriptAction.Text = "Actions Taken";
            this.tbpScriptAction.UseVisualStyleBackColor = true;
            // 
            // scriptAction
            // 
            this.scriptAction.AllowExternalScript = false;
            this.scriptAction.AllowInlineScript = true;
            this.scriptAction.AllowVisualActionScript = true;
            this.scriptAction.AllowVisualConditionScript = false;
            this.scriptAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptAction.Location = new System.Drawing.Point(3, 3);
            this.scriptAction.Name = "scriptAction";
            this.scriptAction.Size = new System.Drawing.Size(452, 236);
            this.scriptAction.TabIndex = 0;
            // 
            // tbpScriptAppear
            // 
            this.tbpScriptAppear.Controls.Add(this.scriptAppear);
            this.tbpScriptAppear.Location = new System.Drawing.Point(4, 22);
            this.tbpScriptAppear.Name = "tbpScriptAppear";
            this.tbpScriptAppear.Padding = new System.Windows.Forms.Padding(3);
            this.tbpScriptAppear.Size = new System.Drawing.Size(458, 242);
            this.tbpScriptAppear.TabIndex = 1;
            this.tbpScriptAppear.Text = "Appears When";
            this.tbpScriptAppear.UseVisualStyleBackColor = true;
            // 
            // scriptAppear
            // 
            this.scriptAppear.AllowExternalScript = false;
            this.scriptAppear.AllowInlineScript = true;
            this.scriptAppear.AllowVisualActionScript = false;
            this.scriptAppear.AllowVisualConditionScript = true;
            this.scriptAppear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptAppear.Location = new System.Drawing.Point(3, 3);
            this.scriptAppear.Name = "scriptAppear";
            this.scriptAppear.Size = new System.Drawing.Size(452, 236);
            this.scriptAppear.TabIndex = 0;
            // 
            // FormDocumentScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 551);
            this.Controls.Add(this.splitNodeList);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormDocumentScene";
            this.Text = "Scene";
            this.Load += new System.EventHandler(this.FormDocumentScene_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitNodeList.Panel1.ResumeLayout(false);
            this.splitNodeList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitNodeList)).EndInit();
            this.splitNodeList.ResumeLayout(false);
            this.splitNodeSettings.Panel1.ResumeLayout(false);
            this.splitNodeSettings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitNodeSettings)).EndInit();
            this.splitNodeSettings.ResumeLayout(false);
            this.tbcNode.ResumeLayout(false);
            this.tbpNodeRoot.ResumeLayout(false);
            this.tbpNodeRoot.PerformLayout();
            this.pnlInjectionSettings.ResumeLayout(false);
            this.pnlInjectionSettings.PerformLayout();
            this.tbpNodeState.ResumeLayout(false);
            this.tbpNodeState.PerformLayout();
            this.tbpNodeChoice.ResumeLayout(false);
            this.tbpNodeChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChoiceCustomWidth)).EndInit();
            this.tbpNodeLink.ResumeLayout(false);
            this.tbpNodeLink.PerformLayout();
            this.tbcScripts.ResumeLayout(false);
            this.tbpScriptAction.ResumeLayout(false);
            this.tbpScriptAppear.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.SplitContainer splitNodeList;
		private System.Windows.Forms.TreeView trvNodes;
		private System.Windows.Forms.SplitContainer splitNodeSettings;
		private System.Windows.Forms.ComboBox cmbLinkTarget;
		private System.Windows.Forms.ToolStripButton tsbAddNode;
		private System.Windows.Forms.ToolStripButton tsbRemoveNode;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbScriptEnter;
		private System.Windows.Forms.ToolStripButton tsbScriptLeave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbExpand;
		private System.Windows.Forms.ToolStripButton tsbCollapse;
		private System.Windows.Forms.TabPage tbpScriptAction;
		private System.Windows.Forms.TabPage tbpScriptAppear;
		private System.Windows.Forms.TextBox txtNodeChoiceTooltip;
		private System.Windows.Forms.ImageList imlNodeIcons;
		private System.Windows.Forms.TextBox txtNodeStateKey;
		private System.Windows.Forms.ToolStripButton tsbScriptCustom;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbMoveUp;
		private System.Windows.Forms.ToolStripButton tsbMoveDown;
		private System.Windows.Forms.TextBox txtNodeChoiceTitle;
		private System.Windows.Forms.ToolStripButton tsbAddLink;
		private System.Windows.Forms.NumericUpDown nudChoiceCustomWidth;
		private System.Windows.Forms.CheckBox chkChoiceHighlight;
		private System.Windows.Forms.CheckBox chkChoiceCustomWidth;
        private ScriptEditorHost scriptAction;
        private ScriptEditorHost scriptAppear;
        private System.Windows.Forms.TabControl tbcScripts;
        private System.Windows.Forms.TabControl tbcNode;
        private System.Windows.Forms.TabPage tbpNodeRoot;
        private System.Windows.Forms.Panel pnlInjectionSettings;
        private AssetPickerControl assetInjectTargetScene;
        private System.Windows.Forms.ComboBox cmbInjectTargetMode;
        private System.Windows.Forms.ComboBox cmbInjectTargetNode;
        private System.Windows.Forms.CheckBox chkRootInject;
        private System.Windows.Forms.TabPage tbpNodeState;
        private System.Windows.Forms.TabPage tbpNodeChoice;
        private System.Windows.Forms.TextBox txtNodeChoiceKey;
        private System.Windows.Forms.TabPage tbpNodeLink;
        private System.Windows.Forms.TabPage tbpNodeCompass;
    }
}