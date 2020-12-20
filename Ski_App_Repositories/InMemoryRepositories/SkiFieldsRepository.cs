using System.Collections.Generic;
using System.Threading.Tasks;
using Ski_App_Application;

namespace Ski_App_Repositories.InMemoryRepositories
{
    public class SkiFieldsRepository : ISkiFieldsRepository
    {
        private readonly List<string> _skiFields = new List<string>();
        public Task Add(string skiFieldName)
        {
            _skiFields.Add(skiFieldName);
            return Task.FromResult<object>(null);
        }

        public Task<List<string>> GetAll()
        {
            return Task.FromResult(_skiFields);
        }
    }
}