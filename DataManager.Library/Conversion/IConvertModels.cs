using DataManager.Library.Models;

namespace DataManager.Library.Conversion
{
    public interface IConvertModels
    {
        AutoClickModel ConvertDBModelToBackEndModel(AutoClickDBModel autoClickDBModel);
    }
}