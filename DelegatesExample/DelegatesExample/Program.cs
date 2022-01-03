using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class DBConnection
    {
        public DBConnection(string name)
        {
            this.name = name;
        }
        protected string Name;
        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
    }
    class DBManager
    {
        static DBConnection[] activeConnections;
        public void AddConnections()
        {
            activeConnections = new DBConnection[5];
            for (int i = 0; i < 5; i++)
            {
                activeConnections[i] = new DBConnection("DBConnection " + (i + 1));
            }
        }
        public delegate void EnumConnectionsCallback(DBConnection connection);
        public static void EnumConnections(EnumConnectionsCallback callback)
        {
            foreach (DBConnection connection in activeConnections)
            {
                callback(connection);
            }
        }
    }
    class Delegate1App
    {
        public static void ActiveConnectionsCallback(DBConnection connection)
        {
            Console.WriteLine("Callback method called for "
                              + connection.name);
            Console.ReadLine();
        }
        public static void Main()
        {
            DBManager dbMgr = new DBManager();
            dbMgr.AddConnections();
            DBManager.EnumConnectionsCallback myCallback =
            new DBManager.EnumConnectionsCallback(ActiveConnectionsCallback);
            DBManager.EnumConnections(myCallback);
        }
    }

    public delegate void mydata(int x, string y);
    class DelegateDemo
    {
        public void data(int a, string b)
        {

        }
        public void data(DelegateDemo delegateDemo)
        {
            DelegateDemo obj1 = new DelegateDemo();
            mydata mydataObj = new mydata(obj1.data);
            mydataObj(10, "G");
        }
        public void data(DelegateDemo[] delegateDemo)
        {

        }
    }
}

