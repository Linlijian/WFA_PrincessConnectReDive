using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using UtilityLib;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Character
{
    public class CharacterDA
    {
        /// <summary>
        ///     Property to return in prop class IMG2PDFDA
        ///     
        public CharacterDTO DTO { get; set; }

        /// <summary>
        ///    constructor
        ///    
        public CharacterDA()
        {
            DTO = new CharacterDTO();
        }
        public CharacterDTO Generate(CharacterDTO dto)
        {
            switch (dto.Model.GenerateType)
            {
                //case IMG2PDFGenerateType.UCIMG2PDFF001: return IM2PCaseSort(dto);
            }
            return dto;
        }
        public CharacterDTO GenerateEx(CharacterDTO dto)
        {
            switch (dto.Model.GenerateType)
            {
                //case IMG2PDFGenerateType.IMG2PDFF002SORT: return IM2FCaseSort(dto);
            }
            return dto;
        }
        #region img 2 pdf

        #endregion

        #region img 2 pdf folder

        #endregion

        #region img 2 pdf multi folder

        #endregion

        #region add on       
        public CharacterDTO test(CharacterDTO dto)
        {
            //WORK
            //dto.Model.IMG2PDFModels = dto.IMG2PDFSort();

            //SelectFolder
            //Regex regex;// = new Regex(@"\d{6,8}_");
            //Match match;
            //if match (_)(.*)[a-zA-Z][-._](\d{1,2})
            //do something eg. __Aneman_10
            //else
            //do (_)(.*)[a-zA-Z](_) eg. __Mane_Seku_
            //else regex/case  select = null them select all image in folder

            return dto;
        }
        #endregion
    }
}
