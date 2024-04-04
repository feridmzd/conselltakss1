using ConsoleApp111;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Mile { get; set; }

    public Vehicle(string brand, string model, double mile)
    {
        if (brand.Length > 3 && model.Length > 3 && mile >= 0)
        {
            Brand = brand;
            Model = model;
            Mile = mile;
        }
        else
        {
            Console.WriteLine("Sehv daxil etdin");
        }
    }
}

class Car : Vehicle
{
    public int DoorsNum { get; set; }

    public Car(string brand, string model, double mile, int doorsNum) : base(brand, model, mile)
    {
        if (doorsNum > 0 && doorsNum < 5)
        {
            DoorsNum = doorsNum;
        }
        else
        {
            Console.WriteLine("Sehv daxil etdin");
        }
    }

    public void ShowFullInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Mile: {Mile}, Doors: {DoorsNum}");
    }
}

class Gallery
{
    public Car[] cars;

    public Gallery()
    {
        cars = new Car[0];
    }

    public void AddCar(Car car)
    {
        Array.Resize(ref cars, cars.Length + 1);
        cars[cars.Length - 1] = car;
    }

    public void FilterCar(string brand)
    {
        foreach (Car car in cars)
        {
            if (car.Brand == brand)
            {
                car.ShowFullInfo();
            }
        }
    }

    public void FilterCar(double mile)
    {
        foreach (Car car in cars)
        {
            if (car.Mile == mile)
            {
                car.ShowFullInfo();
            }
        }
    }

    public void ListCars()
    {
        foreach (Car car in cars)
        {
            car.ShowFullInfo();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gallery gallery = new Gallery();
        Console.WriteLine(@"  









   $$\      $$\  $$$$$$\   $$$$$$\  $$$$$$\ $$\   $$\       $$$$$$$\   $$$$$$\  $$$$$$$$\  $$$$$$\  $$$$$$$\  $$$$$$\ 
   $$$\    $$$ |$$  __$$\ $$  __$$\ \_$$  _|$$$\  $$ |      $$  __$$\ $$  __$$\ \____$$  |$$  __$$\ $$  __$$\ \_$$  _|
   $$$$\  $$$$ |$$ /  $$ |$$ /  \__|  $$ |  $$$$\ $$ |      $$ |  $$ |$$ /  $$ |    $$  / $$ /  $$ |$$ |  $$ |  $$ |  
   $$\$$\$$ $$ |$$$$$$$$ |\$$$$$$\    $$ |  $$ $$\$$ |      $$$$$$$\ |$$$$$$$$ |   $$  /  $$$$$$$$ |$$$$$$$  |  $$ |  
   $$ \$$$  $$ |$$  __$$ | \____$$\   $$ |  $$ \$$$$ |      $$  __$$\ $$  __$$ |  $$  /   $$  __$$ |$$  __$$<   $$ |  
   $$ |\$  /$$ |$$ |  $$ |$$\   $$ |  $$ |  $$ |\$$$ |      $$ |  $$ |$$ |  $$ | $$  /    $$ |  $$ |$$ |  $$ |  $$ |  
   $$ | \_/ $$ |$$ |  $$ |\$$$$$$  |$$$$$$\ $$ | \$$ |      $$$$$$$  |$$ |  $$ |$$$$$$$$\ $$ |  $$ |$$ |  $$ |$$$$$$\ 
   \__|     \__|\__|  \__| \______/ \______|\__|  \__|      \_______/ \__|  \__|\________|\__|  \__|\__|  \__|\______|
                                                                                                                   
⠀⠀⠀⠀⠀


");
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.ResetColor();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Masin elave et");
            Console.WriteLine("2. Masin siyahisi");
            Console.WriteLine("3. Masin axtar");
            Console.WriteLine("\t1. AXTAR Brand");
            Console.WriteLine("\t2. AXTAR Mileage");
            Console.WriteLine("6. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Daxil et Brand:");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Daxil et Model:");
                    string model = Console.ReadLine();
                    Console.WriteLine("Daxil  et Mileage:");
                    double mile = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Daxil et Doors:");
                    int doorsNum = Convert.ToInt32(Console.ReadLine());

                    Car newCar = new Car(brand, model, mile, doorsNum);
                    gallery.AddCar(newCar);
                    break;
                case 2:
                    gallery.ListCars();
                    break;
                case 3:
                    Console.WriteLine("Axtar:");
                    int searchChoice = Convert.ToInt32(Console.ReadLine());
                    switch (searchChoice)
                    {
                        case 1:
                            Console.WriteLine("Daxil et Brand:");
                            string searchBrand = Console.ReadLine();
                            gallery.FilterCar(searchBrand);
                            break;
                        case 2:
                            Console.WriteLine("Daxil et Mileage:");
                            double searchMile = Convert.ToDouble(Console.ReadLine());
                            gallery.FilterCar(searchMile);
                            break;
                        default:
                            Console.WriteLine("BASQA secim.");
                            break;
                    }
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Basqa secim.");
                    break;
            }
        }
    }
}



