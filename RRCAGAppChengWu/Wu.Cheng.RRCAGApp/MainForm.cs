/*
 * Name:Cheng Wu
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2022-11-26
 * Updated: 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wu.Cheng.Business;
using ACE.BIT.ADEV.CarWash;
using System.Runtime.CompilerServices;

namespace Wu.Cheng.RRCAGApp
{
    /// <summary>
    /// Represents a MainForm form.
    /// </summary>
    public partial class MainForm : Form
    {
        private VehicleDataForm vehicleDataForm;
        
        /// <summary> 
        /// Initializes an instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.mnuFileOpenSalesQuote.ShortcutKeys = Keys.Control | Keys.D1;
            this.mnuFileOpenCarWash.ShortcutKeys = Keys.Control | Keys.D2;
            this.mnuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
            this.mnuDataVehicles.ShortcutKeys = Keys.Control | Keys.Shift | Keys.V;

            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
            this.mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_Click;
            this.mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;
            this.mnuDataVehicles.Click += MnuDataVehicles_Click;
        }

        /// <summary>
        /// Handles the Click event of the Vehicle menu.
        /// </summary>
        private void MnuDataVehicles_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.vehicleDataForm == null)
                {

                    this.vehicleDataForm = new VehicleDataForm();
                    this.vehicleDataForm.MdiParent = this;

                    this.vehicleDataForm.Show();

                }
                else
                {
                    this.vehicleDataForm.Activate();
                }

                this.vehicleDataForm.FormClosed += VehicleDataForm_FormClosed;


            }
            catch (Exception)
            {
                string message = "Unable to load vehicle data.";
                string caption = "Data Load Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1;

                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, icon, defaultButton);

            }   
        }

        /// <summary>
        /// Handles the Close event of the Vehicle menu.
        /// </summary>
        private void VehicleDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.vehicleDataForm = null;
        }

        /// <summary>
        /// Handles the Click event of the Car Wash menu.
        /// </summary>
        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            string filepath = @"fragrances.txt";

            try
            {
                if (!File.Exists(filepath))
                {
                    string message = "Fragrances data file not found.";
                    string caption = "Data File Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(this, message, caption, buttons,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign);

                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch (IOException)
            {
                string message = "An error occurred while reading the data file.";
                string caption = "Data File Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            } 

            CarWashForm carWashForm;

            carWashForm = new CarWashForm();

            carWashForm.MdiParent = this;

            carWashForm.Show();
        }

        /// <summary>
        /// Handles the Click event of the Sales Quote menu.
        /// </summary>
        private void MnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm salesQuoteForm;

            salesQuoteForm = new SalesQuoteForm();

            salesQuoteForm.MdiParent = this;

            salesQuoteForm.Show();
        }

        /// <summary>
        /// Handles the Click event of the Help About menu.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form;

            form = new AboutForm();

            form.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the File Exit menu.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
