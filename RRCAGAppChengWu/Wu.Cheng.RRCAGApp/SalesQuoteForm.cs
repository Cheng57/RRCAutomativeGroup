/*
 * Name:Cheng Wu
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2022-11-05
 * Updated: 2022-11-15
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wu.Cheng.Business;
using ACE.BIT.ADEV;
using System.Diagnostics;

namespace Wu.Cheng.RRCAGApp
{
    /// <summary>
    /// Represents a SalesQuoteForm form.
    /// </summary>
    public partial class SalesQuoteForm : Form
    {
        private SalesQuote salesQuote;

        /// <summary>
        /// Initializes an instance of the SalesQuoteForm class.
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();

            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;
            this.txtVehiclSalePrice.TextChanged += InputTextChanged;
            this.txtTradeinValue.TextChanged += InputTextChanged;
            this.chkAccessoriesStereoSystem.CheckedChanged += CheckorValueChanged;
            this.chkAccessoriesLeatherInterior.CheckedChanged += CheckorValueChanged;
            this.chkAccessoriesComputerNavigation.CheckedChanged += CheckorValueChanged;
            this.radExteriorFinishStandard.CheckedChanged += CheckorValueChanged;
            this.radExteriorFinishPearlized.CheckedChanged += CheckorValueChanged;
            this.radExteriorFinishCustomizedDetailing.CheckedChanged += CheckorValueChanged;
            this.nudFinanceNoofYears.ValueChanged += CheckorValueChanged;
            this.nudFinanceAnnualInterestRate.ValueChanged += CheckorValueChanged;
            this.btnReset.Click += BtnReset_Click;



            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.SetIconPadding(txtVehiclSalePrice, 3);
            this.errorProvider1.SetIconPadding(txtTradeinValue, 3);
        }

        /// <summary>
        /// Handles the Click event of the Reset button.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            string message = "Do you want to reset the form?";
            string caption = "Reset Form";
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icon, defaultButton);
            if (result == DialogResult.Yes)
            {
                this.errorProvider1.SetError(this.txtVehiclSalePrice, string.Empty);
                this.errorProvider1.SetError(this.txtTradeinValue, string.Empty);
                Initialize();
                this.txtVehiclSalePrice.Focus();
                this.txtTradeinValue.Text = 0.ToString();
                this.txtVehiclSalePrice.Text = string.Empty;
                this.chkAccessoriesStereoSystem.Checked = false;
                this.chkAccessoriesLeatherInterior.Checked = false;
                this.chkAccessoriesComputerNavigation.Checked = false;
                this.radExteriorFinishStandard.Checked = true;
                this.radExteriorFinishPearlized.Checked = false;
                this.radExteriorFinishCustomizedDetailing.Checked = false;
                this.nudFinanceNoofYears.Value = 1;
                this.nudFinanceAnnualInterestRate.Value = 5.00M;
                this.AcceptButton = btnCalculateQuote;
            }    
        }

        /// <summary>
        /// Initializes the items in Summary and Monthly Payment to Empty.
        /// </summary>
        private void Initialize()
        {
            this.lblSummaryVehicleSalePrice.Text = string.Empty;
            this.lblSummaryOptions.Text = string.Empty;
            this.lblSummarySubtotal.Text = string.Empty;
            this.lblSummarySalesTax.Text = string.Empty;
            this.lblSummaryTotal.Text = string.Empty;
            this.lblSummaryTradeIn.Text = string.Empty;
            this.lblSummaryAmountDue.Text = string.Empty;
            this.lblFinanceMonthlyPayment.Text = string.Empty;
        }

        /// <summary>
        /// Handles the CheckedChanged event of the Checkbox and the Radiobutton and the ValueChanged event of the NumericUpDown controls.
        /// </summary>
        private void CheckorValueChanged(object sender, EventArgs e)
        {
            if (!this.lblFinanceMonthlyPayment.Text.Equals(string.Empty))
            {
                Calculate();
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the VehicleSalePrice and the TradeInChanged textbox.
        /// </summary>
        private void InputTextChanged(object sender, EventArgs e)
        {
            Initialize();
            this.salesQuote = null;
        }


        /// <summary>
        /// Handles the Click event of the Calculate Quote button.
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {
            decimal vehicleSalePrice = 0M;
            decimal tradeinValue = 0M;

            this.errorProvider1.SetError(this.txtVehiclSalePrice, string.Empty);
            this.errorProvider1.SetError(this.txtTradeinValue, string.Empty);

            try
            {
                vehicleSalePrice = Decimal.Parse(this.txtVehiclSalePrice.Text);

                if ((vehicleSalePrice < 0) || (vehicleSalePrice == 0))
                {
                    this.errorProvider1.SetError(txtVehiclSalePrice, "Vehicle price cannot be less than or equal to 0.");
                }
            }
            catch (FormatException)
            {
                if (this.txtVehiclSalePrice.Text.Equals(string.Empty))
                {
                    this.errorProvider1.SetError(this.txtVehiclSalePrice, "Vehicle price is a required field.");
                }
                else
                {
                    this.errorProvider1.SetError(this.txtVehiclSalePrice, "Vehicle price cannot contain letters or special characters.");
                }
            }

            try
            {
                tradeinValue = Decimal.Parse(this.txtTradeinValue.Text);

                if (tradeinValue < 0)
                {
                    this.errorProvider1.SetError(this.txtTradeinValue, "Trade-in value cannot be less than 0.");
                }
            }
            catch (FormatException)
            {
                if (this.txtTradeinValue.Text.Equals(string.Empty))
                {
                    this.errorProvider1.SetError(this.txtTradeinValue, "Trade-in value is a required field.");
                }
                else
                {
                    this.errorProvider1.SetError(this.txtTradeinValue, "Trade-in value cannot contain letters or specail characters.");
                }
            }

            if (this.errorProvider1.GetError(this.txtVehiclSalePrice).Equals(string.Empty) && tradeinValue > vehicleSalePrice)
            {
                this.errorProvider1.SetError(this.txtTradeinValue, "Trade-in value cannot exceed the vehicle sale price.");
            }

            if (this.errorProvider1.GetError(this.txtVehiclSalePrice).Equals(string.Empty) && this.errorProvider1.GetError(this.txtTradeinValue).Equals(string.Empty))
            {
                Calculate();
            }
        }

        /// <summary>
        /// Calculates the items in Summary and Monthly Payment.
        /// </summary>
        private void Calculate()
        {
            const decimal SaleTaxRate = 0.12M;
            decimal vehicleSalePrice = Decimal.Parse(this.txtVehiclSalePrice.Text);
            decimal tradeinValue = Decimal.Parse(this.txtTradeinValue.Text);

            Accessories accessoriesChosen = Accessories.None;

            if (this.chkAccessoriesStereoSystem.Checked)
            {
                accessoriesChosen = Accessories.StereoSystem;
            }
            else if (this.chkAccessoriesLeatherInterior.Checked)
            {
                accessoriesChosen = Accessories.LeatherInterior;
            }
            else if (this.chkAccessoriesComputerNavigation.Checked)
            {
                accessoriesChosen = Accessories.ComputerNavigation;
            }

            if (this.chkAccessoriesStereoSystem.Checked && this.chkAccessoriesLeatherInterior.Checked)
            {
                accessoriesChosen = Accessories.StereoAndLeather;
            }

            if (this.chkAccessoriesStereoSystem.Checked && this.chkAccessoriesComputerNavigation.Checked)
            {
                accessoriesChosen = Accessories.StereoAndNavigation;
            }

            if (this.chkAccessoriesLeatherInterior.Checked && this.chkAccessoriesComputerNavigation.Checked)
            {
                accessoriesChosen = Accessories.LeatherAndNavigation;
            }

            if (this.chkAccessoriesStereoSystem.Checked && this.chkAccessoriesLeatherInterior.Checked &&
                     this.chkAccessoriesComputerNavigation.Checked)
            {
                accessoriesChosen = Accessories.All;
            }

            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            if (this.radExteriorFinishStandard.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Standard;
            }
            else if (this.radExteriorFinishPearlized.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Pearlized;
            }
            else if (this.radExteriorFinishCustomizedDetailing.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Custom;
            }

            this.salesQuote = new SalesQuote(vehicleSalePrice, tradeinValue, SaleTaxRate, accessoriesChosen, exteriorFinishChosen);

            this.lblSummaryVehicleSalePrice.Text = vehicleSalePrice.ToString("C");
            this.lblSummaryOptions.Text = this.salesQuote.TotalOptions.ToString("N");
            this.lblSummarySubtotal.Text = this.salesQuote.SubTotal.ToString("C");
            this.lblSummarySalesTax.Text = this.salesQuote.SalesTax.ToString("N");
            this.lblSummaryTotal.Text = this.salesQuote.Total.ToString("C");
            this.lblSummaryTradeIn.Text = (-tradeinValue).ToString("N");
            this.lblSummaryAmountDue.Text = this.salesQuote.AmountDue.ToString("C");

            decimal rate;
            int numberOfPaymentPeriods;
            decimal presentValue;

            numberOfPaymentPeriods = (int)(this.nudFinanceNoofYears.Value * 12);
            rate = (this.nudFinanceAnnualInterestRate.Value / 100) / 12;
            presentValue = this.salesQuote.AmountDue;

            this.lblFinanceMonthlyPayment.Text = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue).ToString("C");
        }
    }
}
