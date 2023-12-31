﻿namespace ISM.Domain.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Description { get; set; }=string .Empty;   
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Storage? Storage { get; set; }
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
