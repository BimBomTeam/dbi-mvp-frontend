﻿namespace DBI.Client
{
    partial class mainForm
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
            btnBrowse = new Button();
            txtPathPhoto = new TextBox();
            phoDogPicture = new PictureBox();
            txtAnswerDBI = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)phoDogPicture).BeginInit();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(12, 12);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtPathPhoto
            // 
            txtPathPhoto.Location = new Point(93, 12);
            txtPathPhoto.Name = "txtPathPhoto";
            txtPathPhoto.Size = new Size(219, 23);
            txtPathPhoto.TabIndex = 1;
            // 
            // phoDogPicture
            // 
            phoDogPicture.Location = new Point(12, 41);
            phoDogPicture.Name = "phoDogPicture";
            phoDogPicture.Size = new Size(300, 300);
            phoDogPicture.TabIndex = 2;
            phoDogPicture.TabStop = false;
            // 
            // txtAnswerDBI
            // 
            txtAnswerDBI.Location = new Point(12, 347);
            txtAnswerDBI.Name = "txtAnswerDBI";
            txtAnswerDBI.Size = new Size(300, 96);
            txtAnswerDBI.TabIndex = 3;
            txtAnswerDBI.Text = "";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 454);
            Controls.Add(txtAnswerDBI);
            Controls.Add(phoDogPicture);
            Controls.Add(txtPathPhoto);
            Controls.Add(btnBrowse);
            MinimumSize = new Size(336, 493);
            Name = "mainForm";
            Text = "Dog Breed Identification";
            ((System.ComponentModel.ISupportInitialize)phoDogPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private TextBox txtPathPhoto;
        private PictureBox phoDogPicture;
        private RichTextBox txtAnswerDBI;
    }
}