using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public Text LiveText;
    public Text redLiveText;
    
    // Update is called once per frame
    void Update()
    {
        redLiveText.text = PlayerStats.Lives.ToString();
        redLiveText.color = Color.red;
        LiveText.text = "Lives: ";
    }
}
