using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionInvoiceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Close();


            dataGridView1.Columns.Add("Number", "NO");
            dataGridView1.Columns.Add("Name", "장치 이름");
            dataGridView1.Columns.Add("IPAdress", "IP주소");
            dataGridView1.Columns.Add("UserCount", "유저인원");
            dataGridView1.Columns.Add("TransactionCount", "출입ID");
            dataGridView1.Columns.Add("LastLog", "마지막로그");
            dataGridView1.Columns.Add("State", "연결상태");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
