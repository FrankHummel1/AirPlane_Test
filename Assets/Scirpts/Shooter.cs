using System.Collections;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform planeFirePoint;
    [SerializeField] private float fireInterval;

    private TranslatorObjectManager _translatorManager;
    private PoolManager _poolManager;
    private GamePlayManager _gamePlayManager;
    private bool _canShoot;

    public void Initialization(PoolManager poolManager, TranslatorObjectManager translatorManager)
    {
        _poolManager = poolManager;
        _translatorManager = translatorManager;
        _canShoot = true;   
    }

    public void StartFire()
    {
        if (_poolManager != null && _translatorManager != null)
            StartCoroutine(Fire());
    }

    private IEnumerator Fire()
    {
        while(_canShoot)
        {
            yield return new WaitForSeconds(fireInterval);
            _translatorManager.TranslateObject(_poolManager.Get(bullet), planeFirePoint.position);
        }
    }

    public void OnDisable() => _canShoot = false;

    private void OnEnable()
    {
        _canShoot = true;
        StartFire();
    }
}
