using StarterAssets;
using System.Threading;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField]
    FirstPersonController firstPersonController;

    float timer = 0.0f;
    [SerializeField]
    float footstepSpeed = 0.3f;

    public AudioSource playerFootsteps;
    public AudioSource playerHit;


    private void Awake()
    {
        firstPersonController = GetComponent<FirstPersonController>();
    }

    private void Update()
    {
        if (firstPersonController.isMoving && firstPersonController.Grounded)
        {
            if (timer > footstepSpeed)
            {
                playerFootsteps.Play();
                timer = 0.0f;
            }

            timer += Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.gameObject.tag == "HitBox")
        {
            playerHit.Play();
        }
    }

}
