public class PlayPauseButton : IButton
{
    private bool IsPlaying { get; set; }
    public bool State { get => IsPlaying; set { }}
    public PlayPauseButton()
    {
        if(IsPlaying)
        {
            IsPlaying = false;
        }
        else
        {
            IsPlaying = true;
        }
    }
}