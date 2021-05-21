using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageStep
{
    class DVD : Storage
    {
        public double Speed { get; set; } = 1;
        public double Memory { get; set; } = 10;
        public double FreeMemmory { get; set; }
        public double GetTime { get; set; }
        public double Media()
        {
            return Memory;
        }
        public override double CopyData(double data)
        {
            if (data > FreeMemmory)
            {
                throw new Run("No Memmory", DateTime.Now, 20, "DVD.cs");
            }
            else
            {
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