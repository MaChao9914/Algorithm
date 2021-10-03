using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class InvoiceRepository
    {
        private IQueryable<Invoice> _invoices;
        public InvoiceRepository(IQueryable<Invoice> invoices)
        {
            // Console.WriteLine("Sample debug output");
            if (invoices == null)
                throw new ArgumentNullException();
            _invoices = invoices;
        }

        /// <summary>
        /// Should return a total value of an invoice with a given id. If an invoice does not exist null should be returned.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public decimal? GetTotal(int invoiceId)
        {
            var invoice = _invoices.FirstOrDefault(x => x.Id == invoiceId);
            if (invoice == null)
                return null;

            return invoice.InvoiceItems.Sum(c => c.Price * c.Count);
        }

        /// <summary>
        /// Should return a total value of all unpaid invoices.
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalOfUnpaid()
        {
            var ans = _invoices.Where(c => c.AcceptanceDate == null)
                .SelectMany(c => c.InvoiceItems)
                .Sum(c => c.Count * c.Price);
            return ans;
        }

        /// <summary>
        /// Should return a dictionary where the name of an invoice item is a key and the number of bought items is a value.
        /// The number of bought items should be summed within a given period of time (from, to). Both the from date and the end date can be null.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public IReadOnlyDictionary<string, long> GetItemsReport(DateTime? from, DateTime? to)
        {
            IQueryable<Invoice> temp = _invoices;
            if (from != null)
                temp = _invoices.Where(c => c.CreationDate >= from);
            if (to != null)
                temp = _invoices.Where(c => c.CreationDate <= to);
            var ans = temp
                .SelectMany(c => c.InvoiceItems)
                .GroupBy(c => c.Name)
                .ToDictionary(k => k.Key, v => v.Sum(c => c.Count));
            return ans;
        }
    }

    public class Invoice
    {
        // A unique numerical identifier of an invoice (mandatory)
        public int Id { get; set; }
        // A short description of an invoice (optional).
        public string Description { get; set; }
        // A number of an invoice e.g. 134/10/2018 (mandatory).
        public string Number { get; set; }
        // An issuer of an invoice e.g. Metz-Anderson, 600  Hickman Street,Illinois (mandatory).
        public string Seller { get; set; }
        // A buyer of a service or a product e.g. John Smith, 4285  Deercove Drive, Dallas (mandatory).
        public string Buyer { get; set; }
        // A date when an invoice was issued (mandatory).
        public DateTime CreationDate { get; set; }
        // A date when an invoice was paid (optional).
        public DateTime? AcceptanceDate { get; set; }
        // A collection of invoice items for a given invoice (can be empty but is never null).
        public IList<InvoiceItem> InvoiceItems { get; }

        public Invoice()
        {
            InvoiceItems = new List<InvoiceItem>();
        }
    }



    public class InvoiceItem
    {
        // A name of an item e.g. eggs.
        public string Name { get; set; }
        // A number of bought items e.g. 10.
        public uint Count { get; set; }
        // A price of an item e.g. 20.5.
        public decimal Price { get; set; }
    }
    public class ValidateArguments
    {
        public int Validate(string[] args)
        {
            // Console.WriteLine("Sample debug output");
            //throw new System.ArgumentException("Not yet implemented");

            int ans = -1;
            if (args == null || args.Length == 0 || (args.Length > 1 && args.Length < 4))
                ans = -1;

            int length = args.Length;
            if (length == 1)
            {
                var temp = args[0].ToLower();
                if(temp == "help" || temp == "--help" || temp == "-h")
                    ans = 1;
            }

            bool nameWithHelp = false;
            for (int i = 0; i < length; i++)
            {
                switch (args[i].ToLower())
                {
                    case "--name":
                        if (i+1 < length && !args[i + 1].StartsWith("--") && args[i + 1].Length >=3 && args[i + 1].Length <= 10)
                        {
                            ans = 0;
                            if (args[i + 1].ToLower() == "help" || args[i + 1].ToLower() == "--help")
                                nameWithHelp = true;
                        }
                        break;
                    case "--count":
                        {
                            if (i + 1 < length)
                            {
                                var count = args[i + 1];
                                var isInt = int.TryParse(count, out int r);
                                if(isInt && r >= 10 && r <= 100)
                                    ans = 0;
                            }
                            break;
                        }
                }
            }
            if (ans == 0 && nameWithHelp != true && args.Any(c => c.ToLower().Equals("help") || c.ToLower().Equals("--help") || c.ToLower().Equals("-h")))
            {
                ans = 1;
            }
            return ans;
        }
    }
}
