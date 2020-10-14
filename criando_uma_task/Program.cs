using System;
using System.Threading.Tasks;

class Program {
    static void Main(string[] args) {
        
        Task taskA = new Task(() => Console.WriteLine("Olá, sou a tarefa A!"));
        Task taskB = new Task(() => Console.WriteLine("Olá, sou a tarefa B!"));

        taskA.Start();
        taskB.Start();

        Console.WriteLine("Olá, sou a função principal!");

        taskA.Wait();
        taskB.Wait();

    }
}