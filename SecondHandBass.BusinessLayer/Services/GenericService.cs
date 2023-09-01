using AutoMapper;
using SecondHandBass.Core.Abstract;
using SecondHandBass.Core.DTOs.RequestDtos;
using SecondHandBass.Core.DTOs.ResponseDtos;
using SecondHandBass.Core.Helpers;
using SecondHandBass.Core.Repositories;
using SecondHandBass.Core.Services;
using System.Linq.Expressions;

namespace SecondHandBass.BusinessLayer.Services
{
    public class GenericService<TRequestDto, TEntity, TResponseDto> : IGenericService<TRequestDto, TEntity, TResponseDto> where TRequestDto : BaseRequestDto where TResponseDto : BaseResponseDto where TEntity : BaseEntity
    {
        private readonly IGenericRepository<TEntity> genericRepository;
        private readonly IMapper mapper;


        public GenericService(IGenericRepository<TEntity> genericRepository, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public Task<ResponseResult<TResponseDto>> AddEntity(TRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseResult<TResponseDto>> AddRangeAsync(IEnumerable<TRequestDto> entities)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseResult<TResponseDto>> DeleteAsync(TRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseResult<TResponseDto>> GetAllAsync(Expression<Func<TRequestDto, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseResult<TResponseDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseResult<TResponseDto>> RemoveRangeAsync(IEnumerable<TRequestDto> entities)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseResult<TResponseDto>> UpdateAsync(TRequestDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
