//Exceeded core requirements by adding functionality for viewing saved files. This makes loading easier, because you can see what files there are to load. It also makes saving easier because you can see which file you're saving over or know whether or not you should name your new save file something else.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}