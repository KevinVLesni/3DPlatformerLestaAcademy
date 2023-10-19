using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterZone : MonoBehaviour
{
    public Vector3 windDirection = new Vector3(1, 0, 0);
    public float windStrength = 10.0f;

    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(windDirection * windStrength);
        }
    }
}
