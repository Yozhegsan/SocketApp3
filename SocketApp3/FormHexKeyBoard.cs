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
    public partial class FormHexKeyBoard : Form
    {
        List<Button> btns = new List<Button>();

        public string NewText = "";

        //##############################################################################################################

        public FormHexKeyBoard()
        {
            InitializeComponent();
        }

        private void FormHexKeyBoard_Load(object sender, EventArgs e)
        {
            MakeKeyboard();
        }

        public void SetData(string StringHexData)
        {
            txtHEX.Text = StringHexData;
        }

        private void MakeKeyboard()
        {
            int siz = 30;

            int x = 0;
            int y = 0;

            btns.Clear();
            for (int i = 0; i < 256; i++)
            {
                btns.Add(new Button());
                this.Controls.Add(btns[btns.Count - 1]);
                btns[btns.Count - 1].Click += KeyBoard_Click;

                if (i < 16) btns[btns.Count - 1].Text = "0" + Convert.ToString(i, 16).ToUpper(); else btns[btns.Count - 1].Text = Convert.ToString(i, 16).ToUpper();

                btns[btns.Count - 1].Width = siz;
                btns[btns.Count - 1].Height = siz;
                btns[btns.Count - 1].Left = x * siz + 10;
                btns[btns.Count - 1].Top = y * siz + 64;

                x++;
                if (x > 15)
                {
                    x = 0;
                    y++;
                }

            }
        }

        private void KeyBoard_Click(object sender, EventArgs e)
        {

            if (txtHEX.Text.Length == 0)
            {
                txtHEX.AppendText(((Button)sender).Text);
            }
            else
            {
                txtHEX.AppendText("." + ((Button)sender).Text);
            }
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (txtHEX.Text.Length > 0)
            {
                n = txtHEX.Text.Length > 2 ? 3 : 2;
                txtHEX.Text = txtHEX.Text.Substring(0, txtHEX.Text.Length - n);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //List<string> strmas = new List<string>();
            //strmas = txtHEX.Text.Split('.').ToList();

            //string ss = "";
            //foreach (string s in strmas)
            //    ss += Convert.ToInt32(s, 16).ToString() + ".";
            //ss = ss.Substring(0, ss.Length - 1);

            //NewText = ss;


            NewText = txtHEX.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
