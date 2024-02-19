using UnityEngine;
using UnityEngine.UI;

public class ScoreInterfaceManager : MonoBehaviour
{
    [SerializeField] private ScoreView scoreView;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private ScoreModel scoreModel;
    [SerializeField] private Image backRound;
    [SerializeField] private Sprite recordSprite;
    [SerializeField] private Sprite nonRecordSprite;
    [SerializeField] private GameObject recordImage;
    [SerializeField] private GameObject nonRecordImage;
    [SerializeField] private GameObject bestScore;
    [SerializeField] private ScoreView bestScoreView;
    [SerializeField] private GameObject[] interfaceToDisable;

    public void ShowScore(int value)
    {
        foreach (GameObject interFaceElement in interfaceToDisable)
            interFaceElement.SetActive(false);

        if (PlayerPrefs.HasKey("score"))
        {
            int previousScore = PlayerPrefs.GetInt("score");

            if (previousScore > value)
                NonRecord(previousScore);
            else NewRecordAchived(value);
        }
        else
        {
            PlayerPrefs.SetInt("score", value);
            NewRecordAchived(value);
        }


        scoreView.ShowScore(value);
        bestScore.SetActive(true);
        backRound.gameObject.SetActive(true);
    }

    private void NewRecordAchived(int value)
    {
        backRound.sprite = recordSprite;
        recordImage.SetActive(true);
        PlayerPrefs.SetInt("score", value);
        bestScoreView.ShowScore(value);
    }

    private void NonRecord(int value)
    {
        backRound.sprite = nonRecordSprite;
        nonRecordImage.SetActive(true);
        bestScoreView.ShowScore(value);
    }
}