using UnityEngine;

[CreateAssetMenu(fileName = "ObjectToSpawnSO", menuName = "SpawnObjects/ObjectToSpawnSO")]
public class SOObjectForSpawn : ScriptableObject
{
    [SerializeField] protected GameObject prefab;
    [SerializeField] protected float minIntervalTimeToSpawn;
    [SerializeField] protected float maxIntervalTimeToSpawn;
    [SerializeField] protected float intervalBordersToSpawn;

    public GameObject Prefab => prefab;
    public float MinIntervalTimeToSpawn => minIntervalTimeToSpawn;
    public float MaxIntervalTimeToSpawn => maxIntervalTimeToSpawn;
    public float IntervalBordersToSpawn => intervalBordersToSpawn;
}
