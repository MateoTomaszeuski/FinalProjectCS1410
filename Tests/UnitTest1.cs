using NUnit.Framework;
namespace Tests;

public class Tests
{
    // [Test]
    // public void Test1()
    // {
    //     Assert.Pass();
    // }
    [Test]

    public void TestPlaPauseButton()
    {
        PlayPauseButton playPauseButton = new PlayPauseButton();
        playPauseButton.State = true;
        Assert.AreEqual(true, playPauseButton.State);
    }
}