namespace bluetoothTuto
{
    partial class FormSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelect));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.comboBoxSem = new System.Windows.Forms.ComboBox();
            this.comboBoxSub = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonStartScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(635, 136);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Items.AddRange(new object[] {
            "CSE",
            "ME",
            "EEE",
            "CE",
            "TE",
            "Arch",
            "IPE"});
            this.comboBoxDept.Location = new System.Drawing.Point(126, 165);
            this.comboBoxDept.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(180, 27);
            this.comboBoxDept.TabIndex = 4;
            // 
            // comboBoxSem
            // 
            this.comboBoxSem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSem.FormattingEnabled = true;
            this.comboBoxSem.Items.AddRange(new object[] {
            "1/2",
            "2/2",
            "2/1",
            "2/2",
            "3/1",
            "3/2",
            "4/1",
            "4/2"});
            this.comboBoxSem.Location = new System.Drawing.Point(126, 219);
            this.comboBoxSem.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSem.Name = "comboBoxSem";
            this.comboBoxSem.Size = new System.Drawing.Size(180, 27);
            this.comboBoxSem.TabIndex = 5;
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSub.FormattingEnabled = true;
            this.comboBoxSub.Items.AddRange(new object[] {
            "CSE-2824",
            "CSE-2422",
            "CSE-2421"});
            this.comboBoxSub.Location = new System.Drawing.Point(426, 222);
            this.comboBoxSub.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(180, 27);
            this.comboBoxSub.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subject";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(410, 162);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // buttonStartScan
            // 
            this.buttonStartScan.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonStartScan.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartScan.Location = new System.Drawing.Point(222, 280);
            this.buttonStartScan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartScan.Name = "buttonStartScan";
            this.buttonStartScan.Size = new System.Drawing.Size(234, 98);
            this.buttonStartScan.TabIndex = 11;
            this.buttonStartScan.Text = "NEXT";
            this.buttonStartScan.UseVisualStyleBackColor = false;
            this.buttonStartScan.Click += new System.EventHandler(this.buttonStartScan_Click);
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 379);
            this.Controls.Add(this.buttonStartScan);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSub);
            this.Controls.Add(this.comboBoxSem);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSelect";
            this.Text = "FormSelect";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.ComboBox comboBoxSem;
        private System.Windows.Forms.ComboBox comboBoxSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonStartScan;
    }
}