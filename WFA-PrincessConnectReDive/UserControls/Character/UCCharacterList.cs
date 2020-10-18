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

namespace Character
{
    public partial class UCCharacterList : UserControl
    {
        #region init
        public UCCharacterList()
        {
            InitializeComponent();
        }
        private ResourceManager CharacterRes = new ResourceManager("Character.Translate.CharacterRes", typeof(CharacterRes).Assembly);
        private ResourceManager CharacterBtn = new ResourceManager("Character.Translate.CharacterBtn", typeof(CharacterBtn).Assembly);
        #endregion

        #region form
        private void UCCharacterList_Load(object sender, EventArgs e)
        {
            //dll
            BindGuildLis();
            BindCharacterLis();
            //defualt
            picboxCharacter.Image = (Image)CharacterRes.GetObject(ddlCharacterList.SelectedValue.ToString());
            var characterBtn = typeof(CharacterBtn)
              .GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
              .Where(p => p.PropertyType == typeof(string) && p.Name == ddlCharacterList.SelectedValue.ToString())
              .Select(x => new DropDownList { TEXT = x.GetValue(null, null).ToString() })
              .First();
            picboxCharacterBtn.Image = (Image)CharacterRes.GetObject(characterBtn.TEXT);

        }

        #endregion

        #region method
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
            picboxCharacter.Image = (Image)CharacterRes.GetObject(ddlCharacterList.SelectedValue.ToString());
            var characterBtn = typeof(CharacterBtn)
              .GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
              .Where(p => p.PropertyType == typeof(string) && p.Name == ddlCharacterList.SelectedValue.ToString())
              .Select(x => new DropDownList { TEXT = x.GetValue(null, null).ToString() })
              .First();
            picboxCharacterBtn.Image = (Image)CharacterRes.GetObject(characterBtn.TEXT);
        }
        #endregion
    }
}
