﻿using AutoMapper;
using SecondHandBass.Core.DTOs.RequestDtos;
using SecondHandBass.Core.DTOs.ResponseDtos;
using SecondHandBass.Core.Models;
using SecondHandBass.Core.Repositories;
using SecondHandBass.Core.Services;
using SecondHandBass.Core.UnitOfWorks;

namespace SecondHandBass.BusinessLayer.Services
{
    public class CityService : GenericService<CityRequestDto, City, CityResponseDto>, ICityService
    {
        public CityService(IGenericRepository<City> genericRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(genericRepository, mapper, unitOfWork)
        {
        }
    }
}
