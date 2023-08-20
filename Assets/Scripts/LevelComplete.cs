using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int nLevels = 2;

    public void LoadNextLevel()
    {
        Debug.Log("New Level starts.");
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel + 1 == nLevels)
        {
            SceneManager.LoadScene(0);
        } else
        {
            SceneManager.LoadScene(currentLevel + 1);
        }
    }
}
