namespace Temperature_Converter
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
            this.lbltempConver = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFahrenhiet = new System.Windows.Forms.Label();
            this.lblCelsuis = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.lblFahrenResp = new System.Windows.Forms.Label();
            this.lblCelsResp = new System.Windows.Forms.Label();
            this.lblKelvinResp = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltempConver
            // 
            this.lbltempConver.BackColor = System.Drawing.Color.LightYellow;
            this.lbltempConver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltempConver.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltempConver.Location = new System.Drawing.Point(109, 18);
            this.lbltempConver.Name = "lbltempConver";
            this.lbltempConver.Size = new System.Drawing.Size(396, 64);
            this.lbltempConver.TabIndex = 0;
            this.lbltempConver.Text = "Temperature Converter";
            this.lbltempConver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 196);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(154, 29);
            this.txtInput.TabIndex = 1;
            // 
            // lblIndex
            // 
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIndex.Location = new System.Drawing.Point(9, 161);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(176, 27);
            this.lblIndex.TabIndex = 2;
            this.lblIndex.Text = "Type Degree to convert:";
            // 
            // cboSelect
            // 
            this.cboSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Items.AddRange(new object[] {
            "Fahrenhiet",
            "Celsius",
            "Kelvin "});
            this.cboSelect.Location = new System.Drawing.Point(183, 199);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(165, 26);
            this.cboSelect.TabIndex = 3;
            this.cboSelect.Text = "choose the type unit ";
            this.cboSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(365, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // lblFahrenhiet
            // 
            this.lblFahrenhiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenhiet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFahrenhiet.Location = new System.Drawing.Point(520, 163);
            this.lblFahrenhiet.Name = "lblFahrenhiet";
            this.lblFahrenhiet.Size = new System.Drawing.Size(90, 23);
            this.lblFahrenhiet.TabIndex = 5;
            this.lblFahrenhiet.Text = "Fahrenhiet";
            // 
            // lblCelsuis
            // 
            this.lblCelsuis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsuis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCelsuis.Location = new System.Drawing.Point(520, 199);
            this.lblCelsuis.Name = "lblCelsuis";
            this.lblCelsuis.Size = new System.Drawing.Size(81, 23);
            this.lblCelsuis.TabIndex = 6;
            this.lblCelsuis.Text = "celsuis";
            // 
            // lblKelvin
            // 
            this.lblKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKelvin.Location = new System.Drawing.Point(523, 236);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(78, 23);
            this.lblKelvin.TabIndex = 7;
            this.lblKelvin.Text = "kelvin";
            // 
            // lblFahrenResp
            // 
            this.lblFahrenResp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFahrenResp.Location = new System.Drawing.Point(405, 161);
            this.lblFahrenResp.Name = "lblFahrenResp";
            this.lblFahrenResp.Size = new System.Drawing.Size(100, 23);
            this.lblFahrenResp.TabIndex = 8;
            // 
            // lblCelsResp
            // 
            this.lblCelsResp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCelsResp.Location = new System.Drawing.Point(405, 199);
            this.lblCelsResp.Name = "lblCelsResp";
            this.lblCelsResp.Size = new System.Drawing.Size(100, 23);
            this.lblCelsResp.TabIndex = 9;
            // 
            // lblKelvinResp
            // 
            this.lblKelvinResp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKelvinResp.Location = new System.Drawing.Point(405, 236);
            this.lblKelvinResp.Name = "lblKelvinResp";
            this.lblKelvinResp.Size = new System.Drawing.Size(100, 23);
            this.lblKelvinResp.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(359, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 38);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnClear.Location = new System.Drawing.Point(183, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 38);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(611, 333);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblKelvinResp);
            this.Controls.Add(this.lblCelsResp);
            this.Controls.Add(this.lblFahrenResp);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblCelsuis);
            this.Controls.Add(this.lblFahrenhiet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSelect);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbltempConver);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltempConver;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.ComboBox cboSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFahrenhiet;
        private System.Windows.Forms.Label lblCelsuis;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Label lblFahrenResp;
        private System.Windows.Forms.Label lblCelsResp;
        private System.Windows.Forms.Label lblKelvinResp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

