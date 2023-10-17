using System.Collections;
using UnityEngine;



public class TimePlatformTrap : MonoBehaviour
{
    private Renderer rend;
    private bool isTrapActive = true;
    private GameObject objectToActivate;
    public PlayerController playerController;
     LoseGameText loseGameText;

    void Start()
    {
        rend = GetComponent<Renderer>();
        objectToActivate = this.gameObject;
    }

    void OnCollisionEnter(Collision other)
    {
        if (isTrapActive && other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ActivateTrap());
        }
    }

    IEnumerator ActivateTrap()
    {
        Color orange = new Color32(232, 122, 26, 1);
        isTrapActive = false;
        rend.material.color = orange;
        yield return new WaitForSeconds(1f);

        rend.material.color = Color.red;
        loseGameText.Die();
        
        





        rend.material.color = orange;
        yield return new WaitForSeconds(0.5f);

        rend.material.color = orange;
        

        yield return new WaitForSeconds(5f);
        rend.material.color = Color.white;
        isTrapActive = true;
        
    }
}
