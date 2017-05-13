namespace me461_2010_06_YesICanDraw
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
            this.txtBoxXLine1 = new System.Windows.Forms.TextBox();
            this.txtBoxYLine1 = new System.Windows.Forms.TextBox();
            this.txtBoxXLine2 = new System.Windows.Forms.TextBox();
            this.txtBoxYLine2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCLS = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnPaintOnBmp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxXLine1
            // 
            this.txtBoxXLine1.Location = new System.Drawing.Point(16, 33);
            this.txtBoxXLine1.Name = "txtBoxXLine1";
            this.txtBoxXLine1.Size = new System.Drawing.Size(32, 20);
            this.txtBoxXLine1.TabIndex = 0;
            this.txtBoxXLine1.Text = "0\r\n";
            // 
            // txtBoxYLine1
            // 
            this.txtBoxYLine1.Location = new System.Drawing.Point(54, 33);
            this.txtBoxYLine1.Name = "txtBoxYLine1";
            this.txtBoxYLine1.Size = new System.Drawing.Size(36, 20);
            this.txtBoxYLine1.TabIndex = 0;
            this.txtBoxYLine1.Text = "0";
            // 
            // txtBoxXLine2
            // 
            this.txtBoxXLine2.Location = new System.Drawing.Point(16, 71);
            this.txtBoxXLine2.Name = "txtBoxXLine2";
            this.txtBoxXLine2.Size = new System.Drawing.Size(32, 20);
            this.txtBoxXLine2.TabIndex = 0;
            this.txtBoxXLine2.Text = "100\r\n";
            // 
            // txtBoxYLine2
            // 
            this.txtBoxYLine2.Location = new System.Drawing.Point(54, 71);
            this.txtBoxYLine2.Name = "txtBoxYLine2";
            this.txtBoxYLine2.Size = new System.Drawing.Size(36, 20);
            this.txtBoxYLine2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPaintOnBmp);
            this.groupBox1.Controls.Add(this.btnCLS);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnDrawLine);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtBoxXLine1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txtBoxYLine2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtBoxXLine2);
            this.groupBox1.Controls.Add(this.txtBoxYLine1);
            this.groupBox1.Location = new System.Drawing.Point(1, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw Line";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(107, 31);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(69, 48);
            this.btnDrawLine.TabIndex = 1;
            this.btnDrawLine.Text = "Draw";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(196, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(93, 121);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(813, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "0\r\n";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(742, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(36, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "add point";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1070, 94);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(32, 20);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "add point";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(311, 117);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 27);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCLS
            // 
            this.btnCLS.Location = new System.Drawing.Point(412, 71);
            this.btnCLS.Name = "btnCLS";
            this.btnCLS.Size = new System.Drawing.Size(47, 23);
            this.btnCLS.TabIndex = 6;
            this.btnCLS.Text = "cls";
            this.btnCLS.UseVisualStyleBackColor = true;
            this.btnCLS.Click += new System.EventHandler(this.btnCLS_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(42, 38);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(287, 226);
            this.pBox.TabIndex = 2;
            this.pBox.TabStop = false;
            this.pBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pBox_Paint);
            this.pBox.MouseEnter += new System.EventHandler(this.pBox_MouseEnter);
            this.pBox.MouseLeave += new System.EventHandler(this.pBox_MouseLeave);
            this.pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseMove);
            // 
            // btnPaintOnBmp
            // 
            this.btnPaintOnBmp.Location = new System.Drawing.Point(412, 115);
            this.btnPaintOnBmp.Name = "btnPaintOnBmp";
            this.btnPaintOnBmp.Size = new System.Drawing.Size(72, 29);
            this.btnPaintOnBmp.TabIndex = 7;
            this.btnPaintOnBmp.Text = "paint bitmap";
            this.btnPaintOnBmp.UseVisualStyleBackColor = true;
            this.btnPaintOnBmp.Click += new System.EventHandler(this.btnPaintOnBmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 468);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxXLine1;
        private System.Windows.Forms.TextBox txtBoxYLine1;
        private System.Windows.Forms.TextBox txtBoxXLine2;
        private System.Windows.Forms.TextBox txtBoxYLine2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCLS;
        private System.Windows.Forms.Button btnPaintOnBmp;
        private System.Windows.Forms.PictureBox pBox;
    }
}

