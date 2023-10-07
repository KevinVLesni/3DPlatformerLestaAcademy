using System.Collections;
using UnityEngine;

public class TimePlatformTrap : MonoBehaviour
{
    private Renderer rend;
    private bool isTrapActive = true;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision other)
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
        // TODO: Reload Scene

        yield return new WaitForSeconds(0.1f);

        rend.material.color = orange;

        yield return new WaitForSeconds(5f);
        rend.material.color = Color.white;
        isTrapActive = true;
    }
}
