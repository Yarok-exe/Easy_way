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
using globalValue;
namespace WindowsFormsApp1
{
    public partial class Frm : Form
    {
        String query;
        DataSet ds;
        function fn = new function();
        String id, n, s, m, c;
        public Frm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select subjectt.sub_name as 'Назва предмету',Acadperform_mark as 'Оцінка',Acadperform_datemark as 'Дата оцінки',teacher.teach_surname as 'Вчитель' from subjectt,academic_performance,student_form,teacher where student_form.stud_id=academic_performance.stud_id and academic_performance.sub_id=subjectt.sub_id and subjectt.teach_id=teacher.teach_id and stud_code='" + listBox1.Items[comboBox1.SelectedIndex].ToString() + "'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            Class2.Value = comboBox1.SelectedItem.ToString();
            Class2.Value1 = listBox1.Items[comboBox1.SelectedIndex].ToString();
        }

    

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.ShowDialog();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            query = "select stud_code,stud_name,stud_surname,stud_middlename from student_form";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                id = ds.Tables[0].Rows[i][0].ToString();
                n = ds.Tables[0].Rows[i][1].ToString();
                s = ds.Tables[0].Rows[i][2].ToString();
                m = ds.Tables[0].Rows[i][3].ToString();
                c = s + " " + n + " " + m;
                comboBox1.Items.Add(c);
                listBox1.Items.Add(id);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            fn.Clear(dataGridView1);
            comboBox1.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
       
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            query = "select stud_code,stud_name,stud_surname,stud_middlename from student_form";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                id = ds.Tables[0].Rows[i][0].ToString();
                n = ds.Tables[0].Rows[i][1].ToString();
                s = ds.Tables[0].Rows[i][2].ToString();
                m = ds.Tables[0].Rows[i][3].ToString();
                c = s + " " + n + " " + m;
                comboBox1.Items.Add(c);
                listBox1.Items.Add(id);
            }
        }

      
    }
}
