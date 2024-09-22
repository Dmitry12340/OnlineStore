using OnlineStore.AppServices.Attributes.Repositories;
using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Attributes.Repositories
{
    /// <summary>
    /// Репозиторий по работе с атрибутами.
    /// </summary>
    public sealed class AttributesRepository : EfRepositoryBase<ProductAttribute>, IAttributesRepository
    {
        public AttributesRepository(OnlineStoreDbContex dbContex) : base(dbContex)
        {
        }
    }
}
