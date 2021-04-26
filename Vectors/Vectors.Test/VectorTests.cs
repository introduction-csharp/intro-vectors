using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vectors.Lib;

namespace Vectors.Test
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void TestZeroSize()
        {
            Vector<int> v = new Vector<int>();
            Assert.AreEqual(0, v.Size);
        }

        [TestMethod]
        public void TestSize()
        {
            IList<double> elements = new List<double> { 1.0, 2.1, 3.2, -7.6 };
            Vector<double> v = new Vector<double>(elements);
            Assert.AreEqual(4, v.Size);
        }

        [TestMethod]
        public void TestEquals()
        {
            IList<double> elements = new List<double> { 1.0, 2.1, 3.2, -7.6 };
            IList<double> elements2 = new List<double> { 1.0, 2.1, 3.2, -7.6 };
            Vector<double> v1 = new Vector<double>(elements);
            Vector<double> v2 = new Vector<double>(elements);
            Assert.IsTrue(v1.Equals(v2));
        }

        [TestMethod]
        public void TestAdd()
        {
            IList<int> a = new List<int> { 1, 2, 3, -7 };
            IList<int> b = new List<int> { 2, 4, 6, -8 };
            IList<int> c = new List<int> { 3, 6, 9, -15 };
            Vector<int> v1 = new Vector<int>(a);
            Vector<int> v2 = new Vector<int>(b);
            Vector<int> r = new Vector<int>(c);
            Assert.IsTrue(r.Equals(v1.Add(v2)));
        }

    }
}
