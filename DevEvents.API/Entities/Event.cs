namespace DevEvents.API.Entities
{
    public class Event
    {
        public Event(int id, string title, string descrition, DateTime startDate, DateTime endDate, string organizer)
        {
            Id = id;
            Title = title;
            Descrition = descrition;
            StartDate = startDate;
            EndDate = endDate;
            Organizer = organizer;
            CreatedDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Organizer { get; set; }
        public DateTime CreatedDate { get; set; }

        public void Update(string title, string descrition, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Descrition = descrition;
            StartDate = StartDate;
            EndDate = endDate;
        }
    }
}
