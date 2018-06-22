using System;
using System.Collections.Generic;

namespace TestProj
{
    static class Program
    {
        private static bool running;

        public static InputManager input = new InputManager();
        
        static void Main(string[] args)
        {
            var game = new Game();

            List<string> cmdArgs = new List<string>(); 
            
            Console.WriteLine("Welcome! You see Sam and George around.");
            Console.WriteLine("You can 'attack', 'goto' or 'talkto' them.");
            
            running = true;
            while (running)
            {
                var cmd = input.HandleInput(cmdArgs);

                var response = game.HandleInput(cmd, cmdArgs);
                
                Console.WriteLine(response);
                
                cmdArgs.Clear();
            }
        }
    }
}
