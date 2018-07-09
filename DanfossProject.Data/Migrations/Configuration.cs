namespace DanfossProject.Data.Migrations
{
	using DanfossProject.Data.Models.Entities;
	using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DanfossProject.Data.BaseDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BaseDatabaseContext context)
        {
			using (BaseDatabaseContext db = new BaseDatabaseContext())
			{
				db.Buildings.Add(new Building
				{
					Address = new Address
					{
						Country = "������",
						City = "�������",
						Street = "",
						HouseNumber = "217",
						ZIPCode = 143581
					},
					Company = "�������"
				});

				db.Buildings.Add(new Building {
					Address = new Address
					{
						Country = "������",
						City = "������",
						Street = "���������",
						HouseNumber = "12/2",
						ZIPCode = 117997
					},
					Company = "����������"
				});

				db.Buildings.Add(new Building
				{
					Address = new Address
					{
						Country = "������",
						City = "������",
						Street = "8-�����",
						HouseNumber = "10/14",
						ZIPCode = 127083
					},
					Company = "���������"
				});

				db.Buildings.Add(new Building
				{
					Address = new Address
					{
						Country = "������",
						City = "������",
						Street = "4-� ��������-������",
						HouseNumber = "2/11",
						ZIPCode = 100006
					}
				});

				

				db.Buildings.Add(new Building
				{
					Address = new Address
					{
						Country = "������",
						City = "������",
						Street = "������������� �����",
						HouseNumber = "130/1",
						ZIPCode = 100043
					}
				});

				db.SaveChanges();
			}
        }
    }
}
