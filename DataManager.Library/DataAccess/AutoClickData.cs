using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.DataAccess
{
    public class AutoClickData : IAutoClickData
    {
        private readonly ISqlDataAccess sqlDataAccess;

        public AutoClickData(ISqlDataAccess sqlDataAccess)
        {
            this.sqlDataAccess = sqlDataAccess;
        }

        public List<AutoClickDBModel> GetDBModelsWithGivenRequirements(int str, int stam, int dur, string quirk)
        {
            List<AutoClickDBModel> dBModels = sqlDataAccess.LoadData<AutoClickDBModel, dynamic>("spAutoClick_GetMin", new { Quirk = quirk, MinStr = str, MinDur = dur, MinStam = stam }, "Data");
            return dBModels;
        }

        public void InsertDBModel(AutoClickDBModel model)
        {
            //Insert model into database
        }
    }
}