using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExer
{
    public partial class FrmRegistration : Form
    {
        public static string SetFileName;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)

        {

            string[] StudentInfo =
                {

          "Student No.: " + txtStudentNo.Text,
            "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMiddleInitial.Text + ".",
            "Program: " + cmbProgram.Text,
            "Gender: " + cmbGender.Text,
            "Age: " + txtAge.Text,
            "Birthday: " + dtpBirthday.Text,
            "Contact No.: " + txtContactNo.Text
            };

            SetFileName = txtStudentNo.Text + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, txtStudentNo.Text + ".txt")))
            {

                foreach (string line in StudentInfo)
                {
                    outputFile.WriteLine(line);

                }
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentNo.Clear();
                txtLastName.Clear();
                txtFirstName.Clear();
                txtMiddleInitial.Clear();
                txtAge.Clear();
                txtContactNo.Clear();
                cmbProgram.SelectedIndex = -1;
                cmbGender.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmStudentRecord frm = new FrmStudentRecord())
            {
                frm.ShowDialog();
            }
            this.Show();
        }
    }
}
   
