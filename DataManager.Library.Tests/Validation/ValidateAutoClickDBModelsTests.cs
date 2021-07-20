using Autofac;
using DataManager.Library.AutoFac;
using DataManager.Library.Models;
using DataManager.Library.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataManager.Library.Tests.Validation
{
    public class ValidateAutoClickDBModelsTests
    {
        private IValidateAutoClickDBModels _validate;
        public ValidateAutoClickDBModelsTests()
        {
            var container = ContainerConfig.Configure();

            using (ILifetimeScope scope = container.BeginLifetimeScope())
            {
                _validate = scope.Resolve<IValidateAutoClickDBModels>();
            }
        }

        [Theory]
        [InlineData("", "", "ChristmasArmor;", 3)]
        [InlineData("", "", "ChristmasArmor;HalloweenScythe;", 2)]
        [InlineData("ChristmasArmor;HalloweenScythe;", "ChristmasArmor;HalloweenScythe;", "ChristmasArmor;HalloweenScythe;", 0)]
        public void ValidateDbModelsShouldWork(string listOfItems1, string listOfItems2, string listOfItems3, int count)
        {
            AutoClickDBModel autoClickDBModel1 = new AutoClickDBModel()
            {
                Items = listOfItems1
            };
            AutoClickDBModel autoClickDBModel2 = new AutoClickDBModel()
            {
                Items = listOfItems2
            };
            AutoClickDBModel autoClickDBModel3 = new AutoClickDBModel()
            {
                Items = listOfItems3
            };

            List<EnumItem> enumItems = new List<EnumItem>()
            {
                EnumItem.ChristmasArmor
            };

            List<AutoClickDBModel> validDBModels = _validate.ValidateDBModelsWithItems(new List<AutoClickDBModel>() { autoClickDBModel1, autoClickDBModel2, autoClickDBModel3 }, enumItems);

            Assert.Equal(count, validDBModels.Count);

        }

    }
}
