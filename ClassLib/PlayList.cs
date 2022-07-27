
public record MusicPlayList
{
    List<Song> Songs {get; set;}
    public string Name { get; set; }

    public MusicPlayList(List<Song> songs, string name)
    {
        Songs = songs;
        Name = name;
    }
    public static MusicPlayList CreatePlaylist(List<Song> songs, string name)
    {
        return new MusicPlayList(songs, name);
    }
}