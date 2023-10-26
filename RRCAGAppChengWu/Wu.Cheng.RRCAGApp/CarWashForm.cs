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
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV;
using ACE.BIT.ADEV.CarWash;
using Wu.Cheng.Business;

namespace Wu.Cheng.RRCAGApp
{
    /// <summary>
    /// Represents a CarWashForm form.
    /// </summary>
    internal class CarWashForm : ACE.BIT.ADEV.Forms.CarWashForm
    {
        private BindingSource packagesSource;
        private BindingList<Package> packages;


        private BindingSource fragrancesSource;
        private BindingList<Fragrance> fragrances;


        private BindingSource interiorServicesSource;
        private BindingSource exteriorServicesSource;

        private BindingSource subtotalSource;
        private BindingSource pstSource;
        private BindingSource gstSource;
        private BindingSource totalSource;

        private List<string> interiorService1 = new List<string>();
        private List<string> interiorService2 = new List<string>();
        private List<string> interiorService3 = new List<string>();
        private List<string> interiorService4 = new List<string>();



        private List<string> exteriorService1 = new List<string>();
        private List<string> exteriorService2 = new List<string>();
        private List<string> exteriorService3 = new List<string>();
        private List<string> exteriorService4 = new List<string>();

        private decimal packageCost;
        private decimal fragranceCost;

        private CarWashInvoice carWashInvoice;
        private CarWashInvoiceForm carWashInvoiceForm;

        /// <summary>
        /// Initializes an instance of the CarWashForm class
        /// </summary>
        public CarWashForm()
        {
            this.Text = "Car Wash";
            this.mnuToolsGenerateInvoice.Enabled = false;


            string filepath = @"fragrances.txt";

            FileStream fileStream;
            fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);

            StreamReader fileReader;
            fileReader = new StreamReader(fileStream);

            this.fragrances = new BindingList<Fragrance>();

            // Read the Fragrance data from an external file "fragrances.txt"
            while (fileReader.Peek() != -1)
            {
                string record = fileReader.ReadLine();
                char[] delimiters = { ',' };

                string[] fields = record.Split(delimiters);

                string description = fields[0];
                decimal price = Decimal.Parse(fields[1]);

                this.fragrances.Add(new Fragrance(description, price));
            }

            this.fragrances.Add(new Fragrance("Pine", 0.00M));

            // Sort the List fragrances
            List<Fragrance> sortedList = fragrances.OrderBy(fragrance => fragrance.Description).ToList();
            fragrances = new BindingList<Fragrance>(sortedList);

            fileReader.Close();

            this.fragrancesSource = new BindingSource();
            this.fragrancesSource.DataSource = this.fragrances;

            this.cboFragrance.DataSource = this.fragrancesSource;

            this.cboFragrance.Text = "Pine";

            this.cboFragrance.SelectedIndexChanged += CboFragrance_SelectedIndexChanged;

            interiorService1.Add("Fragrance - " + this.cboFragrance.SelectedItem);

            interiorService2.Add("Fragrance - " + this.cboFragrance.SelectedItem);
            interiorService2.Add("Shampoo Carpets");

            interiorService3.Add("Fragrance - " + this.cboFragrance.SelectedItem);
            interiorService3.Add("Shampoo Carpets");
            interiorService3.Add("Shampoo Upholstery");

            interiorService4.Add("Fragrance - " + this.cboFragrance.SelectedItem);
            interiorService4.Add("Shampoo Carpets");
            interiorService4.Add("Shampoo Upholstery");
            interiorService4.Add("Interior Protection Coat");

            exteriorService1.Add("Hand Wash");

            exteriorService2.Add("Hand Wash");
            exteriorService2.Add("Hand Wax");

            exteriorService3.Add("Hand Wash");
            exteriorService3.Add("Hand Wax");
            exteriorService3.Add("Wheel Polish");

            exteriorService4.Add("Hand Wash");
            exteriorService4.Add("Hand Wax");
            exteriorService4.Add("Wheel Polish");
            exteriorService4.Add("Detail Engine Compartment");

            packages = new BindingList<Package>();
            packages.Add(new Package("Standard", 7.50M, interiorService1, exteriorService1));
            packages.Add(new Package("Deluxe", 15.00M, interiorService2, exteriorService2));
            packages.Add(new Package("Executive", 35.00M, interiorService3, exteriorService3));
            packages.Add(new Package("Luxury", 55.00M, interiorService4, exteriorService4));

            this.packagesSource = new BindingSource();
            this.packagesSource.DataSource = this.packages;

            this.cboPackage.DataSource = this.packagesSource;

            this.cboPackage.SelectedItem = null;
            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;

            this.mnuFileClose.Click += MnuFileClose_Click;
            this.mnuToolsGenerateInvoice.Click += MnuToolsGenerateInvoice_Click;

            
            //this.carWashInvoiceForm.FormClosing += CarWashInvoiceForm_FormClosing;


        }

        /// <summary>
        /// 
        /// </summary>
        private void CarWashInvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.lstInterior.Text = string.Empty;

        }

        /// <summary>
        /// Handles the Click event of the ToolSGenerateInvoice menu
        /// </summary>
        /// 
        private void MnuToolsGenerateInvoice_Click(object sender, EventArgs e)
        {
            //pass the carWashInvoice object in this form to CarWashInvoiceForm form
            carWashInvoiceForm = new CarWashInvoiceForm(this.carWashInvoice);
            
            carWashInvoiceForm.ShowDialog();

            this.carWashInvoiceForm.FormClosing += CarWashInvoiceForm_FormClosing;
        }

        /// <summary>
        /// Handles the Click event of the FileClose menu
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Fragrance combobox
        /// </summary>
        private void CboFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.interiorServicesSource = new BindingSource();

            interiorService1[0] = "Fragrance - " + this.cboFragrance.SelectedItem;
            interiorService2[0] = "Fragrance - " + this.cboFragrance.SelectedItem;
            interiorService3[0] = "Fragrance - " + this.cboFragrance.SelectedItem;
            interiorService4[0] = "Fragrance - " + this.cboFragrance.SelectedItem;

            // Convert.ToString(object) converts to string. It can handle the NULL object. The NULL object is converted to an empty string.
            // .ToString() on an object with a NULL value throws a System.NullReferenceException.
            switch (Convert.ToString(this.cboPackage.SelectedItem))
            {
                case "Standard":
                    this.interiorServicesSource.DataSource = this.interiorService1;
                    break;

                case "Deluxe":
                    this.interiorServicesSource.DataSource = this.interiorService2;
                    break;

                case "Executive":
                    this.interiorServicesSource.DataSource = this.interiorService3;
                    break;

                case "Luxury":
                    this.interiorServicesSource.DataSource = this.interiorService4;
                    break;
            }

            this.lstInterior.DataSource = this.interiorServicesSource;

            switch (this.cboFragrance.SelectedItem.ToString())
            {
                case "Hawaiian Mist":
                    this.fragranceCost = 2.75M;
                    break;

                case "Baby Powder":
                    this.fragranceCost = 1.5M;
                    break;

                case "Country Floral":
                    this.fragranceCost = 2.25M;
                    break;

                case "Pina Colada":
                    this.fragranceCost = .75M;
                    break;

                case "Pine":
                    this.fragranceCost = 0M;
                    break;

                case "Vanilla":
                    this.fragranceCost = 2.0M;
                    break;
            }

            this.carWashInvoice = new CarWashInvoice(0.07M, 0.05M, packageCost, fragranceCost);

            // Binds Subtotal label
            this.subtotalSource = new BindingSource();
            this.subtotalSource.DataSource = this.carWashInvoice;

            this.lblSubtotal.DataBindings.Clear();
            
            // Formats the label: must create a Binding class
            Binding subtotalBind = new Binding("Text", this.subtotalSource, "SubTotal");
            this.lblSubtotal.DataBindings.Add(subtotalBind);

            subtotalBind.FormattingEnabled = true;
            subtotalBind.FormatString = "C";

            // Binds PST label
            this.pstSource = new BindingSource();
            this.pstSource.DataSource = this.carWashInvoice;

            this.lblProvincialSalesTax.DataBindings.Clear();

            Binding pstBind = new Binding("Text", this.pstSource, "ProvincialSalesTaxCharged");
            this.lblProvincialSalesTax.DataBindings.Add(pstBind);

            pstBind.FormattingEnabled = true;
            pstBind.FormatString = "N";

            // Binds GST label
            this.gstSource = new BindingSource();
            this.gstSource.DataSource = this.carWashInvoice;

            this.lblGoodsAndServicesTax.DataBindings.Clear();

            Binding gstBind = new Binding("Text", this.gstSource, "GoodsAndServicesTaxCharged");
            this.lblGoodsAndServicesTax.DataBindings.Add(gstBind);

            gstBind.FormattingEnabled = true;
            gstBind.FormatString = "N";

            // Binds Total label
            this.totalSource = new BindingSource();
            this.totalSource.DataSource = this.carWashInvoice;

            this.lblTotal.DataBindings.Clear();

            Binding totalBind = new Binding("Text", this.totalSource, "Total");
            this.lblTotal.DataBindings.Add(totalBind);

            totalBind.FormattingEnabled = true;
            totalBind.FormatString = "C";

        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Package combobox 
        /// </summary>
        private void CboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mnuToolsGenerateInvoice.Enabled = true;

            this.interiorServicesSource = new BindingSource();
            this.exteriorServicesSource = new BindingSource();
            this.subtotalSource = new BindingSource();

            switch (this.cboPackage.SelectedItem.ToString())
            {
                case "Standard":
                    this.interiorServicesSource.DataSource = this.interiorService1;
                    this.exteriorServicesSource.DataSource = this.exteriorService1;
                    this.packageCost = 7.50M;
                    break;

                case "Deluxe":
                    this.interiorServicesSource.DataSource = this.interiorService2;
                    this.exteriorServicesSource.DataSource = this.exteriorService2;
                    this.packageCost = 15.00M;
                    break;

                case "Executive":
                    this.interiorServicesSource.DataSource = this.interiorService3;
                    this.exteriorServicesSource.DataSource = this.exteriorService3;
                    this.packageCost = 35.00M;
                    break;

                case "Luxury":
                    this.interiorServicesSource.DataSource = this.interiorService4;
                    this.exteriorServicesSource.DataSource = this.exteriorService4;
                    this.packageCost = 55.00M;
                    break;
            }

            this.lstInterior.DataSource = this.interiorServicesSource;
            this.lstExterior.DataSource = this.exteriorServicesSource;

            this.carWashInvoice = new CarWashInvoice(0.07M, 0.05M, packageCost, fragranceCost);
            
            // Binds Subtotal label
            this.subtotalSource = new BindingSource();
            this.subtotalSource.DataSource = this.carWashInvoice;

            this.lblSubtotal.DataBindings.Clear();

            Binding subtotalBind = new Binding("Text", this.subtotalSource, "SubTotal");
            this.lblSubtotal.DataBindings.Add(subtotalBind);

            subtotalBind.FormattingEnabled = true;
            subtotalBind.FormatString = "C";

            // Binds PST label
            this.pstSource = new BindingSource();
            this.pstSource.DataSource = this.carWashInvoice;

            this.lblProvincialSalesTax.DataBindings.Clear();

            Binding pstBind = new Binding("Text", this.pstSource, "ProvincialSalesTaxCharged");
            this.lblProvincialSalesTax.DataBindings.Add(pstBind);

            pstBind.FormattingEnabled = true;
            pstBind.FormatString = "N";
            

            // Binds GST label
            this.gstSource = new BindingSource();
            this.gstSource.DataSource = this.carWashInvoice;

            this.lblGoodsAndServicesTax.DataBindings.Clear();

            Binding gstBind = new Binding("Text", this.gstSource, "GoodsAndServicesTaxCharged");
            this.lblGoodsAndServicesTax.DataBindings.Add(gstBind);

            gstBind.FormattingEnabled = true;
            gstBind.FormatString = "N";

            // Binds Total label
            this.totalSource = new BindingSource();
            this.totalSource.DataSource = this.carWashInvoice;

            this.lblTotal.DataBindings.Clear();

            Binding totalBind = new Binding("Text", this.totalSource, "Total");
            this.lblTotal.DataBindings.Add(totalBind);

            totalBind.FormattingEnabled = true;
            totalBind.FormatString = "C";
        }
    }
}


