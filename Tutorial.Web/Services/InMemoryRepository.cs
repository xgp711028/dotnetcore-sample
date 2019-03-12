using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial.Web.Models;

namespace Tutorial.Web.Services
{
	public class InMemoryRepository : IRepository<Student>
	{
		public IEnumerable<Student> GetAll()
		{
			return new List<Student>
				{
					new Student
					{
						Id = 1,
						FirstName = "Nick",
						LastName = "Carter"
					},
					new Student
					{
						Id = 2,
						FirstName = "Kevin",
						LastName = "Richardson"
					},
					new Student
					{
						Id = 3,
						FirstName = "Mark",
						LastName = "Tom"
					}
				};
		}
	}
}
