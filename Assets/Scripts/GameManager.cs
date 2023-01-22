using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameOwerRecord LoseWindow;
    public static GameManager instance;

    private void Start()
    {
        instance = this;
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Lose()
    {
        LoseWindow.gameObject.SetActive(true);
        LoseWindow.PlayerLose();
        Time.timeScale = 0;
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
    }
}
