using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace IMG2PDF
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
            Model.IMG2PDFModels = new List<IMG2PDFModels>();
            Model.IMG2FOLDERModels = new List<IMG2FOLDERModels>();

            SubModel = new SUB_IMG2FOLDERModels();
        }

        /// <summary>
        ///    Property in IMG2PDFDTO
        /// <summary>
        public CharacterModel Model { get; set; }
        public SUB_IMG2FOLDERModels SubModel { get; set; }
        public List<CharacterModel> Models { get; set; }
    }

    public class IMG2PDFGenerateType
    {
        /// <summary>
        /// image to pdf
        /// </summary>
        public const string UCIMG2PDFF001 = "UCIMG2PDFF001";
        /// <summary>
        /// image to folder
        /// </summary>
        public const string UCIMG2PDFF002 = "UCIMG2PDFF002";
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
