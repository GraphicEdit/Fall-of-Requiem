using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource music;

    private void Start()
    {
        music.Play();
    }

    public void ChangeMusic(AudioClip musicSource)
    {
        if (music.clip.name == music.name)
            return;

        music.Stop();
        music.clip = musicSource;
        music.volume = 0.85f;
        music.Play();
    }

    public void StopMusic()
    {
        music.Stop();
        Debug.Log("stop lol");
    }

    public void DeathStinger(AudioClip deathSource)
    {
       
        music.loop = false;

        music.Stop();
        music.clip = deathSource;
        music.volume = 0.85f;
        music.Play();
    }

    public void VictoryStinger(AudioClip victorySource)
    {
        music.loop = false;

        music.Stop();
        music.clip = victorySource;
        music.volume = 0.85f;
        music.Play();
    }
}