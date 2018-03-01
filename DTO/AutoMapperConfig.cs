using AutoMapper;
using Domain;

namespace DTO
{

    /// <summary>
    /// Clase de configuracion para realizar los mapeos de las clases a sus DTOs
    /// </summary>
    public static class AutoMapperConfig
    {

        /// <summary>
        /// inicializa las configuraciones
        /// </summary>
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => {

                cfg.CreateMap<Campaign, CampaignDTO>();

                //Para que no mapee las imagenes desde el DTO, hay que hacerlo a mano
                cfg.CreateMap<Campaign, CampaignDTO>();

                cfg.CreateMap<Image, ImageDTO>().ReverseMap();
                cfg.CreateMap<Banner, BannerDTO>().ReverseMap();
                cfg.CreateMap<BannerRss, BannerRssDTO>().ReverseMap();
                cfg.CreateMap<RssItem, RssItemDTO>().ReverseMap();
                cfg.CreateMap<BannerText, BannerTextDTO>().ReverseMap();

            });
        }

    }
}
