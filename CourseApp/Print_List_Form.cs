using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;

namespace CourseApp
{
    public partial class Print_List_Form : Form
    {
        private string text = "";

        private Library _printLibrary;

        public Print_List_Form(Library printLibrary)
        {
            this._printLibrary = printLibrary;
            InitializeComponent();

            this.Load += Print_List_Form_Load;
        }

        private void Print_List_Form_Load(object sender, EventArgs e)
        {
            Load_List(null, null);
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            _printLibrary.Phrases.Clear();
            result_list2.Items.Clear();
            Load_List(null, null);

        }

        private void Remove_Phrase_Button_Click(object sender, EventArgs e)
        {
            if (result_list2.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей вислів?", "Видалення вислову", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var phrase = result_list2.SelectedItems[0].Tag as Phrase;
                    _printLibrary.Phrases.Remove(phrase);
                    Load_List(null, null);
                    MessageBox.Show("Вислів успішно видалено", "Вислів видалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            else
            {
                MessageBox.Show("Ви не обрали вислів", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_List(object sender, EventArgs e)
        {
            result_list2.Items.Clear();

            foreach (var phrase in _printLibrary.Phrases)
            {
                var item = new ListViewItem(new[] { phrase.PhraseText, phrase.Author, phrase.Theme });
                item.Tag = phrase;
                result_list2.Items.Add(item);
            }
        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintHandler);
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDialog.Document.Print();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка друку", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int currentPhraseIndex = 0;
        private static int currentWordIndex = 0;
        private static float yPos = 0;

        private void PrintHandler(object sender, PrintPageEventArgs e)
        {
            float pageWidth = e.PageSettings.PrintableArea.Width;
            float pageHeight = e.PageSettings.PrintableArea.Height;

            Font printFont = new Font("Arial", 14);
            float leftMargin = e.MarginBounds.Left;
            float yPos = 40;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            float lineSpacing = printFont.GetHeight(e.Graphics);
            float quoteSpacing = lineSpacing * 2;

            StringBuilder sb = new StringBuilder();
            StringFormat stringFormat = new StringFormat();

            for (; currentPhraseIndex < _printLibrary.Phrases.Count; currentPhraseIndex++)
            {
                var phrase = _printLibrary.Phrases[currentPhraseIndex];
                string fullPhrase = phrase.PhraseText;
                string[] words = fullPhrase.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                for (; currentWordIndex < words.Length; currentWordIndex++)
                {
                    string word = words[currentWordIndex];
                    string testLine = sb.ToString() + word + " ";
                    float textWidth = e.Graphics.MeasureString(testLine, printFont).Width;

                    if (textWidth > e.MarginBounds.Width)
                    {
                        e.Graphics.DrawString(sb.ToString(), printFont, Brushes.Black, new RectangleF(leftMargin, yPos, e.MarginBounds.Width, lineSpacing), stringFormat);
                        yPos += lineSpacing;
                        sb.Clear();
                        sb.Append(word + " ");

        
                        if (yPos >= pageHeight - 100)
                        {
                            e.HasMorePages = true;
                            currentWordIndex++; 
                            return;
                        }
                    }
                    else
                    {
                        sb.Append(word + " ");
                    }
                }

                if (sb.Length > 0)
                {
                    e.Graphics.DrawString(sb.ToString(), printFont, Brushes.Black, new RectangleF(leftMargin, yPos, e.MarginBounds.Width, lineSpacing), stringFormat);
                    yPos += lineSpacing;


                    e.Graphics.DrawString($"({phrase.Author})", printFont, Brushes.Black, new RectangleF(leftMargin, yPos, e.MarginBounds.Width, lineSpacing), stringFormat);
                    yPos += quoteSpacing;

                    sb.Clear();

                    if (yPos >= pageHeight - 100)
                    {
                        e.HasMorePages = true;
                        currentWordIndex = 0; 
                        currentPhraseIndex++; 
                        return;
                    }
                }

                currentWordIndex = 0;
            }

            currentPhraseIndex = 0;
            currentWordIndex = 0;
            e.HasMorePages = false;
        }
        private void Export_ToTxt_Button_Click(object sender, EventArgs e)
        {
            if (_printLibrary.Phrases.Count == 0)
            {
                MessageBox.Show("Ви не обрали вислови", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog exportToTxt = new SaveFileDialog();
                exportToTxt.Filter = "Text File|*.txt";
                if (exportToTxt.ShowDialog() == DialogResult.OK)
                {
                    string path = exportToTxt.FileName;
                    using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                    {
                        foreach (var phrase in _printLibrary.Phrases)
                        {
                            sw.WriteLine($"\"{phrase.PhraseText}\"\n{phrase.Author}\n");
                        }
                    }
                }
            }
            
        }
    }   
}
