using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TestService : ITestService
    {
        public string GetTestString()
        {
            return "TestService 2018";
        }

        public string GetUserNameByPhoneNumber(string phoneNumber)
        {
            using (var dbContext = new TestContext())
            {
                Customer customer= dbContext.Customers.First(c => c.CELLPHONENUMBER.Equals(phoneNumber));
                return customer.NAME;
            }
        }
    }
}
