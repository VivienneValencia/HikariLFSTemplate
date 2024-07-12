using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HikariLFSTemplate.Admin;

namespace HikariLFSTemplate
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        

        private void homeButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void adminButton_Click_1(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void btnOrderManager_Click(object sender, EventArgs e)
        {
            AuftragsverwaltungForm auftragsverwaltungForm = new AuftragsverwaltungForm();
            auftragsverwaltungForm.ShowDialog();
        }
    }
}