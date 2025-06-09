using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }
}
