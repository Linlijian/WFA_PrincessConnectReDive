using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;
using WFA.PlugIn;

namespace WFA.PlugIn
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            VerifyStartUp();
        }
        private void VerifyStartUp()
        {
            //load json
            lblStatus.Text = "Load Config";
            var json = new JSONHelper();
            json.loadConfig();

            if (!json.IsComplete())
            {
                SessionHelper.SYS_START_UP = false;
                SessionHelper.SYS_ERROR_CODE = "003";
                SessionHelper.SYS_ERROR_MESSAGE = json.ERROR;
                SessionHelper.SYS_TITLE = "Infomation";

                return;
            }
                       
            SessionHelper.SYS_START_UP = true;
        }
    }
}
