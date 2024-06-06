using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace CourseApp
{
    public class Library
    {
        public List<object> UniqueThemes { get; private set; }
        public List<Phrase> SortedList { get; private set; }
        public bool isLikedList {  get; set; }
        public bool isSorted {  get; set; }
        public List<Phrase> Phrases { get; set; }

        public Library()
        {
            Phrases = new List<Phrase>();
            SortedList = new List<Phrase>();
            UniqueThemes = new List<object> ();
            UniqueThemes.Add("");
            isLikedList = false;
            isSorted = false;
        }


        public List<Phrase> Search(string phraseText, string author, string theme, string origin)
        {
            if (isSorted)
            {
                var result = new List<Phrase>();

                string lowerPhraseText = phraseText.ToLower();
                string lowerAuthor = author.ToLower();
                string lowerTheme = theme.ToLower();
                string lowerOrigin = origin.ToLower();


                foreach (var b in SortedList)
                {
                    if (b.PhraseText.ToLower().Contains(lowerPhraseText) &&
                        b.Author.ToLower().Contains(lowerAuthor) &&
                        b.Theme.ToLower().Contains(lowerTheme) &&
                        b.Origin.ToLower().Contains(lowerOrigin))
                    {
                        result.Add(b);
                    }
                }
                return result;
            }
            else
            {
                var result = new List<Phrase>();

                string lowerPhraseText = phraseText.ToLower();
                string lowerAuthor = author.ToLower();
                string lowerTheme = theme.ToLower();
                string lowerOrigin = origin.ToLower();


                foreach (var b in Phrases)
                {
                    if (b.PhraseText.ToLower().Contains(lowerPhraseText) &&
                        b.Author.ToLower().Contains(lowerAuthor) &&
                        b.Theme.ToLower().Contains(lowerTheme) &&
                        b.Origin.ToLower().Contains(lowerOrigin))
                    {
                        result.Add(b);
                    }
                }
                return result;
            }

            
        }

        public void FillUnique()
        {
            foreach (var b in Phrases)
            {
                if (!UniqueThemes.Contains(b.Theme))
                {
                    UniqueThemes.Add(b.Theme);
                }
            }
        }

        public void sortPhraseByAlphabet()
        {
            SortedList.Clear();
            foreach (var b in Phrases)
            {
                SortedList.Add(b);
            }

            SortedList.Sort((left, right) => left.PhraseText.CompareTo(right.PhraseText));
            isSorted = true;
        }

        public void sortAuthorByAlphabet()
        {
            SortedList.Clear();
            foreach (var b in Phrases)
            {
                SortedList.Add(b);
            }

            SortedList.Sort((left, right) => left.Author.CompareTo(right.Author));
            isSorted = true;
        }

        public void sortOriginByAlphabet()
        {
            SortedList.Clear();
            foreach (var b in Phrases)
            {
                SortedList.Add(b);
            }

            SortedList.Sort((left, right) => left.Origin.CompareTo(right.Origin));
            isSorted = true;
        }

        public void sortThemeByAlphabet()
        {
            SortedList.Clear();
            foreach (var b in Phrases)
            {
                SortedList.Add(b);
            }

            SortedList.Sort((left, right) => left.Theme.CompareTo(right.Theme));
            isSorted = true;
        }



        public void SaveData(string path)
        {            
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(path, jsonString);                    
        }

        public Library LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Library>(jsonString);
        }
    }
}
