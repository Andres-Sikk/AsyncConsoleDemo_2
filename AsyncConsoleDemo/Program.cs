using System;
using System.Threading.Tasks;

namespace AsyncConsoleDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int amount = 5;
            var a = Task.Run(() => new AsyncPrint(amount).Print());
            // var ap = new AsyncPrint(amount);
            // await ap.Print();
            //await Print(amount);
            await a;
            Console.ReadKey(true);
        }
    public class AsyncPrint
    {
        public int _limit = 1;
        public AsyncPrint(int limit)
        {
            _limit = limit;
        }
        public async Task Print()
        {
            while (_limit > 0 && !Console.KeyAvailable)
            {
                Console.WriteLine(_limit);
                Console.WriteLine(Console.KeyAvailable);//delete
                _limit -= 1;
                await Task.Delay(500);
            }
            Console.WriteLine(Console.KeyAvailable);//delete
        }
    }
        /* public async Task Print(int amount){
            while(amount > 0)
            {
                Console.WriteLine(amount);
                await Task.Delay(1000);
                amount -= 1;
            }
        } */
        /*
        public static async Task Print(int amount)
        {
            Console.WriteLine("Press Esc to stop...");
            bool yesorno = true;
            var a = Interupt(yesorno);
            while (yesorno & amount > 0)
            {
                Console.WriteLine(amount);
                await Task.Delay(1000);
                amount -= 1;
            }
            var b = await a;
        }
        public static async Task<bool> Interupt(bool yesorno)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)
            {
                yesorno = false;
                Console.WriteLine("Stop");
            }
            return yesorno;
        }
        */
    }
    
    public class Interupt
    {
        public bool _stop = false;
        public Interupt(bool stop)
        {
            _stop = stop;
        }
        //public async bool Task Stop()
        //{

        //}
    }
}
