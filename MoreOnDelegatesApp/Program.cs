using System.Security.Cryptography.X509Certificates;

namespace MoreOnDelegatesApp
{

    delegate void SayHello(string message);

    //delegate int AddNos(int i, int j);//Func lambda
    internal class Program
    {
        static int add(int i, int j) {return i + j;}
        private static void Main(string[] args)
        {

            //SayHello h = delegate (string message) {
            //    Console.WriteLine(message);


            //};

            //h("Good Morning!!!");

            //AddNos a = (int i, int j) => { return i + j; };

      
            //Func---last parameter in list
            Func<int, int, int> a = (i, j) => { return i + j; };

            int addnos=a(1, 2);

            Func<float,float,double> addFloats=( a1, b1)=> { return a1 + b1; };

            double ansFloats=addFloats(1.2f, 3.4f);
            Console.WriteLine(ansFloats);

            //Action---void
            Action<int, int> actionLambda = (int i, int j) => {
                int c = i + j; 
                Console.WriteLine(c);
            };

            Func<string, string, bool> validateUser = (username, password) => {
              
                bool status = false;
                if (username == "Jack" && password == "Jack@123")
                { 
                status=true;
                
                }
               return status;
            };


            bool validUser=validateUser("Jack", "Jack@123");
            Console.WriteLine(validUser);


            Func<int> f1 = () => {
                int i = 10;
                return i;
            };

            int output=f1();
            Console.WriteLine(output);


            Predicate<int> FindEven=(i)=>{
                bool status = false;
                if (i % 2 == 0) 
                { 
                    status = true; 
                }
                    
                return status;
           
            };

            bool y=FindEven(10);
                













































            Console.Read();



        }
    }
}