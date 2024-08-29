using UnityEngine;
using UnityEngine.Audio;

public class PauseManager : MonoBehaviour
{
    public GameObject PausePanel;
    private bool m_isPaused = false;

    //audiomixer snapshots
    public AudioMixerSnapshot unpaused;
    public AudioMixerSnapshot paused;

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
                unpaused.TransitionTo(.01f);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Debug.Log("oooppoo");
            }
            else
            {
                PausePanel.SetActive(true);
                Time.timeScale = 0;
                paused.TransitionTo(.01f);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
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
