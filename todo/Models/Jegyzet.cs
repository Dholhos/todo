namespace todo.Models
{
    public class Jegyzet
    {
        public int Id { get; set; }
        public int kartyaID{ get; set; }
        public string tartalom { get; set; }
        public DateTime letrehozasIdeje { get; set; }
        public DateTime? modositasIdeje { get; set; }
        public bool kesz{ get; set; }
        public Kartya Kartya { get; set; }
    }
}
