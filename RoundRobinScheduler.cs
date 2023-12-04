using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador_UVA
{
    internal class RoundRobinScheduler
    {
        private Queue<string> processQueue;

        public RoundRobinScheduler() { 
        processQueue = new Queue<string>();
        }

        public void AddProcess(string process)
        {
            processQueue.Enqueue(process);
        }

        public void ExecuteProcesses(int quantum)
        {
            while (processQueue.Count > 0)
            {
                string currentProcess = processQueue.Dequeue();
                Console.WriteLine($"Executando {currentProcess}");

                // Simulação do quantum: coloca o processo de volta na fila

                // para execução futura, se ainda houver tarefas pendentes.
                if (processQueue.Count > 0)
                {
                    Console.WriteLine($"Troca de processo após {quantum} unidades de tempo");
                    processQueue.Enqueue(currentProcess);
                }
            }
        }
    }
}
