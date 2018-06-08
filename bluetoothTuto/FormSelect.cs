using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bluetoothTuto
{
    public partial class FormSelect : Form
    {
        public FormSelect()
        {
            InitializeComponent();
        }

        private void buttonStartScan_Click(object sender, EventArgs e)
        {
            String dept;
            String semes;
            String sub;
            String date;
            
            if (comboBoxDept.Text == "" || comboBoxSem.Text == "" || comboBoxSub.Text == "")
            {
                MessageBox.Show("Select Option !!!!");
            }
            else {
                dept = comboBoxDept.Text;
                semes = comboBoxSem.Text;
                sub = comboBoxSub.Text;
                date = dateTimePicker1.ToString();
                Form1 frm1 = new Form1(dept,semes,sub,date);
                frm1.Show();
            }
        }

    }
}
