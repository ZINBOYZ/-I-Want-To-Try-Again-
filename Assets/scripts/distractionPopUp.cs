using Unity.VisualScripting;
using UnityEngine;

public class distractionPopUp : MonoBehaviour
{
    public GameObject prefab;

    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            prefab.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            prefab.SetActive(false);
        }
    }
}
