using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;

    public Button[] levelButton;

    public void Select(int level) 
    {
        fader.FadeTo(level);
    }
    
}
