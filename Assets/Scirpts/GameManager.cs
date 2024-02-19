using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PauseMenu pauseMenu;
    [SerializeField] private ScoreInterfaceManager scoreCounter;
    [SerializeField] private ScoreModel scoreModel;

    private static bool _isGameOver;

    public bool IsGameOver => _isGameOver;

    private void Start() => _isGameOver = false;

    public void SetTimeScale(float time) => Time.timeScale = time;

    public void SetGameOver(bool isGameOver) => _isGameOver = isGameOver;

    public void LooseGame()
    {
        SetGameOver(true);
        pauseMenu.RemoveAllListeteners();
        scoreCounter.ShowScore(scoreModel.CurrentScore);
        SetTimeScale(0);
    }

    public void StartGame()
    {
        SetGameOver(false);
        SetTimeScale(1);
    }
}