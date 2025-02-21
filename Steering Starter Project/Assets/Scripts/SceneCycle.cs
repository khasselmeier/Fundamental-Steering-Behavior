using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCycle : MonoBehaviour
{
    public void SwitchToSteeringScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex);
    }

    public void SwitchToAvoidanceScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 2;

        SceneManager.LoadScene(nextSceneIndex);
    }

    public void SwitchToDijkstraScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 3;

        SceneManager.LoadScene(nextSceneIndex);
    }
}