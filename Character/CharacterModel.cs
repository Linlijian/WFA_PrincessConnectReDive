using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Character
{
    public class CharacterModel
    {
        public string CHARAC { get; set; }
        public string BTN_CHARAC { get; set; }
        public string UNION_BURST { get; set; }
        public string SKILL1 { get; set; }
        public string SKILL2 { get; set; }
        public string EXSKILL { get; set; }
        public string GIF_UNION_BURST { get; set; }
        public string GIF_SKILL1 { get; set; }
        public string GIF_SKILL2 { get; set; }

        public string KEY_SKILL { get; set; }
        public string LINK_GIF { get; set; }

        public string ErrorMassage { get; set; }
        public string GenerateType { get; set; }

        public string[] REGEX_CASE { get; set; }
        public string[] ARRAY_FILE { get; set; }

        public Rectangle PageSize { get; set; }
        public Match Match { get; set; }
        public Regex Regex { get; set; }
    }    
}
