
namespace D_Anjolell_exam2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblBills = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtBills = new System.Windows.Forms.TextBox();
            this.radJan = new System.Windows.Forms.RadioButton();
            this.radFeb = new System.Windows.Forms.RadioButton();
            this.radMarch = new System.Windows.Forms.RadioButton();
            this.radApril = new System.Windows.Forms.RadioButton();
            this.radMay = new System.Windows.Forms.RadioButton();
            this.radJune = new System.Windows.Forms.RadioButton();
            this.radJuly = new System.Windows.Forms.RadioButton();
            this.radAug = new System.Windows.Forms.RadioButton();
            this.radSept = new System.Windows.Forms.RadioButton();
            this.radOct = new System.Windows.Forms.RadioButton();
            this.radNov = new System.Windows.Forms.RadioButton();
            this.radDec = new System.Windows.Forms.RadioButton();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(248, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Budget Management";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBudget.Location = new System.Drawing.Point(12, 123);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(241, 29);
            this.lblBudget.TabIndex = 1;
            this.lblBudget.Text = "Budget for the month:";
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBills.Location = new System.Drawing.Point(78, 170);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(182, 29);
            this.lblBills.TabIndex = 2;
            this.lblBills.Text = "Number of bills:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMonth.Location = new System.Drawing.Point(539, 79);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(142, 29);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Enter Month";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubmit.Location = new System.Drawing.Point(243, 390);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 48);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExit.Location = new System.Drawing.Point(458, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBudget
            // 
            this.txtBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBudget.Location = new System.Drawing.Point(266, 118);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(99, 34);
            this.txtBudget.TabIndex = 6;
            // 
            // txtBills
            // 
            this.txtBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBills.Location = new System.Drawing.Point(266, 165);
            this.txtBills.Name = "txtBills";
            this.txtBills.Size = new System.Drawing.Size(99, 34);
            this.txtBills.TabIndex = 7;
            // 
            // radJan
            // 
            this.radJan.AutoSize = true;
            this.radJan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radJan.Location = new System.Drawing.Point(457, 119);
            this.radJan.Name = "radJan";
            this.radJan.Size = new System.Drawing.Size(117, 33);
            this.radJan.TabIndex = 8;
            this.radJan.TabStop = true;
            this.radJan.Text = "January";
            this.radJan.UseVisualStyleBackColor = true;
            // 
            // radFeb
            // 
            this.radFeb.AutoSize = true;
            this.radFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radFeb.Location = new System.Drawing.Point(457, 158);
            this.radFeb.Name = "radFeb";
            this.radFeb.Size = new System.Drawing.Size(130, 33);
            this.radFeb.TabIndex = 9;
            this.radFeb.TabStop = true;
            this.radFeb.Text = "February";
            this.radFeb.UseVisualStyleBackColor = true;
            // 
            // radMarch
            // 
            this.radMarch.AutoSize = true;
            this.radMarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radMarch.Location = new System.Drawing.Point(457, 197);
            this.radMarch.Name = "radMarch";
            this.radMarch.Size = new System.Drawing.Size(100, 33);
            this.radMarch.TabIndex = 10;
            this.radMarch.TabStop = true;
            this.radMarch.Text = "March";
            this.radMarch.UseVisualStyleBackColor = true;
            // 
            // radApril
            // 
            this.radApril.AutoSize = true;
            this.radApril.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radApril.Location = new System.Drawing.Point(457, 236);
            this.radApril.Name = "radApril";
            this.radApril.Size = new System.Drawing.Size(83, 33);
            this.radApril.TabIndex = 11;
            this.radApril.TabStop = true;
            this.radApril.Text = "April";
            this.radApril.UseVisualStyleBackColor = true;
            // 
            // radMay
            // 
            this.radMay.AutoSize = true;
            this.radMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radMay.Location = new System.Drawing.Point(457, 275);
            this.radMay.Name = "radMay";
            this.radMay.Size = new System.Drawing.Size(78, 33);
            this.radMay.TabIndex = 12;
            this.radMay.TabStop = true;
            this.radMay.Text = "May";
            this.radMay.UseVisualStyleBackColor = true;
            // 
            // radJune
            // 
            this.radJune.AutoSize = true;
            this.radJune.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radJune.Location = new System.Drawing.Point(457, 314);
            this.radJune.Name = "radJune";
            this.radJune.Size = new System.Drawing.Size(86, 33);
            this.radJune.TabIndex = 13;
            this.radJune.TabStop = true;
            this.radJune.Text = "June";
            this.radJune.UseVisualStyleBackColor = true;
            // 
            // radJuly
            // 
            this.radJuly.AutoSize = true;
            this.radJuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radJuly.Location = new System.Drawing.Point(633, 119);
            this.radJuly.Name = "radJuly";
            this.radJuly.Size = new System.Drawing.Size(76, 33);
            this.radJuly.TabIndex = 14;
            this.radJuly.TabStop = true;
            this.radJuly.Text = "July";
            this.radJuly.UseVisualStyleBackColor = true;
            // 
            // radAug
            // 
            this.radAug.AutoSize = true;
            this.radAug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radAug.Location = new System.Drawing.Point(633, 158);
            this.radAug.Name = "radAug";
            this.radAug.Size = new System.Drawing.Size(107, 33);
            this.radAug.TabIndex = 15;
            this.radAug.TabStop = true;
            this.radAug.Text = "August";
            this.radAug.UseVisualStyleBackColor = true;
            // 
            // radSept
            // 
            this.radSept.AutoSize = true;
            this.radSept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radSept.Location = new System.Drawing.Point(633, 197);
            this.radSept.Name = "radSept";
            this.radSept.Size = new System.Drawing.Size(154, 33);
            this.radSept.TabIndex = 16;
            this.radSept.TabStop = true;
            this.radSept.Text = "September";
            this.radSept.UseVisualStyleBackColor = true;
            // 
            // radOct
            // 
            this.radOct.AutoSize = true;
            this.radOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radOct.Location = new System.Drawing.Point(633, 236);
            this.radOct.Name = "radOct";
            this.radOct.Size = new System.Drawing.Size(121, 33);
            this.radOct.TabIndex = 17;
            this.radOct.TabStop = true;
            this.radOct.Text = "October";
            this.radOct.UseVisualStyleBackColor = true;
            // 
            // radNov
            // 
            this.radNov.AutoSize = true;
            this.radNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radNov.Location = new System.Drawing.Point(633, 275);
            this.radNov.Name = "radNov";
            this.radNov.Size = new System.Drawing.Size(147, 33);
            this.radNov.TabIndex = 18;
            this.radNov.TabStop = true;
            this.radNov.Text = "November";
            this.radNov.UseVisualStyleBackColor = true;
            // 
            // radDec
            // 
            this.radDec.AutoSize = true;
            this.radDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radDec.Location = new System.Drawing.Point(633, 314);
            this.radDec.Name = "radDec";
            this.radDec.Size = new System.Drawing.Size(147, 33);
            this.radDec.TabIndex = 19;
            this.radDec.TabStop = true;
            this.radDec.Text = "December";
            this.radDec.UseVisualStyleBackColor = true;
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 29;
            this.lstResult.Location = new System.Drawing.Point(12, 224);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(418, 178);
            this.lstResult.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.radDec);
            this.Controls.Add(this.radNov);
            this.Controls.Add(this.radOct);
            this.Controls.Add(this.radSept);
            this.Controls.Add(this.radAug);
            this.Controls.Add(this.radJuly);
            this.Controls.Add(this.radJune);
            this.Controls.Add(this.radMay);
            this.Controls.Add(this.radApril);
            this.Controls.Add(this.radMarch);
            this.Controls.Add(this.radFeb);
            this.Controls.Add(this.radJan);
            this.Controls.Add(this.txtBills);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblBills);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblBills;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtBills;
        private System.Windows.Forms.RadioButton radJan;
        private System.Windows.Forms.RadioButton radFeb;
        private System.Windows.Forms.RadioButton radMarch;
        private System.Windows.Forms.RadioButton radApril;
        private System.Windows.Forms.RadioButton radMay;
        private System.Windows.Forms.RadioButton radJune;
        private System.Windows.Forms.RadioButton radJuly;
        private System.Windows.Forms.RadioButton radAug;
        private System.Windows.Forms.RadioButton radSept;
        private System.Windows.Forms.RadioButton radOct;
        private System.Windows.Forms.RadioButton radNov;
        private System.Windows.Forms.RadioButton radDec;
        private System.Windows.Forms.ListBox lstResult;
    }
}

