using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
    public SceneController sceneController;
    public string sceneToLoad;
    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.CompareTag("Player"))
        {
            sceneController.changeScenes(sceneToLoad);
        }
    }
}