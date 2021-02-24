using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    public class User
    {
        public string username  { get; set; }
        public string address { get; set; }
        public int userid  { get; set; }
        public int mobileno  { get; set; }
        public int password  { get; set; }

        public User(string username,string address,int userid,int mobileno,int password)
        {
            this.username = username;
            this.address = address;
            this.userid = userid;
            this.mobileno= mobileno ;
            this.password = password;
        }
        
        public void display()
        {
            Console.WriteLine("Name is:" +this.username);
            Console.WriteLine("Address is:" + this.address);
            Console.WriteLine("Id is:" + this.userid);
            Console.WriteLine("No is:" + this.mobileno);
        }



    }
}

