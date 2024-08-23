using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject PausePanel;
    private bool m_isPaused = false;

    void Update()
    {
        PauseToggle();
    }

    public void PauseToggle()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (m_isPaused)
            {
                PausePanel.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                PausePanel.SetActive(true);
                Time.timeScale = 0;
            }
            m_isPaused = !m_isPaused;
        }

    }

    public void QuitGame()
    {
        Application.Quit();
        PausePanel.SetActive(true);
    }


    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }


}
