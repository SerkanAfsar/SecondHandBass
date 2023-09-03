using AutoMapper;
using SecondHandBass.Core.DTOs.RequestDtos;
using SecondHandBass.Core.DTOs.ResponseDtos;
using SecondHandBass.Core.Models;
using SecondHandBass.Core.Repositories;
using SecondHandBass.Core.Services;
using SecondHandBass.Core.UnitOfWorks;

namespace SecondHandBass.BusinessLayer.Services
{
    public class DistrictService : GenericService<DistrictRequestDto, District, DistrictResponseDto>, IDistrictService
    {
        public DistrictService(IGenericRepository<District> genericRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(genericRepository, mapper, unitOfWork)
        {
        }
    }
}
