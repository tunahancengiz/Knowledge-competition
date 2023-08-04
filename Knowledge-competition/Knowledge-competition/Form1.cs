using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_competition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            a.Enabled = false; b.Enabled = false;
            c.Enabled = false; d.Enabled = false;
            
            
        }

        int question = 0, trueNo = 0, falseNo = 0;

        private void b_Click(object sender, EventArgs e)
        {
            a.Enabled = false; b.Enabled = false;
            c.Enabled = false; d.Enabled = false;
            continueButton.Enabled = true;

            label5.Text = b.Text;
            if (label4.Text == label5.Text)
            {
                trueNo++;
                trueLbl.Text = trueNo.ToString();

            }
            else
            {
                falseNo++;
                falseLbl.Text = falseNo.ToString();
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            a.Enabled = false; b.Enabled = false;
            c.Enabled = false; d.Enabled = false;
            continueButton.Enabled = true;

            label5.Text = c.Text;
            if (label4.Text == label5.Text)
            {
                trueNo++;
                trueLbl.Text = trueNo.ToString();

            }
            else
            {
                falseNo++;
                falseLbl.Text = falseNo.ToString();
            }
        }

        private void d_Click(object sender, EventArgs e)
        {
            a.Enabled = false; b.Enabled = false;
            c.Enabled = false; d.Enabled = false;
            continueButton.Enabled = true;

            label5.Text = d.Text;
            if (label4.Text == label5.Text)
            {
                trueNo++;
                trueLbl.Text = trueNo.ToString();

            }
            else
            {
                falseNo++;
                falseLbl.Text = falseNo.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            falseLbl.Text = "0"; questionLbl.Text = "0"; trueLbl.Text = "0";
            continueButton.Text = "Start";
            button1.Visible = false;
            question = 0; trueNo = 0; falseNo = 0;
            a.Text = "A"; b.Text = "B";
            c.Text = "C"; d.Text = "D";
            richTextBox1.Text = "";
            continueButton.Enabled = true;
            richTextBox1.Enabled = false;
        }

        private void a_Click(object sender, EventArgs e)
        {
            a.Enabled = false; b.Enabled = false;
            c.Enabled = false; d.Enabled = false;
            continueButton.Enabled = true;

            label5.Text = a.Text;
            if(label4.Text == label5.Text)
            {
                trueNo++;
                trueLbl.Text = trueNo.ToString();

            }
            else
            {
                falseNo++;
                falseLbl.Text = falseNo.ToString();
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            a.Enabled = true; b.Enabled = true;
            c.Enabled = true; d.Enabled = true;
            continueButton.Enabled = false;

            question++; questionLbl.Text = question.ToString();
            questionTextBox.Text = question.ToString();
            continueButton.Text = "Continue";
            richTextBox1.Enabled = true;

            if (question == 1)
            {
                richTextBox1.Text = "Which brand manufactures the SSD?";
                a.Text = "MSI";
                b.Text = "GAMEPOWER";
                c.Text = "COOLOR MASTER";
                d.Text = "RAZER";
                label4.Text = "MSI";
               
            }

            if(question == 2)
            {
                richTextBox1.Text = "A computer collector says that when he runs the system he collected, the screen does not turn on, but the system continues to work.\r\n\r\nWhat action might this person have forgotten?";
                a.Text = "Installing the Power Supply";
                b.Text = "Ram Installation";
                c.Text = "Installing the video card";
                d.Text = "Driver Installation";
                label4.Text = "Installing the video card";
            }
            if (question == 3)
            {
                richTextBox1.Text = "Which is not a computer component?";
                a.Text = "Monitor";
                    b.Text = "Mouse";
                c.Text = "RAM";
                d.Text = "Gaming Chair";
                label4.Text = "Gaming Chair";
            }

            if(question == 4)
            {
                richTextBox1.Text = "Which programming language does ASP.NET CORE belong to?";
                a.Text = "Python";
                b.Text = "Java";
                    c.Text = "C#";
                d.Text = "C++";
                label4.Text = "C#";
            }

            if(question == 5)
            {
                richTextBox1.Text = "Which is not a programming language?";
                a.Text = "HTML";
                b.Text = "C";
                c.Text = "JavaScrpit";
                d.Text = "Kotlin";
                label4.Text = "HTML";
                continueButton.Text = "Finish";
        
            }

            if (question == 6)
            {
                a.Enabled = false; b.Enabled = false;
                c.Enabled = false; d.Enabled = false;
                continueButton.Enabled = false;
                questionLbl.Text = "5";
                MessageBox.Show("True: " + trueLbl.Text + "\n" + "False: " + falseLbl.Text);
                button1.Visible = true;
                
            }
        }

    }
}
