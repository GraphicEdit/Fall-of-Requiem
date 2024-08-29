using NUnit.Framework;
using UnityEngine;

public class EdenAudioController : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource footstep;
    public AudioSource attack;

    void Awake()
    {
        AudioSource[] allMyAudioSources = GetComponents<AudioSource>();
        
        footstep = GetComponent<AudioSource>();
        attack = GetComponent<AudioSource>();
    }

    private void EdenFootstep()
    {
        int randomIndex = Random.Range(0, 6);
        AudioClip randomClip = clips[randomIndex];
        footstep.clip = randomClip;

        footstep.Play();
    }

    private void EdenAttack()
    {
        int randomIndex = Random.Range(7, 10);
        AudioClip randomClip = clips[randomIndex];
        attack.clip = randomClip;
        
        attack.Play();
    }

}
