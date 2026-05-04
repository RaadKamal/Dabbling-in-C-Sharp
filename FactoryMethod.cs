using System;

namespace FactoryMethod
{
    class Example
    {
        abstract class PlayingCard
        {
            public abstract string Type { get; set; }
            public abstract int Value { get; set; }
            public abstract string Suit { get; set; }
        }

        class HoylePlayingCard : PlayingCard
        {
            // The proper way to override properties using auto-properties
            public override string Type { get; set; }
            public override int Value { get; set; }
            public override string Suit { get; set; }

            public HoylePlayingCard(int value, string suit)
            {
                Type = "Hoyle"; // Also fixed a small typo here ("Holye")
                Value = value;
                Suit = suit;
            }
        }

        class CongressPlayingCard : PlayingCard
        {
            public override string Type { get; set; }
            public override int Value { get; set; }
            public override string Suit { get; set; }

            public CongressPlayingCard(int value, string suit)
            {
                Type = "Congress";
                Value = value;
                Suit = suit;
            }
        }

        abstract class CardFactory
        {
            public abstract PlayingCard GetPlayingCard();
        }

        class HoyleFactory : CardFactory
        {
            private int value;
            private string suit;

            public HoyleFactory(int value, string suit)
            {
                this.value = value;
                this.suit = suit;
            }

            public override PlayingCard GetPlayingCard()
            {
                return new HoylePlayingCard(value, suit);
            }
        }

        class CongressFactory : CardFactory
        {
            private int value;
            private string suit;

            public CongressFactory(int value, string suit)
            {
                this.value = value;
                this.suit = suit;
            }

            public override PlayingCard GetPlayingCard()
            {
                return new CongressPlayingCard(value, suit);
            }
        }

        public static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.WriteLine("Enter the type of playing card (Hoyle or Congress):");
            string cardType = Console.ReadLine();

            switch (cardType.ToLower())
            {
                case "hoyle":
                    factory = new HoyleFactory(10, "Hearts");
                    break;
                case "congress":
                    factory = new CongressFactory(5, "Spades");
                    break;
                default:
                    Console.WriteLine("Invalid card type.");
                    return;
            }

            // Fixed: "PlayingCard" instead of "PLayingCard"
            PlayingCard card = factory.GetPlayingCard();
            Console.WriteLine($"Created a {card.Type} card with value {card.Value} of suit {card.Suit}.");
            
            // Fixed: capital 'K' in ReadKey
            Console.ReadKey(); 
        }
    }
}