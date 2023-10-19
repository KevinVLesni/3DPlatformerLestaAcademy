using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActive : MonoBehaviour
{
    public GameObject objectToActivate;
    void OnCollisionEnter()
    {
        Cursor.lockState = CursorLockMode.Confined;
        objectToActivate.SetActive(true);
    }
}
