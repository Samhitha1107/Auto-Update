using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=FileUploaadDemo;Integrated Security=True;Trusted_Connection=True;");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void brn_Insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Rfid ON;  insert into Rfid(ID,EmpName,rfid) values('" + txt_ID.Text + "', '" + txt_EmpName.Text + "', '" + txt_rfid.Text + "'); SET IDENTITY_INSERT Rfid OFF", con);
            cmd.ExecuteNonQuery ();
            MessageBox.Show("Data inserted Succesfully");
            con.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Rfid ON;  update  Rfid set rfid = '" + txt_rfid.Text + "' Where EmpName = '" + txt_EmpName.Text + "'; SET IDENTITY_INSERT Rfid OFF", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Succesfully");
            con.Close();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Rfid ON;  delete Rfid where ID= '" + txt_ID.Text + "' SET IDENTITY_INSERT Rfid OFF", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Succesfully");
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from Rfid", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
