using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    protected GameObject _objectPrefab;
    protected List<GameObject> _pooledObjects = new List<GameObject>();

    protected TranslatorObjectManager _translatorManager;
    protected PoolManager _poolManager;
    protected GamePlayManager _gamePlayManager;

    public GameObject ObjectPrefab => _objectPrefab;

    public void SetObjectToSpawn(GameObject objectToSet) => _objectPrefab = objectToSet;

    public void Initialization(PoolManager poolManager, TranslatorObjectManager translatorManager, GamePlayManager gamePlayManager)
    {
        _poolManager = poolManager;
        _translatorManager = translatorManager;
        _gamePlayManager = gamePlayManager;
    }

    public virtual GameObject Get()
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
        return objectPrefab;
    }
}
