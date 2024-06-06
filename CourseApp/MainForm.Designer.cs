namespace CourseApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            phraseTextBox = new TextBox();
            authorBox = new TextBox();
            originBox = new TextBox();
            Search_Button = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            PrintToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            InfoToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            listView1 = new ListView();
            phraseColumn = new ColumnHeader();
            authorColumn = new ColumnHeader();
            themeColumn = new ColumnHeader();
            addButton = new Button();
            Select_Print_Button = new Button();
            Print_List_Button = new Button();
            Remove_Phrase_Button = new Button();
            ShowLikedPhrases_Button = new Button();
            themeBox = new ComboBox();
            phraseBindingSource3 = new BindingSource(components);
            libraryBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phraseBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // phraseTextBox
            // 
            resources.ApplyResources(phraseTextBox, "phraseTextBox");
            phraseTextBox.Name = "phraseTextBox";
            // 
            // authorBox
            // 
            resources.ApplyResources(authorBox, "authorBox");
            authorBox.Name = "authorBox";
            // 
            // originBox
            // 
            resources.ApplyResources(originBox, "originBox");
            originBox.Name = "originBox";
            // 
            // Search_Button
            // 
            resources.ApplyResources(Search_Button, "Search_Button");
            Search_Button.Cursor = Cursors.Hand;
            Search_Button.Name = "Search_Button";
            Search_Button.UseVisualStyleBackColor = true;
            Search_Button.Click += Search_Button_Click;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, OpenToolStripMenuItem, toolStripSeparator, SaveToolStripMenuItem, SaveAsToolStripMenuItem, toolStripSeparator1, PrintToolStripMenuItem, toolStripSeparator2, ExitToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // CreateToolStripMenuItem
            // 
            resources.ApplyResources(CreateToolStripMenuItem, "CreateToolStripMenuItem");
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            resources.ApplyResources(OpenToolStripMenuItem, "OpenToolStripMenuItem");
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(toolStripSeparator, "toolStripSeparator");
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(SaveToolStripMenuItem, "SaveToolStripMenuItem");
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            resources.ApplyResources(SaveAsToolStripMenuItem, "SaveAsToolStripMenuItem");
            SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // PrintToolStripMenuItem
            // 
            resources.ApplyResources(PrintToolStripMenuItem, "PrintToolStripMenuItem");
            PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            PrintToolStripMenuItem.Click += PrintToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            resources.ApplyResources(ExitToolStripMenuItem, "ExitToolStripMenuItem");
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InfoToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            resources.ApplyResources(справкаToolStripMenuItem, "справкаToolStripMenuItem");
            // 
            // InfoToolStripMenuItem
            // 
            InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            resources.ApplyResources(InfoToolStripMenuItem, "InfoToolStripMenuItem");
            InfoToolStripMenuItem.Click += InfoToolStripMenuItem_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // listView1
            // 
            resources.ApplyResources(listView1, "listView1");
            listView1.Columns.AddRange(new ColumnHeader[] { phraseColumn, authorColumn, themeColumn });
            listView1.FullRowSelect = true;
            listView1.Name = "listView1";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // phraseColumn
            // 
            resources.ApplyResources(phraseColumn, "phraseColumn");
            // 
            // authorColumn
            // 
            resources.ApplyResources(authorColumn, "authorColumn");
            // 
            // themeColumn
            // 
            resources.ApplyResources(themeColumn, "themeColumn");
            // 
            // addButton
            // 
            resources.ApplyResources(addButton, "addButton");
            addButton.Cursor = Cursors.Hand;
            addButton.Name = "addButton";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Select_Print_Button
            // 
            resources.ApplyResources(Select_Print_Button, "Select_Print_Button");
            Select_Print_Button.Cursor = Cursors.Hand;
            Select_Print_Button.Name = "Select_Print_Button";
            Select_Print_Button.UseMnemonic = false;
            Select_Print_Button.UseVisualStyleBackColor = true;
            Select_Print_Button.Click += Select_Print_Button_Click;
            // 
            // Print_List_Button
            // 
            resources.ApplyResources(Print_List_Button, "Print_List_Button");
            Print_List_Button.Cursor = Cursors.Hand;
            Print_List_Button.Name = "Print_List_Button";
            Print_List_Button.UseVisualStyleBackColor = true;
            Print_List_Button.Click += Print_List_Button_Click;
            // 
            // Remove_Phrase_Button
            // 
            resources.ApplyResources(Remove_Phrase_Button, "Remove_Phrase_Button");
            Remove_Phrase_Button.Cursor = Cursors.Hand;
            Remove_Phrase_Button.Name = "Remove_Phrase_Button";
            Remove_Phrase_Button.UseVisualStyleBackColor = true;
            Remove_Phrase_Button.Click += Remove_Phrase_Button_Click;
            // 
            // ShowLikedPhrases_Button
            // 
            resources.ApplyResources(ShowLikedPhrases_Button, "ShowLikedPhrases_Button");
            ShowLikedPhrases_Button.Cursor = Cursors.Hand;
            ShowLikedPhrases_Button.Name = "ShowLikedPhrases_Button";
            ShowLikedPhrases_Button.UseVisualStyleBackColor = true;
            ShowLikedPhrases_Button.Click += ShowLikedPhrases_Button_Click;
            // 
            // themeBox
            // 
            themeBox.DataSource = phraseBindingSource3;
            themeBox.DisplayMember = "Theme";
            resources.ApplyResources(themeBox, "themeBox");
            themeBox.FormattingEnabled = true;
            themeBox.Name = "themeBox";
            // 
            // phraseBindingSource3
            // 
            phraseBindingSource3.DataSource = typeof(Phrase);
            // 
            // libraryBindingSource
            // 
            libraryBindingSource.DataSource = typeof(Library);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2"), resources.GetString("comboBox1.Items3"), resources.GetString("comboBox1.Items4") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AcceptButton = Search_Button;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(themeBox);
            Controls.Add(ShowLikedPhrases_Button);
            Controls.Add(Remove_Phrase_Button);
            Controls.Add(Select_Print_Button);
            Controls.Add(Print_List_Button);
            Controls.Add(addButton);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(Search_Button);
            Controls.Add(originBox);
            Controls.Add(authorBox);
            Controls.Add(phraseTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phraseBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)libraryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox phraseTextBox;
        private TextBox authorBox;
        private TextBox originBox;
        private Button Search_Button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem PrintToolStripMenuItem;
        private ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem InfoToolStripMenuItem;
        private TextBox themeBox0;
        private Label label4;
        private ListView listView1;
        private ColumnHeader phraseColumn;
        private ColumnHeader authorColumn;
        private ColumnHeader themeColumn;
        private Button addButton;
        private Button Select_Print_Button;
        private Button Print_List_Button;
        private Button Remove_Phrase_Button;
        private Button ShowLikedPhrases_Button;
        private ComboBox themeBox;
        private BindingSource phraseBindingSource3;
        private BindingSource libraryBindingSource;
        private ComboBox comboBox1;
    }
}
