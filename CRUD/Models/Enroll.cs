using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CRUD.Models
{
	public class Enroll
	{
		public int Id { get; set; }
		public int StudentTd { get; set; }
		public Student Student { get; set; }
		public int CourseId { get; set; }
		public Course Course { get; set; }
	}
}
