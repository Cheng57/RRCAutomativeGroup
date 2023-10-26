namespace Wu.Cheng.RRCAGApp
{
    partial class SalesQuoteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVehiclSalePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeinValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAccessoriesComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkAccessoriesLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkAccessoriesStereoSystem = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radExteriorFinishCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.radExteriorFinishPearlized = new System.Windows.Forms.RadioButton();
            this.radExteriorFinishStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSummaryAmountDue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSummaryTradeIn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSummaryTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSummarySalesTax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSummarySubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSummaryOptions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSummaryVehicleSalePrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblFinanceMonthlyPayment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudFinanceAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudFinanceNoofYears = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceNoofYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle\'s Sale Price:";
            // 
            // txtVehiclSalePrice
            // 
            this.txtVehiclSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehiclSalePrice.Location = new System.Drawing.Point(161, 26);
            this.txtVehiclSalePrice.Name = "txtVehiclSalePrice";
            this.txtVehiclSalePrice.Size = new System.Drawing.Size(131, 22);
            this.txtVehiclSalePrice.TabIndex = 1;
            this.txtVehiclSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trade-in Value:";
            // 
            // txtTradeinValue
            // 
            this.txtTradeinValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTradeinValue.Location = new System.Drawing.Point(161, 66);
            this.txtTradeinValue.Name = "txtTradeinValue";
            this.txtTradeinValue.Size = new System.Drawing.Size(131, 22);
            this.txtTradeinValue.TabIndex = 3;
            this.txtTradeinValue.Text = "0";
            this.txtTradeinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAccessoriesComputerNavigation);
            this.groupBox1.Controls.Add(this.chkAccessoriesLeatherInterior);
            this.groupBox1.Controls.Add(this.chkAccessoriesStereoSystem);
            this.groupBox1.Location = new System.Drawing.Point(28, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accessories";
            // 
            // chkAccessoriesComputerNavigation
            // 
            this.chkAccessoriesComputerNavigation.AutoSize = true;
            this.chkAccessoriesComputerNavigation.Location = new System.Drawing.Point(26, 120);
            this.chkAccessoriesComputerNavigation.Name = "chkAccessoriesComputerNavigation";
            this.chkAccessoriesComputerNavigation.Size = new System.Drawing.Size(155, 20);
            this.chkAccessoriesComputerNavigation.TabIndex = 6;
            this.chkAccessoriesComputerNavigation.Text = "Computer Navigation";
            this.chkAccessoriesComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // chkAccessoriesLeatherInterior
            // 
            this.chkAccessoriesLeatherInterior.AutoSize = true;
            this.chkAccessoriesLeatherInterior.Location = new System.Drawing.Point(26, 79);
            this.chkAccessoriesLeatherInterior.Name = "chkAccessoriesLeatherInterior";
            this.chkAccessoriesLeatherInterior.Size = new System.Drawing.Size(117, 20);
            this.chkAccessoriesLeatherInterior.TabIndex = 5;
            this.chkAccessoriesLeatherInterior.Text = "Leather Interior";
            this.chkAccessoriesLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkAccessoriesStereoSystem
            // 
            this.chkAccessoriesStereoSystem.AutoSize = true;
            this.chkAccessoriesStereoSystem.Location = new System.Drawing.Point(26, 38);
            this.chkAccessoriesStereoSystem.Name = "chkAccessoriesStereoSystem";
            this.chkAccessoriesStereoSystem.Size = new System.Drawing.Size(117, 20);
            this.chkAccessoriesStereoSystem.TabIndex = 4;
            this.chkAccessoriesStereoSystem.Text = "Stereo System";
            this.chkAccessoriesStereoSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radExteriorFinishCustomizedDetailing);
            this.groupBox2.Controls.Add(this.radExteriorFinishPearlized);
            this.groupBox2.Controls.Add(this.radExteriorFinishStandard);
            this.groupBox2.Location = new System.Drawing.Point(28, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 179);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exterior Finish";
            // 
            // radExteriorFinishCustomizedDetailing
            // 
            this.radExteriorFinishCustomizedDetailing.AutoSize = true;
            this.radExteriorFinishCustomizedDetailing.Location = new System.Drawing.Point(26, 121);
            this.radExteriorFinishCustomizedDetailing.Name = "radExteriorFinishCustomizedDetailing";
            this.radExteriorFinishCustomizedDetailing.Size = new System.Drawing.Size(154, 20);
            this.radExteriorFinishCustomizedDetailing.TabIndex = 6;
            this.radExteriorFinishCustomizedDetailing.TabStop = true;
            this.radExteriorFinishCustomizedDetailing.Text = "Customized Detailing";
            this.radExteriorFinishCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // radExteriorFinishPearlized
            // 
            this.radExteriorFinishPearlized.AutoSize = true;
            this.radExteriorFinishPearlized.Location = new System.Drawing.Point(26, 81);
            this.radExteriorFinishPearlized.Name = "radExteriorFinishPearlized";
            this.radExteriorFinishPearlized.Size = new System.Drawing.Size(85, 20);
            this.radExteriorFinishPearlized.TabIndex = 6;
            this.radExteriorFinishPearlized.TabStop = true;
            this.radExteriorFinishPearlized.Text = "Pearlized";
            this.radExteriorFinishPearlized.UseVisualStyleBackColor = true;
            // 
            // radExteriorFinishStandard
            // 
            this.radExteriorFinishStandard.AutoSize = true;
            this.radExteriorFinishStandard.Checked = true;
            this.radExteriorFinishStandard.Location = new System.Drawing.Point(26, 41);
            this.radExteriorFinishStandard.Name = "radExteriorFinishStandard";
            this.radExteriorFinishStandard.Size = new System.Drawing.Size(83, 20);
            this.radExteriorFinishStandard.TabIndex = 7;
            this.radExteriorFinishStandard.TabStop = true;
            this.radExteriorFinishStandard.Text = "Standard";
            this.radExteriorFinishStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSummaryAmountDue);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblSummaryTradeIn);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblSummaryTotal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblSummarySalesTax);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblSummarySubtotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblSummaryOptions);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblSummaryVehicleSalePrice);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(339, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 346);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // lblSummaryAmountDue
            // 
            this.lblSummaryAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSummaryAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryAmountDue.Location = new System.Drawing.Point(180, 280);
            this.lblSummaryAmountDue.Name = "lblSummaryAmountDue";
            this.lblSummaryAmountDue.Size = new System.Drawing.Size(131, 22);
            this.lblSummaryAmountDue.TabIndex = 17;
            this.lblSummaryAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Amount Due:";
            // 
            // lblSummaryTradeIn
            // 
            this.lblSummaryTradeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryTradeIn.Location = new System.Drawing.Point(180, 237);
            this.lblSummaryTradeIn.Name = "lblSummaryTradeIn";
            this.lblSummaryTradeIn.Size = new System.Drawing.Size(131, 22);
            this.lblSummaryTradeIn.TabIndex = 15;
            this.lblSummaryTradeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trade-in:";
            // 
            // lblSummaryTotal
            // 
            this.lblSummaryTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryTotal.Location = new System.Drawing.Point(180, 197);
            this.lblSummaryTotal.Name = "lblSummaryTotal";
            this.lblSummaryTotal.Size = new System.Drawing.Size(131, 22);
            this.lblSummaryTotal.TabIndex = 13;
            this.lblSummaryTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total:";
            // 
            // lblSummarySalesTax
            // 
            this.lblSummarySalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummarySalesTax.Location = new System.Drawing.Point(180, 156);
            this.lblSummarySalesTax.Name = "lblSummarySalesTax";
            this.lblSummarySalesTax.Size = new System.Drawing.Size(131, 22);
            this.lblSummarySalesTax.TabIndex = 11;
            this.lblSummarySalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sales Tax (12%):";
            // 
            // lblSummarySubtotal
            // 
            this.lblSummarySubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummarySubtotal.Location = new System.Drawing.Point(180, 116);
            this.lblSummarySubtotal.Name = "lblSummarySubtotal";
            this.lblSummarySubtotal.Size = new System.Drawing.Size(131, 22);
            this.lblSummarySubtotal.TabIndex = 7;
            this.lblSummarySubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subtotal:";
            // 
            // lblSummaryOptions
            // 
            this.lblSummaryOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryOptions.Location = new System.Drawing.Point(180, 76);
            this.lblSummaryOptions.Name = "lblSummaryOptions";
            this.lblSummaryOptions.Size = new System.Drawing.Size(131, 22);
            this.lblSummaryOptions.TabIndex = 7;
            this.lblSummaryOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Options:";
            // 
            // lblSummaryVehicleSalePrice
            // 
            this.lblSummaryVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryVehicleSalePrice.Location = new System.Drawing.Point(180, 38);
            this.lblSummaryVehicleSalePrice.Name = "lblSummaryVehicleSalePrice";
            this.lblSummaryVehicleSalePrice.Size = new System.Drawing.Size(131, 22);
            this.lblSummaryVehicleSalePrice.TabIndex = 8;
            this.lblSummaryVehicleSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vehicle\'s Sale Price:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblFinanceMonthlyPayment);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.nudFinanceAnnualInterestRate);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.nudFinanceNoofYears);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(339, 383);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 121);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Finance";
            // 
            // lblFinanceMonthlyPayment
            // 
            this.lblFinanceMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblFinanceMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinanceMonthlyPayment.Location = new System.Drawing.Point(228, 74);
            this.lblFinanceMonthlyPayment.Name = "lblFinanceMonthlyPayment";
            this.lblFinanceMonthlyPayment.Size = new System.Drawing.Size(108, 22);
            this.lblFinanceMonthlyPayment.TabIndex = 8;
            this.lblFinanceMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Monthly Payment";
            // 
            // nudFinanceAnnualInterestRate
            // 
            this.nudFinanceAnnualInterestRate.DecimalPlaces = 2;
            this.nudFinanceAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudFinanceAnnualInterestRate.Location = new System.Drawing.Point(132, 74);
            this.nudFinanceAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudFinanceAnnualInterestRate.Name = "nudFinanceAnnualInterestRate";
            this.nudFinanceAnnualInterestRate.Size = new System.Drawing.Size(80, 22);
            this.nudFinanceAnnualInterestRate.TabIndex = 9;
            this.nudFinanceAnnualInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 32);
            this.label11.TabIndex = 8;
            this.label11.Text = "Annual \r\nInterest Rate";
            // 
            // nudFinanceNoofYears
            // 
            this.nudFinanceNoofYears.Location = new System.Drawing.Point(22, 74);
            this.nudFinanceNoofYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFinanceNoofYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFinanceNoofYears.Name = "nudFinanceNoofYears";
            this.nudFinanceNoofYears.Size = new System.Drawing.Size(88, 22);
            this.nudFinanceNoofYears.TabIndex = 8;
            this.nudFinanceNoofYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "No. of  Years";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.Location = new System.Drawing.Point(28, 525);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 40);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalculateQuote.Location = new System.Drawing.Point(560, 525);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(134, 40);
            this.btnCalculateQuote.TabIndex = 10;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 574);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTradeinValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVehiclSalePrice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceNoofYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVehiclSalePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeinValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAccessoriesComputerNavigation;
        private System.Windows.Forms.CheckBox chkAccessoriesLeatherInterior;
        private System.Windows.Forms.CheckBox chkAccessoriesStereoSystem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radExteriorFinishStandard;
        private System.Windows.Forms.RadioButton radExteriorFinishCustomizedDetailing;
        private System.Windows.Forms.RadioButton radExteriorFinishPearlized;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSummarySubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSummaryOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSummaryVehicleSalePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSummaryAmountDue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSummaryTradeIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSummaryTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSummarySalesTax;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblFinanceMonthlyPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudFinanceAnnualInterestRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudFinanceNoofYears;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}