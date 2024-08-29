using UnityEngine;

public class SwitchMusicTrigger : MonoBehaviour
{
    [SerializeField] 
    Eden eden;

    public AudioClip search;
    public AudioClip chase;

    public MusicController musicController;

    bool isChasing = false;

    void Awake()
    {
        eden = GetComponent<Eden>();
        musicController = GameObject.FindGameObjectWithTag("MusicController").GetComponent<MusicController>();
    }

    private void Update()
    {
        if (eden.playerIsDetected)
        {
            if (!isChasing)
            {
                musicController.ChangeMusic(chase);
                isChasing = true;
                Debug.Log("music change");

                return;
            }
            else return;
        }
        else
        {
            if (isChasing)
            {
                musicController.ChangeMusic(search);
                isChasing = false;
                Debug.Log("music change");

                return;
            }
        }
    }
}
