using UnityEngine;

public class EnemyDisabler : ObjectColliderInteraction
{
    [SerializeField] private Enemy enemy;

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (collisionLayers == (collisionLayers | (1 << other.gameObject.layer)))
        {
            if(!enemy.IsImmortal)
                enemy.Die();
        }
    }
}