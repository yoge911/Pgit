using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHome
{
    public interface IFrameWorkApp
    {
        string path { get; set; }
        string name { get; set; } 
        string fullPath { get; set; }
        string displayName { get; set; }
    }




 


}
