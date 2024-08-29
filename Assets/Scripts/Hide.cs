using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hide : MonoBehaviour
{
    public GameObject hide;

    public void hideThis()
    {
        //hide.SetActive(false);
        Destroy(hide);
    }
}
