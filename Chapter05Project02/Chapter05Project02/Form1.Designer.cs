﻿namespace Chapter05Project02
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtCompleteDateAndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtGeneralDateAndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLongTime;
        private System.Windows.Forms.TextBox txtGeneralDate;
        private System.Windows.Forms.TextBox txtLongDate;
        private System.Windows.Forms.TextBox txtShortTime;
        private System.Windows.Forms.TextBox txtNewYears;
        private System.Windows.Forms.TextBox txtFullDateTime;
        private System.Windows.Forms.TextBox txtShortDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

