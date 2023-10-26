/*
 * Name: Cheng Wu
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2022-09-24
 * Updated: 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Wu.Cheng.Business
{
    /// <summary>
    /// Represents a sale quote.
    /// </summary>
    public class SalesQuote
    {
        private decimal vehicleSalePrice;
        private decimal tradeInAmount;
        private decimal salesTaxRate;
        private Accessories accessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;

        /// <summary>
        /// Gets and sets the sale price of the vehicle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the sale price of the vehicle is set to less than or equal to 0.
        /// </exception>
        public decimal VehicleSalePrice
        {
            get
            {
                return this.vehicleSalePrice;
            }

            set
            {
                if (value <= 0M)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than or equal to 0.");
                }

                this.vehicleSalePrice = value;
            }
        }

        /// <summary>
        /// Gets and sets the trade in amount.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the trade in amount is set to less than 0.
        /// </exception>
        public decimal TradeInAmount
        {
            get
            {
                return this.tradeInAmount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }

                this.tradeInAmount = value;
            }
        }

        /// <summary>
        /// Gets and sets the accessories that were chosen.
        /// </summary>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown when the chosen accessories are set to an invalid value.
        /// </exception>
        public Accessories AccessoriesChosen
        {
            get
            {
                return this.accessoriesChosen;
            }

            set
            {
                if (!Enum.IsDefined(typeof(Accessories), value))
                {
                    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value.");
                }

                this.accessoriesChosen = value;
            }
        }

        /// <summary>
        /// Gets and sets the exterior finish that was chosen.
        /// </summary>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown when the chosen exterior finish is set to an invalid value.
        /// </exception>
        public ExteriorFinish ExteriorFinishChosen
        {
            get
            {
                return this.exteriorFinishChosen;
            }

            set
            {
                if (!Enum.IsDefined(typeof(ExteriorFinish), value))
                {
                    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value.");
                }

                this.exteriorFinishChosen = value;
            }
        }
        /// <summary>
        /// Gets the cost of accessories chosen.
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {
                const decimal StereoSystemCost = 505.05M;
                const decimal LeatherInteriorCost = 1010.10M;
                const decimal ComputerNavigationCost = 1515.15M;
                decimal accessoriesCost = 0.00M;

                switch (accessoriesChosen)
                {

                    case Accessories.StereoSystem:
                        accessoriesCost = StereoSystemCost;
                        break;

                    case Accessories.LeatherInterior:
                        accessoriesCost = LeatherInteriorCost;

                        break;

                    case Accessories.StereoAndLeather:
                        accessoriesCost = StereoSystemCost + LeatherInteriorCost;
                        break;

                    case Accessories.ComputerNavigation:
                        accessoriesCost = ComputerNavigationCost;
                        break;

                    case Accessories.StereoAndNavigation:
                        accessoriesCost = StereoSystemCost + ComputerNavigationCost;
                        break;

                    case Accessories.LeatherAndNavigation:
                        accessoriesCost = LeatherInteriorCost + ComputerNavigationCost;
                        break;

                    case Accessories.All:
                        accessoriesCost = StereoSystemCost + LeatherInteriorCost + ComputerNavigationCost;
                        break;

                    case Accessories.None:
                        break;
                }

                return accessoriesCost;
            }
        }

        /// <summary>
        /// Gets the cost of the exterior finish chosen.
        /// </summary>
        public decimal FinishCost
        {
            get
            {
                const decimal StandardCost = 202.02M;
                const decimal PearlizedCost = 404.04M;
                const decimal CustomCost = 606.06M;
                decimal exteriorFinishCost = 0.00M;

                switch (exteriorFinishChosen)
                {
                    case ExteriorFinish.Standard:
                        exteriorFinishCost = StandardCost;
                        break;

                    case ExteriorFinish.Pearlized:
                        exteriorFinishCost = PearlizedCost;
                        break;

                    case ExteriorFinish.Custom:
                        exteriorFinishCost = CustomCost;
                        break;

                    case ExteriorFinish.None:
                        break;
                }

                return exteriorFinishCost;
            }
        }
        /// <summary>
        /// Gets the sum of the cost of the chosen accessories and exterior finish(rounded to two decimal places).
        /// </summary>
        public decimal TotalOptions
        {
            get
            {
                return Math.Round( this.AccessoryCost + this.FinishCost , 2);
            }
        }

        /// <summary>
        /// Gets the sum of the vehicle's sale price and the Accessory and Finish Cost(rounded to two decimal places).
        /// </summary>
        public decimal SubTotal
        {
            get
            {
                return Math.Round(this.VehicleSalePrice + this.TotalOptions, 2);
            }
        }

        /// <summary>
        /// Gets the amount of tax to charge based on the subtotal(rounded to two decimal places).
        /// </summary>
        public decimal SalesTax
        {
            get
            {
                return Math.Round(this.salesTaxRate * this.SubTotal, 2);
            }
        }

        /// <summary>
        /// Gets the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                return (this.SubTotal + this.SalesTax);
            }
        }

        /// <summary>
        /// Gets the result of subtracting the trade-in amount from the total(rounded to two decimal places).
        /// </summary>
        public decimal AmountDue
        {
            get
            {
                return Math.Round(this.Total - this.TradeInAmount, 2);
            }
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in value, sales tax rate, accessories chosen and exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice"></param>
        /// <param name="tradeInAmount"></param>
        /// <param name="salesTaxRate"></param>
        /// <param name="accessoriesChosen"></param>
        /// <param name="exteriorFinishChosen"></param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the vehicle sale price is less than or equal to 0 or the trade in amount is less than 0 or
        /// the sales tax rate is less than 0 or greater than 1.
        /// </exception>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown when the accessories chosen is an invalid argument or the exterior finish chosen is an invalid argument.
        /// </exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            if (vehicleSalePrice <= 0)
            {
                throw new ArgumentOutOfRangeException("vehicleSalePrice", "The argument cannot be less than or equal to 0. ");
            }

            if (tradeInAmount < 0)
            {
                throw new ArgumentOutOfRangeException("tradeInAmount", "The argument cannot be less than 0.");
            }

            if (salesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("salesTaxRate", "The argument cannot be less than 0.");
            }

            if (salesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("salesTaxRate", "The argument cannot be greater than 1.");
            }

            if (!Enum.IsDefined(typeof(Accessories), accessoriesChosen))
            {
                throw new InvalidEnumArgumentException("The argument is an invalid enumeration value.");
            }

            if (!Enum.IsDefined(typeof(ExteriorFinish), exteriorFinishChosen))
            {
                throw new InvalidEnumArgumentException("The argument is an invalid enumeration value.");
            }

            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in amount, sales tax rate,
        /// no accessories chosen and no exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice"></param>
        /// <param name="tradeInAmount"></param>
        /// <param name="salesTaxRate"></param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the vehicle sale price is less than or equal to 0 or the trade in amount is less than 0 or
        /// the sales tax rate is less than 0 or greater than 1.
        /// </exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate) : this(vehicleSalePrice, tradeInAmount, salesTaxRate, Accessories.None, ExteriorFinish.None)
        {
            // No further implementation.
        }
    }
}
