/*
 * Name: Cheng Wu
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2022-09-24
 * Updated: 
 */

using System;

namespace Wu.Cheng.Business
{
    /// <summary>
    /// Represents a CarWashInvoice.
    /// </summary>
    public class CarWashInvoice : Invoice
    {
        private decimal packageCost;
        private decimal fragranceCost;

        /// <summary>
        /// Gets and sets the amount charged for the chosen package.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the packageCost is set to less than 0.
        /// </exception>
        public decimal PackageCost
        {
            get
            {
                return this.packageCost;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }

                this.packageCost = value;
            }
        }

        /// <summary>
        /// Gets and sets the amount charged for the chosen fragrance.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the fragranceCost is set to less than 0.
        /// </exception>
        public decimal FragranceCost
        {
            get
            {
                return this.fragranceCost;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }

                this.fragranceCost = value;
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                return 0.00M;
            }
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer(rounded to 2 decimal places).
        /// </summary>
        public override decimal GoodsAndServicesTaxCharged
        {
            get
            {
                return Math.Round(this.GoodsAndServicesTaxRate * this.SubTotal, 2);
            }
        }

        /// <summary>
        /// Gets the subtotal of the Invoice.
        /// </summary>
        public override decimal SubTotal
        {
            get
            {
                return this.packageCost + this.fragranceCost;
            }
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a specified provincial and goods and services tax rates. The package cost and fragrance cost are 0.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the provincial sales tax rate is less than 0 or greater than 1 or the goods and services tax rate is less than 0 or greater than 1.
        /// </exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            this.packageCost = 0M;
            this.fragranceCost = 0M;
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a specified provincial and goods and services tax rate and package cost and fragrance cost.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        /// <param name="packageCost">The cost of the chosen package.</param>
        /// <param name="fragranceCost">The cost of the chosen fragrance.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the provincial sales tax rate is less than 0 or greater than 1 or the goods and services tax rate is less than 0 or greater than 1 or
        /// the package cost is less than 0 or the fragrance cost is less than 0.
        /// </exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate, decimal packageCost, decimal fragranceCost) 
            : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            if(packageCost < 0)
            {
                throw new ArgumentOutOfRangeException("packageCost", "The argument cannot be less than 0.");
            }

            if(fragranceCost < 0)
            {
                throw new ArgumentOutOfRangeException("fragranceCost", "The argument cannot be less than 0.");
            }

            this.packageCost = packageCost;
            this.fragranceCost = fragranceCost;
        }
    }
}