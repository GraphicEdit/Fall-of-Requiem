using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class DeathAudioTrigger : MonoBehaviour
{
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;

    public AudioClip dead;
    //public AudioClip chase;

    public MusicController musicController;

    void Awake()
    {
        musicController = GameObject.FindGameObjectWithTag("MusicController").GetComponent<MusicController>();

        paused.TransitionTo(.01f);
        musicController.DeathStinger(dead);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void OnDestroy()
    {
        unpaused.TransitionTo(.01f);

        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }
}
