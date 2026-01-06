using SoftwareSimulator;
using TransportSimulator;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestMethod();
            //CompanySimulatorFunction();
            Transport transport = new Transport(new HumanDriver());
            transport.Deliver("Kenya");
        }

        private static void CompanySimulatorFunction()
        {
            List<Company> companies = new List<Company>()
            {
                new GameDevCompany(),
                new OutsourcingCompany(),
            };
            foreach (Company company in companies)
            {
                company.CreateSoftware();
                Console.WriteLine("---------");
            }
        }

        private static void TestMethod()
        {
            List<Unit> units = new List<Unit>()
            {
                new Player(10),
                new Enemy(5),
            };

            foreach (Unit unit in units)
            {
                unit.Move();

                // using as conversion
                /*
                var inventoryUnit = unit as IInventory;
                if (inventoryUnit != null)
                {
                    GetInventoryItems(inventoryUnit);
                }
                */

                // using pattern matching
                if (unit is IInventory inventoryUnit)
                {
                    GetInventoryItems(inventoryUnit);
                }
            }
        }

        private static void GetInventoryItems(IInventory inventoryUnit)
        {
            Console.WriteLine("Inventory contains");
            foreach (string elem in inventoryUnit.Inventory())
            {
                Console.WriteLine(elem);
            }
        }

        public class Player : Unit, IAttackable, IInventory
        {
            public Player(int power)
            {
                SetPower(power);
            }
            public override void Move()
            {
                Console.WriteLine($"Player moves with power {Power}");
            }

            public void Attack()
            {
                Console.WriteLine("Player attacks");
            }

            public List<string> Inventory()
            {
                List<string> items = new List<string>()
                {
                    "Apples",
                    "Sword",
                    "Hat",
                    "Winter Cloth",
                    "Food can"
                };

                return items;
            }
        }

        public class Enemy : Unit, IAttackable
        {
            public Enemy(int power)
            {
                SetPower(power);
            }

            public void Attack()
            {
                Console.WriteLine("Enemy attacks");
            }

            public override void Move()
            {
                Console.WriteLine($"Enemy moves with power {Power}");
            }
        }

        public abstract class Unit
        {
            protected int Power { get; private set; }
            protected void SetPower(int power)
            {
                Power = power;
            }
            public abstract void Move();
        }
    }
}
