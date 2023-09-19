namespace ISM.Domain.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }=string .Empty;   
        public int Amount { get; set; }
        public List<Material>? Materials { get; set; }
         
}
