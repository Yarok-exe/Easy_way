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
    public partial class Form11 : Form
    {
        String query;
        DataSet ds;
        function fn = new function();
        String n, s, m, c, id;

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int i;
            i = listBox1.SelectedIndex;
            query = "delete from teacher where teach_id='" + listBox2.Items[i].ToString() + "'";
            fn.setData(query);
            MessageBox.Show("Готово!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            query = "select teach_id,teach_name,teach_surname,teach_middlename from teacher";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                id = ds.Tables[0].Rows[i][0].ToString();
                n = ds.Tables[0].Rows[i][1].ToString();
                s = ds.Tables[0].Rows[i][2].ToString();
                m = ds.Tables[0].Rows[i][3].ToString();
                c = s + " " + n + " " + m;
                listBox1.Items.Add(c);
                listBox2.Items.Add(id);
            }
        }
    }
}
