using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesUI : MonoBehaviour
{
    public Text LiveText;
    public Text redLiveText;
    public Text LevelNum;
    
    // Update is called once per frame
    void Update()
    {
        redLiveText.text = PlayerStats.Lives.ToString();
        redLiveText.color = Color.red;
        LiveText.text = "Lives: ";
        LevelNum.text = "Level: " + (SceneManager.GetActiveScene().buildIndex).ToString();
    }
}
