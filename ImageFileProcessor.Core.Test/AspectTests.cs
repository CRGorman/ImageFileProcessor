using ImageFileProcessor.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImageFileProcessor.Core.Tests
{
    [TestClass]
    public class AspectTests
    {
        [TestMethod]
        public void AspectMover()
        {
            AspectSearch aspectSearch = new();
            Assert.IsTrue(aspectSearch.SortInstagram(@"C:\Users\Zero\OneDrive\Pictures", true, @"C:\Users\Zero\OneDrive\Pictures\Instagram"));
        }
    }
}