﻿b using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            MySql mySql = new MySql();
            sqlServer.Add();
            mySql.Add();


        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by deafult");
            }
            public virtual void Delete() 
            {
                Console.WriteLine("Deleted by default");
            }
        }
        class SqlServer : Database
        {
            public override void Add() // geneli ezmek
            {
                Console.WriteLine("Added by SQL");
                //base.Add();
            }
        }

        class MySql : Database
        {

        }
    }
}
