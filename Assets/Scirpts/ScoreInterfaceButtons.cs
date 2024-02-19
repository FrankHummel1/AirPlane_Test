using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreInterfaceButtons : MonoBehaviour
{
    [SerializeField] private Button retry;
    [SerializeField] private Button exit;

    private void Start()
    {
        retry.onClick.AddListener(Retry);
        exit.onClick.AddListener(Exit);
    }

    private void OnDestroy()
    {
        retry.onClick.RemoveAllListeners();
        exit.onClick.RemoveAllListeners();
    }

    public void Retry() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    public void Exit() => Application.Quit();
}
