namespace RecordShopFrontEnd
{
    public class Album
    {
        public int Id { get; set; }
        public string albumName { get; set; }
        public string artistName { get; set; } 
        public List<string> songs { get; set; }
    }
}
