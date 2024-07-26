using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MoreOnDelegatesApp
{
    internal class WorkingWithList
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(11);
            list.Add(2);
            list.Add(310);    
            list.Add(41);
            list.Add(5);

            //function lambda
            List<int> ordered = list.OrderBy(e => e).ToList();
            ordered.ForEach(e => Console.WriteLine(e));

            



            //Predicate Lambda
            // int firstOccurence=list.Find(e=>e%2!=0);
            // Console.WriteLine(firstOccurence);


            //Predicate Lambda
            //List<int> AllEvenNos= list.FindAll(e => e % 2 == 0);

            //Action Lambda
            // AllEvenNos.ForEach(e=>Console.WriteLine(e));

            //foreach (var item in AllEvenNos)
            //{
            //    Console.WriteLine(item);
            //}
            















































            Console.ReadLine();
                


















        }
    }
}
