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

namespace registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string student = textBox1.Text;
            string lastName = textBox2.Text;
            string firstName = textBox4.Text;
            string middleName = textBox5.Text;
            string program = comboBox1.Text;
            string gender = comboBox2.Text;
            string age = textBox3.Text;
            string birthday = dateTimePicker1.Text;
            string contact = textBox6.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            student + ".txt")))
            {
                outputFile.WriteLine("Student No: " + student);
                outputFile.WriteLine("Full Name: " + lastName + ", "+ firstName + "," + middleName +".");
                outputFile.WriteLine("Program: " + program);
                outputFile.WriteLine("Gender: " + gender);
                outputFile.WriteLine("Birthday: " + birthday);
                outputFile.WriteLine("Contact No: " + contact);
                Console.WriteLine("Contact Nos: " + contact);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
