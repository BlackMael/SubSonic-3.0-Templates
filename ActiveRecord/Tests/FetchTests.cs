// 
//   SubSonic - http://subsonicproject.com
// 
//   The contents of this file are subject to the New BSD
//   License (the "License"); you may not use this file
//   except in compliance with the License. You may obtain a copy of
//   the License at http://www.opensource.org/licenses/bsd-license.php
//  
//   Software distributed under the License is distributed on an 
//   "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or
//   implied. See the License for the specific language governing
//   rights and limitations under the License.
// 
using System.Linq;
using SouthWind;
using Xunit;

namespace SubSonic.Tests.ActiveRecord
{
  public class FetchTests
  {
    //[Fact]
    //public void ActiveRecord_Should_Load_Single_Product1_Through_Factory()
    //{
    //    var product = Product.SingleOrDefault(x => x.ProductID == 1);
    //    Assert.Equal(1, product.ProductID);
    //}

    //[Fact]
    //public void ActiveRecord_Should_Return_10_Products_LessOrEqual_To_10()
    //{
    //    var products = Product.Find(x => x.ProductID <= 10);
    //    Assert.Equal(10, products.Count);
    //}

    //[Fact]
    //public void ActiveRecord_Should_Return_10_Products_Paged()
    //{
    //    var products = Product.GetPaged(1, 10);
    //    Assert.Equal(10, products.Count);
    //    Assert.Equal(77, products.TotalCount);
    //}

    //[Fact]
    //public void ActiveRecord_Should_Return_20_Products_Using_SkipTake()
    //{
    //    var products = from p in Product.All()
    //                   join od in OrderDetail.All() on p.ProductID equals od.ProductID
    //                   select p;

    //    Assert.Equal(2155, products.Count());
    //}

    [Fact]
    public void ActiveRecord_Should_Return_X_Products_With_Category_4()
    {
      var products = Product.Find(p => p.CategoryID == 3);
      Assert.Equal(13, products.Count);
    }

    [Fact]
    public void ActiveRecord_Find_By_NonKey_Returns_5()
    {
      var orders = Order.Find(item => item.CustomerID == "VINET");
      Assert.Equal<int>(5,orders.Count);
    }

    [Fact]
    public void ActiveRecord_Find_By_NonKey_Returns_123()
    {
      var orders = Order.Find(item => item.EmployeeID == 1);
      Assert.Equal<int>(123, orders.Count);
    }
  }
}