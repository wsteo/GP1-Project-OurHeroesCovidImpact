using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public Text LiveText;
    
    // Update is called once per frame
    void Update()
    { 
        LiveText.text = "Lives: " + PlayerStats.Lives.ToString();
    }
}
