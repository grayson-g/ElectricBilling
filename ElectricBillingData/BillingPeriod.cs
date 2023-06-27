using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBillingData
{
    public readonly record struct FixedFee(string Name, decimal Amount);
    public class BillingPeriod
    {
        private List<FixedFee> _fixedFees;
        private decimal _pricePerKWh;

        public List<FixedFee> FixedFees { get => _fixedFees; }
        public decimal PricePerKWh { get => _pricePerKWh; }

        public BillingPeriod(decimal PricePerKWh)
        {
            _pricePerKWh = PricePerKWh;
            _fixedFees = new List<FixedFee>();
        }

        public BillingPeriod(decimal PricePerKWh, List<FixedFee> FixedFees)
        {
            _pricePerKWh = PricePerKWh;
            _fixedFees = FixedFees;
        }

        public decimal CalculateBilling(Customer customer)
        {
            decimal fixedFees = FixedFees.Sum(Fee => Fee.Amount);
            decimal powerFees = PricePerKWh * customer.PowerUsedKWh;

            return fixedFees + powerFees;
        }
    }
}
