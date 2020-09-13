using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAnimalSounds
{
    interface IAnimal
    {
        string Specie { get; set; }
        string Name { get; set; }
        int NumberOfLegs { get; set; }
        string Says();
        void MakeSomeNoise();
    }
}
