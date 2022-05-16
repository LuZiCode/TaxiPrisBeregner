using ClassLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace MyTaxiCalculater
{

    public class MyTaxiCalculaterTests
    {
        [Test]
        public void TestGetE_UpTo_5_km()
        {
            var t = new GetEBeregner(new TripDtoGetE() { Storvogn = true, ForventetKørtKm = 5m, ValgteTillæg = new List<TillægGetE>() });
            Assert.AreEqual(345m, t.MiniVanBeregner());
        }
        [Test]
        public void TestGetE_5_to_15km()
        {
            var t = new GetEBeregner(new TripDtoGetE() { Storvogn = true, ForventetKørtKm = 16m, ValgteTillæg = new List<TillægGetE>() });

            Assert.AreEqual(345m + (9 * 16), t.MiniVanBeregner());
        }
    }
}
