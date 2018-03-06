using DAL.EntityFramework;
using Domain;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
                Name = "banner rss",
                Description = "descripcion del banner",
                InitDate = new DateTime(2018, 2, 1),
                EndDate = new DateTime(2018, 2, 10),
                InitTime = new TimeSpan(),
                EndTime = new TimeSpan(1),
                Source = new RssSource()
                {

                    Description = "fuente rss",
                    Url = "Una url",
                    RssItems = new List<RssItem> {
                        new RssItem()
                        {
                            Description = "item rss",
                            Url = "una url",
                            Title = "titulo",
                            PublishingDate = DateTime.Now
                        }
                    }

                }
            };

            unit.BannerRepository.Add(newBannerRss);

            Banner newBannerTxt = new Banner()
            {
                Name = "banner texto",
                Description = "descripcion",
                InitDate = new DateTime(2018, 2, 1),
                EndDate = new DateTime(2018, 2, 10),
                InitTime = new TimeSpan(),
                EndTime = new TimeSpan(1),
                Source = new TextSource()
                {
                    Text = "texto de la fuente"
                }
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
