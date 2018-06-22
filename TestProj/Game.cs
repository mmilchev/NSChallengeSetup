using System.Collections.Generic;

namespace TestProj
{
    class Game
    {
        public string HandleInput(Cmd cmd, List<string> args)
        {
            var response = string.Empty;
            switch (cmd)
            {
                case Cmd.Failed:
                    response = "Invalid Cmd";
                    break;
                case Cmd.Attack:
                    if (args.Count > 0)
                    {
                        var name = args[0];
                        if (name == "Sam")
                        {
                            response = "You deal 5 damage to Sam. She doesn't look happy.";
                        }
                        else if (name == "George")
                        {
                            response = "You deal 5 damage to George. He begs you to stop.";
                        }
                    }
                    else
                    {
                        response = "Syntax: attack {name}";
                    }
                    break;
                case Cmd.GoTo:
                    if (args.Count > 0)
                    {
                        var name = args[0];
                        if (name == "Sam")
                        {
                            response = "You start walking towards Sam. She backs away.";
                        }
                        else if(name == "George")
                        {
                            response = "You start walking towards George. He lunges for a hug.";
                        }
                        else
                        {
                            response = "You see no one named " + name + " around";
                        }
                    }
                    else
                    {
                        response = "Syntax: goto {name}";
                    }
                    break;
                case Cmd.TalkTo:
                    if (args.Count > 0)
                    {
                        var name = args[0];
                        if (name == "Sam")
                        {
                            response = "You say 'Hi' to Sam. She says 'Hi' back. You don't trust that 'Hi'.";
                        }
                        else if(name == "George")
                        {
                            response = "You say 'Hi' to George. He laughs at you.";
                        }
                        else
                        {
                            response = "You see no one named " + name + " around";
                        }
                    }
                    else
                    {
                        response = "Syntax: talkto {name}";
                    }
                    break;
            }

            return response;
        }
    }
}