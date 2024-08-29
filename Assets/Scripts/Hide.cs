using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hide : MonoBehaviour
{
    public GameObject hide;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void hideThis()
    {
        //hide.SetActive(false);
        Destroy(hide);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
