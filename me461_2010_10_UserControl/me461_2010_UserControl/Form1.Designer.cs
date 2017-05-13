namespace me461_2010_UserControl
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
            this.myColorfulStupidSquareButton3 = new me461_2010_UserControl.MyColorfulStupidSquareButton();
            this.myColorfulStupidSquareButton2 = new me461_2010_UserControl.MyColorfulStupidSquareButton();
            this.myColorfulStupidSquareButton1 = new me461_2010_UserControl.MyColorfulStupidSquareButton();
            this.SuspendLayout();
            // 
            // myColorfulStupidSquareButton3
            // 
            this.myColorfulStupidSquareButton3.BackColor = System.Drawing.Color.Red;
            this.myColorfulStupidSquareButton3.Location = new System.Drawing.Point(413, 78);
            this.myColorfulStupidSquareButton3.Name = "myColorfulStupidSquareButton3";
            this.myColorfulStupidSquareButton3.Size = new System.Drawing.Size(144, 144);
            this.myColorfulStupidSquareButton3.TabIndex = 2;
            // 
            // myColorfulStupidSquareButton2
            // 
            this.myColorfulStupidSquareButton2.BackColor = System.Drawing.Color.Red;
            this.myColorfulStupidSquareButton2.Location = new System.Drawing.Point(212, 80);
            this.myColorfulStupidSquareButton2.Name = "myColorfulStupidSquareButton2";
            this.myColorfulStupidSquareButton2.Size = new System.Drawing.Size(156, 156);
            this.myColorfulStupidSquareButton2.TabIndex = 1;
            // 
            // myColorfulStupidSquareButton1
            // 
            this.myColorfulStupidSquareButton1.BackColor = System.Drawing.Color.Red;
            this.myColorfulStupidSquareButton1.Location = new System.Drawing.Point(38, 78);
            this.myColorfulStupidSquareButton1.Name = "myColorfulStupidSquareButton1";
            this.myColorfulStupidSquareButton1.Size = new System.Drawing.Size(144, 144);
            this.myColorfulStupidSquareButton1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 400);
            this.Controls.Add(this.myColorfulStupidSquareButton3);
            this.Controls.Add(this.myColorfulStupidSquareButton2);
            this.Controls.Add(this.myColorfulStupidSquareButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyColorfulStupidSquareButton myColorfulStupidSquareButton1;
        private MyColorfulStupidSquareButton myColorfulStupidSquareButton2;
        private MyColorfulStupidSquareButton myColorfulStupidSquareButton3;



    }
}

