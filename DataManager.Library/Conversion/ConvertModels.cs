using DataManager.Library.DataFormatting;
using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.Conversion
{
    public class ConvertModels : IConvertModels
    {
        private IConvertEnum _convertEnum;
        private IDeformatData _deformatData;

        public ConvertModels(IConvertEnum convertEnum, IDeformatData deformatData)
        {
            _convertEnum = convertEnum;
            _deformatData = deformatData;
        }

        public AutoClickModel ConvertDBModelToBackEndModel(AutoClickDBModel autoClickDBModel)
        {
            AutoClickModel toReturn = new AutoClickModel();

            //Convert quirk of type string to type enum
            toReturn.Quirk = _convertEnum.ConvertStringQuirkToEnumQuirk(autoClickDBModel.Quirk);

            //Map over strength stamina and durability
            toReturn.MinimumDurability = autoClickDBModel.MinimumDurability;
            toReturn.MinimumStamina = autoClickDBModel.MinimumStamina;
            toReturn.MinimumStrength = autoClickDBModel.MinimumStrength;

            //Convert string of items to list of enum items, we'll have to do this in two parts. Convert the string into a list of string and then convert the list of string into a list of enum
            toReturn.Items = _convertEnum.ConvertStringToListOfEnumItem(autoClickDBModel.Items);

            //Convert string of moves to a list of string
            toReturn.SequenceOfMoves = new MoveModel()
            {
                //Convert the string to a list of strings
                Moves = _deformatData.DeformatStringIntoList(autoClickDBModel.Moves),
                //Convert the string to a list of int
                Timing = _deformatData.DeformatStringIntoList(autoClickDBModel.Timing).Select(x => int.Parse(x)).ToList()
            };

            return toReturn;
        }
    }
}
