public class PlayPauseButton : IButton
{
    private Action Input { get; set; }
    private bool IsPlaying { get; set; }
    public PlayPauseButton(Action input)
    {
        Input = input;
        if(IsPlaying)
        {
            IsPlaying = false;
        }
        else
        {
            IsPlaying = true;
        }
    }
    
    public Action GetAction()
    {
        return Input;
    }
}