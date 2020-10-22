using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;
using System.Resources;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Net;
using WFA.PlugIn;
using Newtonsoft.Json;

namespace Character
{
    public partial class UCGuild : UserControl
    {
        #region init
        private CharacterDA CHARC = new CharacterDA();

        public UCGuild()
        {
            InitializeComponent();
        }
        private ResourceManager CharacterRes = new ResourceManager("Character.Translate.CharacterRes", typeof(CharacterRes).Assembly);
        private ResourceManager CharacterBtn = new ResourceManager("Character.Translate.CharacterBtn", typeof(CharacterBtn).Assembly);

        private void UCCharacterList_Load(object sender, EventArgs e)
        {           
            BindGuildLis();
            BindCharacterLis();
            ShowButtonImage();

            var dto = new CharacterDA();

            dto.DTO.Model.GenerateType = CharacterGenerateType.GET_Guild;
            dto.DTO.Model.CHARAC = ddlCharacterList.SelectedValue.ToString();
            dto.Generate(dto.DTO);

            picboxCharacter.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.CHARAC);
            picboxCharacterBtn.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.BTN_CHARAC);
            btnUnionBurst.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.UNION_BURST);
            btnSkill_1.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.SKILL1);
            btnSkill_2.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.SKILL2);
            btnExSkill.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.EXSKILL);

            CHARC = dto;
        }
        #endregion

        #region event
        private void btnUnionBurst_Click(object sender, EventArgs e)
        {
            CHARC.DTO.Model.KEY_SKILL = CharacterGenerateType.UnionBurst;
            using (WaitFormGif form = new WaitFormGif(LoadGif))
            {
                form.ShowDialog(this);
            }
        }
        private void btnSkill_1_Click(object sender, EventArgs e)
        {
            CHARC.DTO.Model.KEY_SKILL = CharacterGenerateType.Skill1;
            using (WaitFormGif form = new WaitFormGif(LoadGif))
            {
                form.ShowDialog(this);
            }
        }
        private void btnSkill_2_Click(object sender, EventArgs e)
        {
            CHARC.DTO.Model.KEY_SKILL = CharacterGenerateType.Skill2;
            using (WaitFormGif form = new WaitFormGif(LoadGif))
            {
                form.ShowDialog(this);
            }
        }
        private void btnExSkill_Click(object sender, EventArgs e)
        {
            picboxGif.Image = (Image)CharacterRes.GetObject("error");
        }
        #endregion

        #region method
        private void LoadGif()
        {
            var dto = new CharacterDA();

            dto = CHARC;
            dto.DTO.Model.GenerateType = CharacterGenerateType.GifSkill;
            dto.Generate(dto.DTO);

            picboxGif.Load(dto.DTO.Model.LINK_GIF);
        }
        private void ShowButtonImage()
        {
            btnExSkill.Show();
            btnSkill_1.Show();
            btnSkill_2.Show();
            btnUnionBurst.Show();
        }
        private void HideButtonImage()
        {
            btnExSkill.Hide();
            btnSkill_1.Hide();
            btnSkill_2.Hide();
            btnUnionBurst.Hide();
        }
        private void BindGuildLis()
        {
            var guildList = typeof(GuildName)
               .GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
               .Where(p => p.PropertyType == typeof(string))
               .Select(x => new { TEXT = x.GetValue(null, null), VALUES = x.Name })
               .ToList();

            ddlGuildList.DataSource = guildList;
            ddlGuildList.DisplayMember = "TEXT";
            ddlGuildList.ValueMember = "VALUES";
            ddlGuildList.SelectedIndexChanged += OnSelectedGuild;
        }
        private void OnSelectedGuild(object sender, EventArgs e)
        {
            var condition = ddlGuildList.SelectedValue.ToString().Split('_').Last();
            var characterList = typeof(CharacterName)
               .GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
               .Where(p => p.PropertyType == typeof(string))
               .Select(x => new { TEXT = x.GetValue(null, null), VALUES = x.Name })
               .ToList();

            ddlCharacterList.DataSource = characterList.Where(c => c.VALUES.Split('_')[1] == condition).ToList();
            ddlCharacterList.DisplayMember = "TEXT";
            ddlCharacterList.ValueMember = "VALUES";
        }
        private void BindCharacterLis()
        {
            var characterList = typeof(CharacterName)
               .GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
               .Where(p => p.PropertyType == typeof(string))
               .Select(x => new { TEXT = x.GetValue(null, null), VALUES = x.Name })
               .ToList();

            ddlCharacterList.DataSource = characterList;
            ddlCharacterList.DisplayMember = "TEXT";
            ddlCharacterList.ValueMember = "VALUES";
            ddlCharacterList.SelectedIndexChanged += OnSelectedCharacter;
        }
        private void OnSelectedCharacter(object sender, EventArgs e)
        {
            var dto = new CharacterDA();
            dto = CHARC;

            dto.DTO.Model.GenerateType = CharacterGenerateType.GET_Guild;
            dto.DTO.Model.CHARAC = ddlCharacterList.SelectedValue.ToString();
            dto.Generate(dto.DTO);

            picboxCharacter.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.CHARAC);
            picboxCharacterBtn.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.BTN_CHARAC);
            btnUnionBurst.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.UNION_BURST);
            btnSkill_1.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.SKILL1);
            btnSkill_2.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.SKILL2);
            btnExSkill.Image = (Image)CharacterRes.GetObject(dto.DTO.Model.EXSKILL);
            picboxGif.Image = null;

            ShowButtonImage();
        }
        #endregion
    }
}
