using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockKiller : MonoBehaviour
{
    public GameObject objectToActivate;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            objectToActivate.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0f;
        }
    }
}
