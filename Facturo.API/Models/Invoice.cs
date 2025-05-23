namespace Facturo.API.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public ICollection<InvoiceItem> Items { get; set; }

        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }

}
