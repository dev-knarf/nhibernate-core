using Iesi.Collections.Generic;

namespace NHibernate.Test.NHSpecificTest.NH1925
{
	public class Customer
	{
		public virtual int ID { get; private set; }
		public virtual ISet<Invoice> Invoices { get; set; }
		public virtual string Name { get; set; }
	}

	public class Invoice
	{
		public virtual int ID { get; private set; }
		public virtual Customer Customer { get; set; }
		public virtual int Number { get; set; }
	}
}