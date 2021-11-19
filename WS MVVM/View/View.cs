using System;
using System.Collections.Generic;
using System.Text;

namespace WS_MVVM.View
{
    public class View : Interface1
    {
        ViewModel vm;

        public View()
        {
            vm = new ViewModel(this);
        }

        public void run()
        {
            Console.WriteLine("Entrez la chaîne de caractères :");
            string input;
            input = Console.ReadLine();
            vm.call(input);
            Console.WriteLine(input);
        }

        public void update(string x)
        {
            Console.WriteLine(x);
        }
    }
}