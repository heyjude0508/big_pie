using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 1. 定义全局唯一静态单例实例
    public static GameManager Instance { get; private set; }

    // 2. 初始化单例（确保全局只有一个 GameManager）
    private void Awake()
    {
        Instance = this;
    }

    public GameObject completeUI;

    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public void CompleteLevel()
    {
        Debug.Log("Level Completed");
        completeUI.SetActive(true);

    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
