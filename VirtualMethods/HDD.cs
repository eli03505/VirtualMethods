using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageStep
{
    class HDD : Storage
    {

        public double Speed { get; set; } = 3;
        public double Memory { get; set; } = 15;
        private double FreeMemmory = 15;
        public double GetTime { get; set; }
        public double Media()
        {
            return Memory;
        }
        public override double CopyData(double data)
        {
            if (data > FreeMemmory)
            {
                throw new Run("No Memmory", DateTime.Now, 28, "HDD.cs");
            }
            else
            {
                FreeMemmory = FreeMemmory - data;
                return data / Speed;
            }
        }
        public override double FreeMemory()
        {
            return FreeMemmory;
        }
        public double MemoryPerSecond()
        {
            return Speed;
        }
        public override void Print()
        {
            Console.WriteLine($"Memory:{Memory}");
            Console.WriteLine($"Speed:{Speed}");
            Console.WriteLine($"Time:{GetTime}");
            Console.WriteLine($"Free Memory:{FreeMemmory}");
        }
    }
}