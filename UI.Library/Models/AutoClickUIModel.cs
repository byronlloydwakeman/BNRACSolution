using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Library.Models
{
    public class AutoClickUIModel
    {
        public EnumQuirk Quirk { get; set; }
        public int MinimumStrength { get; set; }
        public int MinimumStamina { get; set; }
        public int MinimumDurability { get; set; }
        public List<EnumItem> Items { get; set; }
        public MoveModel SequenceOfMoves { get; set; }

        public override string ToString()
        {
            string toReturn = $"Quirk : {Quirk}, MinStr : {MinimumStrength}, MinStam : {MinimumStamina}, MinDur : {MinimumDurability}, Items : ";
            foreach (var item in Items)
            {
                toReturn += $"{item}, ";
            }

            return toReturn;
        }
    }
}
