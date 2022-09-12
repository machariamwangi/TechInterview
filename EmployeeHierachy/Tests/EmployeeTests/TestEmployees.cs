using EmployeeHierachy;

namespace EmployeeTests
{
    [TestClass]
    public class TestEmployees
    {
        [TestMethod]
        public void TestExceptionisThrownWhenAnInvalidCSVListIsInput()
        {
            Assert.ThrowsException<Exception>(() => new Employees(""));

        }

        [TestMethod]
        public void TestExceptionisThrownWhenOneEmployessReportsToMoreThanoneManger()
        {
            Assert.ThrowsException<Exception>(() => new Employees("John,manager1,100" +
                "\n" +
                "Joyce,manager1," + //error
                "1900\nJames,manager2,100" +
                "\n" +
                "Joyce,manager3,1900" + //error
                "\nCEO,,1000 \n " +
                "manager1,CEO,1900" +
                "\n" +
                "manager3,CEO,1900\nsalasia,manager1,1900\nmanager2,CEO,1900"));

        }

        [TestMethod]
        public void TestExceptionisThrownWhenWehaveMoreThanOneCEO()
        {
            //Only one ceo
            Assert.ThrowsException<Exception>(() => new Employees("John,manager1,100" +
                "\n" +
                "Joyce,manager1," +
                "1900\nJames,manager2,100" +
                "\n" +
                "Eve,,1900" + // error
                "\nCEO,,1000 \n " + // error
                "manager1,CEO,1900" +
                "\n" +
                "manager3,CEO,1900\nsalasia,manager1,1900\nmanager2,CEO,1900"));

        }

        [TestMethod]
        public void TestExceptionisThrownWhenWehaveCircularReference()
        {
            Assert.ThrowsException<Exception>(() => new Employees("John,manager1,100" +
                "\n" +
                "Joyce,manager1," +
                "1900\nJames,manager2,100" +
                "\n" +
                "Eve,manager1,1900" +
                "\nCEO,,1000 \n " +
                "manager1,CEO,1900" +
                "\n" +
                "manager2,manager1,1900\n" + // error
    "salasia,manager1,1900\nmanager2,CEO,1900"));

        }

        [TestMethod]
        public void TestExceptionisThrownWhenAllManagersAreNotListedInEmployessCell()
        {
            Assert.ThrowsException<Exception>(() => new Employees("John,manager1,100" +
                "\n" +
                "Joyce,manager1," +
                "1900\nJames,manager2,100" +
                "\n" +
                "Eve,manager5,1900" + //error
                "\nCEO,,1000 \n " +
                "manager1,CEO,1900" +
                "\n" +
                "employess,manager1,1900\nsalasia,manager1,1900\nmanager2,CEO,1900"));

        }

        [TestMethod]
        public void TestManagerBurgetsReturnsCorrect()
        {

            Employees employees = new Employees(
                "name1,manager1,56" +
                "\n" +
                "name2,manager2,20" +
                "\n" +
                "name3,manager3,89" +
                "\n" +
                "name4,,100" +   // ceo
                "\n" +
                "manager1,name4,90" + // manager1 under ceo
                "\n" +
                "manager2,name4,90" +
                "\n" +
                "manager3,name4,90"
                );
            //employee name4(CEO) 100 +90+90_90 = 370

            Assert.AreEqual(370, employees.managerSalaryBudget("name4"));

        }
    }
}