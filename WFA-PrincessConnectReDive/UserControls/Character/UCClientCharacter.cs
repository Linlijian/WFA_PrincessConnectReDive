using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;
using WFA_PrincessConnectReDive;
using Character;

namespace UserControls
{
    public partial class UCClientCharacter : UserControl
    {
        public UCClientCharacter()
        {
            InitializeComponent();
            Global.PActiveHide(panelClient);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlTitle.BackColor = Color.Black;
            if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientBody"))
            {
                UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientBody(), dockStyle: UserControlDockStyle.DockStyleFill);
            }
            MainForm.Instance.PnlClientBody.Controls["UCClientBody"].BringToFront();
        }

        private void btnSingleFolder_Click(object sender, EventArgs e)
        {
            Global.PActiveHide(panelClient);
            Global.PActiveShow(PActiveSingleFolder);
            UserControlHelper.SetUserControl(panelClientTask, userControl: new UCCharacterList(), dockStyle: UserControlDockStyle.DockStyleFill);
        }        

        private void btnMulFolder_Click(object sender, EventArgs e)
        {
            Global.PActiveHide(panelClient);
            Global.PActiveShow(PActiveMultiFolder);
        }
    }
}
