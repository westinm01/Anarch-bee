using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        // destroys singleton deleting UI and effectively resetting everything
        // as a new singleton will be created when Level1 is loaded
        Destroy(FindObjectOfType<Singleton>());
    }
    public void LoadNextScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level1");
        FindObjectOfType<ScoreKeeper>().ResetScore();
        FindObjectOfType<InventoryManager>().ResetBees();
    }

    public void LoadSceneName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
