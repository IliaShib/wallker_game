using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject LoseWindow;
    public GameObject RecordMenu;
    public Slider sliderThing;
    private float soundValue;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreTxt;
    public TextMeshProUGUI Records;

    public static GameManager instance;

    private void Start()
    {
        instance = this;
        sliderThing.value = PlayerPrefs.GetInt("soundValue");
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
        int R1 = PlayerPrefs.GetInt("R1");
        int R2 = PlayerPrefs.GetInt("R2");
        int R3 = PlayerPrefs.GetInt("R3");
        int R4 = PlayerPrefs.GetInt("R4");
        int R5 = PlayerPrefs.GetInt("R5");
        int R6 = PlayerPrefs.GetInt("R6");
        int R7 = PlayerPrefs.GetInt("R7");
        if (score > bestScore)
        {
            bestScore = score;
            R7 = R6;
            R6 = R5;
            R5 = R4;
            R4 = R3;
            R3 = R2;
            R2 = R1;
            R1 = score;

        }
        PlayerPrefs.SetInt("R1", R1);
        PlayerPrefs.SetInt("R2", R2);
        PlayerPrefs.SetInt("R3", R3);
        PlayerPrefs.SetInt("R4", R4);
        PlayerPrefs.SetInt("R5", R5);
        PlayerPrefs.SetInt("R6", R6);
        PlayerPrefs.SetInt("R7", R7);
        bestScoreTxt.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
        Time.timeScale = 0;
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
    }

    public void RecordsScene()
    {
        RecordMenu.SetActive(true);
        int R1 = PlayerPrefs.GetInt("R1");
        int R2 = PlayerPrefs.GetInt("R2");
        int R3 = PlayerPrefs.GetInt("R3");
        int R4 = PlayerPrefs.GetInt("R4");
        int R5 = PlayerPrefs.GetInt("R5");
        int R6 = PlayerPrefs.GetInt("R6");
        int R7 = PlayerPrefs.GetInt("R7");
        Records.text = "1 - " + R1 + "\n" +
            "2 - " + R2 + "\n" +
            "3 - " + R3 + "\n" +
            "4 - " + R4 + "\n" +
            "5 - " + R5 + "\n" +
            "6 - " + R6 + "\n" +
            "7 - " + R7;
    }
    public void SliderValueChanger()
    {
        soundValue = sliderThing.value;
        PlayerPrefs.SetInt("soundValue", (int) soundValue);
    }
}
