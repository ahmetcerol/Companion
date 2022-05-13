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
    public partial class Wait_Form : Form
    {
        public Action Action { get; set; }
        public Wait_Form(Action action)
        {
            InitializeComponent();
            if (action!=null)
            {
                Action = action;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Action).ContinueWith(x=> { this.Close();},TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void Wait_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
