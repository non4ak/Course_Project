namespace CourseApp
{
    partial class addElementForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            phraseBox = new TextBox();
            authorBox = new TextBox();
            originBox = new TextBox();
            themeBox = new TextBox();
            cancelButton = new Button();
            phraseBindingSource = new BindingSource(components);
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)phraseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F);
            label1.Location = new Point(13, 43);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 0;
            label1.Text = "Вислів";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.Location = new Point(12, 189);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 1;
            label2.Text = "Тема";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F);
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 2;
            label3.Text = "Джерело";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F);
            label4.Location = new Point(12, 91);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 3;
            label4.Text = "Автор";
            // 
            // phraseBox
            // 
            phraseBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phraseBox.Font = new Font("Segoe UI", 12F);
            phraseBox.Location = new Point(93, 40);
            phraseBox.Name = "phraseBox";
            phraseBox.Size = new Size(576, 29);
            phraseBox.TabIndex = 1;
            // 
            // authorBox
            // 
            authorBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            authorBox.Font = new Font("Segoe UI", 12F);
            authorBox.Location = new Point(93, 88);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(576, 29);
            authorBox.TabIndex = 2;
            // 
            // originBox
            // 
            originBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            originBox.Font = new Font("Segoe UI", 12F);
            originBox.Location = new Point(93, 139);
            originBox.Name = "originBox";
            originBox.Size = new Size(576, 29);
            originBox.TabIndex = 3;
            // 
            // themeBox
            // 
            themeBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            themeBox.Font = new Font("Segoe UI", 12F);
            themeBox.Location = new Point(93, 186);
            themeBox.Name = "themeBox";
            themeBox.Size = new Size(576, 29);
            themeBox.TabIndex = 4;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Font = new Font("Arial", 12F);
            cancelButton.Location = new Point(549, 231);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 29);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // phraseBindingSource
            // 
            phraseBindingSource.DataSource = typeof(Phrase);
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Arial", 12F);
            addButton.Location = new Point(423, 231);
            addButton.Name = "addButton";
            addButton.Size = new Size(120, 29);
            addButton.TabIndex = 6;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // addElementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 273);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(themeBox);
            Controls.Add(originBox);
            Controls.Add(authorBox);
            Controls.Add(phraseBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Arrow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 450);
            Name = "addElementForm";
            Text = "Додавання вислову";
            ((System.ComponentModel.ISupportInitialize)phraseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox phraseBox;
        private TextBox authorBox;
        private TextBox originBox;
        private TextBox themeBox;
        private Button cancelButton;
        private BindingSource phraseBindingSource;
        private Button addButton;
    }
}