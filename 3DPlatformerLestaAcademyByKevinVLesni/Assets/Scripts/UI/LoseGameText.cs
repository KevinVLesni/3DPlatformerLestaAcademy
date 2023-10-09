using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseGameText : MonoBehaviour
{
    public void RestartLevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
