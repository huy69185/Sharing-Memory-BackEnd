namespace MemorySharingAPI.Models
{
    public class Moment
    {
        public int MomentID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MediaURL { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsPublic { get; set; } = true;
    }
}
