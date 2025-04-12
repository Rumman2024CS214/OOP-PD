using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_03.BL;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            BlackjackHand playerHand = new BlackjackHand();
            BlackjackHand dealerHand = new BlackjackHand();
            int option = 0;
            int score = 0;
            bool gameRunning = true;
            do
            {
                Console.Clear();
                UI.Interface.Header();
                option = UI.Interface.GameMenu();
                if(option == 1)
                {
                    score = 0;
                    playerHand.clear();
                    dealerHand.clear();
                    gameRunning = true;
                    Console.Clear();
                    deck.Shuffle();
                    UI.Interface.Header();
                    playerHand.AddCard(deck.DealCard());
                    playerHand.AddCard(deck.DealCard());
                    dealerHand.AddCard(deck.DealCard());
                    dealerHand.AddCard(deck.DealCard());
                    UI.PlayerUI.PlayerHand();
                    UI.Interface.PrintHand(playerHand);
                    UI.PlayerUI.PlayerHandValue(playerHand);
                    UI.DealerUI.DealerHand();
                    UI.Interface.PrintDealerHand(dealerHand);
                    Console.WriteLine("Dealer's Hand Value: UNKNOWN");
                    if (dealerHand.getBlackjackValue() == 21 && playerHand.getBlackjackValue() == 21)
                    {
                        UI.Interface.Tie();
                        gameRunning = false;
                    }
                    else if (dealerHand.getBlackjackValue() == 21 && playerHand.getBlackjackValue() != 21)
                    {
                        UI.DealerUI.DealerBlackjackWin();
                        gameRunning = false;
                    }
                    else if (dealerHand.getBlackjackValue() != 21 && playerHand.getBlackjackValue() == 21)
                    {
                        UI.PlayerUI.PlayerBlackjackWin();
                        score = score + 15;
                        gameRunning = false;
                    }
                    else if (playerHand.getBlackjackValue() > 21 && dealerHand.getBlackjackValue() < 21)
                    {
                        UI.DealerUI.DealerBustWin();
                        gameRunning = false;
                    }
                    else if (playerHand.getBlackjackValue() < 21 && dealerHand.getBlackjackValue() > 21)
                    {
                        UI.PlayerUI.PlayerBustWin();
                        score = score + 10;
                        gameRunning = false;
                    }
                    else
                    {
                        UI.PlayerUI.PlayerTurn();
                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (input.ToLower() == "hit")
                            {
                                playerHand.AddCard(deck.DealCard());
                                UI.Interface.PrintHand(playerHand);
                                UI.PlayerUI.PlayerHandValue(playerHand);
                                if (playerHand.getBlackjackValue() > 21)
                                {
                                    UI.DealerUI.DealerBustWin();
                                    gameRunning = false;
                                    break;
                                }
                                else if (playerHand.getBlackjackValue() == 21 && playerHand.getCardCount() == 2)
                                {
                                    UI.PlayerUI.PlayerBlackjackWin();
                                    score = score + 7;
                                    gameRunning = false;
                                    break;
                                }
                            }
                            else if (input.ToLower() == "stand")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Entry...");
                            }
                        }
                        if(gameRunning)
                        {
                            if (dealerHand.getBlackjackValue() >= 17)
                            {
                                if (dealerHand.getBlackjackValue() > playerHand.getBlackjackValue())
                                {
                                    UI.DealerUI.DealerWins();
                                }
                                else if (dealerHand.getBlackjackValue() < playerHand.getBlackjackValue())
                                {
                                    UI.PlayerUI.PlayerWins();
                                    score = score + 5;
                                }
                                else
                                {
                                    UI.Interface.Tie();
                                }
                            }
                            else
                            {
                                while (dealerHand.getBlackjackValue() < 17)
                                {
                                    dealerHand.AddCard(deck.DealCard());
                                    UI.DealerUI.DealersTurn(dealerHand);
                                    UI.DealerUI.DealerHandValue(dealerHand);
                                    if (dealerHand.getBlackjackValue() > 21)
                                    {
                                        UI.PlayerUI.PlayerBustWin();
                                        score = score+3;
                                        break;
                                    }
                                    else if (dealerHand.getBlackjackValue() > playerHand.getBlackjackValue())
                                    {
                                        UI.DealerUI.DealerWins();
                                        break;
                                    }
                                    else if (dealerHand.getBlackjackValue() < playerHand.getBlackjackValue())
                                    {
                                        UI.PlayerUI.PlayerWins();
                                        score= score+2;
                                        break;
                                    }
                                    else
                                    {
                                        UI.Interface.Tie();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    UI.Interface.PrintScore(score);
                    Console.ReadKey();
                }
            }
            while (option != 2);
        }
    }
}
