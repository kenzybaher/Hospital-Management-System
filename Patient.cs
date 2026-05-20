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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            DisplayPatient();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\future\Documents\Hospital Managment System.mdf"";Integrated Security=True;Connect Timeout=30");

        private void DisplayPatient()
        {
            try
            {
                Con.Open();
                string Query = "select * from Patient";
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
        private void Patient_Load(object sender, EventArgs e)
        {
            DisplayPatient();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox11.Text == " " || textBox22.Text == " " || textBox33.Text == " " || textBox44.Text == " " || textBox55.Text == " " || comboBox1.Text == " " || comboBox2.Text == " " || textBox66.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "insert into Patient Values('" + textBox11.Text + "', '" + textBox22.Text + "' , '" + textBox33.Text + "' ,'" + textBox44.Text + "' ,'" + textBox55.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox66.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    DisplayPatient();
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

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {

            textBox11.Text = " ";
            textBox22.Text = " ";
            textBox33.Text = " ";
            textBox44.Text = " ";
            textBox55.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox66.Text = " ";


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox11.Text == " ")
                {
                    MessageBox.Show("Enter the Patiet Id");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Patient WHERE PId='" + textBox11.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayPatient();
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

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (textBox11.Text == " " || textBox22.Text == " " || textBox33.Text == " " || textBox44.Text == " " || textBox55.Text == " " || comboBox1.Text == " " || comboBox2.Text == " " || textBox66.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update Patient Set  PName =@PName, PAddress= @PAddress, PAge=@PAge,PPhone=@PPhone, PGen=@PGen, BloodGroup=@BloodGroup , MajorDisease=@MajorDisease where PId=@PId ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PName", textBox22.Text);
                    cmd.Parameters.AddWithValue("@PAddress", textBox33.Text);
                    cmd.Parameters.AddWithValue("@PAge", textBox44.Text);
                    cmd.Parameters.AddWithValue("@PPhone", textBox55.Text);
                    cmd.Parameters.AddWithValue("@PGen", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@MajorDisease", textBox66.Text);
                    cmd.Parameters.AddWithValue("@PId", textBox11.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Updated Successfully");
                    DisplayPatient();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home1 obj = new Home1();
            obj.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox11.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBox22.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox33.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox44.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBox55.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                comboBox2.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                textBox66.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
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
    }
}

