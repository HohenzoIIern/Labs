using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIG.PasswordHashingUtils;

namespace Lab3
{
    [TestClass]
    public class HashTest
    {
        [TestMethod]
        public void Route_1_2_3_4_5_6_7_GetHash()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, "Æasdsa⛐⛐", 10));
        }

        [TestMethod]
        public void Route_1_2_3_4_5_6_8_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "Æasdsa⛐⛐", 10));
        }

        [TestMethod]
        public void Route_1_2_3_4_5_6_8_9_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("Æasdsa⛐⛐", "Æasdsa⛐⛐", 10));
        }

        [TestMethod]
        public void Route_1_2_3_4_6_7_GetHash()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, "Æasdsa⛐⛐", null));
        }

        [TestMethod]
        public void Route_1_2_3_4_6_8_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "Æasdsa⛐⛐", null));
        }

        [TestMethod]
        public void Route_1_2_3_4_6_8_9_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("Æasdsa⛐⛐", "Æasdsa⛐⛐", null));
        }

        [TestMethod]
        public void Route_1_2_4_5_6_7_GetHash()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, "1111", 10));
        }

        [TestMethod]
        public void Route_1_2_4_5_6_8_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "1111", 10));
        }

        [TestMethod]
        public void Route_1_2_4_5_6_8_9_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("Æasdsa⛐⛐", "1111", 10));
        }

        [TestMethod]
        public void Route_1_2_4_6_7_GetHash()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, "1111", null));
        }

        [TestMethod]
        public void Route_1_2_4_6_8_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "1111", null));
        }

        [TestMethod]
        public void Route_1_2_4_6_8_9_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("Æasdsa⛐⛐", "1111", null));
        }

        [TestMethod]
        public void Route_1_5_6_7_GetHash()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, null, 10));
        }

        [TestMethod]
        public void Route_1_5_6_8_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", null, 10));
        }

        [TestMethod]
        public void Route_1_5_6_8_9_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("Æasdsa⛐⛐", null, 10));
        }

        [TestMethod]
        public void Route_1_6_7_GetHash()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, null, null));
        }

        [TestMethod]
        public void Route_1_6_8_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", null, null));
        }

        [TestMethod]
        public void Route_1_6_8_9_10_GetHash()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("Æasdsa⛐⛐", null, null));
        }

        [TestMethod]
        public void Route_1_2_3_4_5_6_InitSet()
        {
            PasswordHasher.Init("Æasdsa⛐⛐",  10);
            Assert.IsNotNull(PasswordHasher.GetHash("1111"));
        }

        [TestMethod]
        public void Route_1_2_4_5_6_InitSet()
        {
            PasswordHasher.Init("1111", 10);
            Assert.IsNotNull(PasswordHasher.GetHash("1111"));
        }

        [TestMethod]
        public void Route_1_5_6_InitSet()
        {
            PasswordHasher.Init(null, 10);
            Assert.IsNotNull(PasswordHasher.GetHash("1111"));
        }

        [TestMethod]
        public void Route_1_2_3_4_6_InitSet()
        {
            PasswordHasher.Init("Æasdsa⛐⛐", 0);
            Assert.IsNotNull(PasswordHasher.GetHash("1111"));
        }

        [TestMethod]
        public void Route_1_2_4_6_InitSet()
        {
            PasswordHasher.Init("1111", 0);
            Assert.IsNotNull(PasswordHasher.GetHash("1111"));
        }

        [TestMethod]
        public void Route_1_6_InitSet()
        {
            PasswordHasher.Init(null, 0);
            Assert.IsNotNull(PasswordHasher.GetHash("1111"));
        }
    }
}
