
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;

    public void Select(int level) 
    {
        fader.FadeTo(level);
    }
    
}
