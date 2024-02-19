using UnityEngine;

public class EnemyImmortalityDisabler : ObjectColliderInteraction
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (collisionLayers == (collisionLayers | (1 << other.gameObject.layer)))
        {
            if (other.TryGetComponent(out Enemy enemy))
                enemy.ImmortalitySetting(false);
        }        
    }
}
