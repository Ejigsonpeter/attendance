using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class AllStudentRecord : Form
    {
        public AllStudentRecord()
        {
            InitializeComponent();
        }

        private void AllStudentRecord_Load(object sender, EventArgs e)
        {
           
            List<string[]> items = new List<string[]>();
            dynamic attendanceAll = new AttendanceTable().All();

            if (attendanceAll != null)
            {
                foreach (var attendance in attendanceAll )
                {
                    string studentName = new StudentTable().GetStudentName(attendance.matric_number.ToString());
                    items.Add(new string[] { studentName, attendance.matric_number.ToString() });
                }
            }



            // Convert to DataTable.
            DataTable table = ConvertListToDataTable(items);
            dataGridView1.DataSource = table;
        }




        static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            string[] header = new string[] { "Full Name", "Matric Number" };
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add(header[i]);
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic attendanceAll = new AttendanceTable().Delete();
            //dynamic studentred = new StudentTable().Delete();

            MessageBox.Show("Staff Deleted Successfully");
            dataGridView1.Refresh();
        }
    }
}
