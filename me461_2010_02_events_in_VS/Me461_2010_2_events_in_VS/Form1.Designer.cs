namespace Me461_2010_2_events_in_VS
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChangeBackColour = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIncrementByTwo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Tag = "inc1";
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "reset\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeBackColour
            // 
            this.btnChangeBackColour.Location = new System.Drawing.Point(197, 75);
            this.btnChangeBackColour.Name = "btnChangeBackColour";
            this.btnChangeBackColour.Size = new System.Drawing.Size(75, 36);
            this.btnChangeBackColour.TabIndex = 2;
            this.btnChangeBackColour.Text = "Change Back Colour";
            this.btnChangeBackColour.UseVisualStyleBackColor = true;
            this.btnChangeBackColour.Click += new System.EventHandler(this.btnChangeBackColour_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 111);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // btnIncrementByTwo
            // 
            this.btnIncrementByTwo.Location = new System.Drawing.Point(341, 22);
            this.btnIncrementByTwo.Name = "btnIncrementByTwo";
            this.btnIncrementByTwo.Size = new System.Drawing.Size(29, 23);
            this.btnIncrementByTwo.TabIndex = 4;
            this.btnIncrementByTwo.Tag = "inc2";
            this.btnIncrementByTwo.Text = "+2";
            this.btnIncrementByTwo.UseVisualStyleBackColor = true;
            this.btnIncrementByTwo.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(388, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 23);
            this.button4.TabIndex = 4;
            this.button4.Tag = "inc3";
            this.button4.Text = "+3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 395);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnIncrementByTwo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChangeBackColour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChangeBackColour;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnIncrementByTwo;
        private System.Windows.Forms.Button button4;

    }
}

