﻿namespace LyThuyet4
{
    partial class frm57
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnFlat = new System.Windows.Forms.Button();
            this.ckbMauChu = new System.Windows.Forms.CheckBox();
            this.ckbMauNen = new System.Windows.Forms.CheckBox();
            this.rdFlat = new System.Windows.Forms.RadioButton();
            this.rdPopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.ForeColor = System.Drawing.Color.Black;
            this.btnButton.Location = new System.Drawing.Point(93, 57);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(109, 23);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // btnFlat
            // 
            this.btnFlat.Location = new System.Drawing.Point(93, 124);
            this.btnFlat.Name = "btnFlat";
            this.btnFlat.Size = new System.Drawing.Size(109, 23);
            this.btnFlat.TabIndex = 0;
            this.btnFlat.Text = "Button Flat";
            this.btnFlat.UseVisualStyleBackColor = true;
            // 
            // ckbMauChu
            // 
            this.ckbMauChu.AutoSize = true;
            this.ckbMauChu.Location = new System.Drawing.Point(298, 46);
            this.ckbMauChu.Name = "ckbMauChu";
            this.ckbMauChu.Size = new System.Drawing.Size(112, 17);
            this.ckbMauChu.TabIndex = 1;
            this.ckbMauChu.Text = "Thay đổi màu chữ";
            this.ckbMauChu.UseVisualStyleBackColor = true;
            this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
            // 
            // ckbMauNen
            // 
            this.ckbMauNen.AutoSize = true;
            this.ckbMauNen.Location = new System.Drawing.Point(298, 69);
            this.ckbMauNen.Name = "ckbMauNen";
            this.ckbMauNen.Size = new System.Drawing.Size(112, 17);
            this.ckbMauNen.TabIndex = 1;
            this.ckbMauNen.Text = "Thay đổi màu nền";
            this.ckbMauNen.UseVisualStyleBackColor = true;
            this.ckbMauNen.CheckedChanged += new System.EventHandler(this.ckbMauNen_CheckedChanged);
            // 
            // rdFlat
            // 
            this.rdFlat.AutoSize = true;
            this.rdFlat.Location = new System.Drawing.Point(303, 130);
            this.rdFlat.Name = "rdFlat";
            this.rdFlat.Size = new System.Drawing.Size(66, 17);
            this.rdFlat.TabIndex = 2;
            this.rdFlat.Text = "Kiểu Flat";
            this.rdFlat.UseVisualStyleBackColor = true;
            this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
            // 
            // rdPopup
            // 
            this.rdPopup.AutoSize = true;
            this.rdPopup.Location = new System.Drawing.Point(303, 153);
            this.rdPopup.Name = "rdPopup";
            this.rdPopup.Size = new System.Drawing.Size(80, 17);
            this.rdPopup.TabIndex = 2;
            this.rdPopup.Text = "Kiểu Popup";
            this.rdPopup.UseVisualStyleBackColor = true;
            // 
            // frm57
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdPopup);
            this.Controls.Add(this.rdFlat);
            this.Controls.Add(this.ckbMauNen);
            this.Controls.Add(this.ckbMauChu);
            this.Controls.Add(this.btnFlat);
            this.Controls.Add(this.btnButton);
            this.Name = "frm57";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnFlat;
        private System.Windows.Forms.CheckBox ckbMauChu;
        private System.Windows.Forms.CheckBox ckbMauNen;
        private System.Windows.Forms.RadioButton rdFlat;
        private System.Windows.Forms.RadioButton rdPopup;
    }
}

