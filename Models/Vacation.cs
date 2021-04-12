namespace vacation.Models
{
    public class Vacation
    {
        protected Vacation()
        {
        }

        public string Location { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

    }
}