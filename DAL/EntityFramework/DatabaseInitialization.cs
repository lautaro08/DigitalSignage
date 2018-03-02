using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    class DatabaseInitialization : DropCreateDatabaseAlways<DigitalSignageDbContext>
    {

        protected override void Seed(DigitalSignageDbContext pContext)
        {

            pContext.Campaigns.Add(new Campaign()
            {
                Name = "CatName1",
                Description = "Desc1",
                InitDate = new DateTime(2018, 2, 1),
                EndDate = new DateTime(2018, 2, 10),
                InitTime = new TimeSpan(0,8,0,0,0),
                EndTime = new TimeSpan(0,12,0,0,0),
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
            });

            base.Seed(pContext);
        }
    }
}
