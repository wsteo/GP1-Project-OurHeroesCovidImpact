using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    public Text MoneyText;

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "Gold: " + PlayerStats.Money.ToString();
    }
}
