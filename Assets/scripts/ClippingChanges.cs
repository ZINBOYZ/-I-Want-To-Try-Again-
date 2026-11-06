using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ClippingChanges : MonoBehaviour
{
    public Camera targetCamera;

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetCamera.farClipPlane += 50;   // Extend far plane distance
            Destroy(gameObject);
        }

        
    }
}
