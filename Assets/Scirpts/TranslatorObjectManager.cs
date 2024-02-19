using UnityEngine;

public class TranslatorObjectManager : MonoBehaviour
{
    public void TranslateObject(GameObject poolForObject, Vector2 spawnPosition) => poolForObject.transform.position = spawnPosition;
}
