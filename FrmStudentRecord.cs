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
    public partial class FrmStudentRecord : Form
    {
        // Lab exercise: Student Record form - updated
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "20005071.txt";
            string fullPath = Path.Combine(docPath, fileName);

            if (File.Exists(fullPath))
            {
                lvShowRecord.Items.Clear();
                foreach (string line in File.ReadAllLines(fullPath))
                {
                    lvShowRecord.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File not found.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvShowRecord.Items.Clear();
        }
    }
}
