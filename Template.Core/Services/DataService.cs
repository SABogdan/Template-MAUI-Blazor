using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Core.Services
{
    public class DataService : IDataService
    {
        public async Task<List<string>> GetData()
        {
            return await Task.Run(() => new List<string> { "Data 1", "Data 2", "Data 3" });
        }
    }
}
