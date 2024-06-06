namespace CourseApp
{
    partial class Phrase_Form
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
            phraseBox = new TextBox();
            authorBox = new TextBox();
            themeBox = new TextBox();
            originBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Edit_Phrase_Button = new Button();
            cancelButton = new Button();
            Save_Button = new Button();
            Delete_Button = new Button();
            AddToLiked_Button = new Button();
            RemoveFromLiked_Button = new Button();
            SuspendLayout();
            // 
            // phraseBox
            // 
            phraseBox.Font = new Font("Segoe UI", 12F);
            phraseBox.Location = new Point(12, 38);
            phraseBox.Multiline = true;
            phraseBox.Name = "phraseBox";
            phraseBox.ReadOnly = true;
            phraseBox.ScrollBars = ScrollBars.Vertical;
            phraseBox.Size = new Size(849, 165);
            phraseBox.TabIndex = 0;
            // 
            // authorBox
            // 
            authorBox.Font = new Font("Segoe UI", 12F);
            authorBox.Location = new Point(12, 256);
            authorBox.Name = "authorBox";
            authorBox.ReadOnly = true;
            authorBox.Size = new Size(370, 29);
            authorBox.TabIndex = 1;
            // 
            // themeBox
            // 
            themeBox.Font = new Font("Segoe UI", 12F);
            themeBox.Location = new Point(12, 326);
            themeBox.Name = "themeBox";
            themeBox.ReadOnly = true;
            themeBox.Size = new Size(370, 29);
            themeBox.TabIndex = 2;
            // 
            // originBox
            // 
            originBox.Font = new Font("Segoe UI", 12F);
            originBox.Location = new Point(490, 256);
            originBox.Name = "originBox";
            originBox.ReadOnly = true;
            originBox.Size = new Size(370, 29);
            originBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 4;
            label1.Text = "Вислів";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 5;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(12, 298);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 6;
            label3.Text = "Тема";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(491, 228);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 7;
            label4.Text = "Джерело";
            // 
            // Edit_Phrase_Button
            // 
            Edit_Phrase_Button.Cursor = Cursors.Hand;
            Edit_Phrase_Button.Font = new Font("Segoe UI", 10F);
            Edit_Phrase_Button.Location = new Point(489, 305);
            Edit_Phrase_Button.Name = "Edit_Phrase_Button";
            Edit_Phrase_Button.Size = new Size(120, 50);
            Edit_Phrase_Button.TabIndex = 4;
            Edit_Phrase_Button.Text = "Редагувати вислів";
            Edit_Phrase_Button.UseVisualStyleBackColor = true;
            Edit_Phrase_Button.Click += Edit_Phrase_Button_Click;
            // 
            // cancelButton
            // 
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.Font = new Font("Segoe UI", 10F);
            cancelButton.Location = new Point(615, 361);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 35);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // Save_Button
            // 
            Save_Button.Cursor = Cursors.Hand;
            Save_Button.DialogResult = DialogResult.OK;
            Save_Button.Font = new Font("Segoe UI", 10F);
            Save_Button.Location = new Point(739, 361);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(120, 35);
            Save_Button.TabIndex = 9;
            Save_Button.Text = "Зберегти";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // Delete_Button
            // 
            Delete_Button.Cursor = Cursors.Hand;
            Delete_Button.DialogResult = DialogResult.OK;
            Delete_Button.Font = new Font("Segoe UI", 10F);
            Delete_Button.Location = new Point(489, 361);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(120, 35);
            Delete_Button.TabIndex = 7;
            Delete_Button.Text = "Видалити вислів";
            Delete_Button.UseVisualStyleBackColor = true;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // AddToLiked_Button
            // 
            AddToLiked_Button.Cursor = Cursors.Hand;
            AddToLiked_Button.Font = new Font("Segoe UI", 10F);
            AddToLiked_Button.Location = new Point(615, 305);
            AddToLiked_Button.Name = "AddToLiked_Button";
            AddToLiked_Button.Size = new Size(120, 50);
            AddToLiked_Button.TabIndex = 5;
            AddToLiked_Button.Text = "Додати до улюбленого";
            AddToLiked_Button.UseVisualStyleBackColor = true;
            AddToLiked_Button.Click += AddToLiked_Button_Click;
            // 
            // RemoveFromLiked_Button
            // 
            RemoveFromLiked_Button.Cursor = Cursors.Hand;
            RemoveFromLiked_Button.Font = new Font("Segoe UI", 10F);
            RemoveFromLiked_Button.Location = new Point(741, 305);
            RemoveFromLiked_Button.Name = "RemoveFromLiked_Button";
            RemoveFromLiked_Button.Size = new Size(120, 50);
            RemoveFromLiked_Button.TabIndex = 6;
            RemoveFromLiked_Button.Text = "Прибрати з улюбленого";
            RemoveFromLiked_Button.UseVisualStyleBackColor = true;
            RemoveFromLiked_Button.Click += RemoveFromLiked_Button_Click;
            // 
            // Phrase_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 404);
            Controls.Add(RemoveFromLiked_Button);
            Controls.Add(AddToLiked_Button);
            Controls.Add(Delete_Button);
            Controls.Add(Save_Button);
            Controls.Add(cancelButton);
            Controls.Add(Edit_Phrase_Button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(originBox);
            Controls.Add(themeBox);
            Controls.Add(authorBox);
            Controls.Add(phraseBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Phrase_Form";
            Text = "Вислів";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox phraseBox;
        private TextBox authorBox;
        private TextBox themeBox;
        private TextBox originBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Edit_Phrase_Button;
        private Button cancelButton;
        private Button Save_Button;
        private Button Delete_Button;
        private Button AddToLiked_Button;
        private Button RemoveFromLiked_Button;
    }
}