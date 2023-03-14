using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){}
        private void label3_Click(object sender, EventArgs e){}
        private void button2_Click(object sender, EventArgs e)
        {
            int constraintsCount = int.Parse(textBox3.Text);
            int variablesCount = int.Parse(textBox1.Text);
            this.dataGridView1.RowCount = variablesCount;
            this.dataGridView1.ColumnCount = constraintsCount;
            this.dataGridView2.RowCount = variablesCount;
            this.dataGridView2.ColumnCount = constraintsCount +1;
            for(int i = 0; i <= constraintsCount; i++)
            {
                int c = i + 1;
                if (i < constraintsCount)
                {
                    dataGridView1.Columns[i].HeaderText = "Condition " + c;
                    dataGridView2.Columns[i].HeaderText = "Condition " + c;
                }
                else
                {
                    dataGridView2.Columns[i].HeaderText = "Chosen Values";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int constraintsCount = int.Parse(textBox3.Text);
            int variablesCount = int.Parse(textBox1.Text);
            for (int i = 0; i < variablesCount; i++)
            {
                double max_val = -99999999;
                for (int j = 0; j <= constraintsCount ; j++)
                {
                    if (j < constraintsCount)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                        double valu = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        if (valu > max_val)
                        {
                            max_val = valu;
                        }
                    }
                    if (j == constraintsCount)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = max_val.ToString();
                    }

                }
                max_val = -99999999;
            }
            double maxx = -99999999;
            for (int i = 0; i < variablesCount; i++)
            {
                double valu = Convert.ToDouble(dataGridView2.Rows[i].Cells[constraintsCount].Value);
                if(valu > maxx)
                {
                    maxx = valu;
                    int num = i + 1;
                    label2.Text="Maximax chose project number " + num;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int constraintsCount = int.Parse(textBox3.Text);
            int variablesCount = int.Parse(textBox1.Text);
            for (int i = 0; i < variablesCount; i++)
            {
                double min_val = 99999999;
                for (int j = 0; j <= constraintsCount; j++)
                {
                    if (j < constraintsCount)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                        double valu = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        if (valu < min_val)
                        {
                            min_val = valu;
                        }
                    }
                    if (j == constraintsCount)
                    {
                        dataGridView2.Rows[i].Cells[j ].Value = min_val.ToString();
                    }

                }
                min_val = 99999999;
            }
            double maxx = -99999999;
            for (int i = 0; i < variablesCount; i++)
            {
                double valu = Convert.ToDouble(dataGridView2.Rows[i].Cells[constraintsCount].Value);
                if (valu > maxx)
                {
                    maxx = valu;
                    int num = i + 1;
                    label2.Text = "Maximin chose project number " + num;
                }
            }

        }
    }
}
