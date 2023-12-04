using Escalonador_UVA;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de utilização do FCFS
        FCFSScheduler fcfsScheduler = new FCFSScheduler();
        fcfsScheduler.AddProcess("A");
        fcfsScheduler.AddProcess("B");
        fcfsScheduler.AddProcess("C");

        Console.WriteLine("Execução utilizando FCFS:");
        fcfsScheduler.ExecuteProcesses();

        // Exemplo de utilização do Round Robin
        RoundRobinScheduler rrScheduler = new RoundRobinScheduler();
        rrScheduler.AddProcess("P1");
        rrScheduler.AddProcess("P2");
        rrScheduler.AddProcess("P3");

        Console.WriteLine("\nExecução utilizando Round Robin:");
        rrScheduler.ExecuteProcesses(2); // Quantum de 2 unidades de tempo
    }
}
