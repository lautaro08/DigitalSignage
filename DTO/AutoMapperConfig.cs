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

                cfg.CreateMap<BannerSource, BannerSourceDTO>().ReverseMap();
                cfg.CreateMap<RssSource, RssSourceDTO>()
                    .IncludeBase<BannerSource, BannerSourceDTO>()
                    .ReverseMap();
                cfg.CreateMap<TextSource, TextSourceDTO>()
                    .IncludeBase<BannerSource, BannerSourceDTO>()
                    .ReverseMap();
                cfg.CreateMap<Campaign, CampaignDTO>().ReverseMap();
                cfg.CreateMap<Image, ImageDTO>().ReverseMap();
                cfg.CreateMap<Banner, BannerDTO>();
                cfg.CreateMap<BannerDTO, Banner>();
                cfg.CreateMap<RssItem, RssItemDTO>().ReverseMap();

            });
        }

    }
}
