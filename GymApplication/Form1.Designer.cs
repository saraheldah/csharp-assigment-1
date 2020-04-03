namespace GymApplication
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
            this.components = new System.ComponentModel.Container();
            this.tab = new System.Windows.Forms.TabControl();
            this.Info = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.TabPage();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxReg = new System.Windows.Forms.GroupBox();
            this.rdbtnMonthly = new System.Windows.Forms.RadioButton();
            this.rdbtnDaily = new System.Windows.Forms.RadioButton();
            this.grpBoxExtra = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.grpBoxClass = new System.Windows.Forms.GroupBox();
            this.rdbtnYoga = new System.Windows.Forms.RadioButton();
            this.rdbtnZumba = new System.Windows.Forms.RadioButton();
            this.rdbtnSwimming = new System.Windows.Forms.RadioButton();
            this.rdbtnAqua = new System.Windows.Forms.RadioButton();
            this.Bill = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRegistation = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tab.SuspendLayout();
            this.Info.SuspendLayout();
            this.Registration.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpBoxReg.SuspendLayout();
            this.grpBoxExtra.SuspendLayout();
            this.grpBoxClass.SuspendLayout();
            this.Bill.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.Info);
            this.tab.Controls.Add(this.Registration);
            this.tab.Controls.Add(this.Bill);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(630, 560);
            this.tab.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.btnNext);
            this.Info.Controls.Add(this.txtAddress);
            this.Info.Controls.Add(this.txtNum);
            this.Info.Controls.Add(this.txtName);
            this.Info.Controls.Add(this.label3);
            this.Info.Controls.Add(this.label2);
            this.Info.Controls.Add(this.label1);
            this.Info.Location = new System.Drawing.Point(4, 22);
            this.Info.Name = "Info";
            this.Info.Padding = new System.Windows.Forms.Padding(3);
            this.Info.Size = new System.Drawing.Size(622, 534);
            this.Info.TabIndex = 0;
            this.Info.Text = "Personal Information";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(508, 281);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 33);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(175, 167);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(408, 85);
            this.txtAddress.TabIndex = 5;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(175, 104);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(408, 20);
            this.txtNum.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtNum, "Phone can contain only numbers");
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(408, 20);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telephone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // Registration
            // 
            this.Registration.Controls.Add(this.btnFinish);
            this.Registration.Controls.Add(this.panel1);
            this.Registration.Location = new System.Drawing.Point(4, 22);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(3);
            this.Registration.Size = new System.Drawing.Size(622, 534);
            this.Registration.TabIndex = 1;
            this.Registration.Text = "Registration Information";
            this.Registration.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(466, 282);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 32);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.grpBoxReg);
            this.panel1.Controls.Add(this.grpBoxExtra);
            this.panel1.Controls.Add(this.grpBoxClass);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 276);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(95, 252);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(401, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Days #";
            // 
            // grpBoxReg
            // 
            this.grpBoxReg.Controls.Add(this.rdbtnMonthly);
            this.grpBoxReg.Controls.Add(this.rdbtnDaily);
            this.grpBoxReg.Location = new System.Drawing.Point(44, 131);
            this.grpBoxReg.Name = "grpBoxReg";
            this.grpBoxReg.Size = new System.Drawing.Size(200, 100);
            this.grpBoxReg.TabIndex = 0;
            this.grpBoxReg.TabStop = false;
            this.grpBoxReg.Text = "Registration Type";
            // 
            // rdbtnMonthly
            // 
            this.rdbtnMonthly.AutoSize = true;
            this.rdbtnMonthly.Location = new System.Drawing.Point(6, 49);
            this.rdbtnMonthly.Name = "rdbtnMonthly";
            this.rdbtnMonthly.Size = new System.Drawing.Size(63, 17);
            this.rdbtnMonthly.TabIndex = 2;
            this.rdbtnMonthly.TabStop = true;
            this.rdbtnMonthly.Text = "Monthly";
            this.rdbtnMonthly.UseVisualStyleBackColor = true;
            // 
            // rdbtnDaily
            // 
            this.rdbtnDaily.AutoSize = true;
            this.rdbtnDaily.Location = new System.Drawing.Point(90, 49);
            this.rdbtnDaily.Name = "rdbtnDaily";
            this.rdbtnDaily.Size = new System.Drawing.Size(48, 17);
            this.rdbtnDaily.TabIndex = 3;
            this.rdbtnDaily.TabStop = true;
            this.rdbtnDaily.Text = "Daily";
            this.rdbtnDaily.UseVisualStyleBackColor = true;
            this.rdbtnDaily.CheckedChanged += new System.EventHandler(this.rdbtnDaily_CheckedChanged);
            // 
            // grpBoxExtra
            // 
            this.grpBoxExtra.Controls.Add(this.checkBox4);
            this.grpBoxExtra.Controls.Add(this.checkBox1);
            this.grpBoxExtra.Controls.Add(this.checkBox3);
            this.grpBoxExtra.Controls.Add(this.checkBox2);
            this.grpBoxExtra.Location = new System.Drawing.Point(294, 12);
            this.grpBoxExtra.Name = "grpBoxExtra";
            this.grpBoxExtra.Size = new System.Drawing.Size(200, 219);
            this.grpBoxExtra.TabIndex = 0;
            this.grpBoxExtra.TabStop = false;
            this.grpBoxExtra.Text = "Extra";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(31, 166);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(56, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Sauna";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.cbExtra_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Treadmill";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.cbExtra_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(31, 117);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(46, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Pool";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.cbExtra_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(31, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Eliptical";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.cbExtra_CheckedChanged);
            // 
            // grpBoxClass
            // 
            this.grpBoxClass.Controls.Add(this.rdbtnYoga);
            this.grpBoxClass.Controls.Add(this.rdbtnZumba);
            this.grpBoxClass.Controls.Add(this.rdbtnSwimming);
            this.grpBoxClass.Controls.Add(this.rdbtnAqua);
            this.grpBoxClass.Location = new System.Drawing.Point(44, 12);
            this.grpBoxClass.Name = "grpBoxClass";
            this.grpBoxClass.Size = new System.Drawing.Size(200, 100);
            this.grpBoxClass.TabIndex = 1;
            this.grpBoxClass.TabStop = false;
            this.grpBoxClass.Text = "Class";
            // 
            // rdbtnYoga
            // 
            this.rdbtnYoga.AutoSize = true;
            this.rdbtnYoga.Location = new System.Drawing.Point(6, 28);
            this.rdbtnYoga.Name = "rdbtnYoga";
            this.rdbtnYoga.Size = new System.Drawing.Size(49, 17);
            this.rdbtnYoga.TabIndex = 2;
            this.rdbtnYoga.TabStop = true;
            this.rdbtnYoga.Text = "Yoga";
            this.rdbtnYoga.UseVisualStyleBackColor = true;
            this.rdbtnYoga.CheckedChanged += new System.EventHandler(this.rbClass_CheckedChanged);
            // 
            // rdbtnZumba
            // 
            this.rdbtnZumba.AutoSize = true;
            this.rdbtnZumba.Location = new System.Drawing.Point(90, 28);
            this.rdbtnZumba.Name = "rdbtnZumba";
            this.rdbtnZumba.Size = new System.Drawing.Size(57, 17);
            this.rdbtnZumba.TabIndex = 3;
            this.rdbtnZumba.TabStop = true;
            this.rdbtnZumba.Text = "Zumba";
            this.rdbtnZumba.UseVisualStyleBackColor = true;
            this.rdbtnZumba.CheckedChanged += new System.EventHandler(this.rbClass_CheckedChanged);
            // 
            // rdbtnSwimming
            // 
            this.rdbtnSwimming.AutoSize = true;
            this.rdbtnSwimming.Location = new System.Drawing.Point(6, 65);
            this.rdbtnSwimming.Name = "rdbtnSwimming";
            this.rdbtnSwimming.Size = new System.Drawing.Size(71, 17);
            this.rdbtnSwimming.TabIndex = 4;
            this.rdbtnSwimming.TabStop = true;
            this.rdbtnSwimming.Text = "Swimming";
            this.rdbtnSwimming.UseVisualStyleBackColor = true;
            this.rdbtnSwimming.CheckedChanged += new System.EventHandler(this.rbClass_CheckedChanged);
            // 
            // rdbtnAqua
            // 
            this.rdbtnAqua.AutoSize = true;
            this.rdbtnAqua.Location = new System.Drawing.Point(90, 65);
            this.rdbtnAqua.Name = "rdbtnAqua";
            this.rdbtnAqua.Size = new System.Drawing.Size(85, 17);
            this.rdbtnAqua.TabIndex = 5;
            this.rdbtnAqua.TabStop = true;
            this.rdbtnAqua.Text = "Aqua Zumba";
            this.rdbtnAqua.UseVisualStyleBackColor = true;
            this.rdbtnAqua.CheckedChanged += new System.EventHandler(this.rbClass_CheckedChanged);
            // 
            // Bill
            // 
            this.Bill.Controls.Add(this.btnClose);
            this.Bill.Controls.Add(this.btnRegistation);
            this.Bill.Controls.Add(this.txtDetails);
            this.Bill.Controls.Add(this.txtInfo);
            this.Bill.Controls.Add(this.label6);
            this.Bill.Controls.Add(this.label5);
            this.Bill.Location = new System.Drawing.Point(4, 22);
            this.Bill.Name = "Bill";
            this.Bill.Padding = new System.Windows.Forms.Padding(3);
            this.Bill.Size = new System.Drawing.Size(622, 534);
            this.Bill.TabIndex = 2;
            this.Bill.Text = "Bill";
            this.Bill.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(502, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegistation
            // 
            this.btnRegistation.Location = new System.Drawing.Point(370, 256);
            this.btnRegistation.Name = "btnRegistation";
            this.btnRegistation.Size = new System.Drawing.Size(113, 37);
            this.btnRegistation.TabIndex = 4;
            this.btnRegistation.Text = "New Registration";
            this.btnRegistation.UseVisualStyleBackColor = true;
            this.btnRegistation.Click += new System.EventHandler(this.btnRegistation_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(23, 129);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(565, 107);
            this.txtDetails.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(23, 36);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(565, 74);
            this.txtInfo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Registration details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Personal info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 571);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Gym Application";
            this.tab.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.Registration.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpBoxReg.ResumeLayout(false);
            this.grpBoxReg.PerformLayout();
            this.grpBoxExtra.ResumeLayout(false);
            this.grpBoxExtra.PerformLayout();
            this.grpBoxClass.ResumeLayout(false);
            this.grpBoxClass.PerformLayout();
            this.Bill.ResumeLayout(false);
            this.Bill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.TabPage Bill;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxReg;
        private System.Windows.Forms.GroupBox grpBoxExtra;
        private System.Windows.Forms.GroupBox grpBoxClass;
        private System.Windows.Forms.RadioButton rdbtnYoga;
        private System.Windows.Forms.RadioButton rdbtnZumba;
        private System.Windows.Forms.RadioButton rdbtnSwimming;
        private System.Windows.Forms.RadioButton rdbtnAqua;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbtnMonthly;
        private System.Windows.Forms.RadioButton rdbtnDaily;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRegistation;
    }
}

