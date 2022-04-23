using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anglersking_Uart_Tools
{
    public partial class Form1 : Form
    {
        public delegate void showReceiveDelegate(string text); //当采用响应模式，应申明一个委托，实现不同线程的控件实验

        SerialPort com = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);//初始化构造函数
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int comnu = 0; comnu < 10; comnu++)
            {
                cmbPort.Items.Add("COM" + (i + 1).ToString());

            }
            //cmbPort.SelectedIndex = 0;

            rbResponse.Checked = true;
            chkSendHex.Checked = true;
            chkRecHex.Checked = true;
            //列出常用的波特率
            // cmbBaudRate.Items.Add("1200");
            //cmbBaudRate.Items.Add("2400");
            // cmbBaudRate.Items.Add("4800");
            //cmbBaudRate.Items.Add("9600");
            // cmbBaudRate.Items.Add("19200");
            // cmbBaudRate.Items.Add("38400");
            cmbBaudRate.Items.Add("115200");
            cmbBaudRate.Items.Add("230400");
            cmbBaudRate.SelectedIndex = 2;

            //列出停止位
            cmbStopBits.Items.Add("0");
            cmbStopBits.Items.Add("1");
            cmbStopBits.Items.Add("1.5");
            cmbStopBits.Items.Add("2");
            cmbStopBits.SelectedIndex = 1;

            //列出数据位
            cmbDataBits.Items.Add("8");
            cmbDataBits.Items.Add("7");
            cmbDataBits.Items.Add("6");
            cmbDataBits.Items.Add("5");
            cmbDataBits.SelectedIndex = 0;

            //列出奇偶校验位
            cmbParity.Items.Add("无");
            cmbParity.Items.Add("奇校验");
            cmbParity.Items.Add("偶校验");
            cmbParity.SelectedIndex = 0;

            cmbPort.SelectedIndex = 0;
            // cmbBaudRate.SelectedIndex = 0;
            cmbDataBits.SelectedIndex = 0;
            cmbStopBits.SelectedIndex = 0;
            cmbParity.SelectedIndex = 0;
        }

        private void btn_openport_Click(object sender, EventArgs e)
        {
            txtStatus.BackColor = SystemColors.Control;

            if (btn_openport.Text == "打开串口")
            {
                try
                {
                    if (!com.IsOpen)
                    {
                        com.PortName = cmbPort.Text;
                        com.BaudRate = int.Parse(cmbBaudRate.Text);
                        com.DataBits = int.Parse(cmbDataBits.Text);
                        switch (cmbStopBits.SelectedIndex)
                        {
                            case 0:
                                com.StopBits = StopBits.One; break;
                            case 1:
                                com.StopBits = StopBits.Two; break;
                            case 2:
                                com.StopBits = StopBits.OnePointFive; break;
                            case 3:
                                com.StopBits = StopBits.None; break;
                        }
                        switch (cmbParity.SelectedIndex)
                        {
                            case 0: com.Parity = Parity.None; break;
                            case 1: com.Parity = Parity.Odd; break;
                            case 2: com.Parity = Parity.Even; break;
                        }

                        com.Open();//打开串口
                    }
                    btn_openport.Text = "关闭串口";
                    txtStatus.Text = "串口已打开！";
                    btnSend.Enabled = true;
                    if (rbAck.Checked)
                        btnReceive.Enabled = true; //应答模式，接收按钮有效
                }
                catch
                { txtStatus.Text = "串口打开错误或串口不存在！"; }
            }
            else //关闭串口

                try
                {
                    if (com.IsOpen)
                        com.Close(); //关闭串口
                    btn_openport.Text = "打开串口";
                    txtStatus.Text = "串口已关闭！";
                    btnSend.Enabled = false;
                    if (rbAck.Checked)
                        btnReceive.Enabled = false; //应答模式，接收按钮有效
                }
                catch
                { txtStatus.Text = "串口关闭错误或串口不存在！"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool comExistence = false;    //有可用串口标志位
            cmbPort.Items.Clear();    //清除当前串口号中的所有串口名称
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cmbPort.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (comExistence)
            {
                cmbPort.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("没有找到可用的串口！", "错误提示");
            }
        }
        public static byte[] getBytesFromString(string pString)
        {
            string[] str = pString.Split(' ');     //把十六进制格式的字符串按空格转换为字符串数组。
            byte[] bytes = new byte[str.Length];     //定义字节数组并初始化，长度为字符串数组的长度。
            for (int i = 0; i < str.Length; i++)     //遍历字符串数组，把每个字符串转换成字节类型赋值给每个字节变量。
                bytes[i] = Convert.ToByte(Convert.ToInt32(str[i], 16));
            return bytes;     //返回字节数组。
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = null;
                if (chkSendHex.Checked)
                    data = getBytesFromString(txtSend.Text);
                else
                    data = Encoding.Default.GetBytes(txtSend.Text);
                com.Write(data, 0, data.Length);
            }
            catch (Exception err)
            {
                //txtStatus.Text = err.ToString(); 
                MessageBox.Show("异常" + err.ToString());
            }
        }

        public static string getStringFromBytes(byte[] pByte)
        {
            string str = "";     //定义字符串类型临时变量。
            //遍历字节数组，把每个字节转换成十六进制字符串，不足两位前面添“0”，以空格分隔累加到字符串变量里。
            for (int i = 0; i < pByte.Length; i++)
                str += (pByte[i].ToString("X").PadLeft(2, '0') + " ");
            str = str.TrimEnd(' ');     //去掉字符串末尾的空格。
            return str;     //返回字符串临时变量。
        }
        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                //应答模式
                int count = com.BytesToRead;
                byte[] readBuffer = new byte[count];
                com.Read(readBuffer, 0, count);
                if (chkRecHex.Checked)
                    txtReceive.Text = getStringFromBytes(readBuffer);  //转十六进制
                else
                    txtReceive.Text = Encoding.Default.GetString(readBuffer);  //字母、数字、汉字转换为字符串 

            }
            catch (Exception err)
            {
                //txtStatus.Text = err.ToString();
                MessageBox.Show("异常" + err.ToString());
            }
        }

        private void chkSendHex_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkSendHex.Checked)
                    txtSend.Text = getStringFromBytes(Encoding.Default.GetBytes(txtSend.Text));
                else
                    txtSend.Text = Encoding.Default.GetString(getBytesFromString(txtSend.Text));
            }
            catch
            {
                txtStatus.Text = "数据转换出错，请输入正确的数据格式"; 
            }
        }

        private void chkRecHex_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkRecHex.Checked)
                    txtReceive.Text = getStringFromBytes(Encoding.Default.GetBytes(txtReceive.Text));
                else
                    txtReceive.Text = Encoding.Default.GetString(getBytesFromString(txtReceive.Text));
            }
            catch
            {
                txtStatus.Text = "数据转换出错，请输入正确的数据格式"; 
            }
        }
        public void doShowReceive(string str)
        {
            txtReceive.Text += str;
        }
        private void com_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                int count = com.BytesToRead;
                byte[] readBuffer = new byte[count];
                com.Read(readBuffer, 0, count);
                string strReceive = "";
                if (chkRecHex.Checked)
                    strReceive = getStringFromBytes(readBuffer);  //转十六进制
                else
                    strReceive = Encoding.Default.GetString(readBuffer);  //字母、数字、汉字转换为字符串          
                this.Invoke(new showReceiveDelegate(doShowReceive), strReceive);

            }
            catch (Exception err)
            { //txtStatus.Text = err.ToString();
                MessageBox.Show("异常" + err.ToString());
            }

        }
        private void rbResponse_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                btnReceive.Enabled = rbAck.Checked;
                if (rbResponse.Checked)
                    com.DataReceived += new SerialDataReceivedEventHandler(com_DataReceived);  //加载接收事件
                else
                    com.DataReceived -= new SerialDataReceivedEventHandler(com_DataReceived);  //移除接收事件
            }
            catch (Exception err)
            {
                // txtStatus.Text = err.ToString();
                MessageBox.Show("异常" + err.ToString());
            }
        }
    }
}
