using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.EntityFramework;
using Domain;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class CampaignRepositoryTest
    {
        UnitOfWork unit = new UnitOfWork(new DigitalSignageDbContext());

        [TestMethod]
        public void CreateCampaign()
        {

            Campaign newCampaign = new Campaign()
            {
                Name = "CatName1",
                Description = "Desc1",
                InitDate = new System.DateTime(2018, 2, 1),
                EndDate = new System.DateTime(2018, 2, 10),
                InitTime = new System.TimeSpan(),
                EndTime = new System.TimeSpan(1),
            };

            unit.CampaignRepository.Add(newCampaign);
            unit.Complete();

            IEnumerable<Campaign> result = unit.CampaignRepository.GetAll();

            IEnumerator<Campaign> e = result.GetEnumerator();
            e.MoveNext();
            Assert.IsNotNull(e.Current);
        }


        [TestMethod]
        public void RemoveCampaign()
        {
            Campaign newCampaign = new Campaign()
            {
                Name = "CatName1",
                Description = "Desc1",
                InitDate = new System.DateTime(2018, 2, 1),
                EndDate = new System.DateTime(2018, 2, 10),
                InitTime = new System.TimeSpan(),
                EndTime = new System.TimeSpan(1),
            };

            unit.CampaignRepository.Add(newCampaign);
            unit.Complete();

            IEnumerable<Campaign> result = unit.CampaignRepository.GetAll();

            IEnumerator<Campaign> e = result.GetEnumerator();
            e.MoveNext();
            Campaign addedCampaign = e.Current;

            unit.CampaignRepository.Remove(addedCampaign);
            unit.Complete();

            Assert.IsNull(unit.CampaignRepository.Get(addedCampaign.Id));
        }
    }
}
