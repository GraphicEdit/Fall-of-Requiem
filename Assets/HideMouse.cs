using UnityEngine;

public class HideMouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;   
        Cursor.lockState = CursorLockMode.Locked;
    }
}
