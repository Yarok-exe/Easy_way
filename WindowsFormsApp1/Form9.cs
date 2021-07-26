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
    public partial class Form9 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form9()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                query = "delete from subjectt where sub_name='" + listBox1.SelectedItem.ToString()+"'";
                fn.setData(query);
                MessageBox.Show("Готово!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Оберіть предмет!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            query = "select sub_name from subjectt";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}
