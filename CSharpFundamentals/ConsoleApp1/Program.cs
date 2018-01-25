using MyConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 30;
            int z = x / y;
            Console.WriteLine(z);
            
            MyDelegateLearnClass coolObject = new MyDelegateLearnClass();
            //coolObject.NameChanged = new CoolNameChangedDelegate(OnNameChanged); //THIS IS CORRECT, but it will assing exactly one delegate
            //coolObject.NameChanged += new CoolNameChangedDelegate(OnNameChanged); //this way we can assing multiple delegates
            //coolObject.NameChanged += OnNameChanged; //compiler will automatically create new CoolNameChangedDelegate, no need to specify it
            coolObject.NameChanged += OnNameChangedWithEventArgs;

            coolObject.CoolName = "yaaay";
        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"My cool object changed name from {existingName} to {newName}!!!");
        }

        static void OnNameChangedWithEventArgs(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"My cool object changed name from {args.ExistingName} to {args.NewName}!!!");
        }
        
    }
}
