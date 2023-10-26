/*
 * Name:Cheng Wu
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2022-11-05
 * Updated: 2022-11-15
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV;

namespace Wu.Cheng.RRCAGApp
{
    /// <summary>
    /// Represents a VehicleDataForm form.
    /// </summary>
    internal class VehicleDataForm : ACE.BIT.ADEV.Forms.VehicleDataForm
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataSet;
        private BindingSource bindingSource;
        private OleDbCommandBuilder commandBuilder;
        private string tableName = "VehicleStock";

        /// <summary>
        /// Initilizes an instance of the VehicleDataForm class.
        /// </summary>
        public VehicleDataForm()
        {
            RetrieveDataFromTheDatabase();
            this.bindingSource = new BindingSource();
            this.Load += new EventHandler(VehicleDataForm_Load);
            


        }

        /// <summary>
        /// Handles the Load event of this form.
        /// </summary>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            //RetrieveDataFromTheDatabase();

            BindControls();

            this.Text = "Vehicle Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.mnuFileSave.Click += MnuFileSave_Click;
            this.mnuFileClose.Click += MnuFileClose_Click;
            this.mnuEditDelete.Click += MnuEditDelete_Click;

            this.dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;
            this.dgvVehicles.CellValueChanged += DgvVehicles_CellValueChanged; ;

            this.FormClosing += VehicleDataForm_FormClosing;


        }
        /// <summary>
        /// Handles the FormClosing event of the Vehicle Data Form form.
        /// </summary>
        private void VehicleDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Text == "* Vehicle Data")
            {
                string message = "Do you wish to save the changes?";
                string caption = "Save";
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNoCancel;
                MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error;
                MessageBoxDefaultButton messageBoxDefaultButton = MessageBoxDefaultButton.Button3;

                DialogResult result;
                result = MessageBox.Show(message, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);
                try
                {
                    if (result == DialogResult.No)
                    {
                        return;
                    }

                    if (result == DialogResult.Yes)
                    {
                        this.dgvVehicles.EndEdit();
                        this.bindingSource.EndEdit();

                        this.adapter.Update(this.dataSet, this.tableName);
                    }

                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;

                    }
                }
                catch (Exception)
                {
                    string expMsg = "An error occurred while saving the changes. Do you still wish to close?";
                    string expCap = "Save Error";
                    MessageBoxButtons expMsgBtn = MessageBoxButtons.YesNo;
                    MessageBoxIcon expIcon = MessageBoxIcon.Error;
                    MessageBoxDefaultButton expDfltBtn = MessageBoxDefaultButton.Button2;

                    DialogResult result1;
                    result1 = MessageBox.Show(expMsg, expCap, expMsgBtn, expIcon, expDfltBtn);

                    if (result1 == DialogResult.Yes)
                    {
                        return;
                    }

                    if (result1 == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
               
            }
        }

        /// <summary>
        /// Handles the CellVauleChanged event of the DgvVehicles.
        /// </summary>
        private void DgvVehicles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.mnuFileSave.Enabled = true;
            this.Text = "* Vehicle Data";

        }



        /// <summary>
        /// Handles the SelectionChanged event of the DgvVehicles.
        /// </summary>
        private void DgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvVehicles.CurrentRow.Selected)
            {
                this.mnuEditDelete.Enabled = true;
            }
            else
            {
                this.mnuEditDelete.Enabled = false;
            }

        }

        /// <summary>
        /// Handles the Click event of the Delete menu item.
        /// </summary>
        private void MnuEditDelete_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure you want to permanently delete stock item {this.dgvVehicles.CurrentCell.Value}?";
            string caption = "Delete Stock Item";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2;

            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icon, defaultButton);

            if(result == DialogResult.Yes)
            {
                try
                {
                    
                    this.dgvVehicles.Rows.RemoveAt(this.dgvVehicles.SelectedRows[0].Index);
                    this.Text = "Vehicla Data";
                    this.adapter.Update(this.dataSet, this.tableName);
                }
                catch (Exception)
                {
                    string expMessage = "An error occured while deleting the selected vehicle.";
                    string expCaption = "Deletion Error";
                    MessageBoxButtons expButtons = MessageBoxButtons.OK;
                    MessageBoxIcon expIcon = MessageBoxIcon.Error;
                    MessageBoxDefaultButton expDefaultButton = MessageBoxDefaultButton.Button1;

                    MessageBox.Show(expMessage, expCaption, expButtons, expIcon, expDefaultButton);
                }
                
            }
        }

        /// <summary>
        /// Handles the Click event of the Close menu item.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the Save menu item.
        /// </summary>
        private void MnuFileSave_Click(object sender, EventArgs e)
        { 
            try
            {
                this.dgvVehicles.EndEdit();
                this.bindingSource.EndEdit();

                this.adapter.Update(this.dataSet, this.tableName);
            }
            catch (Exception)
            {
                string message = "An error occured while saving the changes to the vehicle data.";
                string caption = "Save Error";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                MessageBoxIcon boxIcon = MessageBoxIcon.Error;
                MessageBoxDefaultButton boxDefaultButton = MessageBoxDefaultButton.Button1;
                MessageBox.Show(message, caption, boxButtons, boxIcon, boxDefaultButton);
            }

            this.mnuFileSave.Enabled = false;
            this.Text = "Vehicle Data";
            
        }

        /// <summary>
        /// Queries the database and populates a dataset.
        /// </summary>
        private void RetrieveDataFromTheDatabase()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=AMDatabase.mdb";
            this.connection = new OleDbConnection(connectionString);
            this.connection.Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM VehicleStock", this.connection);

            this.adapter = new OleDbDataAdapter(command);

            this.dataSet = new DataSet();

            
            this.adapter.Fill(this.dataSet, tableName);


            this.commandBuilder = new OleDbCommandBuilder(this.adapter);
            this.commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

            this.adapter.DeleteCommand = this.commandBuilder.GetDeleteCommand();
            this.adapter.InsertCommand = this.commandBuilder.GetInsertCommand();
            this.adapter.UpdateCommand = this.commandBuilder.GetUpdateCommand();

            
        }

        /// <summary>
        /// Binds the controls on the form.
        /// </summary>
        private void BindControls()
        {
            this.bindingSource.DataSource = this.dataSet.Tables[tableName];
            this.dgvVehicles.DataSource = this.bindingSource;

            this.dgvVehicles.Columns["ID"].Visible = false;
            this.dgvVehicles.Columns["SoldBy"].Visible = false;


        }
    }
}
