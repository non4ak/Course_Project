using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    public class Phrase
    {
        public string PhraseText { get; set; }
        public string Author { get; set; }
        public string Origin { get; set; }
        public string Theme { get; set; }
        public bool IsLiked { get; set; }

        public Phrase(string phraseText, string author, string origin, string theme)
        {
            PhraseText = phraseText;
            Author = author;
            Origin = origin;
            Theme = theme;
            IsLiked = false;         
        }
    }
}
