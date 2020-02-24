using System;

class Program
{

  static void Main()
  {
    Console.WriteLine("Please, provide X coordinate of the Queen (number from 1 to 8)");
    int queenX = int.Parse(Console.ReadLine());  
    Console.WriteLine("Please, provide Y coordinate of the Queen (number from 1 to 8)");
    int queenY = int.Parse(Console.ReadLine());  
    Console.WriteLine("Please, provide X coordinate of your figure (number from 1 to 8)");
    int figureX = int.Parse(Console.ReadLine());  
    Console.WriteLine("Please, provide Y coordinate of your figure (number from 1 to 8)");
    int figureY = int.Parse(Console.ReadLine()); 

    int[] queen = {queenX, queenY};
    int[] figure = {figureX, figureY};

    // if (queen[0] == figure[0] || queen[1] == figure[1]){
    //   Console.WriteLine("You loose");
    // }
    // else
    // {
    //   Console.WriteLine("You win");
    // }

    for (int i=1; i<=7; i++){
      if (queen[0] == figure[0]+i && queen[1] == figure[1]+i || queen[0] == figure[0]-i && queen[1] == figure[1]-i || queen[0] == figure[0]-1 && queen[1] == figure[1]+1 || queen[0] == figure[0]+1 && queen[1] == figure[1]-1)
      {
        Console.WriteLine("You loose");
      else
      {
        Console.WriteLine("You win");
      }
    }
  }
}


