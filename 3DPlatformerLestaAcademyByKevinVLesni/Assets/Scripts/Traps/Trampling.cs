using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampling : MonoBehaviour
{
    public float bounceForce = 10f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            playerRigidbody.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        }
    }
}
