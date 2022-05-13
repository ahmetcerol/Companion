using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YazılımYapımıProje.Bussiness.Abstract;
using YazılımYapımıProje.Bussiness.Concrete;
using YazılımYapımıProje.DataAccess.Concrete;

namespace YazılımYapımıWfaUI.Forms
{
    public partial class StudentProgress : Form
    {
        public StudentProgress()
        {
            InitializeComponent();
            _topicService = new TopicManager(new TopicsDal());
        }
        private ITopicService _topicService;

        private void StudentProgress_Load(object sender, EventArgs e)
        {
            cbxTopic.DataSource = _topicService.GetAll();
            cbxTopic.DisplayMember = "QuestionTopicName";
            cbxTopic.ValueMember = "QuestionTopicId";
        }
    }
}
