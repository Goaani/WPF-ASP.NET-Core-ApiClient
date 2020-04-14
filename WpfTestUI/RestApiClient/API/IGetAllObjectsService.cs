using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTestUI.RestApiClient.Models;

namespace WpfTestUI.RestApiClient.API
{
    public interface IGetAllObjectsService
    {
        Task<IEnumerable<Country>> GetAllCountries();
    }
}
