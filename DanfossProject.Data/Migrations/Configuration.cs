using System.Data.Entity.Migrations;
using System.Linq;
using DanfossProject.Data.Models.Entities;

namespace DanfossProject.Data.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<BaseDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;

		}

        protected override void Seed(BaseDatabaseContext context)
        {
			using (BaseDatabaseContext db = new BaseDatabaseContext())
			{
				db.Database.ExecuteSqlCommand("ALTER TABLE BuildingModels DROP CONSTRAINT [FK_dbo.BuildingModels_dbo.WaterMeterModels_WaterMeterId]");
				db.Database.ExecuteSqlCommand("ALTER TABLE BuildingModels ADD CONSTRAINT [FK_dbo.BuildingModels_dbo.WaterMeterModels_WaterMeterId] FOREIGN KEY (WaterMeterId) REFERENCES WaterMeterModels (Id) ON DELETE SET NULL");

				if (!db.Buildings.Any())
				{
					db.Buildings.Add(new BuildingModel
					{
						Address = new AddressModel
						{
							Country = "������",
							City = "�������",
							Street = "",
							HouseNumber = "217",
							ZIPCode = 143581
						},
						Company = "�������",
						AddressHashCode = 1286605174
					});

					db.Buildings.Add(new BuildingModel
					{
						Address = new AddressModel
						{
							Country = "������",
							City = "������",
							Street = "���������",
							HouseNumber = "12/2",
							ZIPCode = 117997
						},
						Company = "����������",
						AddressHashCode = -512174128
					});

					db.Buildings.Add(new BuildingModel
					{
						Address = new AddressModel
						{
							Country = "������",
							City = "������",
							Street = "8-�����",
							HouseNumber = "10/14",
							ZIPCode = 127083
						},
						Company = "���������",
						AddressHashCode = -300036173
					});

					db.Buildings.Add(new BuildingModel
					{
						Address = new AddressModel
						{
							Country = "������",
							City = "������",
							Street = "4-� ��������-������",
							HouseNumber = "2/11",
							ZIPCode = 100006
						},
						AddressHashCode = 1911781271
					});



					db.Buildings.Add(new BuildingModel
					{
						Address = new AddressModel
						{
							Country = "������",
							City = "������",
							Street = "������������� �����",
							HouseNumber = "130/1",
							ZIPCode = 100043
						},
						AddressHashCode = 452856981
					});
				}

				if (db.WaterMeters.Count() == 0)
				{
					db.WaterMeters.Add(new WaterMeterModel
					{
						SerialNumber = "TestABC1",
						CounterValue = 123123
					});

					db.WaterMeters.Add(new WaterMeterModel
					{
						SerialNumber = "TestABC2",
						CounterValue = 442
					});

					db.WaterMeters.Add(new WaterMeterModel
					{
						SerialNumber = "TestABC3",
						CounterValue = 987798
					});
				}

				db.SaveChanges();
				base.Seed(db);
			}
        }
    }
}
