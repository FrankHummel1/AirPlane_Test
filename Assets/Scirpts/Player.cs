using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Shooter shooter;
    [SerializeField] private LifeManager lifeManager;
    [SerializeField] private GamePlayManager gamePlayManager;
    [SerializeField] private TranslatorObjectManager translatorObjectManager;
    [SerializeField] private PoolManager poolManager;

    private void Start()
    {
        shooter.Initialization(poolManager, translatorObjectManager);
        shooter.StartFire();
    }

    public void DecreaseLife() => lifeManager.ChangeLifeCount(-1);

    public void IncreaseLife(int count) => lifeManager.ChangeLifeCount(count);
}
