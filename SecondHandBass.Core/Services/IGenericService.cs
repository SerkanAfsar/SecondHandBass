using SecondHandBass.Core.Abstract;
using SecondHandBass.Core.DTOs.RequestDtos;
using SecondHandBass.Core.DTOs.ResponseDtos;
using SecondHandBass.Core.Helpers;
using System.Linq.Expressions;

namespace SecondHandBass.Core.Services
{
    public interface IGenericService<TRequestDto, TEntity, TResponseDto> where TRequestDto : BaseRequestDto where TResponseDto : BaseResponseDto where TEntity : BaseEntity
    {
        Task<ResponseResult<TResponseDto>> GetByIdAsync(int id);
        Task<ResponseResult<TResponseDto>> GetAllAsync(Expression<Func<TRequestDto, bool>> predicate = null);
        Task<ResponseResult<TResponseDto>> AddEntity(TRequestDto entity);
        Task<ResponseResult<TResponseDto>> AddRangeAsync(IEnumerable<TRequestDto> entities);
        Task<ResponseResult<TResponseDto>> UpdateAsync(TRequestDto entity);
        Task<ResponseResult<TResponseDto>> DeleteAsync(TRequestDto entity);
        Task<ResponseResult<TResponseDto>> RemoveRangeAsync(IEnumerable<TRequestDto> entities);
    }
}
