﻿namespace Observatory.UI
{
    partial class CoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreForm));
            ReadAllButton = new Button();
            ToggleMonitorButton = new Button();
            ClearButton = new Button();
            ExportButton = new Button();
            PopupColour = new ColorDialog();
            OverrideTooltip = new ToolTip(components);
            AboutCore = new Button();
            CoreTabControl = new ColourableTabControl();
            CoreTabPage = new TabPage();
            CoreSplitter = new SplitContainer();
            CoreLayoutPanel = new TableLayoutPanel();
            PluginList = new NoHScrollList();
            NameColumn = new ColumnHeader();
            AuthorColumn = new ColumnHeader();
            TypeColumn = new ColumnHeader();
            VersionColumn = new ColumnHeader();
            StatusColumn = new ColumnHeader();
            PluginListButtonsLayoutPanel = new FlowLayoutPanel();
            AboutPluginButton = new Button();
            PluginSettingsButton = new Button();
            PluginDataDirButton = new Button();
            PluginFolderButton = new Button();
            CoreSettingsLayoutPanel = new FlowLayoutPanel();
            PopupSettingsPanel = new Panel();
            FontScaleSpinner = new NumericUpDown();
            PopupTransparentCheckBox = new CheckBox();
            LabelFontScale = new Label();
            DurationSpinner = new NumericUpDown();
            DisplayLabel = new Label();
            CornerLabel = new Label();
            LabelFont = new Label();
            LabelScale = new Label();
            LabelDuration = new Label();
            LabelColour = new Label();
            ScaleSpinner = new NumericUpDown();
            PopupLabel = new Label();
            FontDropdown = new ComboBox();
            TestButton = new Button();
            CornerDropdown = new ComboBox();
            ColourButton = new Button();
            DisplayDropdown = new ComboBox();
            PopupCheckbox = new CheckBox();
            PopupDisabledPanel = new Panel();
            PopupDisabledLabel = new Label();
            VoiceSettingsPanel = new Panel();
            VoiceSpeedSlider = new TrackBar();
            VoiceTestButton = new Button();
            VoiceCheckbox = new CheckBox();
            VoiceLabel = new Label();
            VoiceSpeedLabel = new Label();
            AudioLabel = new Label();
            VoiceDropdown = new ComboBox();
            VoiceDisabledPanel = new Panel();
            VoiceDisabledLabel = new Label();
            CoreSettingsPanel = new Panel();
            AudioDeviceLabel = new Label();
            AudioDeviceDropdown = new ComboBox();
            ExportFormatLabel = new Label();
            CoreConfigFolder = new Button();
            AudioVolumeSlider = new TrackBar();
            ExportFormatDropdown = new ComboBox();
            CoreSettingsLabel = new Label();
            StartReadallCheckbox = new CheckBox();
            StartMonitorCheckbox = new CheckBox();
            LabelJournal = new Label();
            ThemeLabel = new Label();
            VoiceVolumeLabel = new Label();
            LabelJournalPath = new Label();
            ThemeDropdown = new ComboBox();
            ButtonAddTheme = new Button();
            UpdateLink = new LinkLabel();
            CoreTabControl.SuspendLayout();
            CoreTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoreSplitter).BeginInit();
            CoreSplitter.Panel1.SuspendLayout();
            CoreSplitter.Panel2.SuspendLayout();
            CoreSplitter.SuspendLayout();
            CoreLayoutPanel.SuspendLayout();
            PluginListButtonsLayoutPanel.SuspendLayout();
            CoreSettingsLayoutPanel.SuspendLayout();
            PopupSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FontScaleSpinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationSpinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScaleSpinner).BeginInit();
            PopupDisabledPanel.SuspendLayout();
            VoiceSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VoiceSpeedSlider).BeginInit();
            VoiceDisabledPanel.SuspendLayout();
            CoreSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AudioVolumeSlider).BeginInit();
            SuspendLayout();
            // 
            // ReadAllButton
            // 
            ReadAllButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ReadAllButton.FlatAppearance.BorderSize = 0;
            ReadAllButton.FlatStyle = FlatStyle.Flat;
            ReadAllButton.Location = new Point(770, 869);
            ReadAllButton.Name = "ReadAllButton";
            ReadAllButton.Size = new Size(75, 23);
            ReadAllButton.TabIndex = 33;
            ReadAllButton.Text = "Read All";
            ReadAllButton.UseVisualStyleBackColor = false;
            ReadAllButton.Click += ReadAllButton_Click;
            // 
            // ToggleMonitorButton
            // 
            ToggleMonitorButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ToggleMonitorButton.FlatAppearance.BorderSize = 0;
            ToggleMonitorButton.FlatStyle = FlatStyle.Flat;
            ToggleMonitorButton.Location = new Point(667, 869);
            ToggleMonitorButton.Name = "ToggleMonitorButton";
            ToggleMonitorButton.Size = new Size(97, 23);
            ToggleMonitorButton.TabIndex = 32;
            ToggleMonitorButton.Text = "Start Monitor";
            ToggleMonitorButton.UseVisualStyleBackColor = false;
            ToggleMonitorButton.Click += ToggleMonitorButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.FlatAppearance.BorderSize = 0;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Location = new Point(586, 869);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 31;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExportButton.FlatAppearance.BorderSize = 0;
            ExportButton.FlatStyle = FlatStyle.Flat;
            ExportButton.Location = new Point(505, 869);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(75, 23);
            ExportButton.TabIndex = 30;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // AboutCore
            // 
            AboutCore.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AboutCore.FlatAppearance.BorderSize = 0;
            AboutCore.FlatStyle = FlatStyle.Flat;
            AboutCore.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutCore.Location = new Point(16, 864);
            AboutCore.Name = "AboutCore";
            AboutCore.Size = new Size(42, 28);
            AboutCore.TabIndex = 35;
            AboutCore.Text = "ℹ️";
            OverrideTooltip.SetToolTip(AboutCore, "About Elite Observatory Core");
            AboutCore.UseVisualStyleBackColor = true;
            AboutCore.Click += AboutCore_Click;
            // 
            // CoreTabControl
            // 
            CoreTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CoreTabControl.Controls.Add(CoreTabPage);
            CoreTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            CoreTabControl.Location = new Point(12, 12);
            CoreTabControl.Margin = new Padding(0);
            CoreTabControl.Multiline = true;
            CoreTabControl.Name = "CoreTabControl";
            CoreTabControl.SelectedIndex = 0;
            CoreTabControl.SelectedTabColor = Color.Empty;
            CoreTabControl.Size = new Size(833, 851);
            CoreTabControl.TabColor = Color.Empty;
            CoreTabControl.TabIndex = 1;
            CoreTabControl.SelectedIndexChanged += CoreTabControl_SelectedIndexChanged;
            // 
            // CoreTabPage
            // 
            CoreTabPage.BackColor = Color.Transparent;
            CoreTabPage.Controls.Add(CoreSplitter);
            CoreTabPage.Location = new Point(4, 24);
            CoreTabPage.Name = "CoreTabPage";
            CoreTabPage.Padding = new Padding(3);
            CoreTabPage.Size = new Size(825, 823);
            CoreTabPage.TabIndex = 0;
            CoreTabPage.Text = "Core";
            // 
            // CoreSplitter
            // 
            CoreSplitter.BackColor = SystemColors.ControlLight;
            CoreSplitter.Dock = DockStyle.Fill;
            CoreSplitter.FixedPanel = FixedPanel.Panel1;
            CoreSplitter.Location = new Point(3, 3);
            CoreSplitter.Name = "CoreSplitter";
            CoreSplitter.Orientation = Orientation.Horizontal;
            // 
            // CoreSplitter.Panel1
            // 
            CoreSplitter.Panel1.AutoScroll = true;
            CoreSplitter.Panel1.BackColor = SystemColors.Control;
            CoreSplitter.Panel1.Controls.Add(CoreLayoutPanel);
            // 
            // CoreSplitter.Panel2
            // 
            CoreSplitter.Panel2.BackColor = SystemColors.Control;
            CoreSplitter.Panel2.Controls.Add(CoreSettingsLayoutPanel);
            CoreSplitter.Panel2.Padding = new Padding(3);
            CoreSplitter.Size = new Size(819, 817);
            CoreSplitter.SplitterDistance = 179;
            CoreSplitter.TabIndex = 6;
            // 
            // CoreLayoutPanel
            // 
            CoreLayoutPanel.ColumnCount = 1;
            CoreLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CoreLayoutPanel.Controls.Add(PluginList, 0, 0);
            CoreLayoutPanel.Controls.Add(PluginListButtonsLayoutPanel, 0, 1);
            CoreLayoutPanel.Dock = DockStyle.Fill;
            CoreLayoutPanel.Location = new Point(0, 0);
            CoreLayoutPanel.Name = "CoreLayoutPanel";
            CoreLayoutPanel.RowCount = 2;
            CoreLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CoreLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            CoreLayoutPanel.Size = new Size(819, 179);
            CoreLayoutPanel.TabIndex = 35;
            // 
            // PluginList
            // 
            PluginList.BorderStyle = BorderStyle.None;
            PluginList.CheckBoxes = true;
            PluginList.Columns.AddRange(new ColumnHeader[] { NameColumn, AuthorColumn, TypeColumn, VersionColumn, StatusColumn });
            PluginList.Dock = DockStyle.Fill;
            PluginList.FullRowSelect = true;
            PluginList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            PluginList.ImeMode = ImeMode.NoControl;
            PluginList.Location = new Point(3, 3);
            PluginList.MultiSelect = false;
            PluginList.Name = "PluginList";
            PluginList.OwnerDraw = true;
            PluginList.Size = new Size(813, 133);
            PluginList.TabIndex = 2;
            PluginList.UseCompatibleStateImageBehavior = false;
            PluginList.View = View.Details;
            PluginList.ItemChecked += PluginList_ItemChecked;
            PluginList.Resize += PluginList_Resize;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Plugin";
            NameColumn.Width = 180;
            // 
            // AuthorColumn
            // 
            AuthorColumn.Text = "Author";
            AuthorColumn.Width = 100;
            // 
            // TypeColumn
            // 
            TypeColumn.Text = "Type";
            TypeColumn.Width = 120;
            // 
            // VersionColumn
            // 
            VersionColumn.Text = "Version";
            VersionColumn.Width = 120;
            // 
            // StatusColumn
            // 
            StatusColumn.Text = "Status";
            // 
            // PluginListButtonsLayoutPanel
            // 
            PluginListButtonsLayoutPanel.Controls.Add(AboutPluginButton);
            PluginListButtonsLayoutPanel.Controls.Add(PluginSettingsButton);
            PluginListButtonsLayoutPanel.Controls.Add(PluginDataDirButton);
            PluginListButtonsLayoutPanel.Controls.Add(PluginFolderButton);
            PluginListButtonsLayoutPanel.Dock = DockStyle.Fill;
            PluginListButtonsLayoutPanel.Location = new Point(3, 142);
            PluginListButtonsLayoutPanel.Name = "PluginListButtonsLayoutPanel";
            PluginListButtonsLayoutPanel.Size = new Size(813, 34);
            PluginListButtonsLayoutPanel.TabIndex = 9;
            // 
            // AboutPluginButton
            // 
            AboutPluginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AboutPluginButton.FlatAppearance.BorderSize = 0;
            AboutPluginButton.FlatStyle = FlatStyle.Flat;
            AboutPluginButton.Location = new Point(3, 3);
            AboutPluginButton.Name = "AboutPluginButton";
            AboutPluginButton.Size = new Size(120, 23);
            AboutPluginButton.TabIndex = 6;
            AboutPluginButton.Text = "About Plugin";
            AboutPluginButton.UseVisualStyleBackColor = false;
            AboutPluginButton.Click += AboutPluginButton_Click;
            // 
            // PluginSettingsButton
            // 
            PluginSettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PluginSettingsButton.FlatAppearance.BorderSize = 0;
            PluginSettingsButton.FlatStyle = FlatStyle.Flat;
            PluginSettingsButton.Location = new Point(129, 3);
            PluginSettingsButton.Name = "PluginSettingsButton";
            PluginSettingsButton.Size = new Size(120, 23);
            PluginSettingsButton.TabIndex = 3;
            PluginSettingsButton.Text = "Plugin Settings";
            PluginSettingsButton.UseVisualStyleBackColor = false;
            PluginSettingsButton.Click += PluginSettingsButton_Click;
            // 
            // PluginDataDirButton
            // 
            PluginDataDirButton.FlatAppearance.BorderSize = 0;
            PluginDataDirButton.FlatStyle = FlatStyle.Flat;
            PluginDataDirButton.Location = new Point(255, 3);
            PluginDataDirButton.Name = "PluginDataDirButton";
            PluginDataDirButton.Size = new Size(155, 23);
            PluginDataDirButton.TabIndex = 4;
            PluginDataDirButton.Text = "Open Plugin Data Folder";
            PluginDataDirButton.UseVisualStyleBackColor = true;
            PluginDataDirButton.Click += PluginDataDirButton_Click;
            // 
            // PluginFolderButton
            // 
            PluginFolderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PluginFolderButton.FlatAppearance.BorderSize = 0;
            PluginFolderButton.FlatStyle = FlatStyle.Flat;
            PluginFolderButton.Location = new Point(416, 3);
            PluginFolderButton.Name = "PluginFolderButton";
            PluginFolderButton.Size = new Size(130, 23);
            PluginFolderButton.TabIndex = 5;
            PluginFolderButton.Text = "Open Plugins Folder";
            PluginFolderButton.UseVisualStyleBackColor = false;
            PluginFolderButton.Click += PluginFolderButton_Click;
            // 
            // CoreSettingsLayoutPanel
            // 
            CoreSettingsLayoutPanel.AutoScroll = true;
            CoreSettingsLayoutPanel.Controls.Add(PopupSettingsPanel);
            CoreSettingsLayoutPanel.Controls.Add(VoiceSettingsPanel);
            CoreSettingsLayoutPanel.Controls.Add(CoreSettingsPanel);
            CoreSettingsLayoutPanel.Dock = DockStyle.Fill;
            CoreSettingsLayoutPanel.Location = new Point(3, 3);
            CoreSettingsLayoutPanel.Name = "CoreSettingsLayoutPanel";
            CoreSettingsLayoutPanel.Size = new Size(813, 628);
            CoreSettingsLayoutPanel.TabIndex = 34;
            // 
            // PopupSettingsPanel
            // 
            PopupSettingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PopupSettingsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PopupSettingsPanel.BorderStyle = BorderStyle.FixedSingle;
            PopupSettingsPanel.Controls.Add(FontScaleSpinner);
            PopupSettingsPanel.Controls.Add(PopupTransparentCheckBox);
            PopupSettingsPanel.Controls.Add(LabelFontScale);
            PopupSettingsPanel.Controls.Add(DurationSpinner);
            PopupSettingsPanel.Controls.Add(DisplayLabel);
            PopupSettingsPanel.Controls.Add(CornerLabel);
            PopupSettingsPanel.Controls.Add(LabelFont);
            PopupSettingsPanel.Controls.Add(LabelScale);
            PopupSettingsPanel.Controls.Add(LabelDuration);
            PopupSettingsPanel.Controls.Add(LabelColour);
            PopupSettingsPanel.Controls.Add(ScaleSpinner);
            PopupSettingsPanel.Controls.Add(PopupLabel);
            PopupSettingsPanel.Controls.Add(FontDropdown);
            PopupSettingsPanel.Controls.Add(TestButton);
            PopupSettingsPanel.Controls.Add(CornerDropdown);
            PopupSettingsPanel.Controls.Add(ColourButton);
            PopupSettingsPanel.Controls.Add(DisplayDropdown);
            PopupSettingsPanel.Controls.Add(PopupCheckbox);
            PopupSettingsPanel.Controls.Add(PopupDisabledPanel);
            PopupSettingsPanel.Location = new Point(3, 3);
            PopupSettingsPanel.Name = "PopupSettingsPanel";
            PopupSettingsPanel.Size = new Size(550, 240);
            PopupSettingsPanel.TabIndex = 29;
            // 
            // FontScaleSpinner
            // 
            FontScaleSpinner.Location = new Point(292, 109);
            FontScaleSpinner.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            FontScaleSpinner.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FontScaleSpinner.Name = "FontScaleSpinner";
            FontScaleSpinner.Size = new Size(67, 23);
            FontScaleSpinner.TabIndex = 12;
            FontScaleSpinner.Value = new decimal(new int[] { 100, 0, 0, 0 });
            FontScaleSpinner.ValueChanged += FontScaleSpinner_ValueChanged;
            // 
            // PopupTransparentCheckBox
            // 
            PopupTransparentCheckBox.AutoSize = true;
            PopupTransparentCheckBox.Location = new Point(201, 140);
            PopupTransparentCheckBox.Name = "PopupTransparentCheckBox";
            PopupTransparentCheckBox.Size = new Size(95, 19);
            PopupTransparentCheckBox.TabIndex = 13;
            PopupTransparentCheckBox.Text = "Transparency";
            PopupTransparentCheckBox.UseVisualStyleBackColor = true;
            PopupTransparentCheckBox.CheckedChanged += PopupTransparentCheckBox_CheckedChanged;
            // 
            // LabelFontScale
            // 
            LabelFontScale.AutoSize = true;
            LabelFontScale.Location = new Point(201, 111);
            LabelFontScale.Name = "LabelFontScale";
            LabelFontScale.Size = new Size(85, 15);
            LabelFontScale.TabIndex = 11;
            LabelFontScale.Text = "Font Scale (%):";
            LabelFontScale.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DurationSpinner
            // 
            DurationSpinner.Increment = new decimal(new int[] { 25, 0, 0, 0 });
            DurationSpinner.Location = new Point(118, 138);
            DurationSpinner.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            DurationSpinner.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            DurationSpinner.Name = "DurationSpinner";
            DurationSpinner.Size = new Size(67, 23);
            DurationSpinner.TabIndex = 11;
            DurationSpinner.Value = new decimal(new int[] { 8000, 0, 0, 0 });
            DurationSpinner.ValueChanged += DurationSpinner_ValueChanged;
            // 
            // DisplayLabel
            // 
            DisplayLabel.AutoSize = true;
            DisplayLabel.Location = new Point(55, 25);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(48, 15);
            DisplayLabel.TabIndex = 0;
            DisplayLabel.Text = "Display:";
            DisplayLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CornerLabel
            // 
            CornerLabel.AutoSize = true;
            CornerLabel.Location = new Point(57, 54);
            CornerLabel.Name = "CornerLabel";
            CornerLabel.Size = new Size(46, 15);
            CornerLabel.TabIndex = 1;
            CornerLabel.Text = "Corner:";
            CornerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelFont
            // 
            LabelFont.AutoSize = true;
            LabelFont.Location = new Point(69, 83);
            LabelFont.Name = "LabelFont";
            LabelFont.Size = new Size(34, 15);
            LabelFont.TabIndex = 4;
            LabelFont.Text = "Font:";
            LabelFont.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelScale
            // 
            LabelScale.AutoSize = true;
            LabelScale.Location = new Point(45, 111);
            LabelScale.Name = "LabelScale";
            LabelScale.Size = new Size(58, 15);
            LabelScale.TabIndex = 7;
            LabelScale.Text = "Scale (%):";
            LabelScale.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelDuration
            // 
            LabelDuration.AutoSize = true;
            LabelDuration.Location = new Point(20, 140);
            LabelDuration.Name = "LabelDuration";
            LabelDuration.Size = new Size(83, 15);
            LabelDuration.TabIndex = 9;
            LabelDuration.Text = "Duration (ms):";
            LabelDuration.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelColour
            // 
            LabelColour.AutoSize = true;
            LabelColour.Location = new Point(57, 171);
            LabelColour.Name = "LabelColour";
            LabelColour.Size = new Size(46, 15);
            LabelColour.TabIndex = 13;
            LabelColour.Text = "Colour:";
            LabelColour.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ScaleSpinner
            // 
            ScaleSpinner.Location = new Point(118, 109);
            ScaleSpinner.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            ScaleSpinner.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ScaleSpinner.Name = "ScaleSpinner";
            ScaleSpinner.Size = new Size(67, 23);
            ScaleSpinner.TabIndex = 10;
            ScaleSpinner.Value = new decimal(new int[] { 100, 0, 0, 0 });
            ScaleSpinner.ValueChanged += ScaleSpinner_ValueChanged;
            // 
            // PopupLabel
            // 
            PopupLabel.AutoSize = true;
            PopupLabel.Location = new Point(0, -1);
            PopupLabel.Name = "PopupLabel";
            PopupLabel.Size = new Size(113, 15);
            PopupLabel.TabIndex = 30;
            PopupLabel.Text = "Popup Notifications";
            // 
            // FontDropdown
            // 
            FontDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            FontDropdown.FormattingEnabled = true;
            FontDropdown.Location = new Point(117, 80);
            FontDropdown.Name = "FontDropdown";
            FontDropdown.Size = new Size(242, 23);
            FontDropdown.TabIndex = 9;
            FontDropdown.SelectedIndexChanged += FontDropdown_SelectedIndexChanged;
            // 
            // TestButton
            // 
            TestButton.FlatAppearance.BorderSize = 0;
            TestButton.FlatStyle = FlatStyle.Flat;
            TestButton.Location = new Point(187, 167);
            TestButton.Name = "TestButton";
            TestButton.Size = new Size(51, 23);
            TestButton.TabIndex = 13;
            TestButton.Text = "Test";
            TestButton.UseVisualStyleBackColor = false;
            TestButton.Click += TestButton_Click;
            // 
            // CornerDropdown
            // 
            CornerDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            CornerDropdown.FormattingEnabled = true;
            CornerDropdown.Items.AddRange(new object[] { "Bottom-Right", "Bottom-Left", "Top-Right", "Top-Left", "Center-Top", "Center-Bottom", "Center-Left", "Center-Right" });
            CornerDropdown.Location = new Point(117, 51);
            CornerDropdown.Name = "CornerDropdown";
            CornerDropdown.Size = new Size(121, 23);
            CornerDropdown.TabIndex = 8;
            CornerDropdown.SelectedIndexChanged += CornerDropdown_SelectedIndexChanged;
            // 
            // ColourButton
            // 
            ColourButton.FlatStyle = FlatStyle.Flat;
            ColourButton.Location = new Point(118, 167);
            ColourButton.Name = "ColourButton";
            ColourButton.Size = new Size(51, 23);
            ColourButton.TabIndex = 12;
            ColourButton.UseVisualStyleBackColor = true;
            ColourButton.Click += ColourButton_Click;
            // 
            // DisplayDropdown
            // 
            DisplayDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            DisplayDropdown.FormattingEnabled = true;
            DisplayDropdown.Location = new Point(117, 22);
            DisplayDropdown.Name = "DisplayDropdown";
            DisplayDropdown.Size = new Size(121, 23);
            DisplayDropdown.TabIndex = 7;
            DisplayDropdown.SelectedIndexChanged += DisplayDropdown_SelectedIndexChanged;
            // 
            // PopupCheckbox
            // 
            PopupCheckbox.AutoSize = true;
            PopupCheckbox.Location = new Point(117, 196);
            PopupCheckbox.Name = "PopupCheckbox";
            PopupCheckbox.Size = new Size(68, 19);
            PopupCheckbox.TabIndex = 14;
            PopupCheckbox.Text = "Enabled";
            PopupCheckbox.UseVisualStyleBackColor = true;
            PopupCheckbox.CheckedChanged += PopupCheckbox_CheckedChanged;
            // 
            // PopupDisabledPanel
            // 
            PopupDisabledPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PopupDisabledPanel.Controls.Add(PopupDisabledLabel);
            PopupDisabledPanel.Enabled = false;
            PopupDisabledPanel.Location = new Point(3, 17);
            PopupDisabledPanel.Name = "PopupDisabledPanel";
            PopupDisabledPanel.Size = new Size(542, 218);
            PopupDisabledPanel.TabIndex = 16;
            PopupDisabledPanel.Visible = false;
            // 
            // PopupDisabledLabel
            // 
            PopupDisabledLabel.AutoSize = true;
            PopupDisabledLabel.Location = new Point(19, 12);
            PopupDisabledLabel.Name = "PopupDisabledLabel";
            PopupDisabledLabel.Size = new Size(141, 15);
            PopupDisabledLabel.TabIndex = 0;
            PopupDisabledLabel.Text = "Placeholder Disabled Text";
            // 
            // VoiceSettingsPanel
            // 
            VoiceSettingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VoiceSettingsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            VoiceSettingsPanel.BorderStyle = BorderStyle.FixedSingle;
            VoiceSettingsPanel.Controls.Add(VoiceSpeedSlider);
            VoiceSettingsPanel.Controls.Add(VoiceTestButton);
            VoiceSettingsPanel.Controls.Add(VoiceCheckbox);
            VoiceSettingsPanel.Controls.Add(VoiceLabel);
            VoiceSettingsPanel.Controls.Add(VoiceSpeedLabel);
            VoiceSettingsPanel.Controls.Add(AudioLabel);
            VoiceSettingsPanel.Controls.Add(VoiceDropdown);
            VoiceSettingsPanel.Controls.Add(VoiceDisabledPanel);
            VoiceSettingsPanel.Location = new Point(3, 249);
            VoiceSettingsPanel.Name = "VoiceSettingsPanel";
            VoiceSettingsPanel.Size = new Size(550, 240);
            VoiceSettingsPanel.TabIndex = 30;
            // 
            // VoiceSpeedSlider
            // 
            VoiceSpeedSlider.Location = new Point(117, 20);
            VoiceSpeedSlider.Minimum = -10;
            VoiceSpeedSlider.Name = "VoiceSpeedSlider";
            VoiceSpeedSlider.Size = new Size(242, 45);
            VoiceSpeedSlider.TabIndex = 15;
            VoiceSpeedSlider.TickStyle = TickStyle.Both;
            VoiceSpeedSlider.Value = 10;
            VoiceSpeedSlider.Scroll += VoiceSpeedSlider_Scroll;
            // 
            // VoiceTestButton
            // 
            VoiceTestButton.FlatAppearance.BorderSize = 0;
            VoiceTestButton.FlatStyle = FlatStyle.Flat;
            VoiceTestButton.Location = new Point(191, 97);
            VoiceTestButton.Name = "VoiceTestButton";
            VoiceTestButton.Size = new Size(51, 23);
            VoiceTestButton.TabIndex = 13;
            VoiceTestButton.Text = "Test";
            VoiceTestButton.UseVisualStyleBackColor = false;
            VoiceTestButton.Click += VoiceTestButton_Click;
            // 
            // VoiceCheckbox
            // 
            VoiceCheckbox.AutoSize = true;
            VoiceCheckbox.Location = new Point(117, 100);
            VoiceCheckbox.Name = "VoiceCheckbox";
            VoiceCheckbox.Size = new Size(68, 19);
            VoiceCheckbox.TabIndex = 11;
            VoiceCheckbox.Text = "Enabled";
            VoiceCheckbox.UseVisualStyleBackColor = true;
            VoiceCheckbox.CheckedChanged += VoiceCheckbox_CheckedChanged;
            // 
            // VoiceLabel
            // 
            VoiceLabel.AutoSize = true;
            VoiceLabel.Location = new Point(65, 74);
            VoiceLabel.Name = "VoiceLabel";
            VoiceLabel.Size = new Size(38, 15);
            VoiceLabel.TabIndex = 4;
            VoiceLabel.Text = "Voice:";
            VoiceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VoiceSpeedLabel
            // 
            VoiceSpeedLabel.AutoSize = true;
            VoiceSpeedLabel.Location = new Point(61, 32);
            VoiceSpeedLabel.Name = "VoiceSpeedLabel";
            VoiceSpeedLabel.Size = new Size(42, 15);
            VoiceSpeedLabel.TabIndex = 1;
            VoiceSpeedLabel.Text = "Speed:";
            VoiceSpeedLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AudioLabel
            // 
            AudioLabel.AutoSize = true;
            AudioLabel.Location = new Point(0, 0);
            AudioLabel.Name = "AudioLabel";
            AudioLabel.Size = new Size(106, 15);
            AudioLabel.TabIndex = 31;
            AudioLabel.Text = "Voice Notifications";
            // 
            // VoiceDropdown
            // 
            VoiceDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            VoiceDropdown.FormattingEnabled = true;
            VoiceDropdown.Location = new Point(117, 71);
            VoiceDropdown.Name = "VoiceDropdown";
            VoiceDropdown.Size = new Size(121, 23);
            VoiceDropdown.TabIndex = 16;
            VoiceDropdown.SelectedIndexChanged += VoiceDropdown_SelectedIndexChanged;
            // 
            // VoiceDisabledPanel
            // 
            VoiceDisabledPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VoiceDisabledPanel.Controls.Add(VoiceDisabledLabel);
            VoiceDisabledPanel.Enabled = false;
            VoiceDisabledPanel.Location = new Point(3, 18);
            VoiceDisabledPanel.Name = "VoiceDisabledPanel";
            VoiceDisabledPanel.Size = new Size(542, 217);
            VoiceDisabledPanel.TabIndex = 16;
            VoiceDisabledPanel.Visible = false;
            // 
            // VoiceDisabledLabel
            // 
            VoiceDisabledLabel.AutoSize = true;
            VoiceDisabledLabel.Location = new Point(19, 12);
            VoiceDisabledLabel.Name = "VoiceDisabledLabel";
            VoiceDisabledLabel.Size = new Size(141, 15);
            VoiceDisabledLabel.TabIndex = 0;
            VoiceDisabledLabel.Text = "Placeholder Disabled Text";
            // 
            // CoreSettingsPanel
            // 
            CoreSettingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CoreSettingsPanel.BorderStyle = BorderStyle.FixedSingle;
            CoreSettingsPanel.Controls.Add(AudioDeviceLabel);
            CoreSettingsPanel.Controls.Add(AudioDeviceDropdown);
            CoreSettingsPanel.Controls.Add(ExportFormatLabel);
            CoreSettingsPanel.Controls.Add(CoreConfigFolder);
            CoreSettingsPanel.Controls.Add(AudioVolumeSlider);
            CoreSettingsPanel.Controls.Add(ExportFormatDropdown);
            CoreSettingsPanel.Controls.Add(CoreSettingsLabel);
            CoreSettingsPanel.Controls.Add(StartReadallCheckbox);
            CoreSettingsPanel.Controls.Add(StartMonitorCheckbox);
            CoreSettingsPanel.Controls.Add(LabelJournal);
            CoreSettingsPanel.Controls.Add(ThemeLabel);
            CoreSettingsPanel.Controls.Add(VoiceVolumeLabel);
            CoreSettingsPanel.Controls.Add(LabelJournalPath);
            CoreSettingsPanel.Controls.Add(ThemeDropdown);
            CoreSettingsPanel.Controls.Add(ButtonAddTheme);
            CoreSettingsPanel.Location = new Point(3, 495);
            CoreSettingsPanel.Name = "CoreSettingsPanel";
            CoreSettingsPanel.Size = new Size(550, 240);
            CoreSettingsPanel.TabIndex = 33;
            CoreSettingsPanel.Tag = "";
            // 
            // AudioDeviceLabel
            // 
            AudioDeviceLabel.AutoSize = true;
            AudioDeviceLabel.Location = new Point(23, 160);
            AudioDeviceLabel.Name = "AudioDeviceLabel";
            AudioDeviceLabel.Size = new Size(80, 15);
            AudioDeviceLabel.TabIndex = 37;
            AudioDeviceLabel.Text = "Audio Device:";
            // 
            // AudioDeviceDropdown
            // 
            AudioDeviceDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            AudioDeviceDropdown.FormattingEnabled = true;
            AudioDeviceDropdown.Location = new Point(117, 157);
            AudioDeviceDropdown.Name = "AudioDeviceDropdown";
            AudioDeviceDropdown.Size = new Size(214, 23);
            AudioDeviceDropdown.TabIndex = 25;
            AudioDeviceDropdown.SelectedIndexChanged += AudioDeviceDropdown_SelectedIndexChanged;
            AudioDeviceDropdown.Click += AudioDeviceDropdown_Focused;
            // 
            // ExportFormatLabel
            // 
            ExportFormatLabel.AutoSize = true;
            ExportFormatLabel.Location = new Point(18, 57);
            ExportFormatLabel.Name = "ExportFormatLabel";
            ExportFormatLabel.Size = new Size(85, 15);
            ExportFormatLabel.TabIndex = 35;
            ExportFormatLabel.Text = "Export Format:";
            // 
            // CoreConfigFolder
            // 
            CoreConfigFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CoreConfigFolder.FlatAppearance.BorderSize = 0;
            CoreConfigFolder.FlatStyle = FlatStyle.Flat;
            CoreConfigFolder.Location = new Point(455, 3);
            CoreConfigFolder.Name = "CoreConfigFolder";
            CoreConfigFolder.Size = new Size(90, 23);
            CoreConfigFolder.TabIndex = 19;
            CoreConfigFolder.Text = "Config Folder";
            CoreConfigFolder.UseVisualStyleBackColor = true;
            CoreConfigFolder.Click += CoreConfigFolder_Click;
            // 
            // AudioVolumeSlider
            // 
            AudioVolumeSlider.LargeChange = 10;
            AudioVolumeSlider.Location = new Point(117, 112);
            AudioVolumeSlider.Maximum = 100;
            AudioVolumeSlider.Name = "AudioVolumeSlider";
            AudioVolumeSlider.Size = new Size(214, 45);
            AudioVolumeSlider.TabIndex = 24;
            AudioVolumeSlider.TickFrequency = 10;
            AudioVolumeSlider.TickStyle = TickStyle.Both;
            AudioVolumeSlider.Value = 100;
            AudioVolumeSlider.Scroll += AudioVolumeSlider_Scroll;
            // 
            // ExportFormatDropdown
            // 
            ExportFormatDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            ExportFormatDropdown.FormattingEnabled = true;
            ExportFormatDropdown.Items.AddRange(new object[] { "Tab-Separated Values (csv)", "Office Open XML (xlsx)" });
            ExportFormatDropdown.Location = new Point(117, 54);
            ExportFormatDropdown.Name = "ExportFormatDropdown";
            ExportFormatDropdown.Size = new Size(214, 23);
            ExportFormatDropdown.TabIndex = 21;
            ExportFormatDropdown.SelectedIndexChanged += ExportFormatDropdown_SelectedIndexChanged;
            // 
            // CoreSettingsLabel
            // 
            CoreSettingsLabel.AutoSize = true;
            CoreSettingsLabel.Location = new Point(0, 0);
            CoreSettingsLabel.Name = "CoreSettingsLabel";
            CoreSettingsLabel.Size = new Size(77, 15);
            CoreSettingsLabel.TabIndex = 33;
            CoreSettingsLabel.Text = "Core Settings";
            // 
            // StartReadallCheckbox
            // 
            StartReadallCheckbox.AutoSize = true;
            StartReadallCheckbox.Location = new Point(117, 211);
            StartReadallCheckbox.Name = "StartReadallCheckbox";
            StartReadallCheckbox.Size = new Size(130, 19);
            StartReadallCheckbox.TabIndex = 27;
            StartReadallCheckbox.Text = "Read All On Launch";
            StartReadallCheckbox.UseVisualStyleBackColor = true;
            StartReadallCheckbox.CheckedChanged += StartReadallCheckbox_CheckedChanged;
            // 
            // StartMonitorCheckbox
            // 
            StartMonitorCheckbox.AutoSize = true;
            StartMonitorCheckbox.Location = new Point(117, 186);
            StartMonitorCheckbox.Name = "StartMonitorCheckbox";
            StartMonitorCheckbox.Size = new Size(157, 19);
            StartMonitorCheckbox.TabIndex = 26;
            StartMonitorCheckbox.Text = "Start Monitor On Launch";
            StartMonitorCheckbox.UseVisualStyleBackColor = true;
            StartMonitorCheckbox.CheckedChanged += StartMonitorCheckbox_CheckedChanged;
            // 
            // LabelJournal
            // 
            LabelJournal.AutoSize = true;
            LabelJournal.Location = new Point(19, 32);
            LabelJournal.Name = "LabelJournal";
            LabelJournal.Size = new Size(84, 15);
            LabelJournal.TabIndex = 12;
            LabelJournal.Text = "Journal Folder:";
            // 
            // ThemeLabel
            // 
            ThemeLabel.AutoSize = true;
            ThemeLabel.Location = new Point(57, 86);
            ThemeLabel.Name = "ThemeLabel";
            ThemeLabel.Size = new Size(46, 15);
            ThemeLabel.TabIndex = 9;
            ThemeLabel.Text = "Theme:";
            ThemeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VoiceVolumeLabel
            // 
            VoiceVolumeLabel.AutoSize = true;
            VoiceVolumeLabel.Location = new Point(53, 125);
            VoiceVolumeLabel.Name = "VoiceVolumeLabel";
            VoiceVolumeLabel.Size = new Size(50, 15);
            VoiceVolumeLabel.TabIndex = 0;
            VoiceVolumeLabel.Text = "Volume:";
            VoiceVolumeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelJournalPath
            // 
            LabelJournalPath.Font = new Font("Segoe UI", 8.25F);
            LabelJournalPath.Location = new Point(117, 32);
            LabelJournalPath.Name = "LabelJournalPath";
            LabelJournalPath.Size = new Size(424, 13);
            LabelJournalPath.TabIndex = 20;
            LabelJournalPath.Text = "X:\\Journal";
            LabelJournalPath.DoubleClick += LabelJournalPath_DoubleClick;
            // 
            // ThemeDropdown
            // 
            ThemeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            ThemeDropdown.FormattingEnabled = true;
            ThemeDropdown.Location = new Point(117, 83);
            ThemeDropdown.Name = "ThemeDropdown";
            ThemeDropdown.Size = new Size(214, 23);
            ThemeDropdown.TabIndex = 22;
            ThemeDropdown.SelectedIndexChanged += ThemeDropdown_SelectedIndexChanged;
            // 
            // ButtonAddTheme
            // 
            ButtonAddTheme.FlatAppearance.BorderSize = 0;
            ButtonAddTheme.FlatStyle = FlatStyle.Flat;
            ButtonAddTheme.Location = new Point(344, 81);
            ButtonAddTheme.Name = "ButtonAddTheme";
            ButtonAddTheme.Size = new Size(88, 23);
            ButtonAddTheme.TabIndex = 23;
            ButtonAddTheme.Text = "Add Theme";
            ButtonAddTheme.UseVisualStyleBackColor = true;
            ButtonAddTheme.Click += ButtonAddTheme_Click;
            // 
            // UpdateLink
            // 
            UpdateLink.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UpdateLink.AutoSize = true;
            UpdateLink.Enabled = false;
            UpdateLink.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateLink.Location = new Point(60, 865);
            UpdateLink.Name = "UpdateLink";
            UpdateLink.Size = new Size(207, 32);
            UpdateLink.TabIndex = 34;
            UpdateLink.TabStop = true;
            UpdateLink.Text = "Update Available";
            UpdateLink.Visible = false;
            // 
            // CoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 904);
            Controls.Add(AboutCore);
            Controls.Add(UpdateLink);
            Controls.Add(CoreTabControl);
            Controls.Add(ExportButton);
            Controls.Add(ClearButton);
            Controls.Add(ToggleMonitorButton);
            Controls.Add(ReadAllButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 300);
            Name = "CoreForm";
            Text = "Elite Observatory Core";
            FormClosing += CoreForm_FormClosing;
            Load += CoreForm_Load;
            Shown += CoreForm_Shown;
            ResizeBegin += CoreForm_ResizeBegin;
            ResizeEnd += CoreForm_ResizeEnd;
            CoreTabControl.ResumeLayout(false);
            CoreTabPage.ResumeLayout(false);
            CoreSplitter.Panel1.ResumeLayout(false);
            CoreSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CoreSplitter).EndInit();
            CoreSplitter.ResumeLayout(false);
            CoreLayoutPanel.ResumeLayout(false);
            PluginListButtonsLayoutPanel.ResumeLayout(false);
            CoreSettingsLayoutPanel.ResumeLayout(false);
            PopupSettingsPanel.ResumeLayout(false);
            PopupSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FontScaleSpinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationSpinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScaleSpinner).EndInit();
            PopupDisabledPanel.ResumeLayout(false);
            PopupDisabledPanel.PerformLayout();
            VoiceSettingsPanel.ResumeLayout(false);
            VoiceSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VoiceSpeedSlider).EndInit();
            VoiceDisabledPanel.ResumeLayout(false);
            VoiceDisabledPanel.PerformLayout();
            CoreSettingsPanel.ResumeLayout(false);
            CoreSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AudioVolumeSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ReadAllButton;
        private Button ToggleMonitorButton;
        private Button ClearButton;
        private Button ExportButton;
        private ColorDialog PopupColour;
        private ToolTip OverrideTooltip;
        private ColourableTabControl CoreTabControl;
        private TabPage CoreTabPage;
        private SplitContainer CoreSplitter;
        private TableLayoutPanel CoreLayoutPanel;
        private NoHScrollList PluginList;
        private ColumnHeader NameColumn;
        private ColumnHeader TypeColumn;
        private ColumnHeader VersionColumn;
        private ColumnHeader StatusColumn;
        private FlowLayoutPanel PluginListButtonsLayoutPanel;
        private Button PluginFolderButton;
        private Button PluginSettingsButton;
        private FlowLayoutPanel CoreSettingsLayoutPanel;
        private Panel PopupSettingsPanel;
        private NumericUpDown DurationSpinner;
        private NumericUpDown ScaleSpinner;
        private Label LabelColour;
        private Button TestButton;
        private Button ColourButton;
        private CheckBox PopupCheckbox;
        private Label LabelDuration;
        private Label LabelScale;
        private ComboBox FontDropdown;
        private Label LabelFont;
        private ComboBox CornerDropdown;
        private ComboBox DisplayDropdown;
        private Label CornerLabel;
        private Label DisplayLabel;
        private Panel PopupDisabledPanel;
        private Label PopupDisabledLabel;
        private Label PopupLabel;
        private Panel VoiceSettingsPanel;
        private TrackBar VoiceSpeedSlider;
        private TrackBar AudioVolumeSlider;
        private Button VoiceTestButton;
        private CheckBox VoiceCheckbox;
        private ComboBox VoiceDropdown;
        private Label VoiceLabel;
        private Label VoiceSpeedLabel;
        private Label VoiceVolumeLabel;
        private Panel VoiceDisabledPanel;
        private Label VoiceDisabledLabel;
        private Label AudioLabel;
        private Panel CoreSettingsPanel;
        private Label CoreSettingsLabel;
        private CheckBox StartReadallCheckbox;
        private CheckBox StartMonitorCheckbox;
        private Label LabelJournal;
        private Label ThemeLabel;
        private Label LabelJournalPath;
        private ComboBox ThemeDropdown;
        private Button ButtonAddTheme;
        private Label ExportFormatLabel;
        private ComboBox ExportFormatDropdown;
        private Label AudioDeviceLabel;
        private ComboBox AudioDeviceDropdown;
        private Button PluginDataDirButton;
        private Button CoreConfigFolder;
        private LinkLabel UpdateLink;
        private Button AboutCore;
        private ColumnHeader AuthorColumn;
        private Button AboutPluginButton;
        private Label LabelFontScale;
        private NumericUpDown FontScaleSpinner;
        private CheckBox PopupTransparentCheckBox;
    }
}