﻿namespace Configuration.NavigationCommands
{
    partial class IfEq
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._ntb = new Configuration.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._cb_variables = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _ntb
            // 
            this._ntb.AllowSpace = false;
            this._ntb.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._ntb.DoubleValue = 0;
            this._ntb.IntValue = 0;
            this._ntb.Location = new System.Drawing.Point(59, 27);
            this._ntb.Name = "_ntb";
            this._ntb.Size = new System.Drawing.Size(62, 20);
            this._ntb.TabIndex = 6;
            this._ntb.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // _cb_variables
            // 
            this._cb_variables.FormattingEnabled = true;
            this._cb_variables.Items.AddRange(new object[] {
            "Height [m]",
            "Speed [m/s]",
            "Heading [deg]",
            "Unsupported (Flight time [sec])",
            "Satellites in view",
            "Home distance [m]",
            "PPM alive [1 or 0]",
            "Channel 1 [us]",
            "Channel 2 [us]",
            "Channel 3 [us]",
            "Channel 4 [us]",
            "Channel 5 [us]",
            "Channel 6 [us]",
            "Channel 7 [us]",
            "Channel 8 [us]"});
            this._cb_variables.Location = new System.Drawing.Point(0, 0);
            this._cb_variables.Name = "_cb_variables";
            this._cb_variables.Size = new System.Drawing.Size(121, 21);
            this._cb_variables.TabIndex = 3;
            this._cb_variables.Text = "Height [m]";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // UntilEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._ntb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cb_variables);
            this.Controls.Add(this.comboBox1);
            this.Name = "UntilEq";
            this.Size = new System.Drawing.Size(131, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericTextBox _ntb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cb_variables;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
