using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace BrickWorks
{
    //class DatabaseInitializer : DropCreateDatabaseAlways<BrickWorksModel>
    class MyInitializer : CreateDatabaseIfNotExists<BrickWorksModel>
    {
        private static void InitBricksAndCosts(BrickWorksModel db)
        {
            var bricks = new List<Brick>
            {
                new Brick
                {
                    Mark = "Кирпич керамический пустотелый одинарный рядовой",
                    Lenght = 0.25F,
                    Width = 0.12F,
                    Height = 0.065F,
                    Parameters = "Цвет: красный"

                }
            };

            var bc = new BrickCost { Date = new DateTime(2017, 01, 01), Cost = 8, Brick = bricks.Last() };
            db.BrickCosts.Add(bc);

            bricks.Add(new Brick
            {
                Mark = "Кирпич керамический пустотелый утолщенный",
                Lenght = 0.25F,
                Width = 0.12F,
                Height = 0.065F,
                Parameters = "Цвет: оранжевый"
            });

            bc = new BrickCost { Date = new DateTime(2017, 01, 01), Cost = 10.2F, Brick = bricks.Last() };
            db.BrickCosts.Add(bc);

            bricks.Add(new Brick
            {
                Mark = "Кирпич полнотелый одинарный М200",
                Lenght = 0.25F,
                Width = 0.12F,
                Height = 0.065F,
                Parameters = "Цвет: серый"
            });

            bc = new BrickCost { Date = new DateTime(2017, 01, 01), Cost = 10.2F, Brick = bricks.Last() };
            db.BrickCosts.Add(bc);

            bricks.Add(new Brick
            {
                Mark = "Кирпич полнотелый утолщенный М200",
                Lenght = 0.25F,
                Width = 0.12F,
                Height = 0.14F,
                Parameters = "Цвет: коричневый"
            });

            bc = new BrickCost { Date = new DateTime(2017, 01, 01), Cost = 18.92F, Brick = bricks.Last() };
            db.BrickCosts.Add(bc);

            db.Bricks.AddRange(bricks);
            db.SaveChanges();
        }

        private static void InitManufacturedBricks(BrickWorksModel db)
        {
            var mfBricks = new List<ManufacturedBrick>
            {
                new ManufacturedBrick { Date = new DateTime(2017, 02, 01), BrickId = 1, Quantity = 10000 },
                new ManufacturedBrick { Date = new DateTime(2017, 02, 01), BrickId = 2, Quantity = 10000 },
                new ManufacturedBrick { Date = new DateTime(2017, 02, 01), BrickId = 3, Quantity = 10000 },
                new ManufacturedBrick { Date = new DateTime(2017, 02, 01), BrickId = 4, Quantity = 10000 }
            };
            db.ManufacturedBricks.AddRange(mfBricks);
            db.SaveChanges();
        }

        private static void InitClients(BrickWorksModel db)
        {
            var clients = new List<Client>
            {
                new Client { Name = "Иванов Петр Сидорович", Phone = "+79141234567" },
                new Client { Name = "Сидорова Иванна Петровна", Phone = "+79147654321" }
            };
            db.Clients.AddRange(clients);
            db.SaveChanges();
        }

        private static void InitBuildings(BrickWorksModel db)
        {
            var buildings = new List<Building>
            {
                new Building {ClientID = 1, Address = "Красноармейская 205", DeliveryDistanse = 10},
                new Building {ClientID = 2, Address = "Кирова 15", DeliveryDistanse = 15}
            };
            db.Buildings.AddRange(buildings);
        }

        private static void InitWallSizes(BrickWorksModel db)
        {
            var ws = new List<WallSize>
            {
                new WallSize {BuildingId=1, Height=3, Length=6, NumberOfWalls = 4},
                new WallSize {BuildingId=2, Height=3, Length=7, NumberOfWalls = 2},
                new WallSize {BuildingId=2, Height=3, Length=8, NumberOfWalls = 2}
            };
            db.WallSizes.AddRange(ws);
            db.SaveChanges();
        }

        private static void InitOrders(BrickWorksModel db)
        {
            var orders = new List<Order>
            {
                new Order {ClientId = 1, OrderedDate = new DateTime(2017,03,01), DeliveryCost = 100 },
                new Order {ClientId = 2, OrderedDate = new DateTime(2017,03,02), DeliveryCost = 200 }
            };

            db.Orders.AddRange(orders);

            var orderedBricks = new List<OrderedBrick>
            {
                new OrderedBrick {OrderId = 1, BrickId=1, Quantity=50 },
                new OrderedBrick {OrderId = 1, BrickId=2, Quantity=40 },
                new OrderedBrick {OrderId = 2, BrickId=3, Quantity=60 },
                new OrderedBrick {OrderId = 2, BrickId=4, Quantity=20 }
            };

            db.OrderedBricks.AddRange(orderedBricks);
            db.SaveChanges();
        }

        private static void InitDeliveryCosts(BrickWorksModel db)
        {
            var dcosts = new List<DeliveryCost>
            {
                new DeliveryCost { Date = new DateTime(2017,01,01), CostPerKm = 100.00F }
            };

            db.DeliveryCosts.AddRange(dcosts);
            db.SaveChanges();
        }
        // Заполняем базу данных, если такой БД не существует
        protected override void Seed(BrickWorksModel db)
        {
            InitBricksAndCosts(db);
            InitManufacturedBricks(db);
            InitClients(db);
            InitBuildings(db);
            InitWallSizes(db);
            InitOrders(db);
            InitDeliveryCosts(db);
        }
    }
}
