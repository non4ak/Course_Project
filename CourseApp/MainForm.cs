using System.Data;
using System.Reflection;
using static System.Reflection.Metadata.BlobBuilder;

namespace CourseApp
{
    public partial class MainForm : Form
    {
        Library library = new Library();
        Library printLibrary = new Library();

        string path_to_data = "";

        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(NewForm_FormClosing);
            comboBox1.SelectedIndex = 0;
        }

        private void NewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("�������� ���?", "����������", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (File.Exists(path_to_data))
                {
                    library.SaveData(path_to_data);
                }
                else
                {
                    SaveAsToolStripMenuItem_Click(null, null);
                }
            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {

            if (library.isLikedList == false)
            {
                var result = library.Search(phraseTextBox.Text, authorBox.Text, themeBox.Text, originBox.Text);
                listView1.Items.Clear();

                foreach (var phrase in result)
                {
                    var item = new ListViewItem(new[] { phrase.PhraseText, phrase.Author, phrase.Theme });
                    if (phrase.IsLiked)
                    {
                        item.ForeColor = Color.Green;
                    }
                    item.Tag = phrase;
                    listView1.Items.Add(item);
                }

                library.FillUnique();
                phraseBindingSource3.ResetBindings(false);
                phraseBindingSource3.DataSource = library.UniqueThemes;
            }
            else
            {
                var result = library.Search(phraseTextBox.Text, authorBox.Text, themeBox.Text, originBox.Text);
                listView1.Items.Clear();

                foreach (var phrase in result)
                {
                    if (phrase.IsLiked)
                    {
                        var item = new ListViewItem(new[] { phrase.PhraseText, phrase.Author, phrase.Theme });
                        item.ForeColor = Color.Green;
                        item.Tag = phrase;
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var dialog = new addElementForm(library);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Search_Button_Click(null, null);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var phrase = listView1.SelectedItems[0].Tag as Phrase;
                if (phrase != null)
                {
                    var dialog = new Phrase_Form(phrase, library);
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Search_Button_Click(null, null);
                    }
                }
            }
        }

        private void Select_Print_Button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    var phrase = selectedItem.Tag as Phrase;
                    printLibrary.Phrases.Add(phrase);
                }
                listView1.SelectedItems.Clear();
            }
            else
            {
                MessageBox.Show("�� �� ������� �����", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Print_List_Button_Click(object sender, EventArgs e)
        {
            var dialog = new Print_List_Form(printLibrary);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Search_Button_Click(null, null);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(path_to_data))
            {
                library.SaveData(path_to_data);

            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save File";
                sfd.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    library.SaveData(path);
                    path_to_data = path;
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                library = library.LoadData(ofd.FileName);
                path_to_data = ofd.FileName;
                Search_Button_Click(null, null);
            }
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Print_List_Form(printLibrary);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Search_Button_Click(null, null);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save File";
            sfd.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                library.SaveData(path);
                path_to_data = path;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ϳ��������� �����", "�����", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();

            }
            else if (result == DialogResult.No)
            {
                Close();
            }
            else
            {
                if (e is FormClosingEventArgs formClosingEventArgs)
                {
                    formClosingEventArgs.Cancel = true;
                }
            }
        }

        private void Remove_Phrase_Button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("�� �������, �� ������ �������� �����?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem selectedItem in listView1.SelectedItems)
                    {
                        var phrase = selectedItem.Tag as Phrase;
                        library.Phrases.Remove(phrase);
                        Search_Button_Click(null, null);
                    }
                }
                else
                {
                    listView1.SelectedItems.Clear();
                }
            }
            else
            {
                MessageBox.Show("�� �� ������� �����", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowLikedPhrases_Button_Click(object sender, EventArgs e)
        {
            if (library.isLikedList == true)
            {
                library.isLikedList = false;
                Search_Button_Click(null, null);
            }
            else
            {
                var result = library.Search(phraseTextBox.Text, authorBox.Text, themeBox.Text, originBox.Text);
                listView1.Items.Clear();
                library.isLikedList = true;

                foreach (var phrase in result)
                {
                    if (phrase.IsLiked)
                    {
                        var item = new ListViewItem(new[] { phrase.PhraseText, phrase.Author, phrase.Theme });
                        item.ForeColor = Color.Green;
                        item.Tag = phrase;
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("�������� ���?", "����������", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (File.Exists(path_to_data))
                {
                    library.SaveData(path_to_data);
                }
                else
                {
                    SaveAsToolStripMenuItem_Click(null, null);
                }
            }

            if (result != DialogResult.Cancel)
            {
                library = new Library();
                path_to_data = "";
                listView1.Items.Clear();
                MessageBox.Show("���� �������� ��������.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();
            switch (selectedOption)
            {
                case "��� ����������":
                    library.isSorted = false;

                    Search_Button_Click(null, null);
                    break;

                case "������� � ���������� �������":
                    library.sortPhraseByAlphabet();
                    Search_Button_Click(null, null);
                    break;

                case "������ � ���������� �������":
                    library.sortAuthorByAlphabet();
                    Search_Button_Click(null, null);
                    break;

                case "������� � ���������� �������":
                    library.sortOriginByAlphabet();
                    Search_Button_Click(null, null);
                    break;

                case "���� � ���������� �������":
                    library.sortThemeByAlphabet();
                    Search_Button_Click(null, null);
                    break;



            }
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "������� ������� - �� ��������� ������������, ��� ���� ������� ���������" +
                " ��� ��������� ������������ �������� �������� �������. ��������� ��������� ��������������" +
                " ��������� � ���� ������� ��������� ���������� � ��������� �������� � ������ ����������� " +
                "����� ������ ������� ����������. ������� ��������� ���������, �����������, ���������, �����, " +
                "�������� ���������� �� ����� �������. ������ ������� ������ � ���������� ���������� �������� ������" +
                " ��������� ������ �������, � �������� �������� ������� �������� �������� � ������� ����� " +
                "������.";
            MessageBox.Show(text, "���������� ��� ��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
