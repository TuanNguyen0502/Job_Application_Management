using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public partial class UC_Resume : UserControl
    {
        public UC_Resume()
        {
            InitializeComponent();
        }

        private void button_AddEducation_Click(object sender, EventArgs e)
        {
            int ucHeight = 300;
            int ucWidth = 1288;
            // increase flow layout panel height
            flowLayoutPanel_Education.Size = new System.Drawing.Size(ucWidth, flowLayoutPanel_Education.Height + ucHeight);
            // add uc
            UC_Resume_Education uC_Resume_Education = new UC_Resume_Education();
            flowLayoutPanel_Education.Controls.Add(uC_Resume_Education);
        }

        private void button_AddExperience_Click(object sender, EventArgs e)
        {
            int ucHeight = 381;
            int ucWidth = 1674;
            // increase flow layout panel height
            flowLayoutPanel_Experience.Size = new System.Drawing.Size(ucWidth, flowLayoutPanel_Experience.Height + ucHeight);
            // add uc
            UC_Resume_Experience uC_Resume_Experience = new UC_Resume_Experience();
            flowLayoutPanel_Experience.Controls.Add(uC_Resume_Experience);
        }

        private void button_AddCertification_Click(object sender, EventArgs e)
        {
            int ucHeight = 197;
            int ucWidth = 1674;
            // increase flow layout panel height
            flowLayoutPanel_Certificate.Size = new System.Drawing.Size(ucWidth, flowLayoutPanel_Certificate.Height + ucHeight);
            // add uc
            UC_Resume_Certificate uC_Resume_Certificate = new UC_Resume_Certificate();
            flowLayoutPanel_Certificate.Controls.Add(uC_Resume_Certificate);
        }

        private void button_AddSkill_Click(object sender, EventArgs e)
        {
            int ucHeight = 244;
            int ucWidth = 1674;
            // increase flow layout panel height
            flowLayoutPanel_Skill.Size = new System.Drawing.Size(ucWidth, flowLayoutPanel_Skill.Height + ucHeight);
            // add uc
            UC_Resume_Skill uC_Resume_Skill = new UC_Resume_Skill();
            flowLayoutPanel_Skill.Controls.Add(uC_Resume_Skill);
        }

        private void button_AddInterest_Click(object sender, EventArgs e)
        {
            int ucHeight = 244;
            int ucWidth = 1674;
            // increase flow layout panel height
            flowLayoutPanel_Interest.Size = new System.Drawing.Size(ucWidth, flowLayoutPanel_Interest.Height + ucHeight);
            // add uc
            UC_Resume_Interest uC_Resume_Interest = new UC_Resume_Interest();
            flowLayoutPanel_Interest.Controls.Add(uC_Resume_Interest);
        }
    }
}
