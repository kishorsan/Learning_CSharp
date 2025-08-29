using System.Threading;

class Program
{
    static void Main(String[] args)
    {
        // threds = an execution path of a program
        //          We can use multiple threads to perform,
        //          different tasks of our program at same time.
        //          Current thread runnding is "main" thread
        //          using System.Threading;

        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main Thread";
        System.Console.WriteLine(mainThread.Name);

        Thread thread1 = new Thread(() => countDown("Timer #1"));  // if we have to pass a parameter 
        Thread thread2 = new Thread(countUp);

        thread1.Start();
        thread2.Start();

        // countDown();
        // countUp();

        System.Console.WriteLine(mainThread.Name + " is completed!");
        Console.ReadKey();
    }

    public static void countDown(String name)
    {
        for (int i = 10; i >= 0; i--)
        {
            System.Console.WriteLine("Timer #1: " + i + " seconds");
            Thread.Sleep(1000);
        }
        System.Console.WriteLine("Timer #1 is complete ");
    }
    public static void countUp()
    {
        for (int i = 0; i <= 10; i++)
        {
            System.Console.WriteLine("Timer #2: " + i + " seconds");
            Thread.Sleep(1000);
        }
        System.Console.WriteLine("Timer #2 is complete ");
    }
}