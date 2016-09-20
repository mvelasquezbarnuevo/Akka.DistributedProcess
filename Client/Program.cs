using ActorModel;
using Akka.Actor;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var system = ActorSystem.Create("ClientSystem"))
            {
                var client = system.ActorOf(Props.Create<ProcessorActor>("ss"));

                while (true)
                {
                    var input = Console.ReadLine();

                }
            }
        }
    }
}
