using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using DTO;
using DAL.EntityFramework;
using System.Collections.Generic;
using Domain;

namespace Test
{
    [TestClass]
    public class BannerServiceTest
    {

        public BannerServiceTest()
        {
            AutoMapperConfig.RegisterMappings();
        }

        [TestMethod]
        public void CreateBannerService()
        {

            var uow = new UnitOfWork(new DigitalSignageDbContext("DigitalSignageTest"));

            BannerService cS = new BannerService();

            BannerDTO BannerDTO = new BannerDTO();

            BannerDTO.Name = "nueva campaña";
            BannerDTO.Description = "qsy";
            BannerDTO.InitDate = new DateTime().AddYears(2018);
            BannerDTO.EndDate = new DateTime().AddYears(2018);
            BannerDTO.InitTime = new TimeSpan();
            BannerDTO.EndTime = new TimeSpan();
            BannerDTO.Source = new RssSourceDTO()
            {

                Description = "fuente rss",
                Url = "Una url",
                RssItems = new List<RssItemDTO> {
                        new RssItemDTO()
                        {
                            Description = "item rss",
                            Url = "una url",
                            Title = "titulo",
                            PublishingDate = DateTime.Now
                        }
                    }

            };

            try
            {

                cS.Create(BannerDTO);
                var result = cS.GetAll();
                
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);

            }

        }

        [TestMethod]
        public void RemoveBannerService()
        {

            var uow = new UnitOfWork(new DigitalSignageDbContext("DigitalSignageTest"));

            BannerService cS = new BannerService();

            Banner Banner = new Banner();

            Banner.Name = "nueva campaña";
            Banner.Description = "qsy";
            Banner.InitDate = new DateTime().AddYears(2018);
            Banner.EndDate = new DateTime().AddYears(2018);
            Banner.InitTime = new TimeSpan();
            Banner.EndTime = new TimeSpan();

            uow.BannerRepository.Add(Banner);
            uow.Complete();

            var BannerDTO = new BannerDTO();
            AutoMapper.Mapper.Map(Banner, BannerDTO);

            try
            {

                cS.Remove(BannerDTO);

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);

            }

        }

        [TestMethod]
        public void UpdateBannerService()
        {

            var uow = new UnitOfWork(new DigitalSignageDbContext("DigitalSignageTest"));

            BannerService cS = new BannerService();

            Banner Banner = new Banner();

            Banner.Name = "nueva campaña";
            Banner.Description = "qsy";
            Banner.InitDate = new DateTime().AddYears(2018);
            Banner.EndDate = new DateTime().AddYears(2018);
            Banner.InitTime = new TimeSpan();
            Banner.EndTime = new TimeSpan();

            uow.BannerRepository.Add(Banner);
            uow.Complete();

            var BannerDTO = new BannerDTO();
            AutoMapper.Mapper.Map(Banner, BannerDTO);

            BannerDTO.Name = "campaña modificada";
            BannerDTO.Description = "descripcion modificada";

            try
            {

                cS.Update(BannerDTO);
                var updatedBanner = uow.BannerRepository.Get(BannerDTO.Id);

                StringAssert.Equals("campaña modificada", updatedBanner.Name);
                StringAssert.Equals("descripcion modificada", updatedBanner.Description);

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);

            }

        }

        [TestMethod]
        public void GetBannerService()
        {

            var uow = new UnitOfWork(new DigitalSignageDbContext("TestDigitalSignageTest"));

            BannerService cS = new BannerService();

            Banner Banner = new Banner();

            Banner.Name = "nueva campaña";
            Banner.Description = "qsy";
            Banner.InitDate = new DateTime().AddYears(2018);
            Banner.EndDate = new DateTime().AddYears(2018);
            Banner.InitTime = new TimeSpan();
            Banner.EndTime = new TimeSpan();

            uow.BannerRepository.Add(Banner);
            uow.Complete();

            try
            {

                var result = cS.Get(Banner.Id);
                Assert.IsNotNull(result);

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);

            }

        }

        [TestMethod]
        public void GetAllBannerService()
        {

            var uow = new UnitOfWork(new DigitalSignageDbContext("DigitalSignageTest"));

            BannerService bS = new BannerService();

            IEnumerable<BannerDTO> result = bS.GetAll();


            IEnumerator<BannerDTO> e = result.GetEnumerator();
            e.MoveNext();
            Assert.IsNotNull(e.Current);

        }

    }
}
