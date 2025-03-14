using NAudio.Wave;
using System;
using System.Threading;
using System.Windows.Forms;

public class SoundControl
{
    public event EventHandler SoundStopped;
    private IWavePlayer waveOutDevice;
    private WaveFileReader audioFile;
    private Thread audioThread;
    private bool isPlaying = false;
    private bool isLooping = false;
    private float volume = 1.0f;

    public SoundControl(string audioFilePath)
    {
        waveOutDevice = new WaveOut();
        audioFile = new WaveFileReader(audioFilePath);

        waveOutDevice.Init(audioFile);
        waveOutDevice.Volume = volume; // Define o volume inicial

        audioThread = new Thread(PlayAudio);
        audioThread.IsBackground = true;


    }
    public void Play()
    {
        if (!isPlaying)
        {
            waveOutDevice.Play();
            isPlaying = true;
            audioThread.Start();
        }
    }

    public void Pause()
    {
        if (isPlaying)
        {
            waveOutDevice.Pause();
            isPlaying = false;
        }
    }

    public void Stop()
    {
        if (audioFile.Position >= 0)
        {
            waveOutDevice.Stop();
            audioFile.Position = 0;
            isPlaying = false;
        }
    }

    public void PlayLooping()
    {
        isLooping = true;
        Play();
    }

    public void SetVolume(float newVolume)
    {
        volume = newVolume;
        waveOutDevice.Volume = volume;
    }

    private void PlayAudio()
    {
        while (isPlaying || (isLooping || audioFile.Position < audioFile.Length))
        {
            if (!isPlaying)
                break;
            Thread.Sleep(100);
        }

        if (isLooping)
        {
            PlayLooping();
        }
    }
    protected virtual void OnSoundStopped(EventArgs e)
    {
        SoundStopped?.Invoke(this, e);
    }
}


