using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab2
{
    [TestClass]
    public class BinaryFlagTesting
    {

        [TestMethod]
        public void ConstructorOnMinSize()
        {
            new IIG.BinaryFlag.MultipleBinaryFlag(2);
        }

        [TestMethod]
        public void ConstructorOverMinSize()
        {
            new IIG.BinaryFlag.MultipleBinaryFlag(3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorUnderMinSize()
        {
            new IIG.BinaryFlag.MultipleBinaryFlag(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorOverMaxSize()
        {
            new IIG.BinaryFlag.MultipleBinaryFlag(17179868705);
        }

        [TestMethod]
        public void ConstructorUnderMaxSize()
        {
            new IIG.BinaryFlag.MultipleBinaryFlag(17179868703);
        }

        [TestMethod]
        public void ConstructorOnMaxSize()
        {
            new IIG.BinaryFlag.MultipleBinaryFlag(17179868704);
        }

        [TestMethod]
        public void ConstructorDefaultGetTrue()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            Assert.IsTrue((bool)test.GetFlag());
        }

        public void ConstructorGetFalse()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            Assert.IsFalse((bool)test.GetFlag());
        }

        [TestMethod]
        public void SetGetTrue()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            test.SetFlag(0);
            test.SetFlag(1);
            Assert.IsTrue((bool)test.GetFlag());
        }

        [TestMethod]
        public void SetGetFalse()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            test.SetFlag(0);
            Assert.IsFalse((bool)test.GetFlag());
        }

        [TestMethod]
        public void ResetOneGetFalse()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(3);
            test.ResetFlag(1);
            Assert.IsFalse((bool)test.GetFlag());
        }

        [TestMethod]
        public void ResetAllGetFalse()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(3);
            test.ResetFlag(0);
            test.ResetFlag(1);
            test.ResetFlag(2);
            Assert.IsFalse((bool)test.GetFlag());
        }

        [TestMethod]
        public void ResetSetGetTrue()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(3);
            test.ResetFlag(1);
            test.SetFlag(1);
            Assert.IsTrue((bool)test.GetFlag());
        }

        [TestMethod]
        public void Dispose()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(3);
            test.Dispose();
            Assert.AreEqual(null, test.GetFlag());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetOverSize()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            test.SetFlag(2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ResetOverSize()
        {
            var test = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            test.ResetFlag(2);
        }
    }
}

