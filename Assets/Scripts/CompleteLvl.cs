using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLvl : MonoBehaviour
{
    private readonly int menuScene = 0;

    public int levelToUnlock = 2;

    public SceneFader sceneFader;

    public void Continue()
    {
        //PlayerPrefs.SetInt("levelReached", levelToUnlock);
        sceneFader.FadeTo((SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void Menu()
    {
        sceneFader.FadeTo(menuScene);
    }
}
