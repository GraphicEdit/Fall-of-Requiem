using UnityEngine;

public class SwitchMusicTrigger : MonoBehaviour
{

    [SerializeField] float spawnTime = 3f; //timeframe variable
    private float tempCounter = 0f; //timeframe temp variable

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
        if (tempCounter <= 0f)
        {
            //tempCounter = spawnTime;

            if (eden.playerIsDetected)
            {
                if (!isChasing)
                {
                        //change music to combat
                        musicController.ChangeMusic(chase);
                        isChasing = true;
                        Debug.Log("CHASE SONG ON");
                   
                }
            }
            else
            {
                if (isChasing)
                {
                        //change music to idle
                        musicController.ChangeMusic(search);
                        isChasing = false;
                        Debug.Log("SEARCH SONG ON");
                }
            }
            tempCounter = spawnTime;
        }
        else
        {
            tempCounter -= Time.deltaTime;
        }
    }
}
        
        
//        if (eden.playerIsDetected)
//        {
//            if (!isChasing)
//            {
//                //if (tempCounter <= 0f)
//                //{
//                    ChangeMusic();
//                    tempCounter = spawnTime;
//                    Debug.Log("music change");
//                }
//                else
//                {
//                    tempCounter -= Time.deltaTime;
//                }

//                return;
//            }
//            else return;
//        }
//        else
//        {
//            if (isChasing)
//            {

//                return;
//            }
//        }



//        //if (tempCounter <= 0f)
//        //{
//        //    ChangeMusic();
//        //    tempCounter = spawnTime;
//        //    Debug.Log("music change");
//        //}
//        //else
//        //{
//        //    tempCounter -= Time.deltaTime;
//        //}

//    }

//    private void ChangeMusic()
//    {
//       if (!isChasing)
//        {
//            musicController.ChangeMusic(chase);
//            isChasing = true;
//            //Debug.Log("music change");

//            return;
//        }
//        else
//        {
//            musicController.ChangeMusic(search);
//            isChasing = false;
//            //Debug.Log("music change");

//            return;
//        }
            
//            musicController.ChangeMusic(search);
//            isChasing = false;
//             //Debug.Log("music change");

//             return;
//            }
//        }
//     }
//}
