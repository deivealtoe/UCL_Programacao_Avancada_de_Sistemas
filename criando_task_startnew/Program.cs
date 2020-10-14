using System;
using System.Threading;
using System.Threading.Tasks;

class Program {
    static void Main(string[] args) {

        Task[] taskArray = new Task[10];

        for (int i = 0; i < taskArray.Length; i++) {
            taskArray[i] = Task.Factory.StartNew((Object obj) => {
                MeusDados data = obj as MeusDados;

                if (data == null) {
                    return;
                }

                data.NumThread = Thread.CurrentThread.ManagedThreadId;
            },
            new MeusDados() { Nome = i, HoraCriacao = DateTime.Now.Ticks });
        }

        Task.WaitAll(taskArray);

        foreach (var task in taskArray) {
            var data = task.AsyncState as MeusDados;

            if (data != null) {
                Console.WriteLine("Task #{0} criada em {1}, na thread #{2}.", data.Nome, data.HoraCriacao, data.NumThread);
            }
        }

    }
}
