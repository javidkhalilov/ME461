namespace me461_2010_05_functions
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
            this.txtBoxa = new System.Windows.Forms.TextBox();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSwap1 = new System.Windows.Forms.Button();
            this.btnSwap2 = new System.Windows.Forms.Button();
            this.btnStupidAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnFactorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxa
            // 
            this.txtBoxa.Location = new System.Drawing.Point(13, 13);
            this.txtBoxa.Name = "txtBoxa";
            this.txtBoxa.Size = new System.Drawing.Size(30, 20);
            this.txtBoxa.TabIndex = 0;
            this.txtBoxa.Text = "14";
            this.txtBoxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(61, 13);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(37, 20);
            this.txtBoxB.TabIndex = 1;
            this.txtBoxB.Text = "5";
            this.txtBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(134, 9);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 2;
            this.btnSwap.Text = "swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSwap1
            // 
            this.btnSwap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSwap1.Location = new System.Drawing.Point(13, 68);
            this.btnSwap1.Name = "btnSwap1";
            this.btnSwap1.Size = new System.Drawing.Size(85, 31);
            this.btnSwap1.TabIndex = 3;
            this.btnSwap1.Text = "button1";
            this.btnSwap1.UseVisualStyleBackColor = false;
            // 
            // btnSwap2
            // 
            this.btnSwap2.BackColor = System.Drawing.Color.Red;
            this.btnSwap2.ForeColor = System.Drawing.Color.Black;
            this.btnSwap2.Location = new System.Drawing.Point(124, 68);
            this.btnSwap2.Name = "btnSwap2";
            this.btnSwap2.Size = new System.Drawing.Size(85, 31);
            this.btnSwap2.TabIndex = 3;
            this.btnSwap2.Text = "button2";
            this.btnSwap2.UseVisualStyleBackColor = false;
            this.btnSwap2.Click += new System.EventHandler(this.btnSwap2_Click);
            // 
            // btnStupidAdd
            // 
            this.btnStupidAdd.Location = new System.Drawing.Point(215, 9);
            this.btnStupidAdd.Name = "btnStupidAdd";
            this.btnStupidAdd.Size = new System.Drawing.Size(57, 47);
            this.btnStupidAdd.TabIndex = 4;
            this.btnStupidAdd.Text = "stupid add";
            this.btnStupidAdd.UseVisualStyleBackColor = true;
            this.btnStupidAdd.Click += new System.EventHandler(this.btnStupidAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2s",
            "3",
            "4",
            "5",
            "6",
            "7g",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.listBox1.Location = new System.Drawing.Point(13, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 5;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(159, 154);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(89, 29);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "stats";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(269, 79);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(269, 133);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(75, 50);
            this.btnFactorial.TabIndex = 8;
            this.btnFactorial.Text = "compute factorial";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 335);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStupidAdd);
            this.Controls.Add(this.btnSwap2);
            this.Controls.Add(this.btnSwap1);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.txtBoxa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxa;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSwap1;
        private System.Windows.Forms.Button btnSwap2;
        private System.Windows.Forms.Button btnStupidAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnFactorial;
    }
}

