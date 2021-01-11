using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ski_App_Repositories.Models;

namespace Ski_App_Application
{
    public interface ISkiFieldsRepository
    {
        Task Add(SkiFieldReview skiFieldName);
        Task<List<SkiFieldReview>> GetAll();

    }
}
