using System.Numerics;
using System.Reflection.Emit;

namespace Module_7
{
    /// <summary>
    /// 7.2
    /// </summary>
    /// 
    class Car
    {
        public int Mileage;

        public Car()
        {
            Mileage = 0;
        }

        public virtual void Move()
        {
            Console.WriteLine("Вызван метод Move класса Car");
            Mileage++;
        }
    }

    enum FuelType
    {
        Gas = 0,
        Electricity
    }

    class HybridCar : Car
    {
        public FuelType FuelType;

        public double Gas;

        public double Electricity;

        public HybridCar()
        {
            Electricity = 50;
            Gas = 50;
        }

        public override void Move()
        {
            Console.WriteLine("Вызван метод Move класса HybridCar");
            Mileage++;

            switch (FuelType)
            {
                case FuelType.Gas:
                    Gas -= 0.5;
                    break;
                case FuelType.Electricity:
                    Electricity -= 0.5;
                    break;
            }
        }

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }
    /// <summary>
    /// 7,2 End
    /// </summary>
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProjectManager : Employee
    {
        public string ProjectName;
    }
    class Food
    { }
    class Fruit : Food { }

    class Vegetable : Food { }

    class Apple : Fruit { }
    class Banana : Fruit { }
    class Pear : Fruit { }

    class Potato : Vegetable { }
    class Carrot : Vegetable { }
    class Developer : Employee
    {
        public string ProgrammingLanguage;
    }
    /*class Obj
    {
        private string name;
        private string description;

        public Obj()
        {
            Console.WriteLine("Вызван конструктор без параметров");
        }

        public Obj(string name, string description) : this()
        {
            this.name = name;
            this.description = description;
            Console.WriteLine("Вызван конструктор");
        }
    }*/
    /*class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }*/

    ///
    /// 7.2.3
    /// 7.2.5
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
    ///
    /// 7.2.4
    /// 
    /*class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter 
        {
            get
            {
                return counter;
            }
            set
            {
                if(value > 0)
                {
                    counter = value;
                }
            }
        }
    }
    */
    /// <summary>
    /// 7.1.10
    /// </summary>
    /// 
    /*class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }
        public DerivedClass(string name, string description, int counter) : base(name)
        {
            Description = description;
            Counter = counter;
        }
        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }
    }*/
    ///7.2.7

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }
    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }
    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }
    //7.2.12 перегрузука операторов
    //7.2.12 перегрузука +
    class Obj
    {
        public int Value;
        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }
        //7.2.12 перегрузка -
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }
    /// <summary>
    /// Перегрузка + и -; > и <; 
    /// </summary>
    class Counter
    {
        public int Value { get; set; }

        public static Counter operator +(Counter counter1, Counter counter2)
        {
            return new Counter { Value = counter1.Value + counter2.Value };
        }
        public static bool operator >(Counter counter1, Counter counter2)
        {
            return counter1.Value > counter2.Value;
        }
        public static bool operator <(Counter counter1, Counter counter2)
        {
            return counter1.Value < counter2.Value;
        }
    }
    /// <summary>
    /// 7.2.14 индексатор для класса
    /// </summary>
    /// 

    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }
    /// <summary>
    /// 7.3.3
    /// </summary>
    //Агрегация - this, композиция - new
    abstract class ComputerPart
    {
        public abstract void Work();
    }
    class Processor : ComputerPart
    {
        public override void Work()
        { }
    }
    class MotherBoard : ComputerPart
    {
        public override void Work()
        { }
    }
    class GraphicCard : ComputerPart
    {
        public override void Work()
        { }
    }
    /// <summary>
    /// 7.5.2
    /// </summary>
    /*class Obj
    {
        public string Name;
        public string Description;
        public static int MaxValue = 2000;
    }*/
    ///7.5.3
    ///
    class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    /// <summary>
    /// 7.5.5
    /// </summary>
    /// 
    class Obj1
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;
        static void Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
    /// <summary>
    /// 7.5.9
    /// </summary>
    /// 
    static class intExtensions
    {
        public static int GetNegative(this int number)
        {
            if (number > 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }
        public static int GetPositive(this int number)
        {
            if (number < 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }
    }
    /// <summary>
    /// 7.6.2
    /// 7.6.7
    /// 7.6.9
    /// 7.6.10
    /// </summary>
    /// 
    abstract class Engine { }
    class ElectricEngine : Engine{}
    class GasEngine : Engine{ }
    abstract class CarPart { }
    class Battery : CarPart { }
    class Differential : CarPart{ }
    class Wheel : CarPart { }
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;
        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }
    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
        }
    }
    /// <summary>
    /// 7.6.6
    /// </summary>
    /// 
    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }


    abstract class Delivery
    {
        public string Address;

    }

    class HomeDelivery : Delivery { }
    

    class PickPointDelivery : Delivery { /* ... */ }

    class ShopDelivery : Delivery { /* ... */ }
    class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        //var obj = new Obj("Объект", "Нет описания");
        //7.2.3
        /*BaseClass baseClass = new BaseClass();
        baseClass.Display();*/
        //7.2.5
        DerivedClass obj = new DerivedClass();
            obj.Display();
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
            //7.2
            Car car = new Car();
            HybridCar hybridCar = new HybridCar();

            car.Move();         // метод класса Car
            hybridCar.Move();       // метод класса HybridCar
            ((Car)hybridCar).Move();
            //7.2 konec

            Console.WriteLine("Hello, World!");
        }
    }
}