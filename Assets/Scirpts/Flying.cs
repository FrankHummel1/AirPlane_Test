using System.Collections;
using UnityEngine;

public class Flying : MonoBehaviour
{
    [SerializeField] private Transform flyingObject;
    [SerializeField] private Vector2 postiionToMoveTo;
    [SerializeField] private float speed;

    private bool _isFlying;
    private Coroutine FlyCoroutine;

    private void OnEnable()
    {
        _isFlying = true;

        if (FlyCoroutine != null)
            StopCoroutine(FlyCoroutine);

        FlyCoroutine = StartCoroutine(FlyTowards());
    }

    private void OnDisable() => _isFlying = false;

    private IEnumerator FlyTowards()
    {
        while(_isFlying)
        {
            yield return new WaitForEndOfFrame();
            flyingObject.transform.Translate(postiionToMoveTo * speed * Time.deltaTime);
        }
    }
}
