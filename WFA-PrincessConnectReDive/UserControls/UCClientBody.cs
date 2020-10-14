﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_PrincessConnectReDive;
using Helper;

namespace UserControls
{
    public partial class UCClientBody : UserControl
    {
        public UCClientBody()
        {
            InitializeComponent();
        }

        #region event
        #endregion

        private void btnPDFtoImage_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientPDF2IMG"))
            {
                //UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientPDF2IMG(), dockStyle: UserControlDockStyle.DockStyleFill);
            }
            MainForm.Instance.PnlClientBody.Controls["UCClientPDF2IMG"].BringToFront();
            MainForm.Instance.PnlTitle.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnImagetoPDF_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientCharacter"))
            {
                UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientCharacter(), dockStyle: UserControlDockStyle.DockStyleFill);
            }
            MainForm.Instance.PnlClientBody.Controls["UCClientCharacter"].BringToFront();
            MainForm.Instance.PnlTitle.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientCharacter"))
            {
                UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientCharacter(), dockStyle: UserControlDockStyle.DockStyleFill);
            }
            MainForm.Instance.PnlClientBody.Controls["UCClientCharacter"].BringToFront();
            MainForm.Instance.PnlTitle.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnGroupImage_Click(object sender, EventArgs e)
        {
            //if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientGROUPIMG"))
            //{
            //    UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientGROUPIMG(), dockStyle: UserControlDockStyle.DockStyleFill);
            //}
            //MainForm.Instance.PnlClientBody.Controls["UCClientGROUPIMG"].BringToFront();
            //MainForm.Instance.PnlTitle.BackColor = Color.FromArgb(32, 32, 32);
        }
    }
}
