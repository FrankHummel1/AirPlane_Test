using UnityEngine;

public class AidKitTrigger : ObjectColliderInteraction
{
    [SerializeField] private int healthToRestore;

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (collisionLayers == (collisionLayers | (1 << other.gameObject.layer)))
        {
            if (other.TryGetComponent(out Player player))
            {
                player.IncreaseLife(healthToRestore);
                gameObject.SetActive(false);
            }
        }
    }
}
