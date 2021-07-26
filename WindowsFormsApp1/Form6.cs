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
    public partial class Form6 : Form
    {
        String query;
        DataSet ds;
        function fn = new function();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            query = "select Stud_name as 'Імя',Stud_surname as 'Прізвище',stud_middlename as 'По-батькові',Stud_code as 'Номер студ.квитка',stud_datebirth as 'Дата народження',stud_state as 'Стать',stud_phone as 'Номер телефону' from student_form";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            query = "select Stud_name as 'Імя',Stud_surname as 'Прізвище',stud_middlename as 'По-батькові',Stud_code as 'Номер студ.квитка',stud_datebirth as 'Дата народження',stud_state as 'Стать',stud_phone as 'Номер телефону' from student_form";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
       }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            query = "select Stud_name as 'Імя',Stud_surname as 'Прізвище',stud_middlename as 'По-батькові',Stud_code as 'Номер студ.квитка',stud_datebirth as 'Дата народження',stud_state as 'Стать',stud_phone as 'Номер телефону' from student_form where Stud_state like '%Ч%'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            query = "select Stud_name as 'Імя',Stud_surname as 'Прізвище',stud_middlename as 'По-батькові',Stud_code as 'Номер студ.квитка',stud_datebirth as 'Дата народження',stud_state as 'Стать',stud_phone as 'Номер телефону' from student_form where Stud_state like '%Ж%'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.Text = "";
            query = "select Stud_name as 'Імя',Stud_surname as 'Прізвище',stud_middlename as 'По-батькові',Stud_code as 'Номер студ.квитка',stud_datebirth as 'Дата народження',stud_state as 'Стать',stud_phone as 'Номер телефону' from student_form where Stud_name like '%"+textBox1.Text+ "%' or Stud_surname like '%" + textBox1.Text + "%' or Stud_middlename like '%" + textBox1.Text + "%'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton1.Checked = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text = "";
            query = "select Stud_name as 'Імя',Stud_surname as 'Прізвище',stud_middlename as 'По-батькові',Stud_code as 'Номер студ.квитка',stud_datebirth as 'Дата народження',stud_state as 'Стать',stud_phone as 'Номер телефону' from student_form where  Stud_phone like '%" + textBox2.Text + "%'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton1.Checked = false;
        }

     

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
        }

        

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            query = "select Stud_name as 'Імя',Stud_surname as 'Прізвище',stud_middlename as 'По-батькові',Stud_code as 'Номер студ.квитка',stud_datebirth as 'Дата народження',stud_state as 'Стать',stud_phone as 'Номер телефону' from student_form";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton1.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
