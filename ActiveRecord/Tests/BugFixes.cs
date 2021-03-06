﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using SouthWind;

namespace SubSonic.Templates.ActiveRecord.Tests {
    public class BugFixes {

        /// <summary>
        /// Issue 22 from NathanB http://github.com/subsonic/SubSonic-3.0/issues#issue/22
        /// </summary>
        [Fact]
        public void Insertion_Of_NewRecord_With_StringPK_ShouldNot_Overwrite_KeyValue() {
            var customer = new Customer();
            customer.CustomerID = "ROBCO";
            customer.Address = "";
            customer.City = "";
            customer.CompanyName = "";
            customer.ContactName = "";
            customer.ContactTitle = "";
            customer.Country = "";
            customer.Phone = "";
            customer.PostalCode = "";
            customer.Region = "";
            customer.Save();


            Assert.NotNull(customer.CustomerID);
            Assert.Equal("ROBCO", customer.CustomerID);

            //delete
            Customer.Delete(x => x.CustomerID == "ROBCO");
        }

        /// <summary>
        /// Issue #66 from BlackMael http://github.com/subsonic/SubSonic-3.0/issues#issue/66
        /// </summary>
        [Fact]
        public void Get_Single_Record_Using_String_Comparison() {
            string contactName = "Mary Saveley";

            Customer myCustomer = null;

            var result = from c in Customer.All()
                         where c.ContactName == contactName
                         select c;

            myCustomer = result.FirstOrDefault();

            Assert.NotNull(myCustomer);
            Assert.Equal(contactName, myCustomer.ContactName);
        }
    }
}
