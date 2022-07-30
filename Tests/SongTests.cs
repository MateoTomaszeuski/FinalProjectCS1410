using System;
using NUnit.Framework;
public class SongTests
{
    [Test]
   public void newSongTest()
    {
        var expectedname = "Hello - Adele";
        var newSong = new Song(expectedname, "path to downloads");
        Assert.AreEqual(expectedname,newSong.Name);
    }
}