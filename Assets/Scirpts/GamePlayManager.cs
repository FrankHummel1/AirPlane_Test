using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private ScoreModel scoreModel; 
    [SerializeField] private ObjectSpawner objectSpawner;
    [SerializeField] private PoolManager poolManager;
    [SerializeField] private List<SOObjectForSpawn> objectToSpawn = new List<SOObjectForSpawn>();

    private void Start()
    {
        gameManager.StartGame();
        SpawnSet();
    }

    private void SpawnSet()
    {
        foreach (SOObjectForSpawn objectToSpawn in objectToSpawn)
            objectSpawner.CreateObject(objectToSpawn);
    }

    public void PlusScore(int score) => scoreModel.PlusScore(score);
}
