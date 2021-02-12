using BackTest;
using BackTest.Models;
using BackTest.Services;
using System;
using System.Linq;
using TestEDM;
using TestEDM.Service;

namespace LaConsolaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IData<User> userService = new GenericDataService<User>(new DesingTimeDbContextFactory());

            //Console.WriteLine( userService.GetAll().Result.Count());
            //userService.Create(new User { username = "Tute" }).Wait();

            //Console.WriteLine(userService.GetByID(1).Result);
            //Console.WriteLine(userService.Update(1, new User() { email ="algo@algo.nose", username ="Tutin" }).Result);

            Console.WriteLine(userService.Delete(1).Result);


            Console.ReadLine();
        }
    }
}
