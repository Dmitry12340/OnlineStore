using AutoMapper;
using OnlineStore.AppServices.Attributes.Repositories;
using OnlineStore.AppServices.Common.Redis;
using OnlineStore.Contracts;

namespace OnlineStore.AppServices.Attributes.Services
{
    /// <summary>
    /// Сервис по работе с атрибутами продукта.
    /// </summary>
    public class ProductAttributeService : IProductAttributeService
    {
        private readonly IAttributesRepository _attributesRepository;
        private readonly IMapper _mapper;
        private readonly IRedisCache _redisCache;

        /// <inheritdoc/>
        public ProductAttributeService(
            IAttributesRepository attributesRepository,
            IMapper mapper,
            IRedisCache redisCache)
        {
            _attributesRepository = attributesRepository;
            _mapper = mapper;
            _redisCache = redisCache;
        }

        /// <inheritdoc/>
        public async Task<ProductAttributeDto> GetAsync(int id)
        {
            var cacheValue = await _redisCache.GetAsync($"ProductAttributes_{id}");

            if ( cacheValue != null)
            {
                return new ProductAttributeDto
                {
                    Id = id,
                    FullAttributeName = cacheValue
                };
            }

            var attribute = await _attributesRepository.GetAsync(id)
                ?? throw new Exception($"Не найден атрибус с id = {id}");

            var dto = _mapper.Map<ProductAttributeDto>(attribute);

            await _redisCache.SetStringAsync($"ProductAttributes_{dto.Id}", $"{dto.FullAttributeName}");

            return dto;
        }
    }
}
