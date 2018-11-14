using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using AppHome.Models;

namespace AppHome.Controllers
{
    public class BusinessTool
    {

        private ObservableCollection<BIApplication> _businessApplications;        
        public IAppRepository repository;

        public string username
        {
            get { return Environment.UserName; }
        }

        public ObservableCollection<BIApplication> BusinessApplications
        {
            get { return _businessApplications; }
            set { _businessApplications = value; }
        }
        

        public BusinessTool()
        {
            this.repository = new IAppRepository();
            BusinessApplications = new ObservableCollection<BIApplication>(repository.GetAppsForFramework());
        }





    }
}
