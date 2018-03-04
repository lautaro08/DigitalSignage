using DAL.EntityFramework;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    [TestClass]
    public class BannerRepositoryTest
    {
        UnitOfWork unit = new UnitOfWork(new DigitalSignageDbContext("DigitalSignageTest"));

        [TestMethod]
        public void CreateBannerRepsoitory()
        {

            Banner newBannerRss = new Banner()
            {
                Name = "CatName1",
                Description = "Desc1",
                InitDate = new System.DateTime(2018, 2, 1),
                EndDate = new System.DateTime(2018, 2, 10),
                InitTime = new System.TimeSpan(),
                EndTime = new System.TimeSpan(1)
            };

            unit.BannerRepository.Add(newBannerRss);

            Banner newBannerTxt = new Banner()
            {
                Name = "CatName1",
                Description = "Desc1",
                InitDate = new System.DateTime(2018, 2, 1),
                EndDate = new System.DateTime(2018, 2, 10),
                InitTime = new System.TimeSpan(),
                EndTime = new System.TimeSpan(1)
            };

            unit.BannerRepository.Add(newBannerTxt);
            unit.Complete();

            IEnumerable<Banner> result = unit.BannerRepository.GetAll();


            IEnumerator<Banner> e = result.GetEnumerator();
            e.MoveNext();
            Assert.IsNotNull(e.Current);
        }


        [TestMethod]
        public void RemoveBannerRepsoitory()
        {
            Banner newBanner = new Banner()
            {
                Name = "CatName1",
                Description = "Desc1",
                InitDate = new System.DateTime(2018, 2, 1),
                EndDate = new System.DateTime(2018, 2, 10),
                InitTime = new System.TimeSpan(),
                EndTime = new System.TimeSpan(1),
            };

            unit.BannerRepository.Add(newBanner);
            unit.Complete();

            IEnumerable<Banner> result = unit.BannerRepository.GetAll();

            IEnumerator<Banner> e = result.GetEnumerator();
            e.MoveNext();
            Banner addedBanner = e.Current;

            unit.BannerRepository.Remove(addedBanner);
            unit.Complete();

            Assert.IsNull(unit.BannerRepository.Get(addedBanner.Id));
        }

        [TestMethod]
        public void GetBannerRepsoitory()
        {

            Banner result = unit.BannerRepository.Get(1);

            Assert.IsNotNull(result);
        }

    }
}
