using System;

namespace EnterpriseViewer.Model
{
	public class Department
	{
		public Guid Id { get; set; }
		public Guid? ParentId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
	}
}