// done in class

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneController : MonoBehaviour
{
    
    public void quitGame()
    {
        Debug.Log("imma quit");
        Application.Quit();
    }

    public void changeScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}