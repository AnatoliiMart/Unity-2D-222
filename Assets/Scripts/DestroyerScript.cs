using Unity.VisualScripting;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Transform parentTransform = collider.transform.parent;
        Destroy(collider.gameObject);
        if (parentTransform != null)
        {
            Destroy(parentTransform.gameObject);
        }
    }
}
