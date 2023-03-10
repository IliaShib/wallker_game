using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject LoseWindow;
    public GameObject TutorialWindow;
    public GameObject PlayerMenu;
    public GameObject Player;
    public GameObject Spawner;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreTxt;

    public static GameManager instance;

    private void Start()
    {
        instance = this;
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Lose()
    {
        LoseWindow.SetActive(true);
        int score = ScoreManager.Instance.score;
        scoreText.text = score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if (score > bestScore)
        {
            bestScore = score;
        }
        bestScoreTxt.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
        Time.timeScale = 0;
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
    }

    public void TutorialScene()
    {
        int Tutorial = PlayerPrefs.GetInt("Tutorial");
        if (Tutorial == 0)
        {
            TutorialWindow.SetActive(true);
            PlayerPrefs.SetInt("Tutorial", 1);
        }
        else
        {
            PlayerMenu.SetActive(true);
            Player.SetActive(true);
            Spawner.SetActive(true);
        }
    }
}
