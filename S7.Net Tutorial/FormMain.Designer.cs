namespace PROFINET_STEP_7
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cboxPLCs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnDisconnection = new System.Windows.Forms.Button();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.numericUpDownSlot = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRack = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRealOutput = new System.Windows.Forms.TextBox();
            this.txtRealInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadReal = new System.Windows.Forms.Button();
            this.btnWriteReal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWordOutput = new System.Windows.Forms.TextBox();
            this.txtWordInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReadWord = new System.Windows.Forms.Button();
            this.btnWriteWord = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.btnMOn = new System.Windows.Forms.Button();
            this.btnMOff = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBoxConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC Model";
            // 
            // cboxPLCs
            // 
            this.cboxPLCs.FormattingEnabled = true;
            this.cboxPLCs.Items.AddRange(new object[] {
            "S7-200",
            "S7-300",
            "S7-400",
            "S7-1200",
            "S7-1500"});
            this.cboxPLCs.Location = new System.Drawing.Point(98, 26);
            this.cboxPLCs.Name = "cboxPLCs";
            this.cboxPLCs.Size = new System.Drawing.Size(175, 28);
            this.cboxPLCs.TabIndex = 1;
            this.cboxPLCs.SelectedIndexChanged += new System.EventHandler(this.cboxPLCs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP Address";
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.Location = new System.Drawing.Point(98, 61);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(175, 26);
            this.txtIPaddress.TabIndex = 2;
            this.txtIPaddress.Text = "192.168.0.1";
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(279, 22);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(115, 33);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnDisconnection
            // 
            this.btnDisconnection.Location = new System.Drawing.Point(279, 62);
            this.btnDisconnection.Name = "btnDisconnection";
            this.btnDisconnection.Size = new System.Drawing.Size(115, 33);
            this.btnDisconnection.TabIndex = 3;
            this.btnDisconnection.Text = "Disconnect";
            this.btnDisconnection.UseVisualStyleBackColor = true;
            this.btnDisconnection.Click += new System.EventHandler(this.btnDisconnection_Click);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.numericUpDownSlot);
            this.groupBoxConnection.Controls.Add(this.numericUpDownRack);
            this.groupBoxConnection.Controls.Add(this.txtIPaddress);
            this.groupBoxConnection.Controls.Add(this.btnDisconnection);
            this.groupBoxConnection.Controls.Add(this.label1);
            this.groupBoxConnection.Controls.Add(this.label8);
            this.groupBoxConnection.Controls.Add(this.btnConnection);
            this.groupBoxConnection.Controls.Add(this.label7);
            this.groupBoxConnection.Controls.Add(this.label2);
            this.groupBoxConnection.Controls.Add(this.cboxPLCs);
            this.groupBoxConnection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(408, 166);
            this.groupBoxConnection.TabIndex = 4;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection";
            // 
            // numericUpDownSlot
            // 
            this.numericUpDownSlot.Location = new System.Drawing.Point(82, 130);
            this.numericUpDownSlot.Name = "numericUpDownSlot";
            this.numericUpDownSlot.Size = new System.Drawing.Size(190, 26);
            this.numericUpDownSlot.TabIndex = 4;
            this.numericUpDownSlot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownRack
            // 
            this.numericUpDownRack.Location = new System.Drawing.Point(82, 96);
            this.numericUpDownRack.Name = "numericUpDownRack";
            this.numericUpDownRack.Size = new System.Drawing.Size(190, 26);
            this.numericUpDownRack.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Slot:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rack:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRealOutput);
            this.groupBox1.Controls.Add(this.txtRealInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnReadReal);
            this.groupBox1.Controls.Add(this.btnWriteReal);
            this.groupBox1.Location = new System.Drawing.Point(426, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read/write real numbers";
            // 
            // txtRealOutput
            // 
            this.txtRealOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealOutput.Location = new System.Drawing.Point(79, 27);
            this.txtRealOutput.Name = "txtRealOutput";
            this.txtRealOutput.Size = new System.Drawing.Size(131, 30);
            this.txtRealOutput.TabIndex = 15;
            this.txtRealOutput.Text = "DB0.DBD0";
            this.txtRealOutput.TextChanged += new System.EventHandler(this.txtRealOutput_TextChanged);
            // 
            // txtRealInput
            // 
            this.txtRealInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealInput.Location = new System.Drawing.Point(79, 65);
            this.txtRealInput.Name = "txtRealInput";
            this.txtRealInput.Size = new System.Drawing.Size(131, 30);
            this.txtRealInput.TabIndex = 15;
            this.txtRealInput.Text = "0.0";
            this.txtRealInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "I/O:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // btnReadReal
            // 
            this.btnReadReal.Location = new System.Drawing.Point(221, 26);
            this.btnReadReal.Name = "btnReadReal";
            this.btnReadReal.Size = new System.Drawing.Size(112, 31);
            this.btnReadReal.TabIndex = 12;
            this.btnReadReal.Text = "Read data";
            this.btnReadReal.UseVisualStyleBackColor = true;
            this.btnReadReal.Click += new System.EventHandler(this.btnReadReal_Click);
            // 
            // btnWriteReal
            // 
            this.btnWriteReal.Location = new System.Drawing.Point(221, 60);
            this.btnWriteReal.Name = "btnWriteReal";
            this.btnWriteReal.Size = new System.Drawing.Size(112, 31);
            this.btnWriteReal.TabIndex = 14;
            this.btnWriteReal.Text = "Write data ";
            this.btnWriteReal.UseVisualStyleBackColor = true;
            this.btnWriteReal.Click += new System.EventHandler(this.btnWriteReal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWordOutput);
            this.groupBox2.Controls.Add(this.txtWordInput);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnReadWord);
            this.groupBox2.Controls.Add(this.btnWriteWord);
            this.groupBox2.Location = new System.Drawing.Point(425, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 108);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read/write integers";
            // 
            // txtWordOutput
            // 
            this.txtWordOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordOutput.Location = new System.Drawing.Point(79, 27);
            this.txtWordOutput.Name = "txtWordOutput";
            this.txtWordOutput.Size = new System.Drawing.Size(131, 30);
            this.txtWordOutput.TabIndex = 15;
            this.txtWordOutput.Text = "MW0";
            this.txtWordOutput.TextChanged += new System.EventHandler(this.txtWordOutput_TextChanged);
            // 
            // txtWordInput
            // 
            this.txtWordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordInput.Location = new System.Drawing.Point(79, 65);
            this.txtWordInput.Name = "txtWordInput";
            this.txtWordInput.Size = new System.Drawing.Size(131, 30);
            this.txtWordInput.TabIndex = 15;
            this.txtWordInput.Text = "0";
            this.txtWordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWordInput.TextChanged += new System.EventHandler(this.txtWordInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "I/O:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // btnReadWord
            // 
            this.btnReadWord.Location = new System.Drawing.Point(221, 16);
            this.btnReadWord.Name = "btnReadWord";
            this.btnReadWord.Size = new System.Drawing.Size(112, 31);
            this.btnReadWord.TabIndex = 12;
            this.btnReadWord.Text = "Read data";
            this.btnReadWord.UseVisualStyleBackColor = true;
            this.btnReadWord.Click += new System.EventHandler(this.btnReadWord_Click);
            // 
            // btnWriteWord
            // 
            this.btnWriteWord.Location = new System.Drawing.Point(221, 60);
            this.btnWriteWord.Name = "btnWriteWord";
            this.btnWriteWord.Size = new System.Drawing.Size(112, 31);
            this.btnWriteWord.TabIndex = 14;
            this.btnWriteWord.Text = "Write data";
            this.btnWriteWord.UseVisualStyleBackColor = true;
            this.btnWriteWord.Click += new System.EventHandler(this.btnWriteWord_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(12, 232);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(137, 38);
            this.btnOFF.TabIndex = 7;
            this.btnOFF.Text = "OFF  (Q2.7)";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(12, 188);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(137, 38);
            this.btnON.TabIndex = 8;
            this.btnON.Text = "ON   (Q2.7)";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnMOn
            // 
            this.btnMOn.Location = new System.Drawing.Point(155, 186);
            this.btnMOn.Name = "btnMOn";
            this.btnMOn.Size = new System.Drawing.Size(137, 38);
            this.btnMOn.TabIndex = 8;
            this.btnMOn.Text = "ON   (M0.0)";
            this.btnMOn.UseVisualStyleBackColor = true;
            this.btnMOn.Click += new System.EventHandler(this.btnMOn_Click);
            // 
            // btnMOff
            // 
            this.btnMOff.Location = new System.Drawing.Point(155, 230);
            this.btnMOff.Name = "btnMOff";
            this.btnMOff.Size = new System.Drawing.Size(137, 38);
            this.btnMOff.TabIndex = 7;
            this.btnMOff.Text = "OFF   (M0.0)";
            this.btnMOff.UseVisualStyleBackColor = true;
            this.btnMOff.Click += new System.EventHandler(this.btnMOff_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(425, 240);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(359, 38);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 277);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnMOff);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnMOn);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxConnection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 324);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(810, 324);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFINET SIEMENS S7";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxPLCs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPaddress;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnDisconnection;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRealInput;
        private System.Windows.Forms.Button btnReadReal;
        private System.Windows.Forms.Button btnWriteReal;
        private System.Windows.Forms.TextBox txtRealOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWordOutput;
        private System.Windows.Forms.TextBox txtWordInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReadWord;
        private System.Windows.Forms.Button btnWriteWord;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.NumericUpDown numericUpDownSlot;
        private System.Windows.Forms.NumericUpDown numericUpDownRack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMOn;
        private System.Windows.Forms.Button btnMOff;
        private System.Windows.Forms.Button btnAbout;

    }
}