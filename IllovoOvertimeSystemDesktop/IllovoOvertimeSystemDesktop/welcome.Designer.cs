namespace IllovoOvertimeSystemDesktop
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.buttonClockIn = new System.Windows.Forms.Button();
            this.buttonClockOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHello
            // 
            this.lblHello.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.White;
            this.lblHello.Location = new System.Drawing.Point(-2, 153);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(786, 89);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello! Clocking In or Clocking Out?";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClockIn
            // 
            this.buttonClockIn.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClockIn.FlatAppearance.BorderSize = 0;
            this.buttonClockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClockIn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClockIn.ForeColor = System.Drawing.Color.White;
            this.buttonClockIn.Location = new System.Drawing.Point(278, 276);
            this.buttonClockIn.Name = "buttonClockIn";
            this.buttonClockIn.Size = new System.Drawing.Size(230, 44);
            this.buttonClockIn.TabIndex = 2;
            this.buttonClockIn.Text = "Clocking In";
            this.buttonClockIn.UseVisualStyleBackColor = false;
            this.buttonClockIn.Click += new System.EventHandler(this.buttonClockIn_Click);
            // 
            // buttonClockOut
            // 
            this.buttonClockOut.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClockOut.FlatAppearance.BorderSize = 0;
            this.buttonClockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClockOut.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClockOut.ForeColor = System.Drawing.Color.White;
            this.buttonClockOut.Location = new System.Drawing.Point(278, 346);
            this.buttonClockOut.Name = "buttonClockOut";
            this.buttonClockOut.Size = new System.Drawing.Size(230, 44);
            this.buttonClockOut.TabIndex = 3;
            this.buttonClockOut.Text = "Clocking Out";
            this.buttonClockOut.UseVisualStyleBackColor = false;
            this.buttonClockOut.Click += new System.EventHandler(this.buttonClockOut_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonClockOut);
            this.Controls.Add(this.buttonClockIn);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button buttonClockIn;
        private System.Windows.Forms.Button buttonClockOut;
    }
}

