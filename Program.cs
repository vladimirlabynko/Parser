using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parser
{
    class Program
    {
       static void Converttoarray(string data)
        {
            string[] split = data.Split(new Char[] { '\b', '#', ';', '\t' });

            if (split[1] == "SD")
            {
                string type = split[1];
                double date = double.Parse(split[2], CultureInfo.InvariantCulture);
                double time = double.Parse(split[3], CultureInfo.InvariantCulture);
                double lan1 = double.Parse(split[4], CultureInfo.InvariantCulture);
                double lan = lan1 / 100;
                string lan2 = split[5];
                double lat1 = double.Parse(split[6], CultureInfo.InvariantCulture);
                double lat = lat1 / 100;
                string lat2 = split[7];
                int speed = int.Parse(split[8], CultureInfo.InvariantCulture);
                int course = int.Parse(split[9], CultureInfo.InvariantCulture);
                int height = int.Parse(split[10], CultureInfo.InvariantCulture);
                int sats = int.Parse(split[11], CultureInfo.InvariantCulture);
                Console.WriteLine("Type : {0}", type);
                Console.WriteLine("Date : {0}", date);
                Console.WriteLine("Time : {0}", time);
                Console.WriteLine("Широта : {0};Направление :{1}", Math.Round(lan1, 2), lan2);//latitude 
                Console.WriteLine("Долгота: {0}; Направление:{1}", Math.Round(lat1, 2), lat2);//longitude 
                Console.WriteLine("Широта в градусах : {0};Направление : {1}", Math.Round(lan, 2), lan2);//latitude, direction
                Console.WriteLine("Долгота в градусах : {0};Направление : {1}", Math.Round(lat, 2), lat2);//longitude, direction
                Console.WriteLine("Speed :{0}", speed);
                Console.WriteLine("Course :{0}", course);
                Console.WriteLine("Height :{0}", height);
                Console.WriteLine("Sats :{0}", sats);
            }

            if (split[1] == "M")
            {
                Console.WriteLine("Type : {0}",split[1]);
                Console.WriteLine(split[2]);
            }

            
        }

        static void Main(string[] args)
        {
            string arr1 = "#SD#4012011;135515;5544.6025;N;03739.6834;E;35;215;110;7";
            string arr2 = "#M#груз доставлен";
            Console.WriteLine("Первый пакет : {0}", arr1);
            Console.WriteLine("Второй пакет : {0}", arr2);
            Converttoarray(arr1);
            Converttoarray(arr2);
            Console.ReadKey();
        }
    }
}


