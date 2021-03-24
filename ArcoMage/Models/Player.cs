using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcoMage.Models
{
    public class Player : BindableBase
    {
        bool _IsCurrentTurn;
        int _TowerLevel;
        int _WallLevel;
        int _BrickLevel;
        int _MagicLevel;
        int _DungeonLevel;
        int _BrickQuantity;
        int _MagicQuantity;
        int _DungeonQuantity;
        List<Card> _Deck;
        ObservableCollection<Card> _Hand;
        List<Card> _Discard;

        public bool IsCurrentTurn { get { return _IsCurrentTurn; } set { SetProperty(ref _IsCurrentTurn, value); } }
        public int TowerLevel { get { return _TowerLevel; } set { SetProperty(ref _TowerLevel, value); } }
        public int WallLevel { get { return _WallLevel; } set { SetProperty(ref _WallLevel, value); } }
        public int BrickLevel { get { return _BrickLevel; } set { SetProperty(ref _BrickLevel, value); } }
        public int MagicLevel { get { return _MagicLevel; } set { SetProperty(ref _MagicLevel, value); } }
        public int DungeonLevel { get { return _DungeonLevel; } set { SetProperty(ref _DungeonLevel, value); } }
        public int BrickQuantity { get { return _BrickQuantity; } set { SetProperty(ref _BrickQuantity, value); } }
        public int MagicQuantity { get { return _MagicQuantity; } set { SetProperty(ref _MagicQuantity, value); } }
        public int DungeonQuantity { get { return _DungeonQuantity; } set { SetProperty(ref _DungeonQuantity, value); } }
        public List<Card> Deck { get { return _Deck; } set { SetProperty(ref _Deck, value); } }
        public ObservableCollection<Card> Hand { get { return _Hand; } set { SetProperty(ref _Hand, value); } }
        public List<Card> Discard { get { return _Discard; } set { SetProperty(ref _Discard, value); } }

        public Player()
        {

        }
    }
}
