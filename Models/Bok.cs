namespace ConsoleApp1.Models 
{
    public class Bok
    {
        public string Id { get; set; }
        public string Titel { get; set; }
        public string Språk { get; set; }
        public decimal Pris { get; set; }
        public string Utgivningsdatum { get; set; }
        public string FörfattarId { get; set; }
    }
}
