using UnityEngine;

public class ObjectColliderInteraction : MonoBehaviour
{
    [SerializeField] protected LayerMask collisionLayers;

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (collisionLayers == (collisionLayers | (1 << other.gameObject.layer)))
            other.gameObject.SetActive(false);
    }
}