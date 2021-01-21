using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;

    public Button[] levelButton;

    private void Start()
    {
        for (int i = 0; i < levelButton.Length; i++)
        {
            levelButton[i].interactable = false;
        }
    }
    public void Select(int level) 
    {
        fader.FadeTo(level);
    }
    
}
