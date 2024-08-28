using NUnit.Framework;
using UnityEngine;

public class EdenAudioController : MonoBehaviour
{
    public AudioSource footstep;
    //public AudioSource idleBreathing;

    void Awake()
    {
        footstep = GetComponent<AudioSource>();
    }

    private void EdenFootstep()
    {
        footstep.Play(); 
    }

}
