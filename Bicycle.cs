using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_Classes
{
    public class Bicycle
    {
        enum TypesOfChains {Chain1, Chain2, Chain3}
        //Fields
        string _brakes;
        TypesOfChains _chain;
        string _wheelType;
        int _numberOfGears;
        string _frame;
        string _pedals;
        string _handles;
        int _numberofSeats;
        string _uniqueSerial;
        //Constructor
        public Bicycle(int numberofSeats)
        {
            Random rand = new Random();
            int unique = rand.Next(10000000, 100000000);
            _uniqueSerial = unique.ToString(); ;
            NumberOfSeats = numberofSeats;
        }



        //Properties
        public string UniqueSerial
        {
            get => _uniqueSerial;
        }
        public int NumberOfSeats
        {
            get => _numberofSeats;
            set
            {
                if(value > 0)
                {
                    _numberofSeats = value;
                }
                else
                {
                    Console.WriteLine("Please input correct value");
                }
            }
        }
        public string Brakes { get => _brakes; set => _brakes = value; }
        private TypesOfChains Chain { get => _chain; set => _chain = value; }
        public string WheelType { get => _wheelType; set => _wheelType = value; }
        public int NumberOfGears { get => _numberOfGears; set => _numberOfGears = value; }
        public string Frame { get => _frame; set => _frame = value; }
        public string Pedals { get => _pedals; set => _pedals = value; }
        public string Handles { get => _handles; set => _handles = value; }

        //Methods
        public override string ToString()
        {
            return $"Serial: {UniqueSerial}";
        }
    }
}
