using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] protected TranslatorObjectManager spawnManager;
    [SerializeField] protected PoolManager poolManager;
    [SerializeField] protected PlaceRandomazer spawnPlaceRandomazer;

    public void CreateObject(SOObjectForSpawn soObject) => StartCoroutine(CreateObjectCoroutine(soObject));

    private IEnumerator CreateObjectCoroutine(SOObjectForSpawn soObject)
    {
        while(!gameManager.IsGameOver)
        {
            float timeToSpawnIn = Random.Range(soObject.MinIntervalTimeToSpawn, soObject.MaxIntervalTimeToSpawn);
            yield return new WaitForSeconds(timeToSpawnIn);
            spawnManager.TranslateObject(poolManager.Get(soObject.Prefab), spawnPlaceRandomazer.RandomizePlaceForSpawn(soObject.IntervalBordersToSpawn));
        }
    }
}
