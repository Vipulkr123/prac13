using PracThirteenTest2.Models;
using System.Data.Entity;

namespace PracThirteenTest2.DatabaseContext
{
	public class EmployeeDbContext : DbContext
	{
		public EmployeeDbContext() : base("EmpDbEntities")
		{
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EmployeeDbContext>());
		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Designation> Designations { get; set; }
	}
}