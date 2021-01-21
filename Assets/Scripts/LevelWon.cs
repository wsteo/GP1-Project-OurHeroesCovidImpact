using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelWon : MonoBehaviour
{
    public Text roundsText;

    private void OnEnable()
    {
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        roundsText.text = "0";
        int round = 0;

        yield return new WaitForSeconds(0.7f);

        while(round < 25)
        {
            round++;
            roundsText.text = round.ToString();

            yield return new WaitForSeconds(0.07f);
        }
    }
}
