namespace Chapter05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtToUpper = new System.Windows.Forms.TextBox();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSubstringResult = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtImput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "String toUpper():";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Strint ToLower():";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search for Character:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search for last character:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Extract Substring from index:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "txtInput.Remove() =:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Find:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "txtInput.Replace() =";
            // 
            // TxtToUpper
            // 
            this.TxtToUpper.Location = new System.Drawing.Point(192, 82);
            this.TxtToUpper.Name = "TxtToUpper";
            this.TxtToUpper.Size = new System.Drawing.Size(561, 20);
            this.TxtToUpper.TabIndex = 10;
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(192, 136);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(41, 20);
            this.txtSearchChar.TabIndex = 11;
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(192, 110);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(561, 20);
            this.txtLower.TabIndex = 12;
            // 
            // txtLenght
            // 
            this.txtLenght.Location = new System.Drawing.Point(192, 54);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(41, 20);
            this.txtLenght.TabIndex = 13;
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(639, 165);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(39, 20);
            this.txtLastIndexOf.TabIndex = 14;
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(192, 165);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(41, 20);
            this.txtLastChar.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(411, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "txtInput. Text.IndexOf(\"v\",0) =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "txtInput. Text.LastIndexOf(\"s\") =";
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(638, 138);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(39, 20);
            this.txtSearchIndex.TabIndex = 18;
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(192, 191);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(41, 20);
            this.txtStartIndex.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(248, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "for this many characters";
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(401, 195);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(39, 20);
            this.txtEndIndex.TabIndex = 22;
            this.txtEndIndex.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(481, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "txtInput.Text.Substring(18, 7) =";
            // 
            // txtSubstringResult
            // 
            this.txtSubstringResult.Location = new System.Drawing.Point(639, 195);
            this.txtSubstringResult.Name = "txtSubstringResult";
            this.txtSubstringResult.Size = new System.Drawing.Size(114, 20);
            this.txtSubstringResult.TabIndex = 24;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(192, 224);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(159, 20);
            this.txtRemove.TabIndex = 25;
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(192, 260);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(113, 20);
            this.txtReplaceChars.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Replace with:";
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(357, 224);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(396, 20);
            this.txtRemoveResult.TabIndex = 28;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(389, 264);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(155, 20);
            this.txtReplaceWith.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(47, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "String Lenght:";
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(192, 289);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(561, 20);
            this.txtReplaceResult.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(48, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "String to test:";
            // 
            // txtImput
            // 
            this.txtImput.Location = new System.Drawing.Point(192, 28);
            this.txtImput.Name = "txtImput";
            this.txtImput.Size = new System.Drawing.Size(561, 20);
            this.txtImput.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtImput);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtSubstringResult);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.txtSearchIndex);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.txtLenght);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.TxtToUpper);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "String Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtToUpper;
        private System.Windows.Forms.TextBox txtSearchChar;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.TextBox txtLastIndexOf;
        private System.Windows.Forms.TextBox txtLastChar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchIndex;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEndIndex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSubstringResult;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.TextBox txtReplaceChars;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRemoveResult;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtReplaceResult;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtImput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

