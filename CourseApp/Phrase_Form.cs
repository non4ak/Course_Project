using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseApp
{
    public partial class Phrase_Form : Form
    {
        private Phrase phrase;
        private Library library1;

        public Phrase_Form(Phrase phrase, Library library)
        {
            InitializeComponent();

            this.phrase = phrase;
            this.library1 = library;

            phraseBox.Text = phrase.PhraseText;
            authorBox.Text = phrase.Author;
            themeBox.Text = phrase.Theme;
            originBox.Text = phrase.Origin;
        }

        private void Edit_Phrase_Button_Click(object sender, EventArgs e)
        {
            phraseBox.ReadOnly = false;
            authorBox.ReadOnly = false;
            themeBox.ReadOnly = false;
            originBox.ReadOnly = false;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            phrase.PhraseText = phraseBox.Text;
            phrase.Author = authorBox.Text;
            phrase.Theme = themeBox.Text;
            phrase.Origin = originBox.Text;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити вираз?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                library1.Phrases.Remove(phrase);
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void AddToLiked_Button_Click(object sender, EventArgs e)
        {
            phrase.IsLiked = true;
            MessageBox.Show("Ви додали фразу до улюбленого", "Сповіщення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoveFromLiked_Button_Click(object sender, EventArgs e)
        {
            phrase.IsLiked = false;
            MessageBox.Show("Ви прибрали фразу з улюбленого", "Сповіщення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            phraseBox.ReadOnly = true;
            authorBox.ReadOnly = true;
            themeBox.ReadOnly = true;
            originBox.ReadOnly = true;

            phraseBox.Text = phrase.PhraseText;
            authorBox.Text = phrase.Author;
            themeBox.Text = phrase.Theme;
            originBox.Text = phrase.Origin;
        }
    }
}
