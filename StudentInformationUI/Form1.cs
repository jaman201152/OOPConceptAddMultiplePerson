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
using StudentInformationUI.Model;

namespace StudentInformationUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student students = new Student();

            students.Name = nameTextBox.Text;
            students.Address = addressRichTextBox.Text;

            bool rowAffected = Add(students);

            if (rowAffected)
            {
                MessageBox.Show("Student information has been save Successfully.");
                nameTextBox.Clear();
                addressRichTextBox.Clear();
            }

        }

        public bool Add(Student students)
        {
            //1. Connection String

            string conString = @"Server=.\SQLEXPRESS; database=SMS5012; integrated security=true";

            //2. Connection

            SqlConnection con = new SqlConnection(conString);

            //3. Query

            string query = @"INSERT INTO Students VALUES ('" + students.Name + "', '" + students.Address + "')";

            //4. Sql Command

            SqlCommand command = new SqlCommand(query, con);

            //5. Connection Open

            con.Open();

            //6. Execute

            bool isRowAffected = command.ExecuteNonQuery() > 0;

            //7. Connection Close

            con.Close();

            return isRowAffected;

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {

        }


    }
}
