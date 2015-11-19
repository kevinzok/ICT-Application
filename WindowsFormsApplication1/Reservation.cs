using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;

namespace WindowsFormsApplication1
{
    public partial class Reservation : Form
    {

        OleDbConnection myConnection = new OleDbConnection();
        OleDbCommand mySelectComd = new OleDbCommand();
        DataSet mySet = new DataSet();
        OleDbDataAdapter myAdapter = new OleDbDataAdapter();
        OleDbCommand myCommand = new OleDbCommand();

        public Reservation()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='.\\Data\\Project3.mdb';Persist Security Info=True";
            myConnection.ConnectionString = str;
            myConnection.Open();

            Change2Employee();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeAppointment formAppointment = new MakeAppointment();
            formAppointment.Show();
        }

        private void ChangeTab(object sender, EventArgs e)
        {
                        
        }

        public void Change2Employee()
        {
            string selectEmployee = "SELECT * FROM Employees";
            myAdapter.SelectCommand = myCommand;
            myAdapter.SelectCommand.CommandText = selectEmployee;
            myAdapter.SelectCommand.Connection = myConnection;
            myAdapter.Fill(mySet);
            lboxEmployee.Items.Clear();
            foreach (DataRow Employee in mySet.Tables[0].Rows)
            {
                lboxEmployee.Items.Add(Employee["Name"]);
            }
        }
    }
}
