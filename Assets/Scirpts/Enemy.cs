using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Shooter shooterMechanism;
    [SerializeField] private EnemyDisabler enemyDisabler;
    [SerializeField] private int plusScoreCountForEnemy;

    private GamePlayManager _gamePlayManager;
    private bool _isImmortal;

    public bool IsImmortal => _isImmortal;
    public Shooter ShooterMechanism => shooterMechanism;
    public EnemyDisabler EnemyDisabler => enemyDisabler;

    private void OnEnable() => ImmortalitySetting(true);

    public void Initialization(GamePlayManager gamePlayManager) => _gamePlayManager = gamePlayManager;

    public void ImmortalitySetting(bool status)  => _isImmortal = status;

    public void Die()
    {
        _gamePlayManager.PlusScore(plusScoreCountForEnemy);
        gameObject.SetActive(false);
    }
}
