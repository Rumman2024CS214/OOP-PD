using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Task_02.BL;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                UI.Interface.Header();
                option = UI.Interface.GameMenu();
                if (option == 1)
                {
                    bool gameRunning = true;
                    int score = 0;
                    Deck obj = new Deck();
                    obj.Shuffle();
                    Card card1 = obj.DealCard();
                    while (gameRunning)
                    {
                        Console.Clear();
                        int remain_check = obj.cardsLeft();
                        Card card2 = obj.DealCard();
                        UI.Interface.Header();
                        int card_check = UI.Interface.GamePredict(card1);
                        Console.Clear();

                        if (card_check == 1)
                        {
                            if (card2.getValue() >= card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                UI.Interface.Header();
                                UI.Interface.GameOver(card2, score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if(card_check ==2)
                        {
                            if(card1.getValue() < card2.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                UI.Interface.Header();
                                UI.Interface.GameOver(card2, score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if(obj.cardsLeft()==0&&card2==null)
                        {
                            gameRunning =false;
                            UI.Interface.Header();
                            UI.Interface.GameWinner();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }
                }

            }
            while (option != 2);
        }
    }
}
