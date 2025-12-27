using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kuchukbaevExam6DataSet.Первый". При необходимости она может быть перемещена или удалена.
            this.первыйTableAdapter.Fill(this.kuchukbaevExam6DataSet.Первый);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void первыйDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void второйDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kuchukbaevExam6DataSet.Второй". При необходимости она может быть перемещена или удалена.
            this.второйTableAdapter.Fill(this.kuchukbaevExam6DataSet.Второй);
        }

        private void первыйDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
