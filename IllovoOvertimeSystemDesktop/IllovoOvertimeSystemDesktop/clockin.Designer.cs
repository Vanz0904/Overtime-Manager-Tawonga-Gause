namespace IllovoOvertimeSystemDesktop
{
    partial class clockin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelClockIn = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonOvertime = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 1);
            this.label3.TabIndex = 11;
            this.label3.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 1);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.White;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSubmit.Location = new System.Drawing.Point(149, 370);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(150, 41);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.ForestGreen;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxPassword.Location = new System.Drawing.Point(111, 211);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 18);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.BackColor = System.Drawing.Color.ForestGreen;
            this.textBoxEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmployeeId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeId.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxEmployeeId.Location = new System.Drawing.Point(111, 142);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(224, 18);
            this.textBoxEmployeeId.TabIndex = 9;
            this.textBoxEmployeeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmployeeId.TextChanged += new System.EventHandler(this.textBoxEmployeeId_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPassword.Location = new System.Drawing.Point(110, 179);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(225, 23);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClockIn
            // 
            this.labelClockIn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClockIn.ForeColor = System.Drawing.SystemColors.Control;
            this.labelClockIn.Location = new System.Drawing.Point(9, 8);
            this.labelClockIn.Name = "labelClockIn";
            this.labelClockIn.Size = new System.Drawing.Size(421, 40);
            this.labelClockIn.TabIndex = 6;
            this.labelClockIn.Text = "CLOCK IN";
            this.labelClockIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmployeeID.Location = new System.Drawing.Point(107, 110);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(228, 23);
            this.labelEmployeeID.TabIndex = 7;
            this.labelEmployeeID.Text = "Employee ID";
            this.labelEmployeeID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRegular.ForeColor = System.Drawing.Color.Transparent;
            this.radioButtonRegular.Location = new System.Drawing.Point(173, 274);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(98, 19);
            this.radioButtonRegular.TabIndex = 15;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "Regular hours";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            this.radioButtonRegular.CheckedChanged += new System.EventHandler(this.radioButtonRegular_CheckedChanged);
            // 
            // radioButtonOvertime
            // 
            this.radioButtonOvertime.AutoSize = true;
            this.radioButtonOvertime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOvertime.ForeColor = System.Drawing.Color.Transparent;
            this.radioButtonOvertime.Location = new System.Drawing.Point(173, 307);
            this.radioButtonOvertime.Name = "radioButtonOvertime";
            this.radioButtonOvertime.Size = new System.Drawing.Size(107, 19);
            this.radioButtonOvertime.TabIndex = 15;
            this.radioButtonOvertime.TabStop = true;
            this.radioButtonOvertime.Text = "Overtime hours";
            this.radioButtonOvertime.UseVisualStyleBackColor = true;
            this.radioButtonOvertime.CheckedChanged += new System.EventHandler(this.radioButtonOvertime_CheckedChanged);
            // 
            // clockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.radioButtonOvertime);
            this.Controls.Add(this.radioButtonRegular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelClockIn);
            this.Controls.Add(this.labelEmployeeID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "clockin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelClockIn;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonOvertime;
    }
}