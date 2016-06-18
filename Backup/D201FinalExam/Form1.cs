using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace D201FinalExam
{
    public partial class Form1 : Form
    {
        List<ClassA> theCts;
        List<ClassA> theRes;

        public Form1()
        {
            InitializeComponent();

            theCts = new List<ClassA>();
            theRes = new List<ClassA>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassA ca = new ClassA();
            ca.N = textBox1.Text;
            ca.O = textBox2.Text;
            ca.B = textBox3.Text;
            ca.A = int.Parse(textBox4.Text);

            ClassB fm = new ClassB();

            fm.CBMethod1("file.txt", ca);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassB fm = new ClassB();
            theCts = fm.CBMethod2("file.txt");
            UDLB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClassD srta = new ClassD();
            theCts = srta.CDMethod1(theCts);
            UDLB();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClassD srta = new ClassD();
            theCts = srta.CDMethod2(theCts);
            UDLB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClassD srta = new ClassD();
            theCts = srta.CDMethod3(theCts);
            UDLB();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClassD srta = new ClassD();
            theCts = srta.CDMethod4(theCts);
            UDLB();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ClassC srch = new ClassC();
                int gg = int.Parse(textBox5.Text);

                if (radioButton1.Checked)
                {
                    theRes = srch.CCMethod1(theCts, gg);
                }
                else if (radioButton2.Checked)
                {
                    theRes = srch.CCMethod2(theCts, gg);
                }
                else if (radioButton3.Checked)
                {
                    theRes = srch.CCMethod3(theCts, gg);
                }
                dataGridView1.DataSource = theRes;
                dataGridView1.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number", "Error");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string tt = "";

                if (radioButton1.Checked)
                {
                    tt = "greater than";
                }
                else if (radioButton2.Checked)
                {
                    tt = "less than";
                }
                else if (radioButton3.Checked)
                {
                    tt = "with";
                }

                int gg = int.Parse(textBox5.Text);

                ClassB fm = new ClassB();
                bool res = fm.CBMethod3("Results.txt", theRes, tt, gg);

                if (res == true)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failure");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number", "Error");
            }
        }

        public void UDLB()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(theCts.ToArray());
        }
    }
}