using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    private float mouseX;
    private float mouseY;
    public float sensivityMouse = 200f;

    
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        
        mouseX = Input.GetAxis("Mouse X") * sensivityMouse * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensivityMouse * Time.deltaTime;

        player.Rotate(mouseX * new Vector3(0, 1, 0));
        transform.Rotate(-mouseY * new Vector3(1, 0, 0));

    }
    
  


    

    
}
