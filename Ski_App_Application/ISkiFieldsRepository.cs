using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ski_App_Application
{
    public interface ISkiFieldsRepository
    {
        Task Add(string skiFieldName);
        Task<List<string>> GetAll();

    }
}
