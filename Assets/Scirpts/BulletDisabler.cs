using UnityEngine;

public class BulletDisabler : ObjectColliderInteraction
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (collisionLayers == (collisionLayers | (1 << other.gameObject.layer)))
        {
            if (other.TryGetComponent(out Player player))
            {
                player.DecreaseLife();
                gameObject.SetActive(false);
            }
        }
    }
}
