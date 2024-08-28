using NUnit.Framework;
using UnityEngine;

public class EdenAudioController : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource footstep;
    //public AudioSource idleBreathing;

    void Awake()
    {
        footstep = GetComponent<AudioSource>();
    }

    private void EdenFootstep()
    {
        int randomIndex = Random.Range(0, clips.Length);
        AudioClip randomClip = clips[randomIndex];
        footstep.clip = randomClip;

        footstep.Play();
    }

}
