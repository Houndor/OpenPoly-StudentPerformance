using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsPerformance
{
    public partial class ReportForm : Form
    {
        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentsDataSet.Students);
        }

        public ReportForm()
        {
            InitializeComponent();
        }

        private void bMainMenu_Click(object sender, EventArgs e)
        {
            new StudentPerformance().Show();       //Show StudentPerformance Form
            this.Hide();                           //Close this Form
        }

        private void bReportExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);                    //Close the application
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            //Find row by ID
            studentsDataSet.StudentsRow StudentRow = studentsDataSet.Students.FindByID1 (Int32.Parse(tSearch.Text));
            //Error Check
            if (StudentRow == null)
            {
                MessageBox.Show("ID was not found in database...");
                return;
            }


            double[] AMark = new double[10];
            for (int i = 0; i < AMark.Length; i++)
            {
                AMark[0] = StudentRow.Course1;
                AMark[1] = StudentRow.Course2;
                AMark[2] = StudentRow.Course3;
                AMark[3] = StudentRow.Course4;
                AMark[4] = StudentRow.Course5;
                AMark[5] = StudentRow.Course6;
                AMark[6] = StudentRow.Course7;
                AMark[7] = StudentRow.Course8;
                AMark[8] = StudentRow.Course9;
                AMark[9] = StudentRow.Course10;

            }

            double MAve = 0.0;                          //Set Variable for the Average
            for (int i = 0; i < AMark.Length; i++)      //Loop to Calculate the Average
            {
                MAve += AMark[i];
            }
            MAve = MAve / 10;
            tAverage.Text = MAve.ToString();            //Write Average to field


            double max = AMark.Max();                   //Set variable for the Max and find max
            tHighestMark.Text = max.ToString();         //Write Max to field


            double min = AMark.Min();                   //Set Variable for the min and find min
            tLowestMark.Text = min.ToString();          //Write Min to Field

            double level = MAve;
            if ( level < 40)
            {
                tOverallLevel.Text = "Fail";
            }
            else if (level >= 41 && level <= 60)
            {
                tOverallLevel.Text = "Simple Pass";
            }
            else if (level >= 61 && level <= 80)
            {
                tOverallLevel.Text = "Good";
            }
            else if (level > 81)
            {
                tOverallLevel.Text = "Excellent";
            }


            tFirstName.Text = StudentRow.Firstname;
            tLastName.Text = StudentRow.Lastname;
            tMarks.Text = "Course 1  :   " + StudentRow.Course1 + "\r\n" +
                "Course 2   :  " + StudentRow.Course2 + "\r\n" +
                "Course 3   :  " + StudentRow.Course3 + "\r\n" + 
                "Course 4   :  " + StudentRow.Course4 + "\r\n" +
                "Course 5   :  " + StudentRow.Course5 + "\r\n" +
                "Course 6   :  " + StudentRow.Course6 + "\r\n" + 
                "Course 7   :  " + StudentRow.Course7 + "\r\n" + 
                "Course 8   :  " + StudentRow.Course8 + "\r\n" + 
                "Course 9   :  " + StudentRow.Course9 + "\r\n" +
                "Course 10  :  " + StudentRow.Course10;
        }
    }
}
