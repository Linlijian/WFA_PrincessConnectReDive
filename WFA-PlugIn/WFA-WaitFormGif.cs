using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.PlugIn
{
    public partial class WaitFormGif : Form
    {
        public Action Worker { get; set; }
        public WaitFormGif(Action _worker)
        {
            InitializeComponent();
            if (_worker == null)
                throw new ArgumentNullException();
            Worker = _worker;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
