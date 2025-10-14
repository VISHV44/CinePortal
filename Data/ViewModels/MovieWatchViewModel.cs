using System;

namespace CinePortal.Data.ViewModels
{
    public class MovieWatchViewModel
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Cinema { get; set; }
        public string Producer { get; set; }
    }
}
