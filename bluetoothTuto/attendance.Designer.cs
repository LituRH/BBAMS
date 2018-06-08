namespace bluetoothTuto
{
    partial class attendance
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
            this.richTextPresentID = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAbs = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelpresent = new System.Windows.Forms.Label();
            this.labelAbsent = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextPresentID
            // 
            this.richTextPresentID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextPresentID.Location = new System.Drawing.Point(15, 37);
            this.richTextPresentID.Name = "richTextPresentID";
            this.richTextPresentID.ReadOnly = true;
            this.richTextPresentID.Size = new System.Drawing.Size(401, 309);
            this.richTextPresentID.TabIndex = 0;
            this.richTextPresentID.Text = "";
            // 
            // richTextBoxAbs
            // 
            this.richTextBoxAbs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAbs.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxAbs.Location = new System.Drawing.Point(25, 36);
            this.richTextBoxAbs.Name = "richTextBoxAbs";
            this.richTextBoxAbs.ReadOnly = true;
            this.richTextBoxAbs.Size = new System.Drawing.Size(397, 310);
            this.richTextBoxAbs.TabIndex = 1;
            this.richTextBoxAbs.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelpresent);
            this.groupBox1.Controls.Add(this.richTextPresentID);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 395);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Present\"s ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.labelAbsent);
            this.groupBox2.Controls.Add(this.richTextBoxAbs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(488, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 394);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Absent ID";
            // 
            // labelpresent
            // 
            this.labelpresent.AutoSize = true;
            this.labelpresent.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelpresent.Location = new System.Drawing.Point(310, 3);
            this.labelpresent.Name = "labelpresent";
            this.labelpresent.Size = new System.Drawing.Size(92, 31);
            this.labelpresent.TabIndex = 3;
            this.labelpresent.Text = "label1";
            // 
            // labelAbsent
            // 
            this.labelAbsent.AutoSize = true;
            this.labelAbsent.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelAbsent.Location = new System.Drawing.Point(330, -1);
            this.labelAbsent.Name = "labelAbsent";
            this.labelAbsent.Size = new System.Drawing.Size(92, 31);
            this.labelAbsent.TabIndex = 4;
            this.labelAbsent.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(962, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "attendance";
            this.Text = "Attendance List";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextPresentID;
        private System.Windows.Forms.RichTextBox richTextBoxAbs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelpresent;
        private System.Windows.Forms.Label labelAbsent;
        private System.Windows.Forms.Button button2;
    }
}