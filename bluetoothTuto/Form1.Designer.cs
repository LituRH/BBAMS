namespace bluetoothTuto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbox = new System.Windows.Forms.ListBox();
            this.bGo = new System.Windows.Forms.Button();
            this.rBclient = new System.Windows.Forms.RadioButton();
            this.rBServer = new System.Windows.Forms.RadioButton();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxID = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCSE12 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCSE32 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxCSE42 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbox
            // 
            this.lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox.FormattingEnabled = true;
            this.lbox.ItemHeight = 20;
            this.lbox.Location = new System.Drawing.Point(5, 35);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(179, 424);
            this.lbox.TabIndex = 0;
            this.lbox.DoubleClick += new System.EventHandler(this.lbox_DoubleClick);
            // 
            // bGo
            // 
            this.bGo.BackColor = System.Drawing.Color.Tan;
            this.bGo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGo.Location = new System.Drawing.Point(197, 19);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(195, 75);
            this.bGo.TabIndex = 3;
            this.bGo.Text = "Search Device";
            this.bGo.UseVisualStyleBackColor = false;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // rBclient
            // 
            this.rBclient.AutoSize = true;
            this.rBclient.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBclient.Location = new System.Drawing.Point(47, 13);
            this.rBclient.Name = "rBclient";
            this.rBclient.Size = new System.Drawing.Size(134, 35);
            this.rBclient.TabIndex = 4;
            this.rBclient.Text = "CLIENT";
            this.rBclient.UseVisualStyleBackColor = true;
            // 
            // rBServer
            // 
            this.rBServer.AutoSize = true;
            this.rBServer.Checked = true;
            this.rBServer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBServer.Location = new System.Drawing.Point(47, 49);
            this.rBServer.Name = "rBServer";
            this.rBServer.Size = new System.Drawing.Size(139, 35);
            this.rBServer.TabIndex = 5;
            this.rBServer.TabStop = true;
            this.rBServer.Text = "SERVER";
            this.rBServer.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(190, 35);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(197, 262);
            this.textBoxOutput.TabIndex = 6;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connection Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Discovered Devices";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBclient);
            this.groupBox1.Controls.Add(this.bGo);
            this.groupBox1.Controls.Add(this.rBServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(538, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Design and Developed By DUET,  KEYTASK    (Vesrsion 2015.01)";
            // 
            // listBoxID
            // 
            this.listBoxID.FormattingEnabled = true;
            this.listBoxID.Items.AddRange(new object[] {
            "124001",
            "124002",
            "124003",
            "124004",
            "124005",
            "124006",
            "124007",
            "124008",
            "124009",
            "124010",
            "124011",
            "124012",
            "124013",
            "124014",
            "124015",
            "124016",
            "124017",
            "124018",
            "124019",
            "124020",
            "124021",
            "124022",
            "124023",
            "124024",
            "124025",
            "124026",
            "124027",
            "124028",
            "124029",
            "124030",
            "124031",
            "124032",
            "124033",
            "124034",
            "124035",
            "124036",
            "124037",
            "124038",
            "124039",
            "124040",
            "124041",
            "124042",
            "124043",
            "124044",
            "124045",
            "124046",
            "124047",
            "124048",
            "124049",
            "124050",
            "124051",
            "124052",
            "124053",
            "124054",
            "124055",
            "124056",
            "124057",
            "124058",
            "124059",
            "124060",
            "124061",
            "114012"});
            this.listBoxID.Location = new System.Drawing.Point(394, 221);
            this.listBoxID.Name = "listBoxID";
            this.listBoxID.Size = new System.Drawing.Size(62, 147);
            this.listBoxID.TabIndex = 15;
            this.listBoxID.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 66);
            this.button1.TabIndex = 16;
            this.button1.Text = "Attedance";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 21;
            // 
            // listBoxCSE12
            // 
            this.listBoxCSE12.FormattingEnabled = true;
            this.listBoxCSE12.Items.AddRange(new object[] {
            "134001",
            "134002",
            "134003",
            "134004",
            "134005",
            "134006",
            "134007",
            "134008",
            "134009",
            "134010"});
            this.listBoxCSE12.Location = new System.Drawing.Point(394, 52);
            this.listBoxCSE12.Name = "listBoxCSE12";
            this.listBoxCSE12.Size = new System.Drawing.Size(58, 147);
            this.listBoxCSE12.TabIndex = 24;
            this.listBoxCSE12.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "CSE-2/2";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "CSE-1/2";
            this.label6.Visible = false;
            // 
            // listBoxCSE32
            // 
            this.listBoxCSE32.FormattingEnabled = true;
            this.listBoxCSE32.Items.AddRange(new object[] {
            "114001",
            "114002",
            "114003",
            "114004",
            "114005",
            "114006",
            "114007",
            "114008",
            "114009",
            "114010"});
            this.listBoxCSE32.Location = new System.Drawing.Point(468, 54);
            this.listBoxCSE32.Name = "listBoxCSE32";
            this.listBoxCSE32.Size = new System.Drawing.Size(54, 147);
            this.listBoxCSE32.TabIndex = 27;
            this.listBoxCSE32.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "CSE-3/2";
            this.label7.Visible = false;
            // 
            // listBoxCSE42
            // 
            this.listBoxCSE42.FormattingEnabled = true;
            this.listBoxCSE42.Items.AddRange(new object[] {
            "094001",
            "094002",
            "094003",
            "094004",
            "094005",
            "094006",
            "094007",
            "094008",
            "094009",
            "094010"});
            this.listBoxCSE42.Location = new System.Drawing.Point(461, 222);
            this.listBoxCSE42.Name = "listBoxCSE42";
            this.listBoxCSE42.Size = new System.Drawing.Size(60, 147);
            this.listBoxCSE42.TabIndex = 29;
            this.listBoxCSE42.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "CSE-4/2";
            this.label8.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 286);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(384, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 66);
            this.button2.TabIndex = 32;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxCSE42);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxCSE32);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxCSE12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.lbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bluetooth Connecting Apps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.RadioButton rBclient;
        private System.Windows.Forms.RadioButton rBServer;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCSE12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxCSE32;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxCSE42;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

