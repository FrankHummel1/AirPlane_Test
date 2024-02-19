using UnityEngine;

public class SelfDisabler : ObjectColliderInteraction
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (collisionLayers == (collisionLayers | (1 << other.gameObject.layer)))
            gameObject.SetActive(false);
    }
}