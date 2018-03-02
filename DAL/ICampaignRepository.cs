using Domain;

namespace DAL
{

    /// <summary>
    /// Repositorio generico para el acceso a las campañas
    /// </summary>
    public interface ICampaignRepository : IRepository<Campaign>
    {

        void Update(Campaign updatedCampaign);

    }
}
