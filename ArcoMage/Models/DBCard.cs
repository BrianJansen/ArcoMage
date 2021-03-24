using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcoMage.Models
{
    public class DBCard
    {
        public int CardId { get; set; }
        public string CostType { get; set; }
        public string CardName { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public int CostAmount { get; set; }
    }
}
