//Create a C# console application to demonstrate multithreading using GitHub Copilot's suggestions. The application should showcase the creation of a separate worker thread that executes tasks concurrently with the main thread.

class Program
{
    static void Main()
    {
        // Create a new thread and start it
        Thread workerThread = new Thread(WorkerMethod);
        workerThread.Start();

        // Perform some tasks on the main thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: Task {i + 1}");
            Thread.Sleep(1000);
        }

        // Wait for the worker thread to complete
        workerThread.Join();

        Console.WriteLine("Main Thread: Worker thread completed. Press any key to exit.");
        Console.ReadKey();
    }

    static void WorkerMethod()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Worker Thread: Task {i + 1}");
            Thread.Sleep(1000);
        }
    }
}
