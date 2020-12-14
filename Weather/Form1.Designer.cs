namespace Weather
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testOutput = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbWeatherIcon = new System.Windows.Forms.PictureBox();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.lblUnits = new System.Windows.Forms.Label();
            this.rbF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // testOutput
            // 
            this.testOutput.AutoSize = true;
            this.testOutput.Location = new System.Drawing.Point(350, 67);
            this.testOutput.Name = "testOutput";
            this.testOutput.Size = new System.Drawing.Size(38, 15);
            this.testOutput.TabIndex = 0;
            this.testOutput.Text = "label1";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(86, 41);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(217, 23);
            this.cbLocation.TabIndex = 3;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(86, 12);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(217, 23);
            this.cbCountry.TabIndex = 3;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "City/State";
            // 
            // pbWeatherIcon
            // 
            this.pbWeatherIcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbWeatherIcon.Location = new System.Drawing.Point(322, 12);
            this.pbWeatherIcon.Name = "pbWeatherIcon";
            this.pbWeatherIcon.Size = new System.Drawing.Size(76, 52);
            this.pbWeatherIcon.TabIndex = 4;
            this.pbWeatherIcon.TabStop = false;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Checked = true;
            this.rbC.Location = new System.Drawing.Point(86, 73);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(33, 19);
            this.rbC.TabIndex = 5;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(46, 73);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(34, 15);
            this.lblUnits.TabIndex = 2;
            this.lblUnits.Text = "Units";
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(125, 73);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(31, 19);
            this.rbF.TabIndex = 5;
            this.rbF.Text = "F";
            this.rbF.UseVisualStyleBackColor = true;
            this.rbF.CheckedChanged += new System.EventHandler(this.rbF_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 103);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.pbWeatherIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.testOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testOutput;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbWeatherIcon;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.RadioButton rbF;
    }
}

