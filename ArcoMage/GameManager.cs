using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ArcoMage
{
    public class GameManager : BindableBase
    {
        private Player player1;
        private Player player2;
        public Player Player1
        {
            get
            {
                return player1;
            }
            set
            {
                SetProperty(ref player1, value);
            }
        }
        public Player Player2
        {
            get
            {
                return player2;
            }
            set
            {
                SetProperty(ref player2, value);
            }
        }

        Random rand;
        DataAccess db;

        public GameManager()
        {
            db = new DataAccess();
            rand = new Random();
            InstantiateDb();
            StartGame();
        }

        void StartGame()
        {
            Player1 = new Player();
            Player1.Discard = new List<Card>();
            Player1.Deck = InitializeCards();
            Player1.TowerLevel = 50;
            Player1.WallLevel = 50;
            Player1.BrickLevel = 3;
            Player1.MagicLevel = 2;
            Player1.DungeonLevel = 1;
            Player1.BrickQuantity = 300;
            Player1.MagicQuantity = 400;
            Player1.DungeonQuantity = 200;
            Player1.Hand = DrawStarterHand(Player1.Deck);
            Player1.IsCurrentTurn = true;

            Player2 = new Player();
            Player2.Discard = new List<Card>();
            Player2.Deck = InitializeCards();
            Player2.TowerLevel = 100;
            Player2.WallLevel = 50;
            Player2.BrickLevel = 2;
            Player2.MagicLevel = 2;
            Player2.DungeonLevel = 2;
            Player2.BrickQuantity = 200;
            Player2.MagicQuantity = 200;
            Player2.DungeonQuantity = 200;
            Player2.Hand = DrawStarterHand(Player2.Deck);

        }
        ObservableCollection<Card> DrawStarterHand(List<Card> deck)
        {
            ObservableCollection<Card> cards = new ObservableCollection<Card>();
            for(int i = 0; i < 6; i++)
            {
                int index = rand.Next(0, deck.Count);
                cards.Add(deck[index]);
                deck.RemoveAt(index);
            }
            return cards;
        }

        public void DrawNewCard(Card selectedCard)
        {
            
            if (Player1.IsCurrentTurn)
            {
                int index = Player1.Hand.IndexOf(selectedCard);
                Player1.Hand.Remove(selectedCard);
                Card newCard = Player1.Deck.FirstOrDefault();
                Player1.Hand.Insert(index, newCard);
                Player1.Deck.Remove(newCard);
                Player1.Deck.Add(selectedCard);

            }
            else
            {
                int index = Player2.Hand.IndexOf(selectedCard);
                Player2.Hand.Remove(selectedCard);
                Card newCard = Player2.Deck.FirstOrDefault();
                Player2.Hand.Insert(index, newCard);
                Player2.Deck.Remove(newCard);
                Player2.Deck.Add(selectedCard);

            }
        }

        internal void GenerateResources(Player player)
        {
            player.BrickQuantity += player.BrickLevel;
            player.MagicQuantity += player.MagicLevel;
            player.DungeonQuantity += player.DungeonLevel;
        }

        List<Card> InitializeCards()
        {
            List<DBCard> dBCards = db.GetAllDBCards();
            List<Card> cards = new List<Card>();
            foreach (DBCard dBCard in dBCards)
            {
                Card c = new Card();
                c.CardName = dBCard.CardName;
                c.CostAmount = dBCard.CostAmount;
                c.CardId = dBCard.CardId;
                c.Description = dBCard.Description;
                if(File.Exists(String.Format("pack://application:,,,/ArcoMage;component/Images/{0}", dBCard.ImageName)))
                    c.Image = new System.Windows.Media.Imaging.BitmapImage(new Uri(String.Format("pack://application:,,,/ArcoMage;component/Images/{0}", dBCard.ImageName)));
                else
                    c.Image = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/ArcoMage;component/Images/DefaultCardBackground.jpg"));
                switch (dBCard.CostType)
                {
                    case "Brick":
                        c.CostType = Resources.Brick;
                        c.CostColor = Brushes.Crimson;
                        break;
                    case "Dungeon":
                        c.CostType = Resources.Dungeon;
                        c.CostColor = Brushes.ForestGreen;
                        break;
                    case "Magic":
                        c.CostType = Resources.Magic;
                        c.CostColor = Brushes.Blue;
                        break;
                }
                cards.Add(c);


                

            }


            return cards;
        }
        void InstantiateDb()
        {
            if(db.GetCardBynameDBCards("Basic Wall") == null)
            {
                db.AddCard("Basic Wall", "Brick", "6 Wall", "DefaultCardBackground.jpg", 3);
            }
            if (db.GetCardBynameDBCards("Quarrys Help") == null)
            {
                db.AddCard("Quarrys Help", "Dungeon", "2 Quarry 1 Opponent Quarry", "DefaultCardBackground.jpg", 12);
            }
            if (db.GetCardBynameDBCards("Full Moon") == null)
            {
                db.AddCard("Full Moon", "Magic", "1 Dungeon", "DefaultCardBackground.jpg", 6);
            }
            if (db.GetCardBynameDBCards("Sturdy Wall") == null)
            {
                db.AddCard("Sturdy Wall", "Brick", "10 wall", "DefaultCardBackground.jpg", 4);
            }
            if (db.GetCardBynameDBCards("Motherlode") == null)
            {
                db.AddCard("Motherlode", "Dungeon", "15 bricks, 10 magic", "DefaultCardBackground.jpg", 15);
            }
            if (db.GetCardBynameDBCards("Goblin Archers") == null)
            {
                db.AddCard("Goblin Archers", "Dungeon", "4 damage to enemy, 1 damage to self", "DefaultCardBackground.jpg", 2);
            }
            if (db.GetCardBynameDBCards("Pixie Archers") == null)
            {
                db.AddCard("Pixie Archers", "Dungeon", "3 Damage to enemy tower", "DefaultCardBackground.jpg", 5);
            }
            if (db.GetCardBynameDBCards("Assassin") == null)
            {
                db.AddCard("Assassin", "Dungeon", "2 damage to enemy Dungeon", "DefaultCardBackground.jpg", 15);
            }
            if (db.GetCardBynameDBCards("Demonic Pact") == null)
            {
                db.AddCard("Demonic Pact", "Magic", "1 Magic, Dungeon, Quarry. 1 damage to enemy Magic, Dungeon, Quarry", "DefaultCardBackground.jpg", 30);
            }
            if (db.GetCardBynameDBCards("Earthquake") == null)
            {
                db.AddCard("Earthquake", "Magic", "12 damage to enemy wall", "DefaultCardBackground.jpg", 10);
            }
            if (db.GetCardBynameDBCards("Force Field") == null)
            {
                db.AddCard("Force Field", "Magic", "7 wall", "DefaultCardBackground.jpg", 5);
            }
            if (db.GetCardBynameDBCards("Knights") == null)
            {
                db.AddCard("Knights", "Dungeon", "10 damage to enemy", "DefaultCardBackground.jpg", 8);
            }
            if (db.GetCardBynameDBCards("Mole Mercenaries") == null)
            {
                db.AddCard("Mole Mercenaries", "Brick", "10 damage to enemy wall, 2 damage to enemy tower", "DefaultCardBackground.jpg", 10);
            }

        }
    }
}
