using DAL.EntityFramework;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    [TestClass]
    public class CampaignRepositoryTest
    {
        UnitOfWork unit = new UnitOfWork(new DigitalSignageDbContext());

        [TestMethod]
        public void CreateCampaignRepsoitory()
        {

            Campaign newCampaign = new Campaign()
            {
                Name = "CatName1",
                Description = "Desc1",
                InitDate = new System.DateTime(2018, 2, 1),
                EndDate = new System.DateTime(2018, 2, 10),
                InitTime = new System.TimeSpan(),
                EndTime = new System.TimeSpan(1),
                Images = new List<Image> {
                    new Image()
                    {
                        Description = "primer imagen",
                        Duration = 5,
                        Order = 1,
                        Bytes = File.ReadAllBytes("../../../assets/image.jpg")
                    },
                    new Image()
                    {
                        Description = "segunda imagen",
                        Duration = 4,
                        Order = 2,
                        Bytes = File.ReadAllBytes("../../../assets/image.jpg")
                    },
                    new Image()
                    {
                        Description = "tercera imagen",
                        Duration = 7,
                        Order = 3,
                        Bytes = File.ReadAllBytes("../../../assets/image.jpg")
                    }
                }
            };

            unit.CampaignRepository.Add(newCampaign);
            unit.Complete();

            IEnumerable<Campaign> result = unit.CampaignRepository.GetAll();

            IEnumerator<Campaign> e = result.GetEnumerator();
            e.MoveNext();
            Assert.IsNotNull(e.Current);
        }


        [TestMethod]
        public void RemoveCampaignRepsoitory()
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

        [TestMethod]
        public void GetCampaignRepsoitory()
        {

            Campaign result = unit.CampaignRepository.Get(1);

            Assert.IsNotNull(result);
        }

    }
}
