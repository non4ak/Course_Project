namespace CourseApp
{
    partial class Print_List_Form
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
            result_list2 = new ListView();
            phraseColumn = new ColumnHeader();
            authorColumn = new ColumnHeader();
            themeColumn = new ColumnHeader();
            Print_Button = new Button();
            Cancel_Button = new Button();
            Clear_Button = new Button();
            Remove_Phrase_Button = new Button();
            Export_ToTxt_Button = new Button();
            SuspendLayout();
            // 
            // result_list2
            // 
            result_list2.Columns.AddRange(new ColumnHeader[] { phraseColumn, authorColumn, themeColumn });
            result_list2.Font = new Font("Segoe UI", 10F);
            result_list2.FullRowSelect = true;
            result_list2.Location = new Point(12, 93);
            result_list2.MultiSelect = false;
            result_list2.Name = "result_list2";
            result_list2.Size = new Size(824, 438);
            result_list2.TabIndex = 0;
            result_list2.UseCompatibleStateImageBehavior = false;
            result_list2.View = View.Details;
            // 
            // phraseColumn
            // 
            phraseColumn.Text = "Вислів";
            phraseColumn.Width = 400;
            // 
            // authorColumn
            // 
            authorColumn.Text = "Автор";
            authorColumn.Width = 200;
            // 
            // themeColumn
            // 
            themeColumn.Text = "Тема";
            themeColumn.Width = 200;
            // 
            // Print_Button
            // 
            Print_Button.Cursor = Cursors.Hand;
            Print_Button.Font = new Font("Arial", 10F);
            Print_Button.Location = new Point(384, 15);
            Print_Button.Name = "Print_Button";
            Print_Button.Size = new Size(180, 40);
            Print_Button.TabIndex = 3;
            Print_Button.Text = "Друкувати";
            Print_Button.UseVisualStyleBackColor = true;
            Print_Button.Click += Print_Button_Click;
            // 
            // Cancel_Button
            // 
            Cancel_Button.Cursor = Cursors.Hand;
            Cancel_Button.DialogResult = DialogResult.Cancel;
            Cancel_Button.Font = new Font("Arial", 10F);
            Cancel_Button.Location = new Point(706, 15);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(130, 40);
            Cancel_Button.TabIndex = 5;
            Cancel_Button.Text = "Скасувати";
            Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Clear_Button
            // 
            Clear_Button.Cursor = Cursors.Hand;
            Clear_Button.Font = new Font("Arial", 10F);
            Clear_Button.Location = new Point(570, 15);
            Clear_Button.Name = "Clear_Button";
            Clear_Button.Size = new Size(130, 40);
            Clear_Button.TabIndex = 4;
            Clear_Button.Text = "Очистити";
            Clear_Button.UseVisualStyleBackColor = true;
            Clear_Button.Click += Clear_Button_Click;
            // 
            // Remove_Phrase_Button
            // 
            Remove_Phrase_Button.Cursor = Cursors.Hand;
            Remove_Phrase_Button.Font = new Font("Arial", 10F);
            Remove_Phrase_Button.Location = new Point(12, 15);
            Remove_Phrase_Button.Name = "Remove_Phrase_Button";
            Remove_Phrase_Button.Size = new Size(180, 40);
            Remove_Phrase_Button.TabIndex = 1;
            Remove_Phrase_Button.Text = "Видалити вислів";
            Remove_Phrase_Button.UseVisualStyleBackColor = true;
            Remove_Phrase_Button.Click += Remove_Phrase_Button_Click;
            // 
            // Export_ToTxt_Button
            // 
            Export_ToTxt_Button.Cursor = Cursors.Hand;
            Export_ToTxt_Button.Font = new Font("Arial", 10F);
            Export_ToTxt_Button.Location = new Point(198, 15);
            Export_ToTxt_Button.Name = "Export_ToTxt_Button";
            Export_ToTxt_Button.Size = new Size(180, 40);
            Export_ToTxt_Button.TabIndex = 2;
            Export_ToTxt_Button.Text = "Експортувати у txt";
            Export_ToTxt_Button.UseVisualStyleBackColor = true;
            Export_ToTxt_Button.Click += Export_ToTxt_Button_Click;
            // 
            // Print_List_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 543);
            Controls.Add(Export_ToTxt_Button);
            Controls.Add(Remove_Phrase_Button);
            Controls.Add(Clear_Button);
            Controls.Add(Cancel_Button);
            Controls.Add(Print_Button);
            Controls.Add(result_list2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Print_List_Form";
            Text = "Друк";
            ResumeLayout(false);
        }

        #endregion

        private ListView result_list2;
        private ColumnHeader phraseColumn;
        private ColumnHeader authorColumn;
        private ColumnHeader themeColumn;
        private Button Print_Button;
        private Button Cancel_Button;
        private Button Clear_Button;
        private Button Remove_Phrase_Button;
        private Button Export_ToTxt_Button;
    }
}