using System;

namespace Escalonador_UVA;

public class FCFSScheduler
{

	private Queue<string> processQueue;
	public FCFSScheduler()
	{
		processQueue = new Queue<string>();
	}


	public void AddProcess(string process)
	{
		processQueue.Enqueue(process);
	}

	public void ExecuteProcesses()
	{
		while (processQueue.Count > 0)
		{
			string currentProcess  = processQueue.Dequeue();
			Console.WriteLine($"Executando {currentProcess}");
		}
	}
}
