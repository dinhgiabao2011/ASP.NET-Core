using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Context
{
	public class SchoolContext: DbContext
	{
		public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
		{

		}
		public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<Course> Courses { get; set; }
		public virtual DbSet<Enroll> Enrolls { get; set; }
		//optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True");
	}
}
