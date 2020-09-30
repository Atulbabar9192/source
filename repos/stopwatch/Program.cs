using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace stopwatch
  /*  Exercise 1: Design a Stopwatch
Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should
provide two methods: Start and Stop.We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan.Display the duration on the console. We should also be able to use a stopwatch
multiple time.So, we may start and stop it and then start and stop it again.Make sure the duration
value each time is calculated properly.We should not be able to start a stopwatch twice in a row
(because that may overwrite the initial start time). The class should throw an
InvalidOperationException if it is started twice.*/

{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch instance = new StopWatch();
            instance.Start();
            Console.ReadLine();
            Thread.Sleep(5000);
            instance.Stop();
            Console.WriteLine("Interval ="+instance.GetInterval());
            Console.ReadKey();
                    }
    }

    public class StopWatch
    {
        DateTime StartTime { get;set; }
        DateTime StopTime {get; set;}
        
        TimeSpan Interval
        {
            get
            {
                return StopTime - StartTime;
            }
        }
        bool IsStarted { get; set;}
        public void Start()
        {
            if (!IsStarted)
            {
                StartTime = DateTime.Now;
                IsStarted = true;
            }
        }
        public void Stop()
        {
            if (IsStarted)
            {
                StopTime = DateTime.Now;
                IsStarted = false;
            }
        }
        public TimeSpan GetInterval()
        {
            return StopTime - StartTime;
        }

    }
}
