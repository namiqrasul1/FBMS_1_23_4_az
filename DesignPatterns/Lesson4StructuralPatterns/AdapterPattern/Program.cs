interface IAudioFile
{
    void Play();
}

class Mp3 : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("Dunya senin, dunya menim dunya hech kimin");
    }
}

class Wav : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("Ay uchan qushlar, bir qanad chalin, diririm");
    }
}

class OGG // from another dll
{
    public void PlayMusic()
    {
        Console.WriteLine("kepenek, kepenek");
    }
}

class OGGToIAudioFileAdapter : IAudioFile
{
    private OGG _oggFile;

    public OGGToIAudioFileAdapter(OGG oggFile)
    {
        _oggFile = oggFile;
    }

    public void Play()
    {
        // convert code 
        _oggFile.PlayMusic();
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<IAudioFile> audios = [new Wav(), new Mp3()];

        audios.Add(new OGGToIAudioFileAdapter(new OGG()));

        foreach (IAudioFile audio in audios)
        {
            audio.Play();
        }
    }
}