using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Infrastructure.Services
{
    public interface IService
    {
        public Task<T> Get<T>(string id) where T : class;

    }
}
