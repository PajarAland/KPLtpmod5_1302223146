using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD5_1302223146
{
    class DataGeneric<T>
    {
        T Data { get; set; }
        public DataGeneric(T data)
        {
            Data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            DataGeneric<string> dataString = new DataGeneric<string>("Y");
            dataString.PrintData();
            DataGeneric<string> dataNim = new DataGeneric<string>("1302223146");
            dataNim.PrintData();
            Console.ReadLine();
        }
    }
}