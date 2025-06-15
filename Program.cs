using System;
namespace InterfacesTask2
{
    interface IConnectable
    {
        void Connect();
    }
    interface IDisconnectable
    {
        void Disconnect();
    }
    class Device : IConnectable, IDisconnectable
    {
        public void Connect()
        {
            Console.WriteLine("Пристрiй пiдключено");
        }
        public void Disconnect()
        {
            Console.WriteLine("Пристрiй вiдключено");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Device myDevice = new Device();
            myDevice.Connect();
            myDevice.Disconnect();
            Console.ReadLine();
        }
    }
}
