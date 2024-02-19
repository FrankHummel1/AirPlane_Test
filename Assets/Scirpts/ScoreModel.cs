using UnityEngine;

public class ScoreModel : MonoBehaviour
{
    [SerializeField] private ScoreView scoreView;

    private int _currentScore;

    public int CurrentScore => _currentScore;

    public void PlusScore(int number)
    {
        _currentScore += number;
        scoreView.ShowScore(_currentScore);
    }
}
