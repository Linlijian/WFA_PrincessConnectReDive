using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace Character
{
    public class CharacterDTO : GlobalDTO
    {
        /// <summary>
        ///    constructor
        /// <summary>
        public CharacterDTO()
        {
            Model = new CharacterModel();
            Models = new List<CharacterModel>();
        }

        /// <summary>
        ///    Property in Character
        /// <summary>
        public CharacterModel Model { get; set; }
        public List<CharacterModel> Models { get; set; }
    }

    public class IMG2PDFGenerateType
    {
        /// <summary>
        /// Guild Name
        /// </summary>
        public const string DDL001 = "DDL001";
        /// <summary>
        /// Character Name
        /// </summary>
        public const string DDL002 = "DDL002";
        /// <summary>
        /// image to folder sort
        /// </summary>
        public const string IMG2PDFF002SORT = "IMG2PDFF002SORT";
        /// <summary>
        /// image to multi folder
        /// </summary>
        public const string UCIMG2PDFF003 = "UCIMG2PDFF003";
        /// <summary>
        /// image to multi folder sort
        /// </summary>
        public const string IMG2PDFF003SORT = "IMG2PDFF003SORT";
    }
}
