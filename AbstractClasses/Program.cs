using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface'ler gibi abstrackt class'lar da new'lenemez.
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database 
    {
        public void Add() 
        {
            Console.WriteLine("Added by deafult"); // her yerde ayni
        }

        public abstract void Delete(); // butun veri tabanlarinda(ornek olarak) farkli.
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by defaultSql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by defaultOracle");
        }
    }
}
