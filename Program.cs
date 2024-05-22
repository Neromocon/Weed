using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("주 스레드 시작 : " + Thread.
                CurrentThread.GetHashCode());
            ThreadStart ts = new ThreadStart(ThreadFunction);
            Thread thd = new Thread(ts);
            thd.Start();
            Console.WriteLine("스레드 시작" + thd.GetHashCode());
            Console.WriteLine("주 스레드 종료");
            Thread.Sleep(100);
            // 스레드 시작 후 Sleep() 메소드를 통해 0.1초 동안 대기.
            //thd.Abort();
            // Abort()메소드로 동작 중인 스레드를 강제로 종료.
            thd.Join();
            // Join()메소드로 스레드의 모든 작업이 완료된 후 종료.
        }
        public static void ThreadFunction()
        {
            try
            {
                int count = 0;
                while(count < 1000)
                {
                    count++;
                    Console.WriteLine("스레드 동작 중..." + count);
                }
                Console.WriteLine("정상 종료");
            }
            catch(ThreadAbortException e) 
            {
                Console.WriteLine("Abort 예외 발생 : " + e);
                // 스레드에서 발생한 예외 중 Abort()메소드에 의해 강제 종료가 되면
                // ThreadAbortException 예외가 발생하는데, catch문에서 예외 발생 전달인자를 받아 출력.
            }
            finally
            {
                Console.WriteLine("finally!!");
            }
            // try~catch~finally로 스레드 강제 종료 시 예외 처리를 함.
            Console.WriteLine("스렏 식별 : " + Thread.
                CurrentThread.GetHashCode());
            // 현재 어떠한 스레드가 동작하고 있는지 스레드를 식별할 해시 코드를 출력.
        }
    }
}
