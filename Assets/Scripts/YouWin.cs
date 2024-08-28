using UnityEngine;

public class YouWin : MonoBehaviour
{
    public GameObject youWinPanel;

    private void OnTriggerEnter(Collider other)
    {
        youWinPanel.SetActive(true);
    }

}
