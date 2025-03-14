using System;
using System.Media;
using NAudio.Wave;

public class SoundManager
{
    private static SoundPlayer soundPlayer;

    public static void Initialize(string soundFilePath)
    {
        soundPlayer = new SoundPlayer(soundFilePath);
    }

    public static void PlayLooping()
    {
        if (soundPlayer != null)
        {
            soundPlayer.PlayLooping();
        }
    }
    public static void Play()
    {
        if (soundPlayer != null)
        {
            soundPlayer.Play();
        }
    }
    public static void Stop()
    {
        if (soundPlayer != null)
        {
            soundPlayer.Stop();
        }
    }

}
