using System;

namespace ConsoleApp3
{/*car classinda qalmisiq*/
    class Car
    {
        private int id;
        public int ID
        {
            get { return id; }
            set
            {
                if (id >= 0)
                {
                    id = value;
                }
            }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
            }
        }

        private double volume;

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
            }

        }
        private string vendor;

        public string Vendor
        {
            get { return vendor; }
            set
            {
                if (vendor != "") { vendor = value; }


            }
        }
        private double produceYear;
        public double ProduceYear
        {
            get { return produceYear; }
            set
            {
                produceYear = value;
            }
        }
        public double GetAge()
        {
            return 2021 - ProduceYear;
        }

        public Car(int id, double volume, string vendor, string model, double produceYear)
        {
            ID = id;
            Volume = volume;
            Vendor = vendor;
            Model = model;
            ProduceYear = produceYear;
        }

        public void showCarData()
        {

            Console.WriteLine($"ID:{ ID}");
            Console.WriteLine($"Volume:{Volume}");
            Console.WriteLine($"Vendor:{Vendor}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Produce Year:{ProduceYear}");
            Console.WriteLine($"Age of Car:{GetAge()}");
        }
    }
    class Point
    {
        private int x;
        public int X
        {
            get { return x; }
            set
            {
                if (x >= 0)
                {
                    x = value;
                }
                else
                {
                    Console.WriteLine("Unable to assimilate value little than zero(0) to field X");
                }
            }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set
            {
                if (y >= 0)
                {

                    y = value;
                }
                else
                {
                    Console.WriteLine("Unable to assimilate value little than zero(0) to field Y");
                }
            }
        }
        public Point() { }
        public Point(int x)
        {
            X = x;
        }
        public Point(int y, int x) : this(x)
        {
            Y = y;
        }
        public void showData()
        {
            Console.WriteLine($"field X:{x}");
            Console.WriteLine($"field Y:{y}");
        }
    }
    class Counter
    {
        private int startValue;
        public int StartValue
        {
            get { return startValue; }
            set
            {
                if (startValue < 100 && startValue >= 0)
                {
                    startValue = value;
                }
                else
                {
                    Console.WriteLine("Unable to set value to start value more than hundred(100),The max value of this counter is hundred(100).");
                }
            }
        }
        private int stopValue;
        public int StopValue
        {
            get { return stopValue; }
            set
            {
                if (StopValue <= 100)
                {
                    stopValue = value;
                }
                else
                {
                    Console.WriteLine("Unable to set value to Stop Value less than start value or,more than hundred(100)");
                }
            }


        }

        public int currentValue;

        private int Value
        {
            get { return currentValue; }
            set
            {

                currentValue = value;
            }
        }

        public Counter(int startValue, int stopValue)
        {
            StartValue = startValue;
            StopValue = stopValue;
        }
        public void increase()
        {
            if (StartValue >= 0 && StopValue <= 100)
            {
                Value++;
            }
        }
    }
    class FractionCalculator
    {
        private double operand;

        public double Value
        {
            get { return operand; }
            set { operand = value; }
        }
        
       
        public double  Addition(FractionCalculator fraction1,FractionCalculator fraction2)
        {
           return fraction1.Value + fraction2.Value;
        }
        public double Subtraction(FractionCalculator fraction1, FractionCalculator fraction2)
        {
            return fraction1.Value - fraction2.Value;
        }
        public double Multiplication(FractionCalculator fraction1, FractionCalculator fraction2)
        {
            return fraction1.Value * fraction2.Value;
        }
        public double Division(FractionCalculator fraction1, FractionCalculator fraction2)
        {
            return fraction1.Value / fraction2.Value;
        }
        public FractionCalculator(double value)
        {
            this.Value = value;
        }
        public FractionCalculator() { }
    }
    class Program
    {
        static void ForHoldProgram()
        {
            Console.WriteLine("\nPress any key to exit program...");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter class id to start:");
            Console.WriteLine("Point Class:1");
            Console.WriteLine("Counter Class:2");
            Console.WriteLine("Car Class:3");
            Console.WriteLine("Fraction Calculator Class:4");
            Console.Write("Your Choice:");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Point Class:");
                Point point = new Point(17, 17);
                point.showData();
            }
            if (option == 2)
            {
                Console.WriteLine("\nCount Class:");
                Counter counter = new Counter(1, 17);
                for (int i = 0; i < 17; i++)
                {
                    counter.increase();
                    Console.Write(counter.currentValue + " ");
                }
                Console.WriteLine("\n");
            }
            if (option == 3)
            {
                Car jeep = new Car(1, 5.7, "Jeep", "Grand Cheeroke", 2014);
                Car mazda = new Car(2, 2.7, "Mazda", "CX-5", 2018);
                Car mitsubishi = new Car(3, 3.0, "Mitsubishi", "Evolution MR8", 2008);
                jeep.showCarData();
                mazda.showCarData();
                mitsubishi.showCarData();
            }
            if (option == 4)
            {
                Console.WriteLine("Fraction Calculator Class:");
                Console.Write("Enter the first number:");
                double value1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the operator:");
                string symbol = Console.ReadLine();
                Console.Write("Enter the second number:");
                double value2 = Convert.ToDouble(Console.ReadLine());
                FractionCalculator f1 = new FractionCalculator(value1);
                FractionCalculator f2 = new FractionCalculator(value2);
                FractionCalculator forOperations = new FractionCalculator();
                if (symbol == "+")
                {
                    Console.WriteLine(forOperations.Addition(f1, f2));
                }
                if (symbol == "-")
                {
                    Console.WriteLine(forOperations.Subtraction(f1, f2));
                }
                if (symbol == "*")
                {
                    Console.WriteLine(forOperations.Multiplication(f1, f2));
                }
                if (symbol == "/")
                {
                    Console.WriteLine(forOperations.Division(f1, f2));
                }
            }
            ForHoldProgram();
        }
    }
}

