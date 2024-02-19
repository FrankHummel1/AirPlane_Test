using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private GamePlayManager gamePlayManager;
    [SerializeField] private TranslatorObjectManager translatorObjectManager;
    [SerializeField] private Pool poolPrefab;

    private List<Pool> _pools = new List<Pool>();

    public GameObject Get(GameObject objectToCreate)
    {
        foreach(Pool pool in _pools)
        {
            if(pool.ObjectPrefab == objectToCreate)
                return pool.Get();
        }

        GameObject createdObjectForPool = new GameObject();


        if (objectToCreate.TryGetComponent(out Enemy enemy))
        {
            EnemyPool poolEnemyComponent = createdObjectForPool.AddComponent<EnemyPool>();
            poolEnemyComponent.Initialization(this, translatorObjectManager, gamePlayManager);
            return PoolProcessing(poolEnemyComponent, objectToCreate).gameObject;
        }
        else
        {
            Pool poolComponent = createdObjectForPool.AddComponent<Pool>();
            return PoolProcessing(poolComponent, objectToCreate).gameObject;
        }
    }

    private Pool PoolProcessing(Pool pool, GameObject objectToCreate)
    {
        pool.SetObjectToSpawn(objectToCreate);
        pool.name = "Pool - " + objectToCreate.name;
        _pools.Add(pool);
        pool.transform.parent = transform;
        return pool;
    }
}
