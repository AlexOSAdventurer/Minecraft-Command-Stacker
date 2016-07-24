namespace Minecraft_Command_Stacker
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuOfAwesomeness = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuffMostPeopleDontCareAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LeftToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.AddCommand = new System.Windows.Forms.ToolStripButton();
            this.RemoveCommand = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CommandListDisplay = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.RadioButtonHolder1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.StartingCornerLabel = new System.Windows.Forms.Label();
            this.CornerSelector = new System.Windows.Forms.ComboBox();
            this.LeverBox = new System.Windows.Forms.CheckBox();
            this.DumbPlaceholder2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DumbPlaceholder1 = new System.Windows.Forms.Label();
            this.commandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuOfAwesomeness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.LeftToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommandListDisplay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.RadioButtonHolder1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuOfAwesomeness
            // 
            this.MenuOfAwesomeness.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.importToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuOfAwesomeness.Location = new System.Drawing.Point(0, 0);
            this.MenuOfAwesomeness.Name = "MenuOfAwesomeness";
            this.MenuOfAwesomeness.Size = new System.Drawing.Size(784, 24);
            this.MenuOfAwesomeness.TabIndex = 0;
            this.MenuOfAwesomeness.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromSpreadsheetToolStripMenuItem,
            this.fromXMLToolStripMenuItem,
            this.fromtxtToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "&Import";
            // 
            // fromSpreadsheetToolStripMenuItem
            // 
            this.fromSpreadsheetToolStripMenuItem.Name = "fromSpreadsheetToolStripMenuItem";
            this.fromSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.fromSpreadsheetToolStripMenuItem.Text = "From &Spreadsheet";
            // 
            // fromXMLToolStripMenuItem
            // 
            this.fromXMLToolStripMenuItem.Name = "fromXMLToolStripMenuItem";
            this.fromXMLToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.fromXMLToolStripMenuItem.Text = "From &XML";
            // 
            // fromtxtToolStripMenuItem
            // 
            this.fromtxtToolStripMenuItem.Name = "fromtxtToolStripMenuItem";
            this.fromtxtToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.fromtxtToolStripMenuItem.Text = "From &txt";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.stuffMostPeopleDontCareAboutToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // stuffMostPeopleDontCareAboutToolStripMenuItem
            // 
            this.stuffMostPeopleDontCareAboutToolStripMenuItem.Name = "stuffMostPeopleDontCareAboutToolStripMenuItem";
            this.stuffMostPeopleDontCareAboutToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.stuffMostPeopleDontCareAboutToolStripMenuItem.Text = "&Stuff most people don\'t care about";
            this.stuffMostPeopleDontCareAboutToolStripMenuItem.Click += new System.EventHandler(this.stuffMostPeopleDontCareAboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LeftToolbar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 338);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 1;
            // 
            // LeftToolbar
            // 
            this.LeftToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.LeftToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.AddCommand,
            this.RemoveCommand});
            this.LeftToolbar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.LeftToolbar.Location = new System.Drawing.Point(0, 0);
            this.LeftToolbar.Name = "LeftToolbar";
            this.LeftToolbar.Size = new System.Drawing.Size(60, 336);
            this.LeftToolbar.TabIndex = 0;
            this.LeftToolbar.Text = "LeftToolbar";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoToolTip = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 38);
            this.toolStripLabel1.Text = "Tools!";
            this.toolStripLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.toolStripLabel1.ToolTipText = "This does nothing yet. :P";
            // 
            // AddCommand
            // 
            this.AddCommand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCommand.Image = ((System.Drawing.Image)(resources.GetObject("AddCommand.Image")));
            this.AddCommand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(58, 20);
            this.AddCommand.Text = "toolStripButton1";
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // RemoveCommand
            // 
            this.RemoveCommand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveCommand.Image = ((System.Drawing.Image)(resources.GetObject("RemoveCommand.Image")));
            this.RemoveCommand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveCommand.Name = "RemoveCommand";
            this.RemoveCommand.Size = new System.Drawing.Size(58, 20);
            this.RemoveCommand.Text = "toolStripButton2";
            this.RemoveCommand.Click += new System.EventHandler(this.RemoveCommand_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.CommandListDisplay);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(718, 338);
            this.splitContainer2.SplitterDistance = 464;
            this.splitContainer2.TabIndex = 0;
            // 
            // CommandListDisplay
            // 
            this.CommandListDisplay.AllowUserToAddRows = false;
            this.CommandListDisplay.AllowUserToDeleteRows = false;
            this.CommandListDisplay.AllowUserToResizeColumns = false;
            this.CommandListDisplay.AllowUserToResizeRows = false;
            this.CommandListDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommandListDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandListDisplay.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CommandListDisplay.Location = new System.Drawing.Point(0, 0);
            this.CommandListDisplay.MultiSelect = false;
            this.CommandListDisplay.Name = "CommandListDisplay";
            this.CommandListDisplay.RowHeadersVisible = false;
            this.CommandListDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CommandListDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CommandListDisplay.Size = new System.Drawing.Size(462, 336);
            this.CommandListDisplay.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(248, 336);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OptionsPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(240, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Structure Controls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.RadioButtonHolder1);
            this.OptionsPanel.Controls.Add(this.StartingCornerLabel);
            this.OptionsPanel.Controls.Add(this.CornerSelector);
            this.OptionsPanel.Controls.Add(this.LeverBox);
            this.OptionsPanel.Controls.Add(this.DumbPlaceholder2);
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsPanel.Location = new System.Drawing.Point(3, 3);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(234, 304);
            this.OptionsPanel.TabIndex = 0;
            // 
            // RadioButtonHolder1
            // 
            this.RadioButtonHolder1.Controls.Add(this.radioButton3);
            this.RadioButtonHolder1.Controls.Add(this.radioButton2);
            this.RadioButtonHolder1.Controls.Add(this.radioButton1);
            this.RadioButtonHolder1.Location = new System.Drawing.Point(3, 96);
            this.RadioButtonHolder1.Name = "RadioButtonHolder1";
            this.RadioButtonHolder1.Size = new System.Drawing.Size(227, 100);
            this.RadioButtonHolder1.TabIndex = 4;
            this.RadioButtonHolder1.TabStop = false;
            this.RadioButtonHolder1.Text = "Preferred Structure Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(147, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Cubic (64 blocks = 4x4x4)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(166, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Quadratic (64 blocks = 8x1x8)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(155, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Linear (64 blocks = 32x1x2)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // StartingCornerLabel
            // 
            this.StartingCornerLabel.AutoSize = true;
            this.StartingCornerLabel.Location = new System.Drawing.Point(3, 54);
            this.StartingCornerLabel.Name = "StartingCornerLabel";
            this.StartingCornerLabel.Size = new System.Drawing.Size(193, 13);
            this.StartingCornerLabel.TabIndex = 3;
            this.StartingCornerLabel.Text = "Select Which Corner to Generate From:";
            // 
            // CornerSelector
            // 
            this.CornerSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CornerSelector.Enabled = false;
            this.CornerSelector.FormattingEnabled = true;
            this.CornerSelector.Items.AddRange(new object[] {
            "+X +Y +Z",
            "+X +Y -Z",
            "+X -Y +Z",
            "+X -Y -Z",
            "-X +Y +Z",
            "-X +Y -Z",
            "-X -Y +Z",
            "-X -Y -Z"});
            this.CornerSelector.Location = new System.Drawing.Point(3, 69);
            this.CornerSelector.Name = "CornerSelector";
            this.CornerSelector.Size = new System.Drawing.Size(227, 21);
            this.CornerSelector.TabIndex = 2;
            // 
            // LeverBox
            // 
            this.LeverBox.AutoSize = true;
            this.LeverBox.Enabled = false;
            this.LeverBox.Location = new System.Drawing.Point(3, 34);
            this.LeverBox.Name = "LeverBox";
            this.LeverBox.Size = new System.Drawing.Size(148, 17);
            this.LeverBox.TabIndex = 0;
            this.LeverBox.Text = "Include Lever in Structure";
            this.LeverBox.UseVisualStyleBackColor = true;
            // 
            // DumbPlaceholder2
            // 
            this.DumbPlaceholder2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DumbPlaceholder2.Location = new System.Drawing.Point(0, 0);
            this.DumbPlaceholder2.Name = "DumbPlaceholder2";
            this.DumbPlaceholder2.Size = new System.Drawing.Size(234, 304);
            this.DumbPlaceholder2.TabIndex = 1;
            this.DumbPlaceholder2.Text = "Features that haven\'t been implemented yet have their buttons disabled.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DumbPlaceholder1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(240, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Formulas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DumbPlaceholder1
            // 
            this.DumbPlaceholder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DumbPlaceholder1.Location = new System.Drawing.Point(3, 3);
            this.DumbPlaceholder1.Name = "DumbPlaceholder1";
            this.DumbPlaceholder1.Size = new System.Drawing.Size(234, 304);
            this.DumbPlaceholder1.TabIndex = 0;
            this.DumbPlaceholder1.Text = "This is only a potential feature.\r\n\r\nFor now, just create formulas in a spreadshe" +
    "et program.";
            // 
            // commandBindingSource
            // 
            this.commandBindingSource.DataSource = typeof(Minecraft_Command_Stacker.Command);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuOfAwesomeness);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuOfAwesomeness;
            this.Name = "Form1";
            this.Text = "Minecraft Command Stacker v0.0.2ALPHA";
            this.MenuOfAwesomeness.ResumeLayout(false);
            this.MenuOfAwesomeness.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.LeftToolbar.ResumeLayout(false);
            this.LeftToolbar.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CommandListDisplay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.RadioButtonHolder1.ResumeLayout(false);
            this.RadioButtonHolder1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuOfAwesomeness;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromSpreadsheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stuffMostPeopleDontCareAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label DumbPlaceholder1;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.CheckBox LeverBox;
        private System.Windows.Forms.Label DumbPlaceholder2;
        private System.Windows.Forms.ToolStrip LeftToolbar;
        private System.Windows.Forms.ComboBox CornerSelector;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox RadioButtonHolder1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label StartingCornerLabel;
        private System.Windows.Forms.ToolStripButton AddCommand;
        private System.Windows.Forms.ToolStripButton RemoveCommand;
        private System.Windows.Forms.BindingSource commandBindingSource;
        private System.Windows.Forms.DataGridView CommandListDisplay;
    }
}

