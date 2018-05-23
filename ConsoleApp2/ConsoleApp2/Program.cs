using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ClassLibrary1;

namespace ConsoleApp2
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Auto = new List<Car>();
            List<Person> Persona = new List<Person>();
            List<Address> Direccion = new List<Address>();
            Console.WriteLine("1.Para inscribir un auto");
            Console.WriteLine("2.Para inscribir una persona");
            Console.WriteLine("3. Para inscribir una propiedad");
            string Opcion = Console.ReadLine();

            if (Opcion == "1")
            {
                Console.WriteLine("Ingrese la marca");
                string brand = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo");
                string model = Console.ReadLine();
                Console.WriteLine("Ingrese el año");
                int year = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Ingrese el nombre del dueño");
                //Person owner = Console.ReadLine();
                Console.WriteLine("Ingrese la patente");
                string licencePlate = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de cinturones");
                int seatbelt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese si su vehiculo es deisel (1 para si y 2 para no");
                bool diesel = false;
                string bencina = Console.ReadLine();
                if (bencina == "1")
                {
                    diesel = true;
                }
                Car auto = new Car(brand, model, year, null, licencePlate, seatbelt, diesel);
                Auto.Add(auto);

            }

            else if (Opcion == "2")
            {
                Console.WriteLine("Ingrese su nombre");
                string firstName = Console.ReadLine();
                Console.WriteLine("Ingrese su apellido");
                string lastName = Console.ReadLine();
                Console.WriteLine("Ingrese fecha de nacimiento");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                //Console.WriteLine("Ingrese su direccion");
                //Address address1 = Console.ReadLine();
                Console.WriteLine("Ingrese su rut");
                string rut = Console.ReadLine();
                //Console.WriteLine("Ingrese el nombre del padre");
                //Person padre = Console.ReadLine();
                //Console.WriteLine("ingrese el nombre de la madre");
                //string madre = Console.ReadLine();

                Person persona = new Person(firstName, lastName, birthDate, null, rut, null, null);
                Persona.Add(persona);
            }

            else if (Opcion == "3")
            {
                Console.WriteLine("Ingrese el nombre de la calle");
                string street1 = Console.ReadLine();
                Console.WriteLine("Ingrese en numero de la propiedad");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la comuna");
                string commune1 = Console.ReadLine();
                Console.WriteLine("Ingrese la ciudad");
                string city = Console.ReadLine();
                //Console.WriteLine("Ingrese el dueño");
                //Person Owner = Console.ReadLine();
                Console.WriteLine("Ingrese el año de construccion");
                int yearofconstruction = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el numero de habitaciones");
                int bedroom = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el numero de baños");
                int bath = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese si la propiedad tiene patio (1 para si y 2 para no");
                bool backyard1 = false;
                string patio = Console.ReadLine();
                if (patio == "1")
                {
                    backyard1 = true;
                }
                Console.WriteLine("ingrese si la propiedad tiene piscina (1 para si y 2 para no");
                bool pool1 = false;
                string piscina = Console.ReadLine();
                if (piscina == "1")
                {
                    pool1 = true;
                }

                Address direccion = new Address(street1, number1, commune1, city, null, yearofconstruction, bedroom, bath, backyard1, pool1);
                Direccion.Add(direccion);
            }


        }


    }
}
