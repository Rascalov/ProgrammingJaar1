using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Reservation
    {
        private int id;
        public int Id { get { return id; } set { } }
        public Book Book { get; set; }
        public Customer Customer { get; set; }
        public DateTime ReservationDateTime { get; private set;}

        public Reservation(int id, Customer customer, Book book)
        {
            Id = id;
            Customer = customer;
            Book = book;
            ReservationDateTime = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Id: {Id}\n ";
        }

    }
}
