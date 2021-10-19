
using System;

namespace VolumeConverter
{
    partial class volumecon
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
            this.CL_to_Liter = new System.Windows.Forms.Label();
            this.clBox = new System.Windows.Forms.TextBox();
            this.literbox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Label();
            this.liters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CL_to_Liter
            // 
            this.CL_to_Liter.AutoSize = true;
            this.CL_to_Liter.Location = new System.Drawing.Point(353, 67);
            this.CL_to_Liter.Name = "CL_to_Liter";
            this.CL_to_Liter.Size = new System.Drawing.Size(126, 17);
            this.CL_to_Liter.TabIndex = 0;
            this.CL_to_Liter.Text = "Convert CL to Liter";
            // 
            // clBox
            // 
            this.clBox.Location = new System.Drawing.Point(369, 147);
            this.clBox.Name = "clBox";
            this.clBox.Size = new System.Drawing.Size(100, 22);
            this.clBox.TabIndex = 1;
            // 
            // literbox
            // 
            this.literbox.Location = new System.Drawing.Point(369, 215);
            this.literbox.Name = "literbox";
            this.literbox.Size = new System.Drawing.Size(100, 22);
            this.literbox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(369, 304);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(492, 304);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cl
            // 
            this.cl.AutoSize = true;
            this.cl.Location = new System.Drawing.Point(502, 147);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(25, 17);
            this.cl.TabIndex = 5;
            this.cl.Text = "CL";
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // liters
            // 
            this.liters.AutoSize = true;
            this.liters.Location = new System.Drawing.Point(502, 215);
            this.liters.Name = "liters";
            this.liters.Size = new System.Drawing.Size(36, 17);
            this.liters.TabIndex = 6;
            this.liters.Text = "Liter";
            // 
            // volumecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liters);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.literbox);
            this.Controls.Add(this.clBox);
            this.Controls.Add(this.CL_to_Liter);
            this.Name = "volumecon";
            this.Text = "Volume Converter CL to Liter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label CL_to_Liter;
        private System.Windows.Forms.TextBox clBox;
        private System.Windows.Forms.TextBox literbox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label cl;
        private System.Windows.Forms.Label liters;
    }
}

