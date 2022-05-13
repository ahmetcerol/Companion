using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class ExamResult : Form
    {
        
        public ExamResult(int True,int False)
        {
            InitializeComponent();
            tbxCorrect.Text = True.ToString();
            tbxWrong.Text = False.ToString();
        }
    }
}
