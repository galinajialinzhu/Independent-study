using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneBuildIndex; // Specify the scene build index to load in the Inspector.

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }
}
