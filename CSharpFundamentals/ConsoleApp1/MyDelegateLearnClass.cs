using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp
{
    public class MyDelegateLearnClass
    {
        //public CoolNameChangedDelegate NameChanged;
        //public event CoolNameChangedDelegate NameChanged;
        public event CoolNameChangedDelegateForEvent NameChanged;

        private string _coolName;

        public string CoolName 
        { 
            get { return _coolName; }
            set 
            { 
                if(!String.IsNullOrEmpty(value)) 
                {
                    if(_coolName != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _coolName;
                        args.NewName = value;

                        //NameChanged(_coolName, value); //when used as delegate, without event convention arguments
                        NameChanged(this, args);
                    }

                    _coolName = value;
                }
            }
        }

        public MyDelegateLearnClass()
        {
            _coolName = "Cool empty name";
        }
    }
}
