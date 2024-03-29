using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeDekhoMiddleware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CollegeServiceReference.CollegeServiceClient cs = new CollegeServiceReference.CollegeServiceClient();   
            label1.Text = cs.GetCollegeById(2).Name;
        }
    }
}
