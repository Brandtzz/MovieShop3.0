using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreDAL;
using NUnit.Framework;

namespace MovieStoreCustomerTest
{
    [TestFixture]
    class CurrencyConverterTest
    {    [Test]
    public void ConvertToEuroTest()
        {
         Movie movie = new Movie() {Id = 1, Title= "Hest",Price = 200};
        double euro = MovieStoreDAL.CurencyConverter.euro;
        double converted = movie.Price*euro;
        Assert.AreEqual(converted,MovieStoreDAL.CurencyConverter.EuroConverter(movie));

        }
        [Test]
    public void ConvertToDollarsTest()
    {
        Movie movie = new Movie() { Id = 1, Title = "Hest", Price = 200 };
        double dollar = MovieStoreDAL.CurencyConverter.dollar;
        double converted = movie.Price * dollar;
        Assert.AreEqual(converted, MovieStoreDAL.CurencyConverter.DollarConverter(movie));
    }
  }
   


}
