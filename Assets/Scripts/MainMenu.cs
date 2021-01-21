using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    Resolution[] resolutions;
    public GameObject levelSelect;
    public GameObject closeMenu;

    void Start()
    {
        resolutions = Screen.resolutions;

        int currentResolutionIndex = 0;
        List<string> options = new List<string>();

        for (int i =0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions.Length;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;           
            }
        }
    }

    public void Play()
    {
        levelSelect.SetActive(true);
        closeMenu.SetActive(false);
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume) 
    {
        audioMixer.SetFloat("volume",volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
