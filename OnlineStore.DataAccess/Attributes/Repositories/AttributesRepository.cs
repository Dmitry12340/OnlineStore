using Microsoft.Extensions.Configuration;
using OnlineStore.AppServices.Attributes.Repositories;
using OnlineStore.DataAccess.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.Attributes.Repositories
{
    /// <summary>
    /// Репозиторий по работе с атрибутами.
    /// </summary>
    public class AttributesRepository : DapperRepositoryBase<Attribute>, IAttributesRepository
    {
        public AttributesRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
