﻿/**
 * Safe Pad, a double encrypted note pad that uses 2 passwords to protect your documents and help you keep your privacy.
 * 
 * Copyright (C) 2014 Stephen Haunts
 * http://www.stephenhaunts.com
 * 
 * This file is part of Safe Pad.
 * 
 * Safe Pad is free software: you can redistribute it and/or modify it under the terms of the
 * GNU General Public License as published by the Free Software Foundation, either version 2 of the
 * License, or (at your option) any later version.
 * 
 * Safe Pad is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * 
 * See the GNU General Public License for more details <http://www.gnu.org/licenses/>.
 * 
 * Authors: Stephen Haunts
 */
namespace HauntedHouseSoftware.SecureNotePad.Forms
{
    partial class MainForm
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (_findForm != null)
                {
                    _findForm.Dispose();
                    _findForm = null;
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.browseContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.cutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.undoContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.boldContextMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.italicContextMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineContextMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.addBulletsContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseIndentContextMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseIndentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.leftJustifyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centreJustifyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rigthJustifyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDocumentWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCachedPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bulletSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.leftJustifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centreJustifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightJustifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.insertImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowContrastDarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowContrastLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.customBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customeForegroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNotebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNotebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllNotebooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.notebooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolbarLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolbarLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newDocumentWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newDocumentButton = new System.Windows.Forms.ToolStripButton();
            this.openDocumentButton = new System.Windows.Forms.ToolStripButton();
            this.saveDocumentButton = new System.Windows.Forms.ToolStripButton();
            this.printDocumentButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.redoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripFontSelector = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripFontSizeSelector = new System.Windows.Forms.ToolStripComboBox();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bulletButton = new System.Windows.Forms.ToolStripButton();
            this.decreaseIndentButton = new System.Windows.Forms.ToolStripButton();
            this.increaseIndentButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.leftJustifyButton = new System.Windows.Forms.ToolStripButton();
            this.centreButton = new System.Windows.Forms.ToolStripButton();
            this.rightJustifyButton = new System.Windows.Forms.ToolStripButton();
            this.insertImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.themeColorDialog = new System.Windows.Forms.ColorDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.notifyIconContextMenu.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.AutoWordSelection = true;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.BulletIndent = 10;
            this.richTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox.DetectUrls = false;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.EnableAutoDragDrop = true;
            this.richTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.HideSelection = false;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ShowSelectionMargin = true;
            this.richTextBox.Size = new System.Drawing.Size(902, 469);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBoxLinkClicked);
            this.richTextBox.Click += new System.EventHandler(this.RichTextBoxClick);
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBoxKeyDown);
            this.richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBoxKeyPress);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseContextMenuItem,
            this.toolStripSeparator21,
            this.cutContextMenuItem,
            this.copyContextMenuItem,
            this.pasteContextMenuItem,
            this.toolStripSeparator20,
            this.undoContextMenuItem,
            this.redoContextMenuItem,
            this.toolStripSeparator14,
            this.boldContextMenuItem1,
            this.italicContextMenuItem1,
            this.underlineContextMenuItem1,
            this.toolStripSeparator16,
            this.addBulletsContextMenuItem,
            this.increaseIndentContextMenuItem1,
            this.decreaseIndentToolStripMenuItem1,
            this.toolStripSeparator15,
            this.leftJustifyContextMenuItem,
            this.centreJustifyContextMenuItem,
            this.rigthJustifyContextMenuItem,
            this.toolStripSeparator17,
            this.propertiesToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(159, 392);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // browseContextMenuItem
            // 
            this.browseContextMenuItem.Name = "browseContextMenuItem";
            this.browseContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.browseContextMenuItem.Text = "Browse";
            this.browseContextMenuItem.Click += new System.EventHandler(this.browseContextMenuItem_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(155, 6);
            // 
            // cutContextMenuItem
            // 
            this.cutContextMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Cut;
            this.cutContextMenuItem.Name = "cutContextMenuItem";
            this.cutContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cutContextMenuItem.Text = "Cut";
            this.cutContextMenuItem.Click += new System.EventHandler(this.cutContextMenuItem_Click);
            // 
            // copyContextMenuItem
            // 
            this.copyContextMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Copy;
            this.copyContextMenuItem.Name = "copyContextMenuItem";
            this.copyContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyContextMenuItem.Text = "Copy";
            this.copyContextMenuItem.Click += new System.EventHandler(this.copyContextMenuItem_Click);
            // 
            // pasteContextMenuItem
            // 
            this.pasteContextMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Paste;
            this.pasteContextMenuItem.Name = "pasteContextMenuItem";
            this.pasteContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pasteContextMenuItem.Text = "Paste";
            this.pasteContextMenuItem.Click += new System.EventHandler(this.pasteContextMenuItem_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(155, 6);
            // 
            // undoContextMenuItem
            // 
            this.undoContextMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Undo;
            this.undoContextMenuItem.Name = "undoContextMenuItem";
            this.undoContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.undoContextMenuItem.Text = "Undo";
            this.undoContextMenuItem.Click += new System.EventHandler(this.undoContextMenuItem_Click);
            // 
            // redoContextMenuItem
            // 
            this.redoContextMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Redo;
            this.redoContextMenuItem.Name = "redoContextMenuItem";
            this.redoContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.redoContextMenuItem.Text = "Redo";
            this.redoContextMenuItem.Click += new System.EventHandler(this.redoContextMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(155, 6);
            // 
            // boldContextMenuItem1
            // 
            this.boldContextMenuItem1.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Bold;
            this.boldContextMenuItem1.Name = "boldContextMenuItem1";
            this.boldContextMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.boldContextMenuItem1.Text = "Bold";
            this.boldContextMenuItem1.Click += new System.EventHandler(this.boldContextMenuItem1_Click);
            // 
            // italicContextMenuItem1
            // 
            this.italicContextMenuItem1.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Italic;
            this.italicContextMenuItem1.Name = "italicContextMenuItem1";
            this.italicContextMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.italicContextMenuItem1.Text = "Italic";
            this.italicContextMenuItem1.Click += new System.EventHandler(this.italicContextMenuItem1_Click);
            // 
            // underlineContextMenuItem1
            // 
            this.underlineContextMenuItem1.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Underline;
            this.underlineContextMenuItem1.Name = "underlineContextMenuItem1";
            this.underlineContextMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.underlineContextMenuItem1.Text = "Underline";
            this.underlineContextMenuItem1.Click += new System.EventHandler(this.underlineContextMenuItem1_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(155, 6);
            // 
            // addBulletsContextMenuItem
            // 
            this.addBulletsContextMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Bullet;
            this.addBulletsContextMenuItem.Name = "addBulletsContextMenuItem";
            this.addBulletsContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addBulletsContextMenuItem.Text = "Bullet Selection";
            this.addBulletsContextMenuItem.Click += new System.EventHandler(this.addBulletsContextMenuItem_Click);
            // 
            // increaseIndentContextMenuItem1
            // 
            this.increaseIndentContextMenuItem1.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.IncreaseIndent;
            this.increaseIndentContextMenuItem1.Name = "increaseIndentContextMenuItem1";
            this.increaseIndentContextMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.increaseIndentContextMenuItem1.Text = "Increase Indent";
            this.increaseIndentContextMenuItem1.Click += new System.EventHandler(this.increaseIndentContextMenuItem1_Click);
            // 
            // decreaseIndentToolStripMenuItem1
            // 
            this.decreaseIndentToolStripMenuItem1.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.DecreaseIndent;
            this.decreaseIndentToolStripMenuItem1.Name = "decreaseIndentToolStripMenuItem1";
            this.decreaseIndentToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.decreaseIndentToolStripMenuItem1.Text = "Decrease Indent";
            this.decreaseIndentToolStripMenuItem1.Click += new System.EventHandler(this.decreaseIndentToolStripMenuItem1_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(155, 6);
            // 
            // leftJustifyContextMenuItem
            // 
            this.leftJustifyContextMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Left_Justify;
            this.leftJustifyContextMenuItem.Name = "leftJustifyContextMenuItem";
            this.leftJustifyContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.leftJustifyContextMenuItem.Text = "Left Justify";
            this.leftJustifyContextMenuItem.Click += new System.EventHandler(this.leftJustifyContextMenuItem_Click);
            // 
            // centreJustifyContextMenuItem
            // 
            this.centreJustifyContextMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Centre_Justify;
            this.centreJustifyContextMenuItem.Name = "centreJustifyContextMenuItem";
            this.centreJustifyContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.centreJustifyContextMenuItem.Text = "Centre Justify";
            this.centreJustifyContextMenuItem.Click += new System.EventHandler(this.centreJustifyContextMenuItem_Click);
            // 
            // rigthJustifyContextMenuItem
            // 
            this.rigthJustifyContextMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Right_Justify;
            this.rigthJustifyContextMenuItem.Name = "rigthJustifyContextMenuItem";
            this.rigthJustifyContextMenuItem.Size = new System.Drawing.Size(158, 22);
            this.rigthJustifyContextMenuItem.Text = "Rigth Justify";
            this.rigthJustifyContextMenuItem.Click += new System.EventHandler(this.rigthJustifyContextMenuItem_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(155, 6);
            // 
            // propertiesToolStripMenuItem1
            // 
            this.propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            this.propertiesToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.propertiesToolStripMenuItem1.Text = "Properties";
            this.propertiesToolStripMenuItem1.Click += new System.EventHandler(this.propertiesToolStripMenuItem1_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.notebookToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(902, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printToolStripMenuItem1,
            this.removeCachedPasswordToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator2,
            this.recentFilesToolStripMenuItem,
            this.toolStripSeparator18,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocumentToolStripMenuItem,
            this.newDocumentWindowToolStripMenuItem});
            this.newToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.New_Document;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.newToolStripMenuItem.Text = "New";            
            // 
            // newDocumentToolStripMenuItem
            // 
            this.newDocumentToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.New_Document;
            this.newDocumentToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.newDocumentToolStripMenuItem.Name = "newDocumentToolStripMenuItem";
            this.newDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newDocumentToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newDocumentToolStripMenuItem.Text = "New Document";
            this.newDocumentToolStripMenuItem.Click += new System.EventHandler(this.NewDocumentToolStripMenuItemClick);
            // 
            // newDocumentWindowToolStripMenuItem
            // 
            this.newDocumentWindowToolStripMenuItem.Name = "newDocumentWindowToolStripMenuItem";
            this.newDocumentWindowToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newDocumentWindowToolStripMenuItem.Text = "New Document Window";
            this.newDocumentWindowToolStripMenuItem.Click += new System.EventHandler(this.NewDocumentWindowToolStripMenuItemClick);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Open_Document;
            this.loadToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.loadToolStripMenuItem.Text = "&Open";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Save_Document;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveToolStripMenuItem.Text = "S&ave";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exportFileToolStripMenuItem.Text = "Export File";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.exportFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Print_Document;
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.printToolStripMenuItem.Text = "Print Preview";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItemClick);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.PrintToolStripMenuItem1Click);
            // 
            // removeCachedPasswordToolStripMenuItem
            // 
            this.removeCachedPasswordToolStripMenuItem.Name = "removeCachedPasswordToolStripMenuItem";
            this.removeCachedPasswordToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.removeCachedPasswordToolStripMenuItem.Text = "Remove Cached Password";
            this.removeCachedPasswordToolStripMenuItem.Click += new System.EventHandler(this.removeCachedPasswordToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(210, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator5,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.wordWrapToolStripMenuItem,
            this.toolStripSeparator19,
            this.findToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Undo;
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItemClick);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Redo;
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Cut;
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItemClick);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Copy;
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItemClick);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Paste;
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItemClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Checked = true;
            this.wordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.WordWrapToolStripMenuItemClick);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(141, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFontToolStripMenuItem,
            this.selectColorToolStripMenuItem,
            this.toolStripSeparator7,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.toolStripSeparator10,
            this.bulletSelectionToolStripMenuItem,
            this.decreaseIndentToolStripMenuItem,
            this.increaseIndentToolStripMenuItem,
            this.toolStripSeparator11,
            this.leftJustifyToolStripMenuItem,
            this.centreJustifyToolStripMenuItem,
            this.rightJustifyToolStripMenuItem,
            this.toolStripSeparator12,
            this.insertImageToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.selectFontToolStripMenuItem.Text = "Select Font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.SelectFontToolStripMenuItemClick);
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.selectColorToolStripMenuItem.Text = "Select Color";
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.SelectColorToolStripMenuItemClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(182, 6);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Bold;
            this.boldToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.BoldToolStripMenuItemClick);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Italic;
            this.italicToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolStripMenuItemClick);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Underline;
            this.underlineToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.UnderlineToolStripMenuItemClick);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(182, 6);
            // 
            // bulletSelectionToolStripMenuItem
            // 
            this.bulletSelectionToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Bullet;
            this.bulletSelectionToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.bulletSelectionToolStripMenuItem.Name = "bulletSelectionToolStripMenuItem";
            this.bulletSelectionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.bulletSelectionToolStripMenuItem.Text = "Bullet Selection";
            this.bulletSelectionToolStripMenuItem.Click += new System.EventHandler(this.BulletSelectionToolStripMenuItemClick);
            // 
            // decreaseIndentToolStripMenuItem
            // 
            this.decreaseIndentToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.DecreaseIndent;
            this.decreaseIndentToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.decreaseIndentToolStripMenuItem.Name = "decreaseIndentToolStripMenuItem";
            this.decreaseIndentToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.decreaseIndentToolStripMenuItem.Text = "Decrease Indent";
            this.decreaseIndentToolStripMenuItem.Click += new System.EventHandler(this.DecreaseIndentToolStripMenuItemClick);
            // 
            // increaseIndentToolStripMenuItem
            // 
            this.increaseIndentToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.IncreaseIndent;
            this.increaseIndentToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.increaseIndentToolStripMenuItem.Name = "increaseIndentToolStripMenuItem";
            this.increaseIndentToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.increaseIndentToolStripMenuItem.Text = "Increase Indent";
            this.increaseIndentToolStripMenuItem.Click += new System.EventHandler(this.IncreaseIndentToolStripMenuItemClick);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(182, 6);
            // 
            // leftJustifyToolStripMenuItem
            // 
            this.leftJustifyToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Left_Justify;
            this.leftJustifyToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.leftJustifyToolStripMenuItem.Name = "leftJustifyToolStripMenuItem";
            this.leftJustifyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.leftJustifyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.leftJustifyToolStripMenuItem.Text = "Left Justify";
            this.leftJustifyToolStripMenuItem.Click += new System.EventHandler(this.LeftJustifyToolStripMenuItemClick);
            // 
            // centreJustifyToolStripMenuItem
            // 
            this.centreJustifyToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Centre_Justify;
            this.centreJustifyToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.centreJustifyToolStripMenuItem.Name = "centreJustifyToolStripMenuItem";
            this.centreJustifyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.centreJustifyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.centreJustifyToolStripMenuItem.Text = "Centre Justify";
            this.centreJustifyToolStripMenuItem.Click += new System.EventHandler(this.CentreJustifyToolStripMenuItemClick);
            // 
            // rightJustifyToolStripMenuItem
            // 
            this.rightJustifyToolStripMenuItem.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Right_Justify;
            this.rightJustifyToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.rightJustifyToolStripMenuItem.Name = "rightJustifyToolStripMenuItem";
            this.rightJustifyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rightJustifyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rightJustifyToolStripMenuItem.Text = "Right Justify";
            this.rightJustifyToolStripMenuItem.Click += new System.EventHandler(this.RightJustifyToolStripMenuItemClick);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(182, 6);
            // 
            // insertImageToolStripMenuItem
            // 
            this.insertImageToolStripMenuItem.Name = "insertImageToolStripMenuItem";
            this.insertImageToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.insertImageToolStripMenuItem.Text = "Insert Image";
            this.insertImageToolStripMenuItem.Click += new System.EventHandler(this.InsertImageToolStripMenuItemClick);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.invisibleToolStripMenuItem,
            this.lowContrastDarkToolStripMenuItem,
            this.lowContrastLightToolStripMenuItem,
            this.toolStripSeparator13,
            this.customBackgroundColorToolStripMenuItem,
            this.customeForegroundColorToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // invisibleToolStripMenuItem
            // 
            this.invisibleToolStripMenuItem.Name = "invisibleToolStripMenuItem";
            this.invisibleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.invisibleToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.invisibleToolStripMenuItem.Text = "Invisible Mode";
            this.invisibleToolStripMenuItem.Click += new System.EventHandler(this.invisibleToolStripMenuItem_Click);
            // 
            // lowContrastDarkToolStripMenuItem
            // 
            this.lowContrastDarkToolStripMenuItem.Name = "lowContrastDarkToolStripMenuItem";
            this.lowContrastDarkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.lowContrastDarkToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.lowContrastDarkToolStripMenuItem.Text = "Low Contrast (Dark)";
            this.lowContrastDarkToolStripMenuItem.Click += new System.EventHandler(this.lowContrastDarkToolStripMenuItem_Click);
            // 
            // lowContrastLightToolStripMenuItem
            // 
            this.lowContrastLightToolStripMenuItem.Name = "lowContrastLightToolStripMenuItem";
            this.lowContrastLightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.lowContrastLightToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.lowContrastLightToolStripMenuItem.Text = "Low Contrast (Light)";
            this.lowContrastLightToolStripMenuItem.Click += new System.EventHandler(this.lowContrastLightToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(225, 6);
            // 
            // customBackgroundColorToolStripMenuItem
            // 
            this.customBackgroundColorToolStripMenuItem.Name = "customBackgroundColorToolStripMenuItem";
            this.customBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.customBackgroundColorToolStripMenuItem.Text = "Custom Background Color";
            this.customBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.customBackgroundColorToolStripMenuItem_Click);
            // 
            // customeForegroundColorToolStripMenuItem
            // 
            this.customeForegroundColorToolStripMenuItem.Name = "customeForegroundColorToolStripMenuItem";
            this.customeForegroundColorToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.customeForegroundColorToolStripMenuItem.Text = "Custome Foreground Color";
            this.customeForegroundColorToolStripMenuItem.Click += new System.EventHandler(this.customeForegroundColorToolStripMenuItem_Click);
            // 
            // notebookToolStripMenuItem
            // 
            this.notebookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNotebookToolStripMenuItem,
            this.removeNotebookToolStripMenuItem,
            this.clearAllNotebooksToolStripMenuItem,
            this.toolStripSeparator22,
            this.notebooksToolStripMenuItem});
            this.notebookToolStripMenuItem.Name = "notebookToolStripMenuItem";
            this.notebookToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.notebookToolStripMenuItem.Text = "Notebook";
            this.notebookToolStripMenuItem.Visible = false;
            // 
            // addNotebookToolStripMenuItem
            // 
            this.addNotebookToolStripMenuItem.Name = "addNotebookToolStripMenuItem";
            this.addNotebookToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addNotebookToolStripMenuItem.Text = "Add Notebook";
            this.addNotebookToolStripMenuItem.Click += new System.EventHandler(this.addNotebookToolStripMenuItem_Click);
            // 
            // removeNotebookToolStripMenuItem
            // 
            this.removeNotebookToolStripMenuItem.Name = "removeNotebookToolStripMenuItem";
            this.removeNotebookToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.removeNotebookToolStripMenuItem.Text = "Remove Notebook";
            this.removeNotebookToolStripMenuItem.Click += new System.EventHandler(this.removeNotebookToolStripMenuItem_Click);
            // 
            // clearAllNotebooksToolStripMenuItem
            // 
            this.clearAllNotebooksToolStripMenuItem.Name = "clearAllNotebooksToolStripMenuItem";
            this.clearAllNotebooksToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.clearAllNotebooksToolStripMenuItem.Text = "Clear All Notebooks";
            this.clearAllNotebooksToolStripMenuItem.Click += new System.EventHandler(this.clearAllNotebooksToolStripMenuItem_Click);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(176, 6);
            // 
            // notebooksToolStripMenuItem
            // 
            this.notebooksToolStripMenuItem.Name = "notebooksToolStripMenuItem";
            this.notebooksToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.notebooksToolStripMenuItem.Text = "Notebooks";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatePasswordToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // generatePasswordToolStripMenuItem
            // 
            this.generatePasswordToolStripMenuItem.Name = "generatePasswordToolStripMenuItem";
            this.generatePasswordToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.generatePasswordToolStripMenuItem.Text = "Generate Password";
            this.generatePasswordToolStripMenuItem.Click += new System.EventHandler(this.generatePasswordToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolbarLayoutToolStripMenuItem,
            this.loadToolbarLayoutToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // saveToolbarLayoutToolStripMenuItem
            // 
            this.saveToolbarLayoutToolStripMenuItem.Name = "saveToolbarLayoutToolStripMenuItem";
            this.saveToolbarLayoutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.saveToolbarLayoutToolStripMenuItem.Text = "Save Toolbar Layout";
            this.saveToolbarLayoutToolStripMenuItem.ToolTipText = "Save Toolbar Layout";
            this.saveToolbarLayoutToolStripMenuItem.Click += new System.EventHandler(this.SaveToolbarLayoutToolStripMenuItemClick);
            // 
            // loadToolbarLayoutToolStripMenuItem
            // 
            this.loadToolbarLayoutToolStripMenuItem.Name = "loadToolbarLayoutToolStripMenuItem";
            this.loadToolbarLayoutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loadToolbarLayoutToolStripMenuItem.Text = "Load Toolbar Layout";
            this.loadToolbarLayoutToolStripMenuItem.ToolTipText = "Load Toolbar Layout";
            this.loadToolbarLayoutToolStripMenuItem.Click += new System.EventHandler(this.LoadToolbarLayoutToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpMenuItem.Text = "Help";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Secure Pad |*.scp|All Files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Secure Pad |*.scp|All Files|*.*";
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.SystemColors.ControlText;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.MainMenuStrip = this.menuStrip;
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.ShowIcon = false;
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "printDocument";
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocumentBeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocumentPrintPage);
            // 
            // printDialog
            // 
            this.printDialog.AllowCurrentPage = true;
            this.printDialog.AllowSelection = true;
            this.printDialog.AllowSomePages = true;
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Safe Pad";
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Safe Pad";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyIconContextMenu
            // 
            this.notifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocumentWindowToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.notifyIconContextMenu.Name = "notifyIconContextMenu";
            this.notifyIconContextMenu.Size = new System.Drawing.Size(205, 48);
            // 
            // newDocumentWindowToolStripMenuItem1
            // 
            this.newDocumentWindowToolStripMenuItem1.Name = "newDocumentWindowToolStripMenuItem1";
            this.newDocumentWindowToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.newDocumentWindowToolStripMenuItem1.Text = "New Document Window";
            this.newDocumentWindowToolStripMenuItem1.Click += new System.EventHandler(this.NewDocumentWindowToolStripMenuItem1Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1Click);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.AutoScroll = true;
            this.toolStripContainer.ContentPanel.Controls.Add(this.richTextBox);
            this.toolStripContainer.ContentPanel.Controls.Add(this.statusStrip);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(902, 491);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(902, 557);
            this.toolStripContainer.TabIndex = 2;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripDropDownButton});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 469);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(902, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton.Image")));
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(52, 20);
            this.toolStripDropDownButton.Text = "Zoom";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem1.Text = "1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "5";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "6";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "7";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem8.Text = "8";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem9.Text = "9";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem10.Text = "10";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocumentButton,
            this.openDocumentButton,
            this.saveDocumentButton,
            this.printDocumentButton,
            this.toolStripSeparator3,
            this.cutButton,
            this.copyButton,
            this.pasteButton,
            this.toolStripSeparator6,
            this.undoButton,
            this.redoButton});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(294, 33);
            this.toolStrip.TabIndex = 0;
            // 
            // newDocumentButton
            // 
            this.newDocumentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newDocumentButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.New_Document;
            this.newDocumentButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.newDocumentButton.Name = "newDocumentButton";
            this.newDocumentButton.Size = new System.Drawing.Size(30, 30);
            this.newDocumentButton.Text = "New Document";
            this.newDocumentButton.Click += new System.EventHandler(this.NewDocumentButtonClick);
            // 
            // openDocumentButton
            // 
            this.openDocumentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openDocumentButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Open_Document;
            this.openDocumentButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.openDocumentButton.Name = "openDocumentButton";
            this.openDocumentButton.Size = new System.Drawing.Size(30, 30);
            this.openDocumentButton.Text = "Open Document";
            this.openDocumentButton.Click += new System.EventHandler(this.ToolStripButton1Click);
            // 
            // saveDocumentButton
            // 
            this.saveDocumentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveDocumentButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Save_Document;
            this.saveDocumentButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.saveDocumentButton.Name = "saveDocumentButton";
            this.saveDocumentButton.Size = new System.Drawing.Size(30, 30);
            this.saveDocumentButton.Text = "Save Document";
            this.saveDocumentButton.Click += new System.EventHandler(this.SaveDocumentButtonClick);
            // 
            // printDocumentButton
            // 
            this.printDocumentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printDocumentButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Print_Document;
            this.printDocumentButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.printDocumentButton.Name = "printDocumentButton";
            this.printDocumentButton.Size = new System.Drawing.Size(30, 30);
            this.printDocumentButton.Text = "Print Document";
            this.printDocumentButton.Click += new System.EventHandler(this.PrintDocumentButtonClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Cut;
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(30, 30);
            this.cutButton.Text = "Cut Selection";
            this.cutButton.ToolTipText = "Cut Selection";
            this.cutButton.Click += new System.EventHandler(this.CutClick);
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Copy;
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(30, 30);
            this.copyButton.Text = "Copy Selection";
            this.copyButton.ToolTipText = "Copy Selection";
            this.copyButton.Click += new System.EventHandler(this.CopyButtonClick);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Paste;
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(30, 30);
            this.pasteButton.Text = "Paste Selection";
            this.pasteButton.ToolTipText = "Paste Selection";
            this.pasteButton.Click += new System.EventHandler(this.PasteButtonClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Undo;
            this.undoButton.ImageTransparentColor = System.Drawing.Color.White;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(30, 30);
            this.undoButton.Text = "Undo";
            this.undoButton.ToolTipText = "Undo";
            this.undoButton.Click += new System.EventHandler(this.UndoButtonClick);
            // 
            // redoButton
            // 
            this.redoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Redo;
            this.redoButton.ImageTransparentColor = System.Drawing.Color.White;
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(30, 30);
            this.redoButton.Text = "Redo";
            this.redoButton.ToolTipText = "Redo";
            this.redoButton.Click += new System.EventHandler(this.RedoButtonClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFontSelector,
            this.toolStripFontSizeSelector,
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.toolStripSeparator9,
            this.bulletButton,
            this.decreaseIndentButton,
            this.increaseIndentButton,
            this.toolStripSeparator8,
            this.leftJustifyButton,
            this.centreButton,
            this.rightJustifyButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(494, 33);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripFontSelector
            // 
            this.toolStripFontSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripFontSelector.Items.AddRange(new object[] {
            "Calibre",
            "Helvetica",
            "Ariel"});
            this.toolStripFontSelector.Name = "toolStripFontSelector";
            this.toolStripFontSelector.Size = new System.Drawing.Size(121, 33);
            this.toolStripFontSelector.DropDown += new System.EventHandler(this.toolStripFontSelector_DropDown);
            this.toolStripFontSelector.SelectedIndexChanged += new System.EventHandler(this.toolStripFontSelector_SelectedIndexChanged);
            // 
            // toolStripFontSizeSelector
            // 
            this.toolStripFontSizeSelector.DropDownWidth = 70;
            this.toolStripFontSizeSelector.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.toolStripFontSizeSelector.Name = "toolStripFontSizeSelector";
            this.toolStripFontSizeSelector.Size = new System.Drawing.Size(75, 33);
            this.toolStripFontSizeSelector.SelectedIndexChanged += new System.EventHandler(this.toolStripFontSizeSelector_SelectedIndexChanged);
            this.toolStripFontSizeSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripFontSizeSelector_KeyDown);
            this.toolStripFontSizeSelector.TextChanged += new System.EventHandler(this.toolStripFontSizeSelector_TextChanged);
            // 
            // boldButton
            // 
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Bold;
            this.boldButton.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(30, 30);
            this.boldButton.Text = "Bold";
            this.boldButton.ToolTipText = "Bold";
            this.boldButton.Click += new System.EventHandler(this.BoldButtonClick);
            // 
            // italicButton
            // 
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Italic;
            this.italicButton.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(30, 30);
            this.italicButton.Text = "Italic";
            this.italicButton.ToolTipText = "Italic";
            this.italicButton.Click += new System.EventHandler(this.ItalicButtonClick);
            // 
            // underlineButton
            // 
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Underline;
            this.underlineButton.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(30, 30);
            this.underlineButton.Text = "Underline";
            this.underlineButton.ToolTipText = "Underline";
            this.underlineButton.Click += new System.EventHandler(this.UnderlineButtonClick);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 33);
            // 
            // bulletButton
            // 
            this.bulletButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bulletButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Bullet;
            this.bulletButton.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.bulletButton.Name = "bulletButton";
            this.bulletButton.Size = new System.Drawing.Size(30, 30);
            this.bulletButton.Text = "Bullet list selection";
            this.bulletButton.ToolTipText = "Bullet list selection.";
            this.bulletButton.Click += new System.EventHandler(this.ToolStripButton1Click1);
            // 
            // decreaseIndentButton
            // 
            this.decreaseIndentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseIndentButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.DecreaseIndent;
            this.decreaseIndentButton.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.decreaseIndentButton.Name = "decreaseIndentButton";
            this.decreaseIndentButton.Size = new System.Drawing.Size(30, 30);
            this.decreaseIndentButton.Text = "Decrease Indent";
            this.decreaseIndentButton.ToolTipText = "Decrease Indent";
            this.decreaseIndentButton.Click += new System.EventHandler(this.DecreaseIndentButtonClick);
            // 
            // increaseIndentButton
            // 
            this.increaseIndentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseIndentButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.IncreaseIndent;
            this.increaseIndentButton.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.increaseIndentButton.Name = "increaseIndentButton";
            this.increaseIndentButton.Size = new System.Drawing.Size(30, 30);
            this.increaseIndentButton.Text = "Increase Indent";
            this.increaseIndentButton.Click += new System.EventHandler(this.IncreaseIndentButtonClick);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 33);
            // 
            // leftJustifyButton
            // 
            this.leftJustifyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftJustifyButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Left_Justify;
            this.leftJustifyButton.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.leftJustifyButton.Name = "leftJustifyButton";
            this.leftJustifyButton.Size = new System.Drawing.Size(30, 30);
            this.leftJustifyButton.Text = "Left Justlfy";
            this.leftJustifyButton.Click += new System.EventHandler(this.LeftJustifyButtonClick);
            // 
            // centreButton
            // 
            this.centreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centreButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Centre_Justify;
            this.centreButton.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.centreButton.Name = "centreButton";
            this.centreButton.Size = new System.Drawing.Size(30, 30);
            this.centreButton.Text = "Centre";
            this.centreButton.ToolTipText = "Centre";
            this.centreButton.Click += new System.EventHandler(this.CentreButtonClick);
            // 
            // rightJustifyButton
            // 
            this.rightJustifyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightJustifyButton.Image = global::HauntedHouseSoftware.SecureNotePad.Properties.Resources.Right_Justify;
            this.rightJustifyButton.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.rightJustifyButton.Name = "rightJustifyButton";
            this.rightJustifyButton.Size = new System.Drawing.Size(30, 30);
            this.rightJustifyButton.Text = "Right Justify";
            this.rightJustifyButton.ToolTipText = "Right Justify";
            this.rightJustifyButton.Click += new System.EventHandler(this.RightJustifyButtonClick);
            // 
            // insertImageDialog
            // 
            this.insertImageDialog.Filter = "JPG Files|*.jpg|Bmp Files|*.bpm|GIF Files|*.gif|PNG Files|*.png|All files|*.*";
            // 
            // themeColorDialog
            // 
            this.themeColorDialog.AnyColor = true;
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.Filter = "Rich Text File |*.rtf|All Files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 581);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Safe Pad";
            this.Activated += new System.EventHandler(this.MainFormActivated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.notifyIconContextMenu.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.PerformLayout();
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newDocumentButton;
        private System.Windows.Forms.ToolStripButton openDocumentButton;
        private System.Windows.Forms.ToolStripButton saveDocumentButton;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton printDocumentButton;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton undoButton;
        private System.Windows.Forms.ToolStripButton redoButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolbarLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolbarLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bulletButton;
        private System.Windows.Forms.ToolStripMenuItem bulletSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton decreaseIndentButton;
        private System.Windows.Forms.ToolStripButton increaseIndentButton;
        private System.Windows.Forms.ToolStripMenuItem decreaseIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton leftJustifyButton;
        private System.Windows.Forms.ToolStripButton centreButton;
        private System.Windows.Forms.ToolStripButton rightJustifyButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem leftJustifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centreJustifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightJustifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem insertImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog insertImageDialog;
        private System.Windows.Forms.ToolStripMenuItem newDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDocumentWindowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newDocumentWindowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripFontSelector;
        private System.Windows.Forms.ToolStripComboBox toolStripFontSizeSelector;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowContrastDarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowContrastLightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem customBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customeForegroundColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog themeColorDialog;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem boldContextMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem italicContextMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem underlineContextMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem addBulletsContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseIndentContextMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decreaseIndentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem leftJustifyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centreJustifyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rigthJustifyContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem invisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripMenuItem browseContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.ToolStripMenuItem removeCachedPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNotebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNotebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllNotebooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripMenuItem notebooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePasswordToolStripMenuItem;
    }
}

