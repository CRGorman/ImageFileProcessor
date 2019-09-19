using ImageFileProcessor.Core;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AspectMover()
        {
            AspectSearch aspectSearch = new AspectSearch();
            if (aspectSearch.SortInstagram(@"C:\Users\Zero\OneDrive\Pictures", true, @"C:\Users\Zero\OneDrive\Pictures\Instagram"))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}