using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppHome.Models
{
    public class BIApplication : IFrameWorkApp, INotifyPropertyChanged
    {
        private string _path;
        private string _name;
        private string _fullPath;
        private string _displayName;
        private string _firstLetter;

        public string path
        {
            get
            {
                return this._path;
            }

            set
            {
                if(value != this._path)
                {
                    this._path = value; 
                    NotifyPropertyChanged();
                }
                

            }
        }

        public string name
        {
            get
            {
                return this._name;
            }

            set
            {
                if(value != this._name)
                {
                    this._name = value.Substring(0, value.Length - 4);
                    this._firstLetter = this.name.ToUpper()[0].ToString();
                    NotifyPropertyChanged();
                }
                
            }
        }

        public string fullPath
        {
            get
            {
                return this._fullPath;
            }

            set
            {
                if (value != this._fullPath)
                {
                    this._fullPath = value;
                    NotifyPropertyChanged();
                }             
            }
        }

        public string displayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                if(value != this._displayName)
                {
                    this._displayName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string firstLetter
        {
            get
            {
                return this._firstLetter;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

    
}
