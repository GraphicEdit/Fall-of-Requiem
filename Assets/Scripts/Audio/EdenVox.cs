using Unity.VisualScripting;
using UnityEngine;

public class EdenVox : MonoBehaviour
{
    [SerializeField]
    Eden eden;

    public AudioClip[] voxClips;
    public AudioSource edenVox;

    int clipIndex = 0;
    bool isChasing = false;


    private void Awake()
    {
        eden = GetComponent<Eden>();

        AudioSource[] allMyAudioSources = GetComponents<AudioSource>();

        edenVox = GetComponent<AudioSource>();
    }

    private void Start()
    {
        eden = GetComponent<Eden>();
        AudioClip voxClip = voxClips[clipIndex];
        edenVox.clip = voxClip;

        edenVox.Play();

    }

    private void Update()
    {
        if (eden.playerIsDetected)
        {
            if (!isChasing)
            {
                edenVox.Stop();

                isChasing = true;
                clipIndex = 1;
                AudioClip voxClip = voxClips[clipIndex];
                edenVox.clip = voxClip;
                edenVox.Play();
                Debug.Log("haha new sound");
                return;
            }
            else return;
        }
        else
        {
            if(isChasing)
            {
                edenVox.Stop();

                isChasing = false;
                clipIndex = 0;
                AudioClip voxClip = voxClips[clipIndex];
                edenVox.clip = voxClip;
                edenVox.Play();
                Debug.Log("haha new sound");
                return;
            }
        }
        
    }
}
