using System;


namespace FactoryMethod
{
    class Example
    {
        abstract class PlayingCard
        {
            public abstract string Type { get; set;}
            public abstract int Value { get; set;}
            public abstract string Suit {get; set;}
        }

        class HoylePlayingCard: PlayingCard
        {
            public override string Type ;
            public override int Value ;
            public override string Suit ;

            public HoylePlayingCard( int value, string suit)
            {
                Type = "Holye";
                this.Value = value;
                this.Suit = suit;
            }

            public override string Type
            {
                get {return type;}
                set {type = value;}
            }

            public override int Value
            {
                get {return value;}
                set {this.value = value;}
            }

            public override string Suit
            {
                get {return suit;}
                set {suit = value;}
            }
        }

            class CongressPlayingCard: PlayingCard
            {
                public override string Type ;
                public override int Value ;
                public override string Suit ;

                public CongressPlayingCard( int value, string suit)
                {
                    Type = "Congress";
                    this.Value = value;
                    this.Suit = suit;
                }

                public override string Type
                {
                    get {return type;}
                    set {type = value;}
                }

                public override int Value
                {
                    get {return value;}
                    set {this.value = value;}
                }

                public override string Suit
                {
                    get {return suit;}
                    set {suit = value;}
                }
            }

            abstract class CardFactory
            {
                public abstract PlayingCard GetPlayingCard();
                    
            }

            class HoyleFactory: CardFactory
            {
                private string type;
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

            class CongressFactory: CardFactory
            {
                private string type;
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

                    PLayingCard card = factory.GetPlayingCard();
                    Console.WriteLine($"Created a {card.Type} card with value {card.Value} of suit {card.Suit}.");
                    Console.Readkey();

                }
            }
}

