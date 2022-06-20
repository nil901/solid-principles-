using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
public class InsurancePremiumDiscountCalculator
    {
        public int CalculateDiscountPremiumPercent(ICustomerProfile customer)
        {
            if (customer.IsLoyalCustomer())
                return 20;
            else
                return 0;
        } 


    }

    public class HealthInsuranceCustomerProfile : ICustomerProfile
    {
        public Boolean IsLoyalCustomer()
        {
            //return true or false
            return true;
        }
    }

    public class MotorInsuranceCustomerProfile : ICustomerProfile
    {
        public Boolean IsLoyalCustomer()
        {
            //return true or false
            return true;
        }
    }
    public class HomeInsuranceCustomerProfile : ICustomerProfile
    {
        public Boolean IsLoyalCustomer()
        {
            //return true or false
            return true;
        }
    }

}
