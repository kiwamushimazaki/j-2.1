using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApplication1


{
    abstract class Player
    {
        private int hand;
        //public string temp;
        //private string handInput;
        public int Hand
        {
            get
            {
                return hand;
            }
            set
            {
                hand = value;
            }
        }
        //public int Hand
        //{
        //    return int.Parse(this.handInput);
        //}
    }

    class Userplayer : Player
    {
        public Userplayer(int hand) : base()
        {

        }
        public Userplayer()
        {

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
    }
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("複数人じゃんけんゲーム");
            Console.WriteLine("プレイヤーの人数を選択してください>>>");

            string X;
            X = Console.ReadLine();
            int X1 = int.Parse(X);

            var playerList = new List<Player>();
            for (int i = 1; i <= X1; i++)
            {
                playerList.Add(new Userplayer());
            }

            Console.WriteLine("コンピュータの人数を選択してください>>>");

            string Y;
            Y = Console.ReadLine();
            int Y1 = int.Parse(Y);

            for (int i = 1; i <= Y1; i++)
            {
                playerList.Add(new Cpuplayer());
            }

            //foreach (Player player in playerList)
            //{
            //    int hand = player.hand;
            //}
            for (int i = 1; i <= X1; i++)
            {
                Console.WriteLine("プレイヤー{0}", i);
                Console.WriteLine("1.グー, 2.チョキ, 3.パー");
                Console.WriteLine("1～3のいずれかを選択してください>>> ");

                string handInput = Console.ReadLine();

                if (handInput == "1" || handInput == "2" || handInput == "3")
                {

                }
                else
                {
                    Console.WriteLine("誤ったキーが選択されました");
                    Console.WriteLine("もう一度、1.グー, 2.チョキ, 3.パーから再入力してください >>>");
                    continue;
                }
                int userHand = int.Parse(handInput);
                Player player = playerList[i-1];
                player.Hand = userHand;

                //playerList[i].HandInput = handInput;

                //userHand
            }
            for (int i = 1; i <= Y1; i++)
            {
                Random temp2 = new Random();
                int cpuHand = temp2.Next(1, 4);
                Player player = playerList[X1 + i -1];
                player.Hand = cpuHand;
            }

            bool r1 = false;
            foreach (var handInput in playerList)
            {
                if (handInput.Hand == 1)
                {
                    r1 = true;
                    break;
                }
            }
            bool r2 = false;
            foreach (var handInput in playerList)
            {
                if (handInput.Hand == 2)
                {
                    r2 = true;
                    break;
                }
            }
            bool r3 = false;
            foreach (var handInput in playerList)
            {
                if (handInput.Hand == 3)
                {
                    r3 = true;
                    break;
                }
            }

            while (r1 == true && r2 == true && r3 == true ||
                   r1 == true && r2 == false && r3 == false ||
                   r1 == false && r2 == true && r3 == false ||
                   r1 == false && r2 == false && r3 == true)
            {
                Console.WriteLine("あいこです ( 'ω' )");

                for (int i = 1; i <= X1; i++)
                {
                    Console.WriteLine("プレイヤー{0}", i);
                    Console.WriteLine("1.グー, 2.チョキ, 3.パー");
                    Console.WriteLine("1～3のいずれかを選択してください>>> ");

                    string temp3 = Console.ReadLine();

                    if (temp3 == "1" || temp3 == "2" || temp3 == "3")
                    {

                    }
                    else
                    {
                        Console.WriteLine("誤ったキーが選択されました");
                        Console.WriteLine("もう一度、1.グー, 2.チョキ, 3.パーから再入力してください >>>");
                        continue;
                    }
                    int userHand = int.Parse(temp3);
                    Player player = playerList[i-1];
                    player.Hand = userHand;
                }
                for (int i = 1; i <= Y1; i++)
                {
                    Random temp2 = new Random();
                    int cpuHand = temp2.Next(1, 4);
                    Player player = playerList[X1 + i - 1];
                    player.Hand = cpuHand;
                }



            }
            if (r1 == true && r2 == true && r3 == false)
            {

                for (int i = 1; i <= X1; i++)
                {
                    Console.WriteLine("プレイヤー{0}は", i);
                    if (playerList[i].Hand == 1)
                    {
                        Console.WriteLine("勝ちですヽ(〃v〃)ﾉ");
                        Console.WriteLine("おめでとうございます！！");
                    }
                    else
                    {
                        Console.WriteLine("負けです (_　_|||)");
                        Console.WriteLine("残念でした (>_<)");
                    }
                }
            }
            if (r1 == true && r2 == false && r3 == true)
            {
                for (int i = 1; i <= X1; i++)
                {
                    Console.WriteLine("プレイヤー{0}は", i);
                    if (playerList[i].Hand == 3)
                    {
                        Console.WriteLine("勝ちですヽ(〃v〃)ﾉ");
                        Console.WriteLine("おめでとうございます！！");
                    }
                    else
                    {
                        Console.WriteLine("負けです (_　_|||)");
                        Console.WriteLine("残念でした (>_<)");
                    }
                }
            }
            if (r1 == false && r2 == true && r3 == true)
            {
                for (int i = 1; i <= X1; i++)
                {
                    Console.WriteLine("プレイヤー{0}は", i);
                    if (playerList[i].Hand == 2)
                    {
                        Console.WriteLine("勝ちですヽ(〃v〃)ﾉ");
                        Console.WriteLine("おめでとうございます！！");
                    }
                    else
                    {
                        Console.WriteLine("負けです (_　_|||)");
                        Console.WriteLine("残念でした (>_<)");
                    }
                }
            }
            Console.WriteLine("もう一度じゃんけんを行う場合は 1 を押してください>>>");
            Console.WriteLine("終了する場合は 0 を押してください>>>");
            int choice = 1;
            string temp4;
            do
            {
                temp4 = Console.ReadLine();
                if (temp4 == "1")
                {

                }
                else if (temp4 == "0")
                {
                    Console.WriteLine("終了します。お疲れ様でしたm(_ _)m");
                    break;
                }
                else
                {
                    Console.WriteLine("誤ったキーが選択されました");
                    Console.WriteLine("もう一度、1.続行 0.終了 を再入力してください >>>");
                    continue;
                }
                choice = int.Parse(temp4);


            } while (choice == 0 || choice == 1);

        }
    }
}


//            //for (int i = 1; i <= X1; i++)
//            //{


//            //string userHand = Console.ReadLine();

//            //if (userHand == "1" || userHand == "2" || userHand == "3")
//            //{

//            //}
//            //else
//            //{
//            //    Console.WriteLine("誤ったキーが選択されました");
//            //    Console.WriteLine("もう一度、1.グー, 2.チョキ, 3.パーから再入力してください >>>");
//            //    continue;
//            //int[] result = new int[3] { userHand1, cpuHand1, cpuHand2 };

//            //bool r1 = result.Contains(1);
//            //bool r2 = result.Contains(2);
//            //bool r3 = result.Contains(3);

//            //if (r1 = true && r2 = true && r3 = true)
//            //{

//            //}

//        }

//        //TODO atodekesite
//        static void TestMain()
//        {
//            Console.WriteLine("複数人じゃんけんゲーム");
//            Console.WriteLine("プレイヤーの人数を選択してください>>>");

//            string X;
//            X = Console.ReadLine();
//            int X1 = int.Parse(X);

//            var playerList = new List<SampleUser>();
//            for (int i = 1; i <= X1; i++)
//            {
//                playerList.Add(new SampleUser());
//            }

//            //Console.WriteLine("コンピュータの人数を選択してください>>>");

//            //string Y;
//            //Y = Console.ReadLine();
//            //int Y1 = int.Parse(Y);

//            //for (int i = 1; i <= Y1; i++)
//            //{
//            //    playerList.Add(new Cpuplayer());
//            //}

//            for (int i = 1; i <= X1; i++)
//            {
//                Console.WriteLine("プレイヤー{0}", i);
//                Console.WriteLine("1.グー, 2.チョキ, 3.パー");
//                Console.WriteLine("1～3のいずれかを選択してください>>> ");

//                string temp = Console.ReadLine();

//                if (temp == "1" || temp == "2" || temp == "3")
//                {

//                }
//                else
//                {
//                    Console.WriteLine("誤ったキーが選択されました");
//                    Console.WriteLine("もう一度、1.グー, 2.チョキ, 3.パーから再入力してください >>>");
//                    continue;
//                }
//                playerList[i-1].HandInput = temp;
//            }
//            //for (int i = 1; i <= Y1; i++)
//            //{
//            //    Random temp2 = new Random();
//            //    int cpuHund = temp2.Next(1, 4);
//            //}



//            do
//            {
//                bool r1 = false;
//                foreach(var user in playerList)
//                {
//                    if (user.Hand() == 1)
//                    {
//                        r1 = true;
//                        break;
//                    }
//                }

//                bool r2 = false;
//                foreach (var user in playerList)
//                {
//                    if (user.Hand() == 2)
//                    {
//                        r2 = true;
//                        break;
//                    }
//                }


//                bool r3 = false;
//                foreach (var user in playerList)
//                {
//                    if (user.Hand() == 3)
//                    {
//                        r3 = true;
//                        break;
//                    }
//                }


//                while (r1 == true && r2 == true && r3 == true ||
//                       r1 == true && r2 == false && r3 == false ||
//                       r1 == false && r2 == true && r3 == false ||
//                       r1 == false && r2 == false && r3 == true)
//                {
//                    Console.WriteLine("あいこです ( 'ω' )");

//                    for (int i = 1; i <= X1; i++)
//                    {
//                        Console.WriteLine("プレイヤー{0}", i);
//                        Console.WriteLine("1.グー, 2.チョキ, 3.パー");
//                        Console.WriteLine("1～3のいずれかを選択してください>>> ");

//                        string temp = Console.ReadLine();

//                        if (temp == "1" || temp == "2" || temp == "3")
//                        {

//                        }
//                        else
//                        {
//                            Console.WriteLine("誤ったキーが選択されました");
//                            Console.WriteLine("もう一度、1.グー, 2.チョキ, 3.パーから再入力してください >>>");
//                            continue;
//                        }
//                        int userHand = int.Parse(temp);
//                    }


//                }

//                while (r1 == true && r2 == true && r3 == false)
//                {

//                    for (int i = 1; i <= X1; i++)
//                    {
//                        Console.WriteLine("プレイヤー{0}は", i);
//                        int userHand = 0;
//                        if (userHand == 1)
//                        {
//                            Console.WriteLine("勝ちですヽ(〃v〃)ﾉ");
//                            Console.WriteLine("おめでとうございます！！");
//                        }
//                    }
//                }

//            } while (temp == 1 || temp30 == 2 || temp30 == 3);


//            //for (int i = 1; i <= X1; i++)
//            //{


//            //string userHand = Console.ReadLine();

//            //if (userHand == "1" || userHand == "2" || userHand == "3")
//            //{

//            //}
//            //else
//            //{
//            //    Console.WriteLine("誤ったキーが選択されました");
//            //    Console.WriteLine("もう一度、1.グー, 2.チョキ, 3.パーから再入力してください >>>");
//            //    continue;
//            //int[] result = new int[3] { userHand1, cpuHand1, cpuHand2 };

//            //bool r1 = result.Contains(1);
//            //bool r2 = result.Contains(2);
//            //bool r3 = result.Contains(3);

//            //if (r1 = true && r2 = true && r3 = true)
//            //{

//            //}

//        }


//    }
//}





