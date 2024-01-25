namespace IllovoOvertimeSystemDesktop
{
    partial class clockout
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
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelClockOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmployeeID.Location = new System.Drawing.Point(99, 111);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(228, 23);
            this.labelEmployeeID.TabIndex = 0;
            this.labelEmployeeID.Text = "Employee ID";
            this.labelEmployeeID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.BackColor = System.Drawing.Color.ForestGreen;
            this.textBoxEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmployeeId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeId.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxEmployeeId.Location = new System.Drawing.Point(103, 143);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(224, 18);
            this.textBoxEmployeeId.TabIndex = 1;
            this.textBoxEmployeeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.White;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSubmit.Location = new System.Drawing.Point(138, 344);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(150, 41);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 1);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPassword.Location = new System.Drawing.Point(102, 180);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(225, 23);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.ForestGreen;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxPassword.Location = new System.Drawing.Point(103, 212);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 18);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 1);
            this.label3.TabIndex = 3;
            this.label3.Text = "label1";
            // 
            // labelClockOut
            // 
            this.labelClockOut.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClockOut.ForeColor = System.Drawing.SystemColors.Control;
            this.labelClockOut.Location = new System.Drawing.Point(1, 9);
            this.labelClockOut.Name = "labelClockOut";
            this.labelClockOut.Size = new System.Drawing.Size(421, 40);
            this.labelClockOut.TabIndex = 0;
            this.labelClockOut.Text = "CLOCK OUT";
            this.labelClockOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelClockOut);
            this.Controls.Add(this.labelEmployeeID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "clockout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelClockOut;
    }
}