using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseApp
{
    public partial class addElementForm : Form
    {
        private Library library;

        public addElementForm(Library inplibrary)
        {
            InitializeComponent();
            this.library = inplibrary;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phraseBox.Text) ||
                string.IsNullOrEmpty(authorBox.Text) ||
                string.IsNullOrEmpty(originBox.Text) ||
                string.IsNullOrEmpty(themeBox.Text))
            {
                MessageBox.Show("Введіть усі необхідні дані", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                         
                var newPhrase = new Phrase(phraseBox.Text, authorBox.Text, originBox.Text, themeBox.Text);
                library.Phrases.Add(newPhrase);
                DialogResult = DialogResult.OK;             
            }
        }
    }
}
