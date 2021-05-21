using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageStep
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage st1 = new HDD()
            {
                Name = "Hdd",
                Model = "Toshiba"
            };
            Storage st2 = new Flash()
            {
                Name = "Flash",
                Model = "3D Export"
            };
            Storage st3 = new DVD
            {
                Name = "DVD",
                Model = "Philips"
            };
            st3.Print();
            try
            {
                Console.WriteLine(st3.CopyData(2));
            }
            catch (Run ex)
            {
                ex.Show();
            }
            st3.Print();
        }
    }
}

