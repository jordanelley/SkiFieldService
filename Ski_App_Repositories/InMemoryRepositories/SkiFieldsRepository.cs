using System.Collections.Generic;
using System.Threading.Tasks;
using Ski_App_Application;
using Ski_App_Repositories.Models;

namespace Ski_App_Repositories.InMemoryRepositories
{
    public class SkiFieldsRepository : ISkiFieldsRepository
    {
        private readonly List<SkiFieldReview> _skiFields = new List<SkiFieldReview>();
        public Task Add(SkiFieldReview skiFieldName)
        {
            _skiFields.Add(skiFieldName);
            return Task.FromResult("success");
        }

        public Task<List<SkiFieldReview>> GetAll()
        {
            return Task.FromResult(_skiFields);
        }
    }
}