using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using InTheHand;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Ports;
using InTheHand.Net.Sockets;
using System.IO;

namespace bluetoothTuto
{
    public partial class Form1 : Form
    {
        List<String> items;
        string depts;
        string semess;
        string subs;
        string dates;
        public Form1(string dept, string semes, string sub, string date)
        {
            items=new List<string>();
            InitializeComponent();
            depts = dept;
            semess = semes;
            subs = sub;
            dates = date;
           // MessageBox.Show(dept);
        }

      

        public Form1()
        {
            // TODO: Complete member initialization
          
        }

        private void bGo_Click(object sender, EventArgs e)
        {
     
         
            i = 0;
            count = 0;
           if (serverStarted) 
                {
                    updateUI("server already started sitll usage");
                    return;
                }
            if (rBclient.Checked)
            {
                startScan();
            }
            else {
                connectAsServer();
            }
        }
        private void startScan()
        {
            lbox.DataSource = null;
            lbox.Items.Clear();
            items.Clear();
            textBoxOutput.Clear();
            Thread bluetoothScanThread = new Thread(new ThreadStart(scan));
            bluetoothScanThread.Start();
        
        }
        BluetoothDeviceInfo[] devices;
        private void scan()
        {
            
            updateUI("Starting Scan........");
            BluetoothClient client = new BluetoothClient();
             devices = client.DiscoverDevicesInRange();
            updateUI("Scan Completed!\n");
            updateUI(devices.Length.ToString() + " Devices Discoverd.\n");
            updateUI("\n");
            updateUI("Take Attendance Now.\n");
            foreach (BluetoothDeviceInfo d in devices) 
            {
                items.Add(d.DeviceName);
                
            }
            
            updateDevicesList();
        }
        private void connectAsServer()
        {
            Thread bluetoothServerThead = new Thread(new ThreadStart (ServerConnectThread));
            bluetoothServerThead.Start();
        }

        private void connectAsClient()
        {
            throw new NotImplementedException();
        }
        Guid mWid = new Guid("00001101-0000-1000-8000-00005F9D34FD");
       bool serverStarted=false;
        public void ServerConnectThread() 
        {
            serverStarted=true;
            updateUI("Server Started. Wating for Client");
            BluetoothListener blueListener = new BluetoothListener(mWid);
            blueListener.Start();
            BluetoothClient conn = blueListener.AcceptBluetoothClient();
            updateUI("Client Connected");
            Stream mStream = conn.GetStream();
            while (true)
            {
                try
                {
                    byte[] received = new byte[1024];
                    mStream.Read(received, 0, received.Length);
                    updateUI("Received:" + Encoding.ASCII.GetString(received));
                    byte[] sent = Encoding.ASCII.GetBytes("Hello World");
                    mStream.Write(sent, 0, sent.Length);
                }
                catch (IOException exception)
                {
                    updateUI("Client has Disconnected");
                }
            }
        }
        private void updateUI(string meessage)
        {
            Func<int> del = delegate()
            {
                textBoxOutput.AppendText(meessage + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }
        private void updateDevicesList()
        {
            Func<int> del = delegate()
            {
                lbox.DataSource = items;
                return 0;
            };
            Invoke(del);
        
        }
 
        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
        BluetoothDeviceInfo deviceinfo;
        private void lbox_DoubleClick(object sender, EventArgs e)
        {
            deviceinfo = devices.ElementAt(lbox.SelectedIndex);
            updateUI(deviceinfo.DeviceName+" was selected. \n Attempting coneeecting.....");
           if (pairDevice())
           {
                
               
                updateUI("Devices  Paired");
            }
           else 
           {
             updateUI("Pair Failed");
            }
        }
        
        
       string myPin = "1234";
        private bool pairDevice()
        {
          if (!deviceinfo.Authenticated)
           {
               if (!BluetoothSecurity.PairRequest(deviceinfo.DeviceAddress,myPin))
               {
                   return false;
                }
            }
            return true;
        }
      
      

        private void Form1_Load(object sender, EventArgs e)
        {
          
            String date;
            DateTime datethe;
            datethe = DateTime.Now;
            date = datethe.ToString();
            //label3.Show = date;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        int i = 0,count=0;
        String text="";
        String abs = "";
       // private string dept;
      //  private string semes;
      //  private string sub;
      //  private string date;
        
        public void button1_Click(object sender, EventArgs e)
        {
            if (rBclient.Checked)
            {
                ///////////rbclient Checked start if
                if (depts == "CSE" && semess == "2/2")
                {
                    foreach (String idd in listBoxID.Items)
                    {
                        int flag = 0;
                        foreach (String id in lbox.Items)
                        {
                            if (id == idd)
                            {

                                i++;
                                text += id.ToString() + "\n";
                                flag = 1;

                            }


                        }
                        if (flag == 0)
                        {
                            count++;
                            abs += idd.ToString() + ",  ";

                        }

                    }
                    attendance frm2 = new attendance(text, abs, i, count);
                    frm2.ShowDialog();
                    count = 0;
                    i = 0;
                    text = "";
                    abs = "";
                    

                }
                else if (depts == "CSE" && semess == "1/2")
                {
                    foreach (String idd in listBoxCSE12.Items)
                    {

                        int flag = 0;
                        foreach (String id in lbox.Items)
                        {
                            if (id == idd)
                            {

                                i++;


                                text += id.ToString() + "\n";
                                flag = 1;

                            }


                        }
                        if (flag == 0)
                        {
                            count++;
                            abs += idd.ToString() + ",  ";

                        }

                    }

                    count = 0;
                    i = 0;
                    attendance frm2 = new attendance(text, abs,i,count);
                    text = "";
                    abs = "";
                    frm2.ShowDialog();

                }
                else if (depts == "CSE" && semess == "3/2")
                {
                    foreach (String idd in listBoxCSE32.Items)
                    {

                        int flag = 0;
                        foreach (String id in lbox.Items)
                        {
                            if (id == idd)
                            {

                                i++;


                                text += id.ToString() + "\n";
                                flag = 1;

                            }


                        }
                        if (flag == 0)
                        {
                            count++;
                            abs += idd.ToString() + ",  ";

                        }

                    }

                   
                    attendance frm2 = new attendance(text, abs,i,count);
                    frm2.ShowDialog();
                    count = 0;
                    i = 0;
                    text = "";
                    abs = "";
                    

                }
                else
                {
                    MessageBox.Show("Under Development!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                }
                //rbclient Checked close if
            }
            else
            {
                MessageBox.Show("Please Select Client Type Button");
            }
         ///////////////////////////   
        }


        public ComboBox.ObjectCollection CSE { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSelect frmselect = new FormSelect();
            frmselect.Show();
            this.Hide();
        }
    }
}
