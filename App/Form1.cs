using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void switchWebService_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void addCHFByUserName_Click(object sender, EventArgs e)
        {
            if(!switchWebService.Checked)
                WebServiceClient_REST.addCHFByUserName(username.Text, Convert.ToDecimal(chf.Text));


        }

        private void getusernameByUID_Click(object sender, EventArgs e)
        {
            if (!switchWebService.Checked)
                usernameResult.Text = WebServiceClient_REST.getUsernameByUserID(Convert.ToInt32(userId.Text));
        }


        private void getAccount_Click(object sender, EventArgs e)
        {
            if (!switchWebService.Checked)
                Account.Text = WebServiceClient_REST.getUserAccount(username.Text);
            else
            {
                Account.Text = WebServiceClient_Soap.GetUserAccount(username.Text);
            }
        }

        private void addCHFByUID_Click(object sender, EventArgs e)
        {
            if (!switchWebService.Checked)
                WebServiceClient_REST.addCHFByUID(Convert.ToInt32(userId.Text), Convert.ToDecimal(chf.Text));
        }

        private void switchWebService_CheckedChanged_1(object sender, EventArgs e)
        {
            if (switchWebService.Checked)
                switchWebService.Text = "SOAP";
            else
                switchWebService.Text = "REST";
        }
    }
}
