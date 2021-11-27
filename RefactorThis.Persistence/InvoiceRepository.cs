using RefactorThis.Persistence.Model;

namespace RefactorThis.Persistence {
	public class InvoiceRepository : IRepository<Invoice>
	{
		private Invoice _invoice;

		public Invoice Get( string reference )
		{
			//TODO: Connect it to a datasource
			return new Invoice();
		}

		public void Save()
		{
			//saves the invoice to the database
		}

		public void Add( Invoice invoice )
		{
			_invoice = invoice;
		}
	}
}