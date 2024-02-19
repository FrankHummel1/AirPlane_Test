using UnityEngine;

public class EnemyPool : Pool
{
    public override GameObject Get()
    {
        for (int i = 0; i < _pooledObjects.Count; i++)
        {
            if (!_pooledObjects[i].gameObject.activeInHierarchy)
            {
                _pooledObjects[i].gameObject.SetActive(true);
                return _pooledObjects[i];
            }
        }

        GameObject objectPrefab = Instantiate(_objectPrefab, Vector2.zero, Quaternion.identity);
        _pooledObjects.Add(objectPrefab);
        objectPrefab.transform.parent = transform;
        Enemy enemy = objectPrefab.GetComponent<Enemy>();
        enemy.ShooterMechanism.Initialization(_poolManager, _translatorManager);
        enemy.Initialization(_gamePlayManager);
        enemy.ShooterMechanism.StartFire();
        return objectPrefab;
    }
}
