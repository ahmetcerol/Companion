using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class WaitFormResult : Form
    {
        public Action Action { get; set; }
        public WaitFormResult(Action action)
        {
   
            InitializeComponent();
            if (action != null)
            {
                Action = action;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Action).ContinueWith(x => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

    }
}
