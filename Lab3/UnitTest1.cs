using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIG.PasswordHashingUtils;

namespace Lab3
{
    [TestClass]
    public class HashTest
    {

        [TestMethod]
        public void Route_1_2_3_4_5_6_7()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, "1111", 3));
        }

        [TestMethod]
        public void Route_1_2_3_4_5_6_8_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "BCF8082AE63068A0A80A50F83E0F3FA8B7A7CB0167BB3885F7D92977F2FA349B", 3));
        }

        [TestMethod]
        public void Route_1_2_3_4_5_6_8_9_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "BCF8082AE63068A0A80A50F83E0F3FA8B7A7CB0167BB3885F7D92977F2FA349B", 3));
        }

        [TestMethod]
        public void Route_1_2_3_4_6_7()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, "BCF8082AE63068A0A80A50F83E0F3FA8B7A7CB0167BB3885F7D92977F2FA349B"));
        }

        [TestMethod]
        public void Route_1_2_3_4_6_8_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "BCF8082AE63068A0A80A50F83E0F3FA8B7A7CB0167BB3885F7D92977F2FA349B"));
        }

        [TestMethod]
        public void Route_1_2_3_4_6_8_9_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "BCF8082AE63068A0A80A50F83E0F3FA8B7A7CB0167BB3885F7D92977F2FA349B"));
        }

        [TestMethod]
        public void Route_1_2_4_5_6_7()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, "1111", 3));
        }

        [TestMethod]
        public void Route_1_2_4_5_6_8_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "1111", 3));
        }

        [TestMethod]
        public void Route_1_2_4_5_6_8_9_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "1111", 3));
        }

        [TestMethod]
        public void Route_1_2_4_6_7()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, "1111"));
        }

        [TestMethod]
        public void Route_1_2_4_6_8_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "1111"));
        }

        [TestMethod]
        public void Route_1_2_4_6_8_9_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", "1111"));
        }

        [TestMethod]
        public void Route_1_5_6_7()
        {
            Assert.IsNull(PasswordHasher.GetHash(null, null, 3));
        }

        [TestMethod]
        public void Route_1_5_6_8_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", null, 3));
        }

        [TestMethod]
        public void Route_1_5_6_8_9_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111", null, 3));
        }

        [TestMethod]
        public void Route_1_6_7()
        {
            Assert.IsNull(PasswordHasher.GetHash(null));
        }

        [TestMethod]
        public void Route_1_6_8_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111"));
        }

        [TestMethod]
        public void Route_1_6_8_9_10()
        {
            Assert.IsNotNull(PasswordHasher.GetHash("1111"));
        }
    }
}
