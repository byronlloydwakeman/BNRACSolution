using DataManager.Library.DataFormatting;
using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.Validation
{
    public class ValidateAutoClickDBModels : IValidateAutoClickDBModels
    {
        private readonly IDeformatData _deformatData;

        public ValidateAutoClickDBModels(IDeformatData deformatData)
        {
            _deformatData = deformatData;
        }

        public List<AutoClickDBModel> ValidateDBModelsWithItems(List<AutoClickDBModel> autoClickDBModels, List<EnumItem> enumItems)
        {
            List<AutoClickDBModel> toReturn = new List<AutoClickDBModel>();

            //loop through list of db models, and add those which enumItems contains
            foreach (var item in autoClickDBModels)
            {
                //Get the list of items as a string
                List<string> itemsEnumItemsAsStrings = _deformatData.DeformatStringIntoList(item.Items);

                bool doesContain = true;

                //Convert the strings to an enum, and as we do check if it contains it
                foreach (var itemsEnumItem in itemsEnumItemsAsStrings)
                {
                    //Convert the string to an enum and see if the users list of items contains it

                    EnumItem a = (EnumItem)Enum.Parse(typeof(EnumItem), itemsEnumItem);
                    if (!enumItems.Contains(a))
                    {
                        doesContain = false;
                    }
                }

                if (doesContain)
                {
                    toReturn.Add(item);
                }

            }

            return toReturn;
        }
    }
}
