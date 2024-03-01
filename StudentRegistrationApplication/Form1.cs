using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            for (int i = 1; i < 32; i++)
            {
                int Days = i;
                Day.Items.Add(Days);
            }

            for (int i = 0; i < 12; i++)
            {
                string[] MonthsName = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                Month.Items.Add(MonthsName[i]);
            }
            for(int i = 1900; i < 2025; i++)
            {
                int Years = i;
                Year.Items.Add(i);
            }
            
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            string LastName = LastNameTb.Text;
            string FirstName = FirstNameTb.Text;
            string MiddleName = MiddleNameTb.Text;
            string Gender;

            if (Gen_Male.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            MessageBox.Show("Student Name: " + LastName + " " + FirstName + " " + MiddleName
                + "\n" + "Gender: " + Gender
                + "\n" + "Date of Birth: " + Day.Text + "/" + Month.Text + "/" + Year.Text);
                
                

        }
    }
    }

