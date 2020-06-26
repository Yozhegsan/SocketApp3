using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketApp3
{
    public partial class FormEdit1 : Form
    {
        public string NewData = "";

        //########################################################3

        public FormEdit1()
        {
            InitializeComponent();
        }

        private void FormEdit1_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string txt)
        {
            txt0.Text = txt;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NewData = txt0.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
