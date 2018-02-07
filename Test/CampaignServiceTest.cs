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
    public class CampaignServiceTest
    {

        public CampaignServiceTest()
        {
            AutoMapperConfig.RegisterMappings();
        }

        [TestMethod]
        public void CreateCampaignService()
        {

            var uow = new UnitOfWork(new DigitalSignageDbContext("Test"));

            CampaignService cS = new CampaignService(uow);

            CampaignDTO campaignDTO = new CampaignDTO();

            campaignDTO.Name = "nueva campaña";
            campaignDTO.Description = "qsy";
            campaignDTO.InitDate = new DateTime().AddYears(2018);
            campaignDTO.EndDate = new DateTime().AddYears(2018);
            campaignDTO.InitTime = new TimeSpan();
            campaignDTO.EndTime = new TimeSpan();

            try
            {

                cS.Create(campaignDTO);
                
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);

            }

        }

        [TestMethod]
        public void RemoveCampaignService()
        {

            var uow = new UnitOfWork(new DigitalSignageDbContext("Test"));

            CampaignService cS = new CampaignService(uow);

            Campaign campaign = new Campaign();

            campaign.Name = "nueva campaña";
            campaign.Description = "qsy";
            campaign.InitDate = new DateTime().AddYears(2018);
            campaign.EndDate = new DateTime().AddYears(2018);
            campaign.InitTime = new TimeSpan();
            campaign.EndTime = new TimeSpan();

            uow.CampaignRepository.Add(campaign);
            uow.Complete();

            var campaignDTO = new CampaignDTO();
            AutoMapper.Mapper.Map(campaign, campaignDTO);

            try
            {

                cS.Remove(campaignDTO);

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);

            }

        }

        [TestMethod]
        public void UpdateCampaignService()
        {

            var uow = new UnitOfWork(new DigitalSignageDbContext("Test"));

            CampaignService cS = new CampaignService(uow);

            Campaign campaign = new Campaign();

            campaign.Name = "nueva campaña";
            campaign.Description = "qsy";
            campaign.InitDate = new DateTime().AddYears(2018);
            campaign.EndDate = new DateTime().AddYears(2018);
            campaign.InitTime = new TimeSpan();
            campaign.EndTime = new TimeSpan();

            uow.CampaignRepository.Add(campaign);
            uow.Complete();

            var campaignDTO = new CampaignDTO();
            AutoMapper.Mapper.Map(campaign, campaignDTO);

            campaignDTO.Name = "campaña modificada";
            campaignDTO.Description = "descripcion modificada";

            try
            {

                cS.Update(campaignDTO);
                var updatedCampaign = uow.CampaignRepository.Get(campaignDTO.Id);

                StringAssert.Equals("campaña modificada", updatedCampaign.Name);
                StringAssert.Equals("descripcion modificada", updatedCampaign.Description);

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);

            }

        }

        [TestMethod]
        public void GetCampaignService()
        {

            var uow = new UnitOfWork(new DigitalSignageDbContext("Test"));

            CampaignService cS = new CampaignService(uow);

            Campaign campaign = new Campaign();

            campaign.Name = "nueva campaña";
            campaign.Description = "qsy";
            campaign.InitDate = new DateTime().AddYears(2018);
            campaign.EndDate = new DateTime().AddYears(2018);
            campaign.InitTime = new TimeSpan();
            campaign.EndTime = new TimeSpan();

            uow.CampaignRepository.Add(campaign);
            uow.Complete();

            try
            {

                var result = cS.Get(campaign.Id);
                Assert.IsNotNull(result);

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);

            }

        }

    }
}
