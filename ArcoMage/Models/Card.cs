using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ArcoMage.Models
{
    public class Card : BindableBase
    {
        public int CardId { get; set; }
        public Resources CostType { get; set; }
        public int CostAmount { get; set; }
        public string CardName { get; set; }
        public BitmapImage Image { get; set; }
        public string Description { get; set; }
        public SolidColorBrush CostColor { get; set; }

        public Card()
        {
        }

        void Damage(Player player, int amount)
        {
            int overflow = player.WallLevel - amount;
            if (overflow < 0)
            {
                player.WallLevel = 0;
                player.TowerLevel = player.TowerLevel <= Math.Abs(overflow) ? 0 : player.TowerLevel += overflow;
            }
            else
                player.WallLevel -= amount;
        }

        public void RunEffect(Player player, Player opponent)
        {
            switch(CardName)
            {
                case "Basic Wall":
                    player.WallLevel += 6;
                    break;
                case "Full Moon":
                    player.DungeonLevel += 1;
                    break;
                case "Goblin Archers":
                    Damage(player, 1);
                    Damage(opponent, 4);
                    break;
                case "Motherlode":
                    player.BrickQuantity += 15;
                    player.MagicQuantity += 10;
                    break;
                case "Quarrys Help":
                    player.BrickLevel += 2;
                    opponent.BrickLevel += 1;
                    break;
                case "Sturdy Wall":
                    player.WallLevel += 10;
                    break;
                case "Assassin":
                    opponent.DungeonLevel = opponent.DungeonLevel <= 1 ?  1 : opponent.DungeonLevel -= 2;
                    break;
                case "Demonic Pact":
                    player.BrickLevel++; player.MagicLevel++; player.DungeonLevel++;
                    opponent.BrickLevel = opponent.BrickLevel <= 1 ? 1 : opponent.BrickLevel -= 1;
                    opponent.MagicLevel = opponent.MagicLevel <= 1 ? 1 : opponent.MagicLevel -= 1;
                    opponent.DungeonLevel = opponent.DungeonLevel <= 1 ? 1 : opponent.DungeonLevel -= 1;
                    break;
                case "Earthquake":
                    opponent.WallLevel = opponent.WallLevel <= 12 ? 0 : opponent.WallLevel -= 12;
                    break;
                case "Force Field":
                    player.WallLevel += 7;
                    break;
                case "Knights":
                    Damage(opponent, 10);
                    break;
                case "Mole Mercenaries":
                    opponent.WallLevel = opponent.WallLevel <= 10 ? 0 : opponent.WallLevel -= 10;
                    opponent.TowerLevel = opponent.TowerLevel <= 2 ? 0 : opponent.TowerLevel -= 2;
                    break;
                case "Pixie Archers":
                    opponent.TowerLevel = opponent.TowerLevel <= 3 ? 0 : opponent.TowerLevel -= 3;
                    break;
                //case CardName:
                //    break;
                //case CardName:
                //    break;
                //case CardName:
                //    break;
            }
        }
        
    }
}
