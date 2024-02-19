using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject pauseMenuFrame;
    [SerializeField] private Button pauseMenu;
    [SerializeField] private Button okMenu;
    [SerializeField] private Button exitMenu;

    private void Start()
    {
        pauseMenu.onClick.AddListener(PauseGame);
        okMenu.onClick.AddListener(OKButton);
        exitMenu.onClick.AddListener(ExitGame);
    }

   public void ExitGame() => Application.Quit();

    public void PauseGame()
    {
        pauseMenuFrame.gameObject.SetActive(true);
        gameManager.SetTimeScale(0);
    }

    public void OKButton()
    {
        pauseMenuFrame.gameObject.SetActive(false);
        gameManager.SetTimeScale(1);
    }

    public void RemoveAllListeteners()
    {
        pauseMenu.onClick.RemoveAllListeners();
        okMenu.onClick.RemoveAllListeners();
        exitMenu.onClick.RemoveAllListeners();
    }

    private void OnDestroy() => RemoveAllListeteners();
}
