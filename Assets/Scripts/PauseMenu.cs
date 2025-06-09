using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    private Game game;
    private GameObject gridGameObject;
    public GameObject pausePanel;
    private bool isPause;

    private void Awake()
    {
        gridGameObject = GameObject.Find("Grid");
        if (gridGameObject != null)
        {
            game = gridGameObject.GetComponent<Game>();
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
            pausePanel.SetActive(isPause);
        }
    }
    public void OnClickRestart()
    {
        if (game != null)
        {
            game.NewGame();
        }
    }
    public void OnClickMenu()
    {
        SceneManager.LoadScene(0);
    }
}
