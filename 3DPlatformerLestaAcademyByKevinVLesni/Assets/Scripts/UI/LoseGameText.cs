using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseGameText : MonoBehaviour
{
    public GameObject objectToActivate;
    public void RestartLevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    
    
        void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeadZone"))
        {
            Die();
        }
    }
    void Die()
    {
        objectToActivate.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0f;
    }
}
