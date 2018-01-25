using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp
{
    public delegate void CoolNameChangedDelegate(string existingName, string newName); //2 strings as parameters in delegate is not a convention for the event

    //by convention delegates used for events takes 2 parameters: sender (object) and arguments needed by event
    public delegate void CoolNameChangedDelegateForEvent(object sender, NameChangedEventArgs args);
}
