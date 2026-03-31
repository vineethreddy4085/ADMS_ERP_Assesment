using System.Collections.Generic;

namespace ItemProcessingApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        // Parent-Child relationship
        public int? ParentId { get; set; }
        public List<Item> Children { get; set; }
    }
}
