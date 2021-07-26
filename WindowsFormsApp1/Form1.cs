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
    public partial class Form1 : Form
    {
        String query;
        DataSet ds;
        function fn = new function();
        String n, s, m, c,id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            query = "select stud_code,stud_name,stud_surname,stud_middlename from student_form";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                id= ds.Tables[0].Rows[i][0].ToString();
                n = ds.Tables[0].Rows[i][1].ToString();
                s = ds.Tables[0].Rows[i][2].ToString();
                m = ds.Tables[0].Rows[i][3].ToString();
                c = s + " " + n + " " + m;
                listBox1.Items.Add(c);
                listBox2.Items.Add(id);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int i;
            i = listBox1.SelectedIndex;
            query = "delete from student_form where stud_code='"+listBox2.Items[i].ToString()+ "'";
            fn.setData(query);
               MessageBox.Show("Готово!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

