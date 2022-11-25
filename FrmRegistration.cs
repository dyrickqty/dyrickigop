using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LobustaLabExercise
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        public static string SetFileName;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFileName fileName = new FrmFileName();
            fileName.ShowDialog();
            string getStudentNo = txtStudentNo.Text;
            string getLastName = txtLastName.Text;
            string getAge = txtAge.Text;
            string getBirthday = dateBirthdayPicker.Text;
            string getProgram = cbPrograms.Text;
            string getFirstName = txtFirstName.Text;
            string getMiddleInitial = txtMiddileInitial.Text;
            string getGender = cbGender.Text;
            string getContactNo = txtContactNo.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                string[] getInfo ={"Student No: "+getStudentNo, "Last Name: "+getLastName,  "Age: "+getAge, "Birthday: "+getBirthday, "Program: "+getProgram, "First Name: "+getFirstName, "Middle Initial "+getMiddleInitial, "Gender: "+getGender, "Contact No: "+getContactNo, };

                Console.WriteLine(getStudentNo);
                foreach (string i in getInfo)
                outputFile.WriteLine(i);
                outputFile.Close();
                Close();


            }
        }
    }
}
