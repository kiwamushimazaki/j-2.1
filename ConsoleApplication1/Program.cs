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
    class Handlist
    {
        public const int グー = 1;
        public const int チョキ = 2;
        public const int パー = 3;
    }
    class MainClass
    {
        static void Main()
        {
            const int グー = 1;
            const int チョキ = 2;
            const int パー = 3;

            Console.WriteLine("複数人じゃんけんゲーム");


            bool zokko = true;

            do
            {

                Console.WriteLine("プレイヤーの人数を１人～４人で選択してください>>>");


                string X;
                X = Console.ReadLine();
                if (X == "1" || X == "2" || X == "3" || X == "4")
                {

                }
                else
                {
                    Console.WriteLine("誤ったキーが選択されました");
                    Console.WriteLine("プレイヤーの人数を１人～４人から再入力してください >>>");
                    continue;
                }
                int X1 = int.Parse(X);

                var playerList = new List<Player>();
                for (int i = 1; i <= X1; i++)
                {
                    playerList.Add(new Userplayer());
                }

                Console.WriteLine("コンピュータの人数を１人～４人で選択してください>>>");

                string Y;
                Y = Console.ReadLine();
                if (Y == "1" || Y == "2" || Y == "3" || Y == "4")
                {

                }
                else
                {
                    Console.WriteLine("誤ったキーが選択されました");
                    Console.WriteLine("プレイヤーの人数を１人～４人から再入力してください >>>");
                    continue;
                }
                int Y1 = int.Parse(Y);

                for (int i = 1; i <= Y1; i++)
                {
                    playerList.Add(new Cpuplayer());
                }
                bool aiko = false;
                do
                {
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
                        Player player = playerList[i - 1];
                        player.Hand = userHand;
                    }
                    Random temp2 = new Random();
                    for (int i = 1; i <= Y1; i++)
                    {
                       
                        int cpuHand = temp2.Next(1, 4);
                        Player player = playerList[X1 + i - 1];
                        player.Hand = cpuHand;
                    }

                    bool r1 = false;
                    foreach (var hand in playerList)
                    {
                        if (hand.Hand == Handlist.グー)
                        {
                            r1 = true;
                            break;
                        }
                    }
                    bool r2 = false;
                    foreach (var hand in playerList)
                    {
                        if (hand.Hand == チョキ)
                        {
                            r2 = true;
                            break;
                        }
                    }
                    bool r3 = false;
                    foreach (var hand in playerList)
                    {
                        if (hand.Hand == パー)
                        {
                            r3 = true;
                            break;
                        }
                    }

                    if (r1 == true && r2 == true && r3 == false)
                    {
                        aiko = false;
                        for (int i = 1; i <= X1; i++)
                        {
                            Console.WriteLine("プレイヤー{0}は", i);
                            if (playerList[i - 1].Hand == グー)
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
                    else if (r1 == true && r2 == false && r3 == true)
                    {
                        aiko = false;
                        for (int i = 1; i <= X1; i++)
                        {
                            Console.WriteLine("プレイヤー{0}は", i);
                            if (playerList[i - 1].Hand == パー)
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
                    else if (r1 == false && r2 == true && r3 == true)
                    {
                        aiko = false;
                        for (int i = 1; i <= X1; i++)
                        {
                            Console.WriteLine("プレイヤー{0}は", i);
                            if (playerList[i - 1].Hand == チョキ)
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
                    else
                    {
                        aiko = true;
                        Console.WriteLine("あいこです ( 'ω' )");
                        Console.WriteLine("もう一度選んでください");
                    }
                } while (aiko);
                Console.WriteLine("もう一度じゃんけんを行う場合は 1 を押してください>>>");
                Console.WriteLine("終了する場合は 0 を押してください>>>");

                bool choice = true;
                string temp4;
                do
                {
                    temp4 = Console.ReadLine();

                    if (temp4 == "1")
                    {
                        choice = false;
                    }
                    else if (temp4 == "0")
                    {
                        Console.WriteLine("終了します。お疲れ様でしたm(_ _)m");
                        zokko = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("誤ったキーが選択されました");
                        Console.WriteLine("もう一度、1.続行 0.終了 を再入力してください >>>");
                        continue;
                    }

                } while (choice);

            } while (zokko);
        }
    }
}




