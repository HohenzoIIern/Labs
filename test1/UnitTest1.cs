using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab2
{
    [TestClass]
    public class BinaryFlagTesting
    {

        [TestMethod]
        
        public void MinSize()
        {
            new IIG.BinaryFlag.MultipleBinaryFlag(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OverMaxSize()
        {
            new IIG.BinaryFlag.MultipleBinaryFlag(17179868705);
        }

        [TestMethod]
        public void GetTrueSize1()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(1);
            test.SetFlag(0);
            Assert.IsTrue((bool)test.GetFlag());
        }

        public void GetTrue()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            test.SetFlag(0);
            Assert.IsTrue((bool)test.GetFlag());
        }

        [TestMethod]
        public void GetTrueByDefault()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(1);
            Assert.IsFalse((bool)test.GetFlag());
        }


        [TestMethod]
        public void Dispose()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2);

            test.SetFlag(0);
            test.SetFlag(1);
            test.Dispose();
            test.SetFlag(1);

            Assert.AreEqual(null, test.GetFlag());
        }

        [TestMethod]
        public void ResetAll()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2);

            test.SetFlag(0);
            test.SetFlag(1);
            test.ResetFlag(0);
            test.ResetFlag(1);

            Assert.IsFalse((bool)test.GetFlag());
        }

        [TestMethod]
        public void ResetPartly()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2);

            test.SetFlag(0);
            test.SetFlag(1);
            test.ResetFlag(0);

            Assert.IsFalse((bool)test.GetFlag());
        }

        [TestMethod]
        public void MultipleReset()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(10, true);

            for (ulong i = 0; i < 10; i++)
            {
                test.ResetFlag(i);
            }

            Assert.IsFalse((bool)test.GetFlag());
        }

        [TestMethod]
        public void MultipleGetT()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(10, true);
            for (ulong i = 0; i < 10; i++)
            {
                Assert.IsTrue((bool)test.GetFlag());
            }
        }

        [TestMethod]
        public void MultipleGetF()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(10, true);
            test.ResetFlag(0);
            Assert.IsFalse((bool)test.GetFlag());
        }
    }
}

