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
    public partial class Form2 : Form
    {
        String query;
        DataSet ds;
        function fn = new function();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            query = "select sub_name as 'Назва предмету',sub_times as 'Кількість годин',sub_control as 'Тип атестації',concat(teach_surname,' ',teach_name, ' ',teach_middlename) as 'Викладач'from subjectt join teacher using (teach_id) ";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            query = "select sub_name as 'Назва предмету',sub_times as 'Кількість годин',sub_control as 'Тип атестації',concat(teach_surname,' ',teach_name, ' ',teach_middlename) as 'Викладач'from subjectt join teacher using (teach_id) ";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            textBox2.Text = "";
            radioButton3.Checked = false;
            radioButton1.Checked = false;
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            query = "select sub_name as 'Назва предмету',sub_times as 'Кількість годин',sub_control as 'Тип атестації',concat(teach_surname,' ',teach_name, ' ',teach_middlename) as 'Викладач'from subjectt join teacher using (teach_id) where sub_name like '%" + textBox1.Text+"%'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            textBox2.Text = "";
            radioButton3.Checked = false;
            radioButton1.Checked = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            query = "select sub_name as 'Назва предмету',sub_times as 'Кількість годин',sub_control as 'Тип атестації',concat(teach_surname,' ',teach_name, ' ',teach_middlename) as 'Викладач'from subjectt join teacher using (teach_id) where teach_surname like '%" + textBox2.Text + "%' or teach_name like '%"+textBox2.Text+"%' or teach_middlename like '%"+textBox2.Text+"%'" ;
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = "";
            radioButton3.Checked = false;
            radioButton1.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            query = "select sub_name as 'Назва предмету',sub_times as 'Кількість годин',sub_control as 'Тип атестації',concat(teach_surname,' ',teach_name, ' ',teach_middlename) as 'Викладач'from subjectt join teacher using (teach_id) where sub_control='" + radioButton1.Text + "'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton3.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            query = "select sub_name as 'Назва предмету',sub_times as 'Кількість годин',sub_control as 'Тип атестації',concat(teach_surname,' ',teach_name, ' ',teach_middlename) as 'Викладач'from subjectt join teacher using (teach_id) where sub_control='" + radioButton3.Text + "'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }
    }
}
