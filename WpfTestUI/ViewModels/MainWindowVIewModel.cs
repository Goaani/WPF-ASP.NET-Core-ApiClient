using CommonMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfTestUI.HttpService;

namespace WpfTestUI.ViewModels
{
    using DemoClient;
    using MVVMCore.Helpers;
    using System.Collections.ObjectModel;
    using WpfTestUI.RestApiClient.API.Models;

    class MainWindowVIewModel : BaseViewModel
    {
        public ObservableCollection<Person> Persons {get;set;}
        
        public MainWindowVIewModel()
        {
            var _client = new ApiClient("https://localhost:44344", new System.Net.Http.HttpClient());
            var collection = _client.PersonGetAsync().Result.ToList();
            Persons = new ObservableCollection<Person>(collection);

            //GetAllCountryObjectsService.GetAllCountries();
            //GetAllCountryObjectsService.GetAllPersons();
        }
    }
}
