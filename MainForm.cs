using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Speech.Synthesis;
namespace MultiFaceRec
{
    public partial class FrmPrincipal : Form
    {
        

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterFace().ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Attendance().ShowDialog();
            this.Show();
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Do You Want To Quit Application?", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {
                
            }
            else
            {
                Application.ExitThread();
            }
            
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Do You Want To Quit Application?", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;

            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            buttonAll.Enabled = false;
            buttonView.Enabled = false;
            List<string> _items = new List<string>();

            dynamic at = new AttendanceTable().All();

            Dictionary<string, int> uniquedate = new Dictionary<string, int>();
            
            if( at != null )
            {
                foreach (var attendance in at)
                {
                    if (!uniquedate.ContainsKey(attendance.date_taken.ToString()))
                    {
                        _items.Add(attendance.date_taken.ToString());
                        uniquedate.Add(attendance.date_taken.ToString(), 1);
                    }

                }
            }

	        comboBoxDate.DataSource = _items;

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            List<string[]> items = new List<string[]>();
             string dateTime = comboBoxDate.SelectedItem.ToString();
             dynamic attendanceByDate = new AttendanceTable().All(where: String.Format("date_taken='{0}'", dateTime));
            
             if( attendanceByDate != null )
             {
                 foreach( var attendance in attendanceByDate )
                 {
                     string studentName = new StudentTable().GetStudentName(attendance.matric_number.ToString());
                     items.Add( new string[] {studentName, attendance.matric_number.ToString()});
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

            string[] header = new string[]{"Name", "Matric Number"};
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

        private void buttonAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AllStudentRecord().ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin")
            {
                MessageBox.Show("Login Successfully, Option Buttons Enabled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = true;
                button2.Enabled = true;
                buttonAll.Enabled = true;
                buttonView.Enabled = true;
                groupBox1.Visible = false;

                button1.Visible = true;
                button2.Visible = true;
                buttonAll.Visible = true;
                buttonView.Visible = true;
                comboBoxDate.Visible = true;
                label1.Visible = true;
                buttonView.Visible = true;
                dataGridView1.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Login Details Incorrect", "Incorrect Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                password.PasswordChar = default(char);
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SpeechSynthesizer talk = new SpeechSynthesizer();
            talk.Speak("Welcome To Student Facial Recognition Attendance System");
            talk.SelectVoiceByHints(VoiceGender.Female);
            talk.Volume = 100;
            timer1.Stop();
        }

        

    }
}


