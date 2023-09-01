using SecondHandBass.Core.DTOs.RequestDtos;
using SecondHandBass.Core.DTOs.ResponseDtos;
using SecondHandBass.Core.Models;

namespace SecondHandBass.Core.Services
{
    public interface IModelService : IGenericService<ModelRequestDto, Model, ModelResponseDto>
    {
    }
}
