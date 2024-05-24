class HomeCinemaFacade
{
    private Tv _tv;
    private VideoPlayer _videoPlayer;
    private SoundSystem _soundSystem;

    public HomeCinemaFacade(Tv tv, VideoPlayer videoPlayer, SoundSystem soundSystem)
    {
        _tv = tv;
        _videoPlayer = videoPlayer;
        _soundSystem = soundSystem;
    }

    public void PlayMovie()
    {
        _tv.TurnOn();
        _soundSystem.SetVolume(100);
        _videoPlayer.StartMovie();
    }

    public void StopMovie()
    {
        _videoPlayer.StopMovie();
        _soundSystem.SetVolume(0);
        _tv.TurnOff();
    }
}
