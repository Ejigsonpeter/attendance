namespace MultiFaceRec
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelAttendance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfn = new System.Windows.Forms.Label();
            this.textBoxMatricNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAttendance
            // 
            this.labelAttendance.AutoSize = true;
            this.labelAttendance.BackColor = System.Drawing.Color.Transparent;
            this.labelAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttendance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAttendance.Location = new System.Drawing.Point(35, 413);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(235, 24);
            this.labelAttendance.TabIndex = 28;
            this.labelAttendance.Text = "Last Attendance Taken: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "label2";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "label1";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackColor = System.Drawing.Color.Transparent;
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(23, 111);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(355, 268);
            this.imageBoxFrameGrabber.TabIndex = 17;
            this.imageBoxFrameGrabber.TabStop = false;
            this.imageBoxFrameGrabber.Click += new System.EventHandler(this.ImageBoxFrameGrabber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Camera Feed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = " Class Attendance Interface";
            // 
            // txtfn
            // 
            this.txtfn.AutoSize = true;
            this.txtfn.BackColor = System.Drawing.Color.Transparent;
            this.txtfn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfn.ForeColor = System.Drawing.Color.White;
            this.txtfn.Location = new System.Drawing.Point(595, 180);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(0, 16);
            this.txtfn.TabIndex = 39;
            // 
            // textBoxMatricNumber
            // 
            this.textBoxMatricNumber.AutoSize = true;
            this.textBoxMatricNumber.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMatricNumber.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatricNumber.ForeColor = System.Drawing.Color.White;
            this.textBoxMatricNumber.Location = new System.Drawing.Point(584, 111);
            this.textBoxMatricNumber.Name = "textBoxMatricNumber";
            this.textBoxMatricNumber.Size = new System.Drawing.Size(0, 16);
            this.textBoxMatricNumber.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(405, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(394, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = " Matric Number  ";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiFaceRec.Properties.Resources.pexels_photo_247676;
            this.ClientSize = new System.Drawing.Size(794, 486);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.textBoxMatricNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAttendance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAttendance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtfn;
        private System.Windows.Forms.Label textBoxMatricNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}