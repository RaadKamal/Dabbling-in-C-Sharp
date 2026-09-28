using System;
using System.Threading;

namespace ConsoleApp1
{
    public abstract class Handlerbase
    {
        public Handlerbase NextContestant { get: private set; }
        public ContextObject Question {get; private set; 
        
        public Handlerbase(Handlerbase nextContestant, ContextObject question)
        {
            NextContestant = nextContestant;
            Question = question;
        }

        public abstract void HandleRequest();
    }

    public class ContestantOne : Handlerbase
    {
        
    }
    {
        public ContestantOne(Handlerbase nextContestant, ContextObject question) : base(nextContestant, question)
        {
        }

        public override void HandleRequest()
        {
            if (Question.QuestionNumber == 1)
            {
                Console.WriteLine("Contestant One answered the question.");
            }
            else if (NextContestant != null)
            {
                NextContestant.HandleRequest();
            }
        }
    }
    class Example
    {
        public static void Main(string[] args)
        {
            // Create handlers

        }
    }
}