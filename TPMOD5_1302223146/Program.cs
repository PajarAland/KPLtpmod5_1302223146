using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD5_1302223146
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T userName)
        {
            Console.WriteLine($"Halo user {userName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();


            string nickname = "Morano";
            halo.SapaUser(nickname);
            Console.Read();
        }
    }
}