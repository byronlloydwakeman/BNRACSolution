using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.Models
{
    public class AutoClickModel
    {
        public EnumQuirk Quirk { get; set; }
        public int MinimumStrength { get; set; }
        public int MinimumStamina { get; set; }
        public int MinimumDurability { get; set; }
        public List<EnumItem> Items { get; set; }
        public MoveModel SequenceOfMoves { get; set; }

        public void PerformMove()
        {
            //Loop through sequence of moves, performing given keystrokes and what not
        }
    }
}
