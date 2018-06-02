using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace HY_PIP
{
    public class modbus_TCP
    {
        private string ipAddress = "192.168.1.10";
        private int tcpPort = 3000;
        public static Socket newclient;
        public bool Connected;
        public Thread myThread;

        public delegate void MyInvoke(string str);

        public modbus_TCP(string portName, int baudRate)
        {

        }

        public void Connect()
        {
            byte[] data = new byte[1024];

            string ipadd = ipAddress;//将服务器IP地址存放在字符串 ipadd中
            int port = Convert.ToInt32(tcpPort);//将端口号强制为32位整型，存放在port中

            //创建一个套接字

            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ipadd), port);
            newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //将套接字与远程服务器地址相连
            try
            {
                newclient.Connect(ie);
                Connected = true;
            }
            catch (SocketException e)
            {
                //MessageBox.Show("连接服务器失败  " + e.Message);
                return;
            }

            ThreadStart myThreaddelegate = new ThreadStart(ReceiveMsg);
            myThread = new Thread(myThreaddelegate);
            myThread.Start();
            System.Timers.Timer t = new System.Timers.Timer(500);
            t.Elapsed += new System.Timers.ElapsedEventHandler(timersend_Tick);
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件
        }

        private void timersend_Tick(object sender, EventArgs e)
        {
            byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x04, 0x00, 0x00, 0x00, 0x09 };//读取温度
            newclient.Send(data);
        }

        public void ReceiveMsg()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                newclient.Receive(data);
                int length = data[5];
                Byte[] datashow = new byte[length + 6];

                if (data[7] == 0x04)
                {
                    for (int i = 0; i <= length + 5; i++)
                        datashow[i] = data[i];
                    GenericOp.temperature41 = BitConverter.ToInt16(new byte[] { datashow[10], datashow[9] }, 0);//把数组转换成16进制字符串
                    GenericOp.temperature51 = BitConverter.ToInt16(new byte[] { datashow[12], datashow[11] }, 0);
                    GenericOp.temperature61 = BitConverter.ToInt16(new byte[] { datashow[14], datashow[13] }, 0);
                    GenericOp.temperature71 = BitConverter.ToInt16(new byte[] { datashow[16], datashow[15] }, 0);
                    GenericOp.temperature111 = BitConverter.ToInt16(new byte[] { datashow[18], datashow[17] }, 0);
                    GenericOp.temperature121 = BitConverter.ToInt16(new byte[] { datashow[20], datashow[19] }, 0);
                    GenericOp.temperature1 = BitConverter.ToInt16(new byte[] { datashow[22], datashow[21] }, 0);
                    GenericOp.temperature3 = BitConverter.ToInt16(new byte[] { datashow[24], datashow[23] }, 0);
                    GenericOp.temperature10 = BitConverter.ToInt16(new byte[] { datashow[26], datashow[25] }, 0);
                }
            }
        }

        public static void send1(int temp1)//预热炉温度设置
        {
            byte sendbuff, sendbuff1;
            string temp11;
            if(temp1>0)
            {
                temp11 = Convert.ToString(temp1, 16);
                if (temp11.Length > 2)
                {
                    sendbuff = Convert.ToByte(temp11.Substring(0, temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff = 0x00;
                }
                sendbuff1 = Convert.ToByte(temp11.Substring(temp11.Length - 2), 16);
                byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0x3C, sendbuff, sendbuff1 };
                newclient.Send(data);
            }

        }

        public static void send2(int temp2)//1#氯化炉炉温度设置
        {
            byte sendbuff, sendbuff1;
            string temp11;
            if(temp2>0)
            {
                temp11 = Convert.ToString(temp2, 16);
                if (temp11.Length > 2)
                {
                    sendbuff = Convert.ToByte(temp11.Substring(0, temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff = 0x00;
                }
                sendbuff1 = Convert.ToByte(temp11.Substring(temp11.Length - 2), 16);
                byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0x3D, sendbuff, sendbuff1 };
                newclient.Send(data);
            }
        }

        public static void send3(int temp3)//3#氯化炉炉温度设置
        {
            byte sendbuff, sendbuff1;
            string temp11;
            if(temp3>0)
            {
                temp11 = Convert.ToString(temp3, 16);
                if (temp11.Length > 2)
                {
                    sendbuff = Convert.ToByte(temp11.Substring(0, temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff = 0x00;
                }
                sendbuff1 = Convert.ToByte(temp11.Substring(temp11.Length - 2), 16);
                byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0x3E, sendbuff, sendbuff1 };
                newclient.Send(data);
            }
 
        }

        public static void send4(int temp4)//氧化炉炉温度设置
        {
            byte sendbuff, sendbuff1;
            string temp11;
            if(temp4>0)
            {
                temp11 = Convert.ToString(temp4, 16);
                if (temp11.Length > 2)
                {
                    sendbuff = Convert.ToByte(temp11.Substring(0, temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff = 0x00;
                }
                sendbuff1 = Convert.ToByte(temp11.Substring(temp11.Length - 2), 16);
                byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0x3F, sendbuff, sendbuff1 };
                newclient.Send(data);
            }
            
        }

        public static void send5(int temp5)//油炉炉温度设置
        {
            byte sendbuff, sendbuff1;
            string temp11;
            if(temp5>0)
            {
                temp11 = Convert.ToString(temp5, 16);
                if (temp11.Length > 2)
                {
                    sendbuff = Convert.ToByte(temp11.Substring(0, temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff = 0x00;
                }
                sendbuff1 = Convert.ToByte(temp11.Substring(temp11.Length - 2), 16);
                byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0x40, sendbuff, sendbuff1 };
                newclient.Send(data);
            }
 
        }

        public static void send6(int temp6)//粒子稳定炉炉温度设置
        {
            byte sendbuff, sendbuff1;
            string temp11;
            if(temp6>0)
            {
                temp11 = Convert.ToString(temp6, 16);
                if (temp11.Length > 2)
                {
                    sendbuff = Convert.ToByte(temp11.Substring(0, temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff = 0x00;
                }

                sendbuff1 = Convert.ToByte(temp11.Substring(temp11.Length - 2), 16);
                byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0x41, sendbuff, sendbuff1 };
                newclient.Send(data);
            }
        }

        public static void send7(int temp7)//1#热水操温度设置
        {
            byte sendbuff, sendbuff1;
            string temp11;
            if(temp7>0)
            {
                temp11 = Convert.ToString(temp7, 16);
                if (temp11.Length > 2)
                {
                    sendbuff = Convert.ToByte(temp11.Substring(0, temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff = 0x00;
                }
                if (temp7 > 10)
                {
                    sendbuff1 = Convert.ToByte(temp11.Substring(temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff1 = 0x00;
                }

                byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0x42, sendbuff, sendbuff1 };
                newclient.Send(data);
            }
 
        }

        public static void send8(int temp8)//2#热水槽温度设置
        {
            byte sendbuff, sendbuff1;
            string temp11;
            if(temp8>0)
            {
                temp11 = Convert.ToString(temp8, 16);
                if (temp11.Length > 2)
                {
                    sendbuff = Convert.ToByte(temp11.Substring(0, temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff = 0x00;
                }
                if (temp8 > 10)
                {
                    sendbuff1 = Convert.ToByte(temp11.Substring(temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff1 = 0x00;
                }

                byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0x43, sendbuff, sendbuff1 };
                newclient.Send(data);
            }

        }

        public static void send9(int temp9)//3#热水操炉温度设置
        {
            byte sendbuff, sendbuff1;
            string temp11;
            if(temp9>0)
            {
                temp11 = Convert.ToString(temp9, 16);
                if (temp11.Length > 2)
                {
                    sendbuff = Convert.ToByte(temp11.Substring(0, temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff = 0x00;
                }
                if (temp9 > 10)
                {
                    sendbuff1 = Convert.ToByte(temp11.Substring(temp11.Length - 2), 16);
                }
                else
                {
                    sendbuff1 = 0x00;
                }
                byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0x44, sendbuff, sendbuff1 };
                newclient.Send(data);
            }
 
        }

        public static void OpenTemp(int indx)
        {
            byte sendbuff;
            switch (indx)
            {
                case 3:  //预热炉
                    sendbuff = 0x00;
                    byte[] data1 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x00 };
                    newclient.Send(data1);
                    GenericOp.temp4 = true;
                    break;

                case 4:  //1#氮化炉
                    sendbuff = 0x01;
                    byte[] data2 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x00 };
                    newclient.Send(data2);
                    GenericOp.temp5 = true;
                    break;

                case 5:  //2#氮化炉
                    sendbuff = 0x02;
                    byte[] data3 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x00 };
                    newclient.Send(data3);
                    GenericOp.temp6 = true;
                    break;

                case 6:  //氧化炉
                    sendbuff = 0x03;
                    byte[] data4 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x00 };
                    newclient.Send(data4);
                    GenericOp.temp7 = true;
                    break;

                case 12:  //油炉
                    sendbuff = 0x04;
                    byte[] data5 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x00 };
                    newclient.Send(data5);
                    GenericOp.temp12 = true;
                    break;

                case 11:  //离子稳定炉
                    sendbuff = 0x05;
                    byte[] data6 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x00 };
                    newclient.Send(data6);
                    GenericOp.temp11 = true;
                    break;

                case 0:  //1#热水槽
                    sendbuff = 0x06;
                    byte[] data7 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x00 };
                    newclient.Send(data7);
                    GenericOp.temp1 = true;
                    break;

                case 2:  //2#热水槽
                    sendbuff = 0x07;
                    byte[] data8 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x00 };
                    newclient.Send(data8);
                    GenericOp.temp3 = true;
                    break;

                case 10: //3#热水槽
                    sendbuff = 0x08;
                    byte[] data9 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x00 };
                    newclient.Send(data9);
                    GenericOp.temp10 = true;
                    break;

                default:
                    break;
            }
        }

        public static void CloseTemp(int indx)
        {
            byte sendbuff;

            switch (indx)
            {
                case 3:
                    sendbuff = 0x00;
                    byte[] data1 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x01 };
                    newclient.Send(data1);
                    GenericOp.temp4 = false;
                    break;

                case 4:
                    sendbuff = 0x01;
                    byte[] data2 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x01 };
                    newclient.Send(data2);
                    GenericOp.temp5 = false;
                    break;

                case 5:
                    sendbuff = 0x02;
                    byte[] data3 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x01 };
                    newclient.Send(data3);
                    GenericOp.temp6 = false;
                    break;

                case 6:
                    sendbuff = 0x03;
                    byte[] data4 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x01 };
                    newclient.Send(data4);
                    GenericOp.temp7 = false;
                    break;

                case 12:
                    sendbuff = 0x04;
                    byte[] data5 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x01 };
                    newclient.Send(data5);
                    GenericOp.temp12 = false;
                    break;

                case 11:
                    sendbuff = 0x05;
                    byte[] data6 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x01 };
                    newclient.Send(data6);
                    GenericOp.temp11 = false;
                    break;

                case 0:
                    sendbuff = 0x06;
                    byte[] data7 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x01 };
                    newclient.Send(data7);
                    GenericOp.temp1 = false;
                    break;

                case 2:
                    sendbuff = 0x07;
                    byte[] data8 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x01 };
                    newclient.Send(data8);
                    GenericOp.temp3 = false;
                    break;

                case 10:
                    sendbuff = 0x08;
                    byte[] data9 = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, sendbuff, 0x00, 0x01 };
                    newclient.Send(data9);
                    GenericOp.temp10 = false;
                    break;

                default:

                    break;
            }
        }
    }
}