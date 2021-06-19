namespace A2NicholasNieto
{
    partial class Form1
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
            this.hourlyPay = new System.Windows.Forms.RadioButton();
            this.commissionBased = new System.Windows.Forms.RadioButton();
            this.weeklySalary = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.hoursWorked = new System.Windows.Forms.TextBox();
            this.hourlyWage = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grossEarnings = new System.Windows.Forms.TextBox();
            this.netEarnings = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listEmployees = new System.Windows.Forms.ComboBox();
            this.lessTax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select type of employee";
            // 
            // hourlyPay
            // 
            this.hourlyPay.AutoSize = true;
            this.hourlyPay.Location = new System.Drawing.Point(99, 64);
            this.hourlyPay.Name = "hourlyPay";
            this.hourlyPay.Size = new System.Drawing.Size(102, 21);
            this.hourlyPay.TabIndex = 1;
            this.hourlyPay.TabStop = true;
            this.hourlyPay.Text = "Hourly Paid";
            this.hourlyPay.UseVisualStyleBackColor = true;
            this.hourlyPay.CheckedChanged += new System.EventHandler(this.hourlyPay_CheckedChanged);
            // 
            // commissionBased
            // 
            this.commissionBased.AutoSize = true;
            this.commissionBased.Location = new System.Drawing.Point(301, 64);
            this.commissionBased.Name = "commissionBased";
            this.commissionBased.Size = new System.Drawing.Size(137, 21);
            this.commissionBased.TabIndex = 2;
            this.commissionBased.TabStop = true;
            this.commissionBased.Text = "Comission Based";
            this.commissionBased.UseVisualStyleBackColor = true;
            this.commissionBased.CheckedChanged += new System.EventHandler(this.commissionBased_CheckedChanged);
            // 
            // weeklySalary
            // 
            this.weeklySalary.AutoSize = true;
            this.weeklySalary.Location = new System.Drawing.Point(525, 64);
            this.weeklySalary.Name = "weeklySalary";
            this.weeklySalary.Size = new System.Drawing.Size(119, 21);
            this.weeklySalary.TabIndex = 3;
            this.weeklySalary.TabStop = true;
            this.weeklySalary.Text = "Weekly Salary";
            this.weeklySalary.UseVisualStyleBackColor = true;
            this.weeklySalary.CheckedChanged += new System.EventHandler(this.weeklySalary_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input the employee\'s information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(96, 176);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(98, 213);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(103, 17);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Hours Worked:";
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(98, 250);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(94, 17);
            this.lblWage.TabIndex = 7;
            this.lblWage.Text = "Hourly Wage:";
            // 
            // empName
            // 
            this.empName.AcceptsTab = true;
            this.empName.Location = new System.Drawing.Point(230, 176);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(180, 22);
            this.empName.TabIndex = 8;
            // 
            // hoursWorked
            // 
            this.hoursWorked.Location = new System.Drawing.Point(230, 213);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(180, 22);
            this.hoursWorked.TabIndex = 9;
            // 
            // hourlyWage
            // 
            this.hourlyWage.Location = new System.Drawing.Point(230, 250);
            this.hourlyWage.Name = "hourlyWage";
            this.hourlyWage.Size = new System.Drawing.Size(180, 22);
            this.hourlyWage.TabIndex = 10;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(525, 176);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(88, 23);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(525, 213);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(88, 23);
            this.clearAll.TabIndex = 12;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(525, 250);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(88, 23);
            this.close.TabIndex = 13;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Calculated Wage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gross Earnings:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Less Tax:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Net Earnings:";
            // 
            // grossEarnings
            // 
            this.grossEarnings.Location = new System.Drawing.Point(222, 357);
            this.grossEarnings.Name = "grossEarnings";
            this.grossEarnings.ReadOnly = true;
            this.grossEarnings.Size = new System.Drawing.Size(180, 22);
            this.grossEarnings.TabIndex = 18;
            // 
            // netEarnings
            // 
            this.netEarnings.Location = new System.Drawing.Point(222, 430);
            this.netEarnings.Name = "netEarnings";
            this.netEarnings.ReadOnly = true;
            this.netEarnings.Size = new System.Drawing.Size(180, 22);
            this.netEarnings.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Employees:";
            // 
            // listEmployees
            // 
            this.listEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listEmployees.FormattingEnabled = true;
            this.listEmployees.Location = new System.Drawing.Point(200, 488);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(382, 24);
            this.listEmployees.TabIndex = 22;
            this.listEmployees.SelectedIndexChanged += new System.EventHandler(this.listEmployees_SelectedIndexChanged);
            // 
            // lessTax
            // 
            this.lessTax.Location = new System.Drawing.Point(221, 392);
            this.lessTax.Name = "lessTax";
            this.lessTax.ReadOnly = true;
            this.lessTax.Size = new System.Drawing.Size(180, 22);
            this.lessTax.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 554);
            this.Controls.Add(this.listEmployees);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.netEarnings);
            this.Controls.Add(this.lessTax);
            this.Controls.Add(this.grossEarnings);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.close);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.hourlyWage);
            this.Controls.Add(this.hoursWorked);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weeklySalary);
            this.Controls.Add(this.commissionBased);
            this.Controls.Add(this.hourlyPay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton hourlyPay;
        private System.Windows.Forms.RadioButton commissionBased;
        private System.Windows.Forms.RadioButton weeklySalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.TextBox hoursWorked;
        private System.Windows.Forms.TextBox hourlyWage;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox grossEarnings;
        private System.Windows.Forms.TextBox netEarnings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox listEmployees;
        private System.Windows.Forms.TextBox lessTax;
    }
}

