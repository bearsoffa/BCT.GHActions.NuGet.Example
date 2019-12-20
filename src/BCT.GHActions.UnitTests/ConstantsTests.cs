using BCT.GHActions.NuGet.Example;
using System;
using Xunit;

namespace BCT.GHActions.UnitTests
{
    public class ConstantTests
    {
        [Fact]
        public void ProjectNameTest()
        {
            var project = Constants.Project;
            Assert.Equal("TNG", project);
        }
    }
}
