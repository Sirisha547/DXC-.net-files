namespace InterfaceExercise
{
    namespace Interface
    {
        interface IVehicle
        {
            void Drive();
            bool Refuel(int x);
        }
        class Car : IVehicle
        {
            public int gasoline;
            public Car(int startinggasoline)
            {
                gasoline = startinggasoline;
            }
            public void Drive()
            {
                if (gasoline > 0)
                {
                    Console.WriteLine("The car is driving");
                }
            }
            public bool Refuel(int amount)
            {
                if (amount > 0)
                {



                    Console.WriteLine("Invaild amount");
                    return false;
                }
                gasoline += amount;



                Console.WriteLine("gasoline refueled.current level:" + gasoline);
                return true;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {



                Console.WriteLine("Enter amount of gasoline to refuel");
                int amount = Convert.ToInt32(Console.ReadLine());
                Car car = new Car(0);
                car.Refuel(amount);
                car.Drive();



            }
        }



    }
}
   