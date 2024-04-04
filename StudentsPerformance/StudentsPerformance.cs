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
    public partial class StudentPerformance : Form
    {
        public StudentPerformance()
        {
            InitializeComponent();
        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            new ShowAllForm().Show();       //Show ShowAllForm Form
            this.Hide();                    //Close this Form
        }

        private void bGradeStudent_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();        //Show ReportForm Form
            this.Hide();                    //Close this Form
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);                        //Close the application
        }
    }
}
