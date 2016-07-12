using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Player
    {
        public int hand;
        public string temp;

    }
    class Userplayer : Player
    {
        public Userplayer(int hand) : base()
        {

        }
        public Userplayer()
        {

        }
        public int selectHand()
        {
            return 1;
        }
    }
    class Cpuplayer : Player
    {
        public Cpuplayer(int hand) : base()
        {

        }
        public Cpuplayer()
        {

        }
        public int selectHand()
        {
            return 1;
        }
    }
    class MainClass
    {
        static void Main()
        {
            Userplayer user1 = new Userplayer();
            int userHand1 = user1.selectHand();
            string temp1;
            //Userplayer user2 = new Userplayer();
            //int userHand2 = user2.selectHand();

            Cpuplayer cpu1 = new Cpuplayer();
            int cpuHand1 = cpu1.selectHand();
            Cpuplayer cpu2 = new Cpuplayer();
            int cpuHand2 = cpu2.selectHand();
            //Cpuplayer cpu3 = new Cpuplayer();
            //int cpuHand3 = cpu3.selectHand();

            Console.WriteLine("じゃんけんゲーム");
            Console.WriteLine("1.グー, 2.チョキ, 3.パー");
            Console.WriteLine("1～3のいずれかを選択してください>>> ");
            Console.WriteLine("終了するときは0を選択してください>>>");

            do
            {
                temp1 = Console.ReadLine();

                if (temp1 == "1" || temp1 == "2" || temp1 == "3")
                {

                }
                else if (temp1 =="0")
                {
                    Console.WriteLine("終了します。お疲れ様でしたm(_ _)m");
                    break;
                }
                else
                {
                    Console.WriteLine("誤ったキーが選択されました");
                    Console.WriteLine("もう一度、1.グー, 2.チョキ, 3.パーから再入力してください >>>");
                    continue; 
                }
                userHand1 = int.Parse(temp1);

                Random temp3 = new Random();
                cpuHand1 = temp3.Next(1, 4);
                Random temp4 = new Random();
                cpuHand2 = temp3.Next(1, 4);

                int[] result = new int[3] { userHand1, cpuHand1, cpuHand2 };

                bool r1 = result.Contains(1);
                bool r2 = result.Contains(2);
                bool r3 = result.Contains(3);

                if ( r1 = true && r2 =true && r3 =true)
                {

                }


            } while ( userHand1 == 1 || userHand1 == 2 || userHand1 == 3);





        }
    }
}
