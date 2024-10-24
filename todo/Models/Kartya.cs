namespace todo.Models
{
    public class Kartya
    {
        public int id {get; set;}
        public string nev {get; set; }
        public List<Jegyzet> Jegyzetek { get; set; }
    }
}
