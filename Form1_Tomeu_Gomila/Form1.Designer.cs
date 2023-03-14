namespace Form1_Tomeu_Gomila
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Hostname = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_getaway = new System.Windows.Forms.Label();
            this.lbl_ssid = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_ssid_status = new System.Windows.Forms.Label();
            this.lbl_mac_address = new System.Windows.Forms.Label();
            this.lbl_Internet_Connection = new System.Windows.Forms.Label();
            this.lbl_VirtualBoxInstalled = new System.Windows.Forms.Label();
            this.lbl_VBOX_V = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.Teal;
            this.label12.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(770, 69);
            this.label12.TabIndex = 0;
            this.label12.Text = "WELCOME TO VIRTUAL BOX MANAGEMENT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(95, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP HOST:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(95, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP GETAWAY:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(95, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "USERNAME:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(98, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "HOSTNAME:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(98, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "SSID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(454, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "SSID STATUS:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(457, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "MAC ADDRESS:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(460, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "INTERNET CONNECTION:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(460, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "IS VIRTUALBOX INSTALLED?";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(463, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "VIRTUAL BOX VERSION:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Black;
            this.lbl_Username.ForeColor = System.Drawing.Color.Red;
            this.lbl_Username.Location = new System.Drawing.Point(173, 159);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(91, 16);
            this.lbl_Username.TabIndex = 11;
            this.lbl_Username.Text = "lbl_Username";
            // 
            // lbl_Hostname
            // 
            this.lbl_Hostname.AutoSize = true;
            this.lbl_Hostname.BackColor = System.Drawing.Color.Black;
            this.lbl_Hostname.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hostname.Location = new System.Drawing.Point(176, 188);
            this.lbl_Hostname.Name = "lbl_Hostname";
            this.lbl_Hostname.Size = new System.Drawing.Size(90, 16);
            this.lbl_Hostname.TabIndex = 12;
            this.lbl_Hostname.Text = "lbl_Hostname";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.BackColor = System.Drawing.Color.Black;
            this.lbl_ip.ForeColor = System.Drawing.Color.Red;
            this.lbl_ip.Location = new System.Drawing.Point(159, 98);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(39, 16);
            this.lbl_ip.TabIndex = 13;
            this.lbl_ip.Text = "lbl_ip";
            // 
            // lbl_getaway
            // 
            this.lbl_getaway.AutoSize = true;
            this.lbl_getaway.BackColor = System.Drawing.Color.Black;
            this.lbl_getaway.ForeColor = System.Drawing.Color.Red;
            this.lbl_getaway.Location = new System.Drawing.Point(179, 127);
            this.lbl_getaway.Name = "lbl_getaway";
            this.lbl_getaway.Size = new System.Drawing.Size(79, 16);
            this.lbl_getaway.TabIndex = 14;
            this.lbl_getaway.Text = "lbl_getaway";
            // 
            // lbl_ssid
            // 
            this.lbl_ssid.AutoSize = true;
            this.lbl_ssid.BackColor = System.Drawing.Color.Black;
            this.lbl_ssid.ForeColor = System.Drawing.Color.Red;
            this.lbl_ssid.Location = new System.Drawing.Point(147, 224);
            this.lbl_ssid.Name = "lbl_ssid";
            this.lbl_ssid.Size = new System.Drawing.Size(53, 16);
            this.lbl_ssid.TabIndex = 15;
            this.lbl_ssid.Text = "lbl_ssid";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "label13";
            // 
            // lbl_ssid_status
            // 
            this.lbl_ssid_status.AutoSize = true;
            this.lbl_ssid_status.BackColor = System.Drawing.Color.Black;
            this.lbl_ssid_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_ssid_status.Location = new System.Drawing.Point(542, 97);
            this.lbl_ssid_status.Name = "lbl_ssid_status";
            this.lbl_ssid_status.Size = new System.Drawing.Size(95, 16);
            this.lbl_ssid_status.TabIndex = 17;
            this.lbl_ssid_status.Text = "lbl_ssid_status";
            // 
            // lbl_mac_address
            // 
            this.lbl_mac_address.AutoSize = true;
            this.lbl_mac_address.BackColor = System.Drawing.Color.Black;
            this.lbl_mac_address.ForeColor = System.Drawing.Color.Red;
            this.lbl_mac_address.Location = new System.Drawing.Point(545, 126);
            this.lbl_mac_address.Name = "lbl_mac_address";
            this.lbl_mac_address.Size = new System.Drawing.Size(111, 16);
            this.lbl_mac_address.TabIndex = 18;
            this.lbl_mac_address.Text = "lbl_mac_address";
            // 
            // lbl_Internet_Connection
            // 
            this.lbl_Internet_Connection.AutoSize = true;
            this.lbl_Internet_Connection.BackColor = System.Drawing.Color.Black;
            this.lbl_Internet_Connection.ForeColor = System.Drawing.Color.Red;
            this.lbl_Internet_Connection.Location = new System.Drawing.Point(596, 158);
            this.lbl_Internet_Connection.Name = "lbl_Internet_Connection";
            this.lbl_Internet_Connection.Size = new System.Drawing.Size(145, 16);
            this.lbl_Internet_Connection.TabIndex = 19;
            this.lbl_Internet_Connection.Text = "lbl_Internet_Connection";
            // 
            // lbl_VirtualBoxInstalled
            // 
            this.lbl_VirtualBoxInstalled.AutoSize = true;
            this.lbl_VirtualBoxInstalled.BackColor = System.Drawing.Color.Black;
            this.lbl_VirtualBoxInstalled.ForeColor = System.Drawing.Color.Red;
            this.lbl_VirtualBoxInstalled.Location = new System.Drawing.Point(616, 188);
            this.lbl_VirtualBoxInstalled.Name = "lbl_VirtualBoxInstalled";
            this.lbl_VirtualBoxInstalled.Size = new System.Drawing.Size(138, 16);
            this.lbl_VirtualBoxInstalled.TabIndex = 20;
            this.lbl_VirtualBoxInstalled.Text = "lbl_VirtualBoxInstalled";
            // 
            // lbl_VBOX_V
            // 
            this.lbl_VBOX_V.AutoSize = true;
            this.lbl_VBOX_V.BackColor = System.Drawing.Color.Black;
            this.lbl_VBOX_V.ForeColor = System.Drawing.Color.Red;
            this.lbl_VBOX_V.Location = new System.Drawing.Point(599, 222);
            this.lbl_VBOX_V.Name = "lbl_VBOX_V";
            this.lbl_VBOX_V.Size = new System.Drawing.Size(80, 16);
            this.lbl_VBOX_V.TabIndex = 21;
            this.lbl_VBOX_V.Text = "lbl_VBOX_V";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 429);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Image = global::Form1_Tomeu_Gomila.Properties.Resources.wp4615518;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 451);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_VBOX_V);
            this.Controls.Add(this.lbl_VirtualBoxInstalled);
            this.Controls.Add(this.lbl_Internet_Connection);
            this.Controls.Add(this.lbl_mac_address);
            this.Controls.Add(this.lbl_ssid_status);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_ssid);
            this.Controls.Add(this.lbl_getaway);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.lbl_Hostname);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VirtualBoxManagement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Hostname;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_getaway;
        private System.Windows.Forms.Label lbl_ssid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_ssid_status;
        private System.Windows.Forms.Label lbl_mac_address;
        private System.Windows.Forms.Label lbl_Internet_Connection;
        private System.Windows.Forms.Label lbl_VirtualBoxInstalled;
        private System.Windows.Forms.Label lbl_VBOX_V;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

