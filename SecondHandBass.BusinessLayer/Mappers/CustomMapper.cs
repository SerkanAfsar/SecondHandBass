using AutoMapper;
using SecondHandBass.Core.DTOs.RequestDtos;
using SecondHandBass.Core.DTOs.ResponseDtos;
using SecondHandBass.Core.Models;

namespace SecondHandBass.BusinessLayer.Mappers
{
    public class CustomMapper : Profile
    {
        public CustomMapper()
        {
            CreateMap<AdvertisementRequestDto, Advertisement>();
            CreateMap<Advertisement, AdvertisementResponseDto>();

            CreateMap<AdvertisementPictureRequestDto, AdvertisementPicture>();
            CreateMap<AdvertisementPicture, AdvertisementPictureResponseDto>();

            CreateMap<BrandRequestDto, Brand>();
            CreateMap<Brand, BrandResponseDto>();

            CreateMap<CityRequestDto, City>();
            CreateMap<City, CityResponseDto>();

            CreateMap<ConversationMessageRequestDto, ConversationMessage>();
            CreateMap<ConversationMessage, ConversationMessageResponseDto>();

            CreateMap<ConversationRequestDto, Conversation>();
            CreateMap<Conversation, ConversationResponseDto>();

            CreateMap<DistrictRequestDto, District>();
            CreateMap<District, DistrictResponseDto>();

            CreateMap<ModelRequestDto, Model>();
            CreateMap<Model, ModelResponseDto>();

        }
    }
}
