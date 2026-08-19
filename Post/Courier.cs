namespace Post
{
    public class Courier
    {

        public int Id { get; set; }
        private static int IdCount { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsAvaiable { get; set; }
        public Courier(string name)
        {
            IdCount++;
            Id = IdCount;
            Name = name;
        }


    }
}
