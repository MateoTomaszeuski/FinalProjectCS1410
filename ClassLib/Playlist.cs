public class PlayList // 2 Class
{
    public string Name { get; set; } // Property
    public List<Song> Songs { get; set; } // Property

    public PlayList(string name, List<Song> songs)
    {
        Name = name;
        Songs = songs;
    }

}