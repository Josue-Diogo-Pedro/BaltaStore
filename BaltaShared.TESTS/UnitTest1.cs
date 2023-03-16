using BaltaShared.DOMAIN.StoreContext.Entities;

namespace BaltaShared.TESTS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer("Josué","Pedro","pedro@gmail.com","999999", "adresss");

            var order = new Order(c);
        }
    }
}