using NConsoleGraphics;
using System;

namespace OOPGame {

  public class Program {

    static void Main(string[] args) {

      Console.WindowWidth = 40;     //width in columns
      Console.WindowHeight = 40;    //height in rows
      Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
      Console.BackgroundColor = ConsoleColor.White;
      Console.CursorVisible = false;
      Console.Clear();

      ConsoleGraphics graphics = new ConsoleGraphics();

      GameEngine engine = new SampleGameEngine(graphics);
      engine.Start();
    }
  }
}
