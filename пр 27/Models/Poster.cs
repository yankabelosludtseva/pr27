using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр_27.Models
{
    public class Poster
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public string CinemaName { get; set; }
        public string FilmName { get; set; }
        public DateTime SessionTime { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
