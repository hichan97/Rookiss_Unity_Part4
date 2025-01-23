namespace ServerCore
{
    class Program
    {
        static bool _stop = false;

        static void ThreadMain()
        {
            Console.WriteLine("쓰레드 시작!");

            while(_stop == false)
            {
                //누군가 stop 신호를 해주기를 기달딘다.
            }

            Console.WriteLine("쓰레드 종료!");
        }
        static void Main(string[] args)
        {
            Task t = new Task(ThreadMain);
            t.Start();

            Thread.Sleep(1000);

            _stop = true;

            Console.WriteLine("stop 호출");
            Console.WriteLine("종료 대기중 호출");

            t.Wait();

            Console.WriteLine("종료 성공");
        }
    }
}