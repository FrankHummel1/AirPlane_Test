using UnityEngine;

public class PlaceRandomazer : MonoBehaviour
{
    [SerializeField] private Transform centerSpawn;

    public Vector2 RandomizePlaceForSpawn(float spawnIntervalForX)
    {
        float xCoordinatesForSpawn = Random.Range(-spawnIntervalForX, spawnIntervalForX);
        Vector2 centerSpawnpostiion = centerSpawn.position;
        centerSpawnpostiion.x += xCoordinatesForSpawn;
        return centerSpawnpostiion;
    }
}
