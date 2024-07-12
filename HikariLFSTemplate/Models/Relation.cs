namespace HikariLFSTemplate.Models
{
    public class Relation
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }

        public Relation(int id, string name, string barcode, string size, string description)
        {
            Id = id;
            Name = name;
            Barcode = barcode;
            Size = size;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} - {Barcode} - {Size} - {Description}";
        }
    }
}