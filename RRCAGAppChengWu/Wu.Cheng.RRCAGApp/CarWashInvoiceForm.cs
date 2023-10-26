/*
 * Name:Cheng Wu
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2022-11-26
 * Updated: 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wu.Cheng.Business;

namespace Wu.Cheng.RRCAGApp
{
    /// <summary>
    /// Represents a CarWashInvoiceForm form
    /// </summary>
    internal class CarWashInvoiceForm : ACE.BIT.ADEV.Forms.CarWashInvoiceForm
    {
        private BindingSource packagePriceSource;
        private BindingSource fragrancePriceSource;
        private BindingSource subTotalSource;
        private BindingSource pstSource;
        private BindingSource gstSource;
        private BindingSource totalSource;

        private CarWashInvoice carWashInvoice;

        /// <summary>
        /// Initializes an instance of CarWashInvoiceForm class
        /// </summary>
        public CarWashInvoiceForm(CarWashInvoice carWashInvoice)// This overloaded constructor helps to get in the carWashInvoice object from the form CarWashForm
        {
            this.Text = "Car Wash Invoice";
            this.carWashInvoice = carWashInvoice;

            // Binds Package Price label
            this.packagePriceSource = new BindingSource();
            this.packagePriceSource.DataSource = this.carWashInvoice;

            Binding packagePriceBind = new Binding("Text", this.packagePriceSource, "PackageCost");
            this.lblPackagePrice.DataBindings.Add(packagePriceBind);

            packagePriceBind.FormattingEnabled = true;
            packagePriceBind.FormatString = "C";

            // Binds Fragrance Price label
            this.fragrancePriceSource = new BindingSource();
            this.fragrancePriceSource.DataSource = this.carWashInvoice;

            Binding fragrancePriceBind = new Binding("Text", this.fragrancePriceSource, "FragranceCost");
            this.lblFragrancePrice.DataBindings.Add(fragrancePriceBind);

            fragrancePriceBind.FormattingEnabled = true;
            fragrancePriceBind.FormatString = "N";

            // Binds Subtotal label
            this.subTotalSource = new BindingSource();
            this.subTotalSource.DataSource = this.carWashInvoice;

            Binding subtotalBind = new Binding("Text", this.subTotalSource, "SubTotal");
            this.lblSubtotal.DataBindings.Add(subtotalBind);

            subtotalBind.FormattingEnabled = true;
            subtotalBind.FormatString = "C";

            // Binds PST label
            this.pstSource = new BindingSource();
            this.pstSource.DataSource = this.carWashInvoice;

            Binding pstBind = new Binding("Text", this.pstSource, "ProvincialSalesTaxCharged");
            this.lblProvincialSalesTax.DataBindings.Add(pstBind);

            pstBind.FormattingEnabled = true;
            pstBind.FormatString = "N";

            // Binds GST label
            this.gstSource = new BindingSource();
            this.gstSource.DataSource = this.carWashInvoice;

            Binding gstBind = new Binding("Text", this.gstSource, "GoodsAndServicesTaxCharged");
            this.lblGoodsAndServicesTax.DataBindings.Add(gstBind);

            gstBind.FormattingEnabled = true;
            gstBind.FormatString = "N";

            // Binds Total label
            this.totalSource = new BindingSource();
            this.totalSource.DataSource = this.carWashInvoice;

            Binding totalBind = new Binding("Text", this.totalSource, "Total");
            this.lblTotal.DataBindings.Add(totalBind);

            totalBind.FormattingEnabled = true;
            totalBind.FormatString = "C";
        }
    }
}
