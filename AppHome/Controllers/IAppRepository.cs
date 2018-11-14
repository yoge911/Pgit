using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppHome.Models;

namespace AppHome.Controllers
{
    public class IAppRepository
    {
        public string FrameWorkDir;
        public IAppRepository()
        {
            SetFrameWorkDirectory();
            
        }

        private void SetFrameWorkDirectory()
        {
            string FrameWorkDir = @"C:\Users\Yogesh\Documents\Visual Studio 2010\Projects\BELUGA_WeightData\BELUGA_WeightData\bin\x64\Debug";
            if (!Directory.Exists(FrameWorkDir))
            {
                throw new DirectoryNotFoundException("Path: " + FrameWorkDir + " not found!!");
            }
            else
            {
                this.FrameWorkDir = FrameWorkDir;
            }
        }

        public IEnumerable<BIApplication> GetAppsForFramework()
        {
            IEnumerable<BIApplication> FrameWorkApps = from fileName in Directory.EnumerateFiles(this.FrameWorkDir)
                                                       where fileName.Contains("vshost.exe") == false
                                                       where System.IO.Path.GetExtension(fileName).Equals(".exe")
                                                       select new BIApplication { path = this.FrameWorkDir, name = Path.GetFileName(fileName), fullPath = fileName };

            return FrameWorkApps;

        }
    }
}
