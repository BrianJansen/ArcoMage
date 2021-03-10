using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ArcoMage
{
    public class MainVM : BindableBase
    {
        GameManager gm;
        Visibility player1Visibility;
        Visibility player2Visibility = Visibility.Collapsed;
        public MainVM(GameManager gm)
        {
            this.gm = gm;
            TestButton1 = new DelegateCommand(OnTest1);
            TestButton2 = new DelegateCommand(OnTest2);
            TestButton3 = new DelegateCommand(OnTest3);
            CardSelected = new DelegateCommand<Card>(OnCardSelected);
        }

        public DelegateCommand TestButton1 { get; set; }
        public DelegateCommand TestButton2 { get; set; }
        public DelegateCommand TestButton3 { get; set; }

        public DelegateCommand<Card> CardSelected { get; set; }

        public Player Player1 { get { return gm.Player1; } }
        public Player Player2 { get { return gm.Player2; } }

        public Visibility Player1Visibility { get { return player1Visibility; } set { SetProperty(ref player1Visibility, value); } }
        public Visibility Player2Visibility { get { return player2Visibility; } set { SetProperty(ref player2Visibility, value); } }

        void OnCardSelected(Card selectedCard)
        {
            Player CurrentPlayer;
            Player IdlePlayer;
            if (gm.Player1.IsCurrentTurn)
            {
                CurrentPlayer = gm.Player1;
                IdlePlayer = gm.Player2;
            }
            else
            {
                CurrentPlayer = gm.Player2;
                IdlePlayer = gm.Player1;
            }

            switch(selectedCard.CostType)
            {
                case Resources.Brick:
                    if(CurrentPlayer.BrickQuantity >= selectedCard.CostAmount)
                    {
                        CurrentPlayer.BrickQuantity -= selectedCard.CostAmount;
                        selectedCard.RunEffect(CurrentPlayer, IdlePlayer);
                        gm.DrawNewCard(selectedCard);
                        SwitchCurrentPlayer();
                    }
                    else
                    {
                        //run not enough resource message
                    }
                    break;
                case Resources.Magic:
                    if (CurrentPlayer.MagicQuantity >= selectedCard.CostAmount)
                    {
                        CurrentPlayer.MagicQuantity -= selectedCard.CostAmount;
                        selectedCard.RunEffect(CurrentPlayer, IdlePlayer);
                        gm.DrawNewCard(selectedCard);
                        SwitchCurrentPlayer();
                    }
                    else
                    {
                        //run not enough resource message
                    }
                    break;
                case Resources.Dungeon:
                    if (CurrentPlayer.DungeonQuantity >= selectedCard.CostAmount)
                    {
                        CurrentPlayer.DungeonQuantity -= selectedCard.CostAmount;
                        selectedCard.RunEffect(CurrentPlayer, IdlePlayer);
                        gm.DrawNewCard(selectedCard);
                        SwitchCurrentPlayer();
                    }
                    else
                    {
                        //run not enough resource message
                    }
                    break;
            }
        }

        public void SwitchCurrentPlayer()
        {
            Player1.IsCurrentTurn = !Player1.IsCurrentTurn;
            Player2.IsCurrentTurn = !Player2.IsCurrentTurn;
            if (Player1.IsCurrentTurn)
            {
                Player1Visibility = Visibility.Visible;
                Player2Visibility = Visibility.Collapsed;
                gm.GenerateResources(Player1);
            }
            else
            {
                Player1Visibility = Visibility.Collapsed;
                Player2Visibility = Visibility.Visible;
                gm.GenerateResources(Player2);
            }
        }

        void OnTest1()
        {
        }
        void OnTest2()
        {
        }
        void OnTest3()
        {
        }
    }
}
