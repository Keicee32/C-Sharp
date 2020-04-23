using System;

namespace GuessGame
{
    class Program
    {
       static int guessTries = 6;
       static int guessTries1 = 4;
       static int guessTries2 = 3;
       static int userChoice;
       static int winNum = 9;
       static int winNum2 = 19;
       static int winNum3 = 35;

        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Welcome, would you like to play a Game? Yes or No");
                Console.Write("Please make a choice: ");
                string choice = Console.ReadLine();

                if(choice == "no" || choice == "NO" || choice == "No")
                {
                    Console.WriteLine("Thanks you for your time, see you soon!");
                }


                else if(choice == "YES" || choice == "yes" || choice == "Yes")
                {
                    Console.WriteLine("\n"+"Let's play a number guessing game");
                    Console.WriteLine("Please select a difficulty level" + "\n" + "1) Easy \n2) Medium \n3) Hard");
                    Console.Write("Please make a choice: ");
                    string choice1 = Console.ReadLine();
                    
                        if(choice1 == "1" || choice1 == "easy")
                        {
                            Console.WriteLine("\nGuess a number between 1 - 10 \nYou have 6 tries to guess the correct number \n");
                            Console.Write("Enter Your Guess: ");
                            userChoice = int.Parse(Console.ReadLine());
                            guessTries--;
                            
                            while(userChoice != winNum)
                            {
                                Console.Write("That was wrong \n");
                                Console.Write("You have " + guessTries + " tries left \n");

                                if(guessTries > 0)
                                {
                                    Console.Write("Enter Your Guess: ");
                                    userChoice = int.Parse(Console.ReadLine());
                                    guessTries--;
                                    
                                } 
                                
                                else if(userChoice == winNum)
                                {
                                    Console.Write("You got it right. Game Over \n");
                                    break;
                                } 

                                else if(guessTries == 0){
                                    Console.Write("You have used all your tries. Game Over \n");
                                    break;
                                }
                                
                            }
                            if(userChoice == winNum)
                            {
                                Console.Write("You got it right \n");
                                
                            } else
                            {
                                Console.Write("Goodbye! You've made a wrong choice.");
                            }
                        }


                        else if(choice1 == "2" || choice1 == "Medium")
                        {
                            Console.WriteLine("\nGuess a number between 1 - 20 \nYou have 4 tries to guess the correct number \n");
                            Console.Write("Enter Your Guess: ");
                            userChoice = int.Parse(Console.ReadLine());
                            guessTries1--;
                            
                            while(userChoice != winNum2)
                            {
                                Console.Write("That was wrong \n");
                                Console.Write("You have " + guessTries1 + " tries left \n");
                                if(guessTries1 > 0)
                                {
                                    Console.Write("Enter Your Guess: ");
                                    userChoice = int.Parse(Console.ReadLine());
                                    guessTries1--;
                                    
                                }  
                                else if(userChoice == winNum2)
                                {
                                    Console.Write("You got it right. Game Over \n");
                                    break;
                                } else if(guessTries1 == 0){
                                    Console.Write("You have used all your tries. Game Over \n");
                                    break;
                                }
                                
                            }
                            if(userChoice == winNum2)
                            {
                                Console.Write("You got it right \n");
                                
                            } else
                            {
                                Console.Write("Goodbye! You've made a wrong choice.");
                            }
                        }
                        

                        else if(choice1 == "3" || choice1 == "Hard")
                        {
                            Console.WriteLine("\nGuess a number between 1 - 50 \nYou have 3 tries to guess the correct number \n");
                            Console.Write("Enter Your Guess: ");
                            userChoice = int.Parse(Console.ReadLine());
                            guessTries2--;
                            
                            while(userChoice != winNum3)
                            {
                                Console.Write("That was wrong \n");
                                Console.Write("You have " + guessTries2 + " tries left \n");
                                if(guessTries2 > 0)
                                {
                                    Console.Write("Enter Your Guess: ");
                                    userChoice = int.Parse(Console.ReadLine());
                                    guessTries2--;
                                    
                                }  
                                else if(userChoice == winNum3)
                                {
                                    Console.Write("You got it right. Game Over \n");
                                    break;
                                } else if(guessTries2 == 0){
                                    Console.Write("You have used all your tries. Game Over \n");
                                    break;
                                }
                                
                            }
                            if(userChoice == winNum3)
                            {
                                Console.Write("You got it right \n");
                                
                            } else
                            {
                                Console.Write("Goodbye! You've made a wrong choice.");
                            }
                        } else{
                            Console.WriteLine("You didn't make a valid selection. GoodBye!!");
                        }
                } 

                else{
                    Console.WriteLine("You didn't make a valid selection. GoodBye!!");
                }
            } catch(Exception e) {
                Console.WriteLine("You didn't make a valid selection. Numbers ONLY. GoodBye!!");
            }

        }
    }
}