using Microsoft.Extensions.DependencyInjection;
using SecondHandBass.BusinessLayer.Mappers;
using SecondHandBass.BusinessLayer.Services;
using SecondHandBass.Core.Repositories;
using SecondHandBass.Core.Services;
using SecondHandBass.Core.UnitOfWorks;
using SecondHandBass.DataAccessLayer.Repositories;
using SecondHandBass.DataAccessLayer.UnitOfWorks;

namespace SecondHandBass.BusinessLayer.Configurations
{
    public static class CustomConfigurations
    {
        public static IServiceCollection ConfigureConstantServices(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddAutoMapper(typeof(CustomMapper).Assembly);
            return services;
        }

        public static IServiceCollection ConfigureRespositories(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAdvertisementPictureRepository, AdvertisementPictureRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IConversationMessageRepository, ConversationMessageRepository>();
            services.AddScoped<IConversationRepository, ConversationRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddScoped(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddScoped<IAdvertisementPictureService, AdvertisementPictureService>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IConversationMessageService, ConversationMessageService>();
            services.AddScoped<IConversationService, ConversationService>();
            services.AddScoped<IDistrictService, DistrictService>();
            services.AddScoped<IModelService, ModelService>();

            return services;
        }
    }
}
