using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle_S
{   
    class UserHandle
    {
        public void AddUser( string username )
        {
            Console.WriteLine($"{username} added to the database");
            
        }

        public void Log(string message)
        {
            Console.WriteLine($"{message} logging");
            Console.ReadLine();
        }




    }
    //class Logger
    //{
    //    public void Log( string message)
    //    {

    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            UserHandle user = new UserHandle();
            user.AddUser("dashrath");


            UserHandle user2 = new UserHandle();
            user2.Log("dashrath added succesfullly");






            //UserHandle user2 = new UserHandle();


            // user2.AddUser("")


            //Logger loger = new Logger();


            ////user.AddUser("dashrath");
            //loger.Log("user dashrath added succsessfully");


        }
    }
}
