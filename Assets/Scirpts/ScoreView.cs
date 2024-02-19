using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    public void ShowScore(int number) => scoreText.text = number.ToString();
}
