namespace Knowledge_competition
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
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.b = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trueTextBox = new System.Windows.Forms.TextBox();
            this.falseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.falseLbl = new System.Windows.Forms.Label();
            this.trueLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionTextBox
            // 
            this.questionTextBox.BackColor = System.Drawing.Color.White;
            this.questionTextBox.Enabled = false;
            this.questionTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.questionTextBox.Location = new System.Drawing.Point(177, 39);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(133, 26);
            this.questionTextBox.TabIndex = 0;
            this.questionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of questions";
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Silver;
            this.a.Location = new System.Drawing.Point(46, 295);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(190, 34);
            this.a.TabIndex = 2;
            this.a.Text = "A";
            this.a.UseVisualStyleBackColor = false;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(44, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(395, 204);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.Silver;
            this.b.Location = new System.Drawing.Point(249, 296);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(190, 34);
            this.b.TabIndex = 4;
            this.b.Text = "B";
            this.b.UseVisualStyleBackColor = false;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Silver;
            this.c.Location = new System.Drawing.Point(46, 335);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(190, 34);
            this.c.TabIndex = 5;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.Silver;
            this.d.Location = new System.Drawing.Point(249, 335);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(190, 34);
            this.d.TabIndex = 6;
            this.d.Text = "D";
            this.d.UseVisualStyleBackColor = false;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "True";
            // 
            // trueTextBox
            // 
            this.trueTextBox.BackColor = System.Drawing.Color.Lime;
            this.trueTextBox.Enabled = false;
            this.trueTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trueTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.trueTextBox.Location = new System.Drawing.Point(344, 39);
            this.trueTextBox.Name = "trueTextBox";
            this.trueTextBox.Size = new System.Drawing.Size(83, 26);
            this.trueTextBox.TabIndex = 8;
            this.trueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // falseTextBox
            // 
            this.falseTextBox.BackColor = System.Drawing.Color.Red;
            this.falseTextBox.Enabled = false;
            this.falseTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.falseTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.falseTextBox.Location = new System.Drawing.Point(62, 39);
            this.falseTextBox.Name = "falseTextBox";
            this.falseTextBox.Size = new System.Drawing.Size(83, 26);
            this.falseTextBox.TabIndex = 10;
            this.falseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "False";
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Yellow;
            this.continueButton.Location = new System.Drawing.Point(344, 395);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(95, 26);
            this.continueButton.TabIndex = 11;
            this.continueButton.Text = "Start";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // falseLbl
            // 
            this.falseLbl.AutoSize = true;
            this.falseLbl.BackColor = System.Drawing.Color.Red;
            this.falseLbl.ForeColor = System.Drawing.Color.White;
            this.falseLbl.Location = new System.Drawing.Point(97, 42);
            this.falseLbl.Name = "falseLbl";
            this.falseLbl.Size = new System.Drawing.Size(16, 18);
            this.falseLbl.TabIndex = 12;
            this.falseLbl.Text = "0";
            // 
            // trueLbl
            // 
            this.trueLbl.AutoSize = true;
            this.trueLbl.BackColor = System.Drawing.Color.Lime;
            this.trueLbl.ForeColor = System.Drawing.Color.White;
            this.trueLbl.Location = new System.Drawing.Point(377, 43);
            this.trueLbl.Name = "trueLbl";
            this.trueLbl.Size = new System.Drawing.Size(16, 18);
            this.trueLbl.TabIndex = 13;
            this.trueLbl.Text = "0";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.Color.White;
            this.questionLbl.Location = new System.Drawing.Point(237, 43);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(16, 18);
            this.questionLbl.TabIndex = 14;
            this.questionLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(50, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "Start again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(508, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.trueLbl);
            this.Controls.Add(this.falseLbl);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.falseTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionTextBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Knowledge Competition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trueTextBox;
        private System.Windows.Forms.TextBox falseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label falseLbl;
        private System.Windows.Forms.Label trueLbl;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

