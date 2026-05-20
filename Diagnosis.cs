using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Managment_System
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
            DisplayDiagnosis();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\future\Documents\Hospital Managment System.mdf"";Integrated Security=True;Connect Timeout=30");

        private void DisplayDiagnosis()
        {
            try
            {
                Con.Open();
                string Query = "select * from Diagnosis";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        void DisplayPatientId()
        {
            string sql = "select * from Patient";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox1.ValueMember = "PId";
                comboBox1.DataSource = dt;
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox111.Text == " " || comboBox1.Text == " " || textBox222.Text == " " || textBox333.Text == " " || textBox444.Text == " " || textBox555.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "insert into Diagnosis Values('" + textBox111.Text + "', '" + comboBox1.Text + "' , '" + textBox222.Text + "' ,'" + textBox333.Text + "' ,'" + textBox444.Text + "','" + textBox555.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    DisplayDiagnosis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox111.Text == " " || comboBox1.Text == " " || textBox222.Text == " " || textBox333.Text == " " || textBox444.Text == " " || textBox555.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update Diagnosis Set  PatientId =@PatientId, PatientName= @PPatientName ,Symptoms=@S, DiagnosticTest=@D, Medicines=@M, where DId=@DId ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PatientId", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@PatientName", textBox222.Text);
                    cmd.Parameters.AddWithValue("@S", textBox333.Text);
                    cmd.Parameters.AddWithValue("@D", textBox444.Text);
                    cmd.Parameters.AddWithValue("@M", textBox555.Text);
                    cmd.Parameters.AddWithValue("@DId", textBox111.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Updated Successfully");
                    DisplayDiagnosis();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox111.Text == " ")
                {
                    MessageBox.Show("Enter the Diagnosis Id");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Diagnosis WHERE DId='" + textBox111.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayDiagnosis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home1 obj = new Home1();
            obj.Show();
            this.Hide();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox111.Text = " ";
            comboBox1.Text = " ";
            textBox222.Text = " ";
            textBox333.Text = " ";
            textBox444.Text = " ";
            textBox555.Text = " ";



        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox111.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox222.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox333.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBox444.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                textBox555.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                label99.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                label3.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                label111.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                label4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            DisplayPatientId();
        }
        string pname = " ";
        void DisplayPatientName()
        {
            try
            {
                Con.Open();
                string ss = "select * from Patient WHERE PId=" + comboBox1.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand(ss, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    pname = dr["PName"].ToString();
                    textBox222.Text = pname;
                }
                Con.Close();

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisplayPatientName();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
