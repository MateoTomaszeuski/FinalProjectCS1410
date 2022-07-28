
public record Song
{
    public string Name { get; set; }
    public string SongPath { get; set; }

    public Song(string name, string path)
    {
        Name = name;
        SongPath = path;
    }
    public static void AddSongsToList(string DirectorySongs, ref List<Song> SongList)
    {
        SongList.Clear();
        SongList.Add(new Song("", ""));
        var allfiles = Directory.GetFiles(DirectorySongs);
        foreach (var song in allfiles)
        {
            var songNameWithoutPath = song.Remove(0, DirectorySongs.Length + 1);
            var lastpositionName = 0;
            for (int i = 0; i < songNameWithoutPath.Length; i++)
            {
                if (songNameWithoutPath[i] == '.' && songNameWithoutPath[i + 1] == 'm')
                {
                    lastpositionName = i;
                }

            }
            var songNameWithoutExtension = new Song(songNameWithoutPath.Remove(lastpositionName), song);
            SongList.Add(songNameWithoutExtension);
        }
    }

    public static void GetNameandPath(ref string SelectedSong, ref string[]? nameAndPath, ref string path, ref string Songname)
    {

        nameAndPath = SelectedSong?.Split("🆗");
        path = nameAndPath?[0];
        path = "/Songs/" + path?.Remove(0,7) + ".mp3";
        Songname = path.Remove(0, 7);
        Songname = Songname.Remove(Songname.Length - 4);
    }
    public static void nextSong(List<Song> SongList, string Songname, int songpositon, ref string selectedSong, ref string[]? nameAndPath, ref string temppath, ref string songname)
    {
        for (int i = 0; i < SongList.Count; i++)
        {

            if (Songname == SongList[i].Name)
            {
                songpositon = i;
                break;
            }
        }
        if (songpositon + 2 > SongList.Count)
        {
            selectedSong = SongList[1].ToString();
        }
        else
        {
            selectedSong = SongList[songpositon + 1].ToString();

        }
        GetNameandPath(ref selectedSong!, ref nameAndPath!, ref temppath, ref songname);
    }

    public override string? ToString()
    {
        return "Name = " + Name + "🆗 " + "SongPath = " + SongPath;
    }
}