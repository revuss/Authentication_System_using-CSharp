namespace LoginSampleWithWindowForms
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.dataviewGrid = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btncle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "HireDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salary";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(178, 136);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(216, 22);
            this.txtID.TabIndex = 7;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(178, 179);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(216, 22);
            this.txtfirstname.TabIndex = 8;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(178, 224);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(216, 22);
            this.txtlastname.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(178, 282);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(558, 22);
            this.txtemail.TabIndex = 10;
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(520, 133);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(216, 22);
            this.txtGen.TabIndex = 11;
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(520, 224);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(216, 22);
            this.txtsal.TabIndex = 13;
            // 
            // dataviewGrid
            // 
            this.dataviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewGrid.Location = new System.Drawing.Point(50, 370);
            this.dataviewGrid.Name = "dataviewGrid";
            this.dataviewGrid.RowHeadersWidth = 51;
            this.dataviewGrid.RowTemplate.Height = 24;
            this.dataviewGrid.Size = new System.Drawing.Size(686, 177);
            this.dataviewGrid.TabIndex = 14;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(463, 321);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 37);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(558, 321);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 37);
            this.btnup.TabIndex = 16;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(657, 321);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 37);
            this.btndel.TabIndex = 17;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btncle
            // 
            this.btncle.Location = new System.Drawing.Point(371, 321);
            this.btncle.Name = "btncle";
            this.btncle.Size = new System.Drawing.Size(75, 37);
            this.btncle.TabIndex = 18;
            this.btncle.Text = "Clear";
            this.btncle.UseVisualStyleBackColor = true;
            this.btncle.Click += new System.EventHandler(this.btncle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(288, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Employee Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 80);
            this.panel1.TabIndex = 20;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(520, 179);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(216, 22);
            this.txtdate.TabIndex = 22;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(281, 321);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 37);
            this.Quit.TabIndex = 23;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncle);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataviewGrid);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.DataGridView dataviewGrid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btncle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Button Quit;
    }
}