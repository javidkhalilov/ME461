namespace me461_2010_Inherit101
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
            this.rtBox = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAccelerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtBox
            // 
            this.rtBox.Location = new System.Drawing.Point(12, 12);
            this.rtBox.Name = "rtBox";
            this.rtBox.Size = new System.Drawing.Size(618, 179);
            this.rtBox.TabIndex = 0;
            this.rtBox.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(39, 222);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 31);
            this.numericUpDown1.TabIndex = 1;
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(140, 222);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(75, 31);
            this.btnAccelerate.TabIndex = 2;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 474);
            this.Controls.Add(this.btnAccelerate);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAccelerate;
    }
}

