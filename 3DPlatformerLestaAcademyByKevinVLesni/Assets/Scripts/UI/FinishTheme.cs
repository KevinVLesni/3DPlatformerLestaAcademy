using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTheme : MonoBehaviour
{
    public GameObject objectToActivate;
    public void RestartLevel()
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
