using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject image;


    public void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("Player"))
        {
            image.SetActive(true);


        }
    }

    void OnTriggerExit(Collider other)
    {

        //Destroy(other.gameObject);
        image.SetActive(false);
    }



}
