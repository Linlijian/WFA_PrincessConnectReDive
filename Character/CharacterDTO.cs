﻿using System;
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

    public class CharacterGenerateType
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
        public const string GET_SKILL = "GET_SKILL";

        public const string GifSkill = "GifSkill";
        public const string UnionBurst = "UnionBurst";
        public const string Skill1 = "Skill1";
        public const string Skill2 = "Skill2";
        public const string ExSkill = "ExSkill";
    }
}
