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
                case CharacterGenerateType.GET_SKILL: return GET_SKILL(dto);
                case CharacterGenerateType.GifSkill: return GifSkill(dto);
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
        public CharacterDTO GET_SKILL(CharacterDTO dto)
        {
            dto.Model = SessionHelper.SYS_JSON_FILE.Where(m => m.CHARC == dto.Model.CHARAC)
                .Select(x => new CharacterModel
                {
                    CHARAC = x.CHARC,
                    BTN_CHARAC = x.BTNCHARAC,
                    SKILL1 = x.SKILL1,
                    SKILL2 = x.SKILL2,
                    EXSKILL = x.EXSKILL,
                    UNION_BURST = x.UNIONBURST,
                    GIF_SKILL1  =x.GIFSKILL1,
                    GIF_SKILL2 = x.GIFSKILL2,
                    GIF_UNION_BURST = x.GIFUNIONBURST
                }).FirstOrDefault();

            return dto;
        }
        public CharacterDTO GifSkill(CharacterDTO dto)
        {
            var model = SessionHelper.SYS_JSON_FILE.Where(m => m.CHARC == dto.Model.CHARAC)
                .Select(x => new CharacterModel
                {
                    CHARAC = x.CHARC,
                    BTN_CHARAC = x.BTNCHARAC,
                    SKILL1 = x.SKILL1,
                    SKILL2 = x.SKILL2,
                    EXSKILL = x.EXSKILL,
                    UNION_BURST = x.UNIONBURST,
                    GIF_SKILL1 = x.GIFSKILL1,
                    GIF_SKILL2 = x.GIFSKILL2,
                    GIF_UNION_BURST = x.GIFUNIONBURST
                }).FirstOrDefault();

            switch (dto.Model.KEY_SKILL)
            {
                case CharacterGenerateType.UnionBurst:  dto.Model.LINK_GIF = model.GIF_UNION_BURST; break;
                case CharacterGenerateType.Skill1: dto.Model.LINK_GIF = model.GIF_SKILL1; break;
                case CharacterGenerateType.Skill2: dto.Model.LINK_GIF = model.GIF_SKILL2; break;
            }

            return dto;
        }
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
