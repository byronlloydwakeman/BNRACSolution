using Autofac;
using DataManager.Library.AutoFac;
using DataManager.Library.Conversion;
using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataManager.Library.Tests.Conversion
{
    public class ConvertEnumTests
    {
        private IConvertEnum _convert;
        public ConvertEnumTests()
        {
            using (ILifetimeScope scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                _convert = scope.Resolve<IConvertEnum>();
            }
        }

        [Theory]
        [InlineData("Electric", EnumQuirk.Electric)]
        [InlineData("AllForOne", EnumQuirk.AllForOne)]
        public void ConvertStringQuirkToEnumQuirkShouldWork(string quirk, EnumQuirk expected)
        {
            EnumQuirk actual = _convert.ConvertStringQuirkToEnumQuirk(quirk);

            Assert.Equal(expected, actual);
        }

        [Fact]  
        public void ConvertStringToListOfEnumItemShouldWork()
        {
            string items = "HalloweenScythe;ChristmasArmor;";

            List<EnumItem> actual = _convert.ConvertStringToListOfEnumItem(items);

            List<EnumItem> expected = new List<EnumItem>()
            {
                EnumItem.HalloweenScythe,
                EnumItem.ChristmasArmor
            };

            Assert.Equal(expected, actual);

        }
    }
}
