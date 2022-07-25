using UnityEngine;
using TMPro;

public class CircleScoreController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private int score = 0;

    public void IncreaseScoreValue()
    {
        score++;

        SetScoreTextValue();
    }


    private void SetScoreTextValue()
    {
        scoreText.text = score.ToString();
    }
}
