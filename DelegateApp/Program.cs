using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    public delegate void displayDeleagte(string message);
    class Program
    {
        static void Main(string[] args)
        {
            displayDeleagte obj = new displayDeleagte(DisplayMessage);
            obj("My Name is Avnish");
            //DisplayMessage("My Name is Avnish");
        }
        public static void DisplayMessage (string message)
        {
            Console.WriteLine("Here is message passed by parameter is - {0} ", message);
        }
    }
}
