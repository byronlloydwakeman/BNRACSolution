using DataManager.Library.Conversion;
using DataManager.Library.DataAccess;
using DataManager.Library.DataFormatting;
using DataManager.Library.Models;
using DataManager.Library.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.Data
{
    public class AutoClickFormattedData : IAutoClickFormattedData
    {
        private readonly IAutoClickData _autoClickData;
        private readonly IValidateAutoClickDBModels _validateAutoClickDBModels;
        private readonly IConvertModels _convertModels;
        private readonly IConvertEnum _convertEnum;

        public AutoClickFormattedData(IAutoClickData autoClickData, IValidateAutoClickDBModels validateAutoClickDBModels, IConvertModels convertModels
            , IConvertEnum convertEnum)
        {
            _autoClickData = autoClickData;
            _validateAutoClickDBModels = validateAutoClickDBModels;
            _convertModels = convertModels;
            _convertEnum = convertEnum;
        }

        public List<AutoClickModel> GetModelsWithGivenRequirements(int str, int stam, int dur, string itemsAsString, EnumQuirk quirk)
        {
            //Db models with given str, stam and dur requirements
            List<AutoClickDBModel> autoClickDBModels = _autoClickData.GetDBModelsWithGivenRequirements(str, stam, dur, quirk.ToString());

            //Convert the string of items to a list of enum
            List<EnumItem> enumItems = _convertEnum.ConvertStringToListOfEnumItem(itemsAsString);

            //All valid db models
            List<AutoClickDBModel> validAutoClickDbModels = _validateAutoClickDBModels.ValidateDBModelsWithItems(autoClickDBModels, enumItems);

            //Convert Db model to a back end model
            List<AutoClickModel> autoClickModels = new List<AutoClickModel>();

            foreach (var model in validAutoClickDbModels)
            {
                autoClickModels.Add(_convertModels.ConvertDBModelToBackEndModel(model));
            }

            return autoClickModels;
        }

        public void InsertAutoClickModel(AutoClickModel model)
        {
            //Convert model to AutoClickDBModel then call a method in AutoClickData
        }
    }
}
