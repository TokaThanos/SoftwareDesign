using SoftwareSimulator;
using TransportSimulator;
using OrderSimulator;
using PaymentSimulatorStrategyPattern;
using WeatherForecastSimulatorObserverPatternPush;
using WeatherForecastObserverPullPattern;
using PizzaSimulatorDecoratorPattern;
using LogisticsServiceFactoryPattern;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestMethod();
            //CompanySimulatorFunction();
            //TransportSimulatorFunction();
            //OrderSimulatorFunction();
            //ShoppingCardSimulatorFunctionUsingStrategyPattern();
            //WeatherForecastSimulatorFunctionUsingObserverPushPattern();
            //WeatherForecastSimulatorFunctionUsingObserverPullPattern();
            //PizzaSimulatorFunction();
            LogisticsFactoryFuction();
        }

        private static void LogisticsFactoryFuction()
        {
            LogisticsService service = new LogisticsService();
            service.Send("water");
        }

        private static void PizzaSimulatorFunction()
        {
            IBasePizza pizza = new PlainPizza();
            pizza = new Chicken(new Mushroom(pizza));
            IBasePizza pizza2 = new Farmhouse();
            pizza2 = new Mushroom(new Cheese(pizza2));
            GetPizzaOrderDetails(pizza);
            GetPizzaOrderDetails(pizza2);
        }

        private static void GetPizzaOrderDetails(IBasePizza pizza)
        {
            Console.WriteLine($"Pizza description: {pizza.GetDescription()}");
            Console.WriteLine($"Pizza price is {pizza.GetCost()} rs.");
        }

        private static void WeatherForecastSimulatorFunctionUsingObserverPullPattern()
        {
            WeatherForecastStation station = new WeatherForecastStation();
            station.AddSubscriber(new TempStatDisplay(station));
            station.AddSubscriber(new HumStatDisplay(station));
            station.SetWeatherData(12.55, 52);
        }

        private static void WeatherForecastSimulatorFunctionUsingObserverPushPattern()
        {
            WeatherStation weatherStation = new WeatherStation();
            weatherStation.AddSubscriber(new StatisticsDisplay());
            weatherStation.AddSubscriber(new CurrentConditionDisplay());
            weatherStation.SetWeatherReading(14, 55);
        }

        private static void ShoppingCardSimulatorFunctionUsingStrategyPattern()
        {
            ShoppingCart shoppingCart = new ShoppingCart(new CashPayment());
            shoppingCart.Checkout(120);
            ShoppingCart shoppingCart2 = new ShoppingCart(new CreditCardPayment());
            shoppingCart2.Checkout(230);
        }

        private static void OrderSimulatorFunction()
        {
            var itemList = new List<Item>()
            {
                new Item("Controller", 1250, 0.3, 2),
                //new Item("Mouse", 3500, 0.65, 1),
                //new Item("LightBar", 3210, 0.2, 1),
                //new Item("Monitor", 19650, 10.5, 2)
            };

            Order order = new Order(itemList);
            Console.WriteLine($"Item shipped! Total item cost is {order.GetTotalCost()} with shipping charges {order.GetShippingCost()}");
            Console.WriteLine($"Estimated delivery on {order.GetShippingDate()}");
        }

        private static void TransportSimulatorFunction()
        {
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
