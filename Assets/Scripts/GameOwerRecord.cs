using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOwerRecord : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void PlayerLose()
    {
        scoreText.text = ScoreManager.Instance.score.ToString();
    }
}
