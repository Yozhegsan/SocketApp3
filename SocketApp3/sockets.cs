using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketApp3
{
    public static class sockets
    {
        public static IPEndPoint ipPoint;
        public static Socket socket;

        public static byte[] AllDataArray = new byte[201];
        //#############################################################################################################################

        private static bool ConnectNow(string ip, int port)
        {
            ipPoint = null;
            socket = null;

            try
            {
                ipPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.ReceiveTimeout = 2000;
                socket.SendTimeout = 2000;
                socket.Connect(ipPoint);
                return true;
            }
            catch { }
            return false;
        }

        private static void DisconectNow()
        {

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        public static void GetEEPROM(string ip, int port)
        {
            if (ConnectNow(ip, port))
            {
                byte[] data = Encoding.ASCII.GetBytes("r;");
                socket.Send(data);
                Thread.Sleep(50);
                int total = socket.Receive(AllDataArray, AllDataArray.Length, 0);
                DisconectNow();
                //System.Windows.Forms.MessageBox.Show("AllDataArray[13] = " + AllDataArray[13]);
                //System.Windows.Forms.MessageBox.Show("total = " + total);
            }

        }

        public static string GetNewThermoSensor(string ip, int port)
        {
            byte[] mas = new byte[8];
            if (ConnectNow(ip, port))
            {
                byte[] data = Encoding.ASCII.GetBytes("n;");
                socket.Send(data);
                Thread.Sleep(50);
                int total = socket.Receive(mas, 8, 0);
                DisconectNow();
                string result = "";
                foreach (byte b in mas)
                    result += Convert.ToString(b, 16) + ".";
                result = result.Substring(0, result.Length - 1);
                return result;
            }
            return "";
        }

        public static void SetEEPROM(ref byte[] arr, string ip, int port)
        {
            if (ConnectNow(ip, port))
            {
                arr[0] = (byte)'w';
                arr[200] = (byte)';';

                socket.Send(arr);
                Thread.Sleep(50);
                DisconectNow();
            }
        }

        public static string GetSensorData(string cmd, string ip, int port)
        {

            string result = "";

            return result;
        }



        private static void FillMas(ref byte[] DestMas, ref byte[] SourceMas, int StartIndex, int count)
        {
            for (int i = 0; i < count; i++)
                DestMas[i] = SourceMas[i + StartIndex];
        }

        //public static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
        //{
        //    var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        //    var result = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
        //    handle.Free();
        //    return result;
        //}
    }
}
