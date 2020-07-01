using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void GetAllData(string ip, int port)
        {
            for (int i = 0; i < 201; i++)
                sockets.AllDataArray[i] = 111;
            sockets.GetEEPROM(ip, port);
            ParseAllData();
        }

        private void ParseAllData()
        {
            ref byte[] arr = ref sockets.AllDataArray;
            chkDefaultFlag.Checked = arr[7] > 0 ? true : false;
            txtIpAddress.Text = MakeDataString(ref arr, 8, 4);
            txtSubnetMask.Text = MakeDataString(ref arr, 12, 4);
            txtGateway.Text = MakeDataString(ref arr, 16, 4);
            byte[] bb = new byte[2];
            bb[0] = arr[20];
            bb[1] = arr[21];
            txtPort.Text = BitConverter.ToInt16(bb, 0).ToString(); ;
            txtMacAddress.Text = MakeHexDataString(ref arr, 22, 6);
            txtThermosensorsCount.Text = arr[28].ToString();
            txtVibrosensorsCount.Text = arr[29].ToString();
            // - - -
            lstThermoSensors.Items.Clear();
            int k = 30;
            int n = 0;
            for (int i = 0; i < 20; i++)
            {
                n = k + (i * 8);
                lstThermoSensors.Items.Add((i + 1).ToString("00") + " - " + MakeHexDataString(ref arr, n, 8));
            }
            if (lstThermoSensors.Items.Count > 0) lstThermoSensors.SelectedIndex = 0;
            // = = =
            txtVibroSensorInfo1.Text = MakeHexDataString(ref arr, 190, 1);
            txtVibroSensorInfo2.Text = MakeHexDataString(ref arr, 191, 1);
        }

        private string MakeDataString(ref byte[] arr, int StartId, int Count)
        {
            string st = "";
            for (int i = 0; i < Count; i++)
            {
                if (i == Count - 1)
                    st += arr[i + StartId].ToString();
                else
                    st += arr[i + StartId].ToString() + ".";
            }
            return st;
        }

        private string MakeHexDataString(ref byte[] arr, int StartId, int Count)
        {
            string st = "";
            for (int i = 0; i < Count; i++)
            {
                if (arr[i + StartId] < 16)
                {
                    if (i == Count - 1)
                        st += "0" + Convert.ToString(arr[i + StartId], 16).ToUpper();
                    else
                        st += "0" + Convert.ToString(arr[i + StartId], 16).ToUpper() + ".";
                }
                else
                {
                    if (i == Count - 1)
                        st += Convert.ToString(arr[i + StartId], 16).ToUpper();
                    else
                        st += Convert.ToString(arr[i + StartId], 16).ToUpper() + ".";
                }
            }
            return st;
        }

        private void btnGetAllData_Click(object sender, EventArgs e)
        {
            GetAllData(txtReadIP.Text, int.Parse(txtReadPort.Text));
        }

        private void lstThermoSensors_DoubleClick(object sender, EventArgs e)
        {
            EditItem(lstThermoSensors.SelectedIndex, lstThermoSensors.SelectedItem.ToString().Substring(5));
        }

        private void EditItem(int id, string txt)
        {
            FormHexKeyBoard frm = new FormHexKeyBoard();
            frm.SetData(txt);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                lstThermoSensors.Items[id] = (id + 1).ToString("00") + " - " + frm.NewText;
            }
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            btnWriteData.Enabled = false;
            byte[] SendMas = new byte[201];
            for (int i = 0; i < 7; i++)
            {
                SendMas[i] = 255;
            }
            SendMas[7] = chkDefaultFlag.Checked ? (byte)255 : (byte)0;
            StringToByteMas(txtIpAddress.Text, ref SendMas, 8);
            StringToByteMas(txtSubnetMask.Text, ref SendMas, 12);
            StringToByteMas(txtGateway.Text, ref SendMas, 16);
            byte[] bb = BitConverter.GetBytes(Int16.Parse(txtPort.Text));
            SendMas[20] = bb[0];
            SendMas[21] = bb[1];
            StringHexToByteMas(txtMacAddress.Text, ref SendMas, 22);
            SendMas[28] = byte.Parse(txtThermosensorsCount.Text);
            SendMas[29] = byte.Parse(txtVibrosensorsCount.Text);
            int k = 30;
            int n = 8;
            for (int i = 0; i < 20; i++)
            {
                StringHexToByteMas(lstThermoSensors.Items[i].ToString().Substring(5), ref SendMas, k + (n * i));
            }


            SendMas[190] = Convert.ToByte(txtVibroSensorInfo1.Text, 16);
            SendMas[191] = Convert.ToByte(txtVibroSensorInfo2.Text, 16);


            //File.WriteAllBytes( Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\TestDump.dat" , SendMas);
            sockets.SetEEPROM(ref SendMas, txtReadIP.Text, int.Parse(txtReadPort.Text));
            btnWriteData.Enabled = true;
        }

        private void StringToByteMas(string txt, ref byte[] arr, int offset)
        {
            txt = txt.Replace(',', '.');
            string[] mas = txt.Split('.');
            for (int i = 0; i < mas.Count(); i++)
            {
                arr[i + offset] = byte.Parse(mas[i]);
            }
        }

        private void StringHexToByteMas(string txt, ref byte[] arr, int offset)
        {
            txt = txt.Replace(',', '.');
            string[] mas = txt.Split('.');
            for (int i = 0; i < mas.Count(); i++)
            {
                arr[i + offset] = Convert.ToByte(mas[i], 16);
            }
        }
    }
}
