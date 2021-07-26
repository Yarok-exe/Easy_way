using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using func;
namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        String query;
        DataSet ds;
        function fn = new function();
        public Form3()
        {
            InitializeComponent();
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            query = "select teach_name as 'Імя',teach_surname as 'Прізвище',teach_middlename as 'По-батькові',teach_category as 'Категорія' from teacher";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            query = "select teach_name as 'Імя',teach_surname as 'Прізвище',teach_middlename as 'По-батькові',teach_category as 'Категорія' from teacher where teach_name like '%" + textBox1.Text+ "%' or teach_surname like '%" + textBox1.Text + "%' or teach_middlename like '%" + textBox1.Text + "%'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            query = "select teach_name as 'Імя',teach_surname as 'Прізвище',teach_middlename as 'По-батькові',teach_category as 'Категорія'  from teacher";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.ShowDialog();
        }
    }
}
