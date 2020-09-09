using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingApplication
{
    class Program :Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Click += new EventHandler
            (
                (sender, EventArgs) =>
                {
                    Console.WriteLine("Closing Window");
                }
            );
            Console.WriteLine("Starting");
            Application.Run(form);
            Console.WriteLine("Exiting");
        }
    }
}
