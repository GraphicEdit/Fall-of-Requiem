using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Restart : MonoBehaviour
{



    public void RestartGame()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
