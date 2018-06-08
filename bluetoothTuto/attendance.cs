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
    public partial class attendance : Form
    {
        private string text;
        private string abs;
        private int count;
        private int i;

        public attendance(String idd, String id, int i, int count)
        {
            InitializeComponent();
            richTextPresentID.Text = idd.ToString();
            richTextBoxAbs.Text = id.ToString();
            labelpresent.Text = i.ToString();
            labelAbsent.Text = count.ToString();
        }

        public attendance()
        {
            // TODO: Complete member initialization
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            String filename = save.FileName;
            String filter = "Text Files|*.txt|All Files|*.*";
            save.Filter = filter;
            save.Title = "Save";

            if (save.ShowDialog() != DialogResult.Cancel)
            {
                System.IO.StreamWriter strwri = new System.IO.StreamWriter(save.FileName);
                {
                    strwri.Write(richTextPresentID.Text);
                    strwri.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            FormSelect frm2 = new FormSelect();
            FormStart frm3 = new FormStart();
            frm1.Close();
            frm2.Close();
            frm3.Close();
            this.Close();
        }

      

    }
}
