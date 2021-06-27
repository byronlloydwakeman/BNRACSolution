using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.DataAccess
{
    public class MoveData
    {
        public List<AutoClickModel> FindMovesWithRequirements(int str, int stam, int dur
            , List<EnumItem> enumItems, EnumQuirk enumQuirk)
        {

            //Call stored procedure that find the entries which are below the minimum values for str, stam and dur 
            //Which use the user enumItems and is of the type enumQuirk

            return new List<AutoClickModel>();
        }

        public void SaveMove(AutoClickModel autoClickModel)
        {
            //Save the model to the data base, make sure to serialise it first
        }
    }
}
