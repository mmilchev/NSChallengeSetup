using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProj
{
    enum Cmd
    {
        Attack,
        GoTo,
        TalkTo,
        Failed
    }

    class InputManager
    {
        //This is a simple translation from text to enum. You don't have to use it
        private Dictionary<string, Cmd> cmds = new Dictionary<string, Cmd>
        {
            {"attack", Cmd.Attack},
            {"fight", Cmd.Attack},
            {"goto", Cmd.GoTo},
            {"go", Cmd.GoTo},
            {"walk", Cmd.GoTo},
            {"talkto", Cmd.TalkTo},
            {"talk", Cmd.TalkTo},
        };
        
        public Cmd HandleInput(List<string> outArgs)
        {
            var line = Console.ReadLine();

            //Let's split all words
            var words = line.Split(' ');

            //The first word is the command
            string cmdStr = words[0];

            List<string> args;
            //If there are more than 1 word in there, take the rest to be the arguments
            //E.g. "talkto Sam" - 'talk' is the command and 'Sam' is the argument
            //"goto Canada UK USA" - 'goto' is the command and 'Canada', 'UK' and 'USA' are the arguments
            if (words.Length > 1)
            {
                args = words.TakeLast(words.Length - 1).ToList();            
            }
            else
            {
                args = new List<string>();
            }
        
            Cmd cmd;
            //If we can't find a string that matches the command, the use has put in something we don't know about
            if (!cmds.TryGetValue(cmdStr, out cmd))
            {
                cmd = Cmd.Failed;
            }
            else
            {
                outArgs.AddRange(args);
            }

            return cmd;
        }
    }
}