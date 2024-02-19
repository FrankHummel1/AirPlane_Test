using System;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject[] lives;

    private int _lifeCount;
    private int _maxLifeCount;

    private void Start()
    {
        _lifeCount = lives.Length;
        _maxLifeCount = lives.Length;
    }

    public void ChangeLifeCount(int value)
    {
        if (value > 0)
            _lifeCount = Math.Min(_lifeCount + value, _maxLifeCount);

        if (value < 0)
        {
            _lifeCount = Math.Max(_lifeCount + value, 0);

            if (_lifeCount == 0)
                gameManager.LooseGame();
        }

        for (int i = 0; i < lives.Length; i ++)
            lives[i].SetActive(_lifeCount > i);
    }
}
