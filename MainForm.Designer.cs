namespace DIRT5LanguageSelect
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.startButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.createShortcutButton = new System.Windows.Forms.Button();
            this.saveToDesktopCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(484, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "启动/Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(213, 12);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(265, 28);
            this.languageComboBox.TabIndex = 1;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageListView
            // 
            this.languageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.languageListView.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.languageListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.languageListView.Location = new System.Drawing.Point(12, 81);
            this.languageListView.MultiSelect = false;
            this.languageListView.Name = "languageListView";
            this.languageListView.ShowGroups = false;
            this.languageListView.ShowItemToolTips = true;
            this.languageListView.Size = new System.Drawing.Size(566, 223);
            this.languageListView.TabIndex = 2;
            this.languageListView.UseCompatibleStateImageBehavior = false;
            this.languageListView.View = System.Windows.Forms.View.Details;
            this.languageListView.SelectedIndexChanged += new System.EventHandler(this.languageListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "代码/Code";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "全称/Full Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "语言/Language";
            this.columnHeader3.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择语言/Select Language";
            // 
            // createShortcutButton
            // 
            this.createShortcutButton.Location = new System.Drawing.Point(252, 46);
            this.createShortcutButton.Name = "createShortcutButton";
            this.createShortcutButton.Size = new System.Drawing.Size(326, 29);
            this.createShortcutButton.TabIndex = 4;
            this.createShortcutButton.Text = "创建快捷方式/Create Shortcut";
            this.createShortcutButton.UseVisualStyleBackColor = true;
            this.createShortcutButton.Click += new System.EventHandler(this.createShortcutButton_Click);
            // 
            // saveToDesktopCheckBox
            // 
            this.saveToDesktopCheckBox.AccessibleDescription = "";
            this.saveToDesktopCheckBox.AutoSize = true;
            this.saveToDesktopCheckBox.Checked = true;
            this.saveToDesktopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToDesktopCheckBox.Location = new System.Drawing.Point(12, 49);
            this.saveToDesktopCheckBox.Name = "saveToDesktopCheckBox";
            this.saveToDesktopCheckBox.Size = new System.Drawing.Size(234, 24);
            this.saveToDesktopCheckBox.TabIndex = 5;
            this.saveToDesktopCheckBox.Text = "保存到桌面/Save To Desktop";
            this.toolTip.SetToolTip(this.saveToDesktopCheckBox, "勾选时快捷方式存放到桌面，否则存放到当前目录。\r\nWhen checked, the shortcut is stored to the desktop, oth" +
        "erwise it is stored to the current directory.");
            this.saveToDesktopCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 316);
            this.Controls.Add(this.saveToDesktopCheckBox);
            this.Controls.Add(this.createShortcutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageListView);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "DIRT5LanguageSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton;
        private ComboBox languageComboBox;
        private ListView languageListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Button createShortcutButton;
        private CheckBox saveToDesktopCheckBox;
        private ToolTip toolTip;
    }
}