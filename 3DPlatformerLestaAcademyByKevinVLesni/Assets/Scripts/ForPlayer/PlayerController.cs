using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public TimePlatformTrap TPT;
    public float speed = 0.5f;
    private Vector3 moveVector;
    public float jumpForce;
    public bool isGround;
    public Vector3 jump;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        TPT = GetComponent<TimePlatformTrap>();
    }

    void Update()
    {

        GetInput();
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }



    }
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Invoke("SetIsGroundFalse", 0.1f); 
        }
    }

    public void SetIsGroundFalse()
    {
        isGround = false;
    }
}


















