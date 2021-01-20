using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip PlayerAttackSound, CrashGlassSound, WinSound, LoseSound, VirusAttackSound, BackgroundSound;
    static AudioSource AudioSrc;

    void Start()
    {
        PlayerAttackSound= Resources.Load<AudioClip> ("PlayerAttack");
        CrashGlassSound= Resources.Load<AudioClip> ("PlayerAttackHitVirus");
        WinSound= Resources.Load<AudioClip> ("PlayerWin");
        LoseSound= Resources.Load<AudioClip> ("PlayerLose");
        VirusAttackSound= Resources.Load<AudioClip> ("VirusAttack");
        BackgroundSound= Resources.Load<AudioClip> ("BackgroundSound");
        
        AudioSrc= GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlayerSound (string Clip)
    {
        switch(Clip)
        {
            case"PlayerAttack":
                AudioSrc.PlayOneShot(PlayerAttackSound);
                break;
            case"PlayerAttackHitVirus":
                AudioSrc.PlayOneShot(CrashGlassSound);
                break;
            case"PlayerWin":
                AudioSrc.PlayOneShot(WinSound);
                break;
            case"PlayerLose":
                AudioSrc.PlayOneShot(LoseSound);
                break;
            case"VirusAttack":
                AudioSrc.PlayOneShot(VirusAttackSound);
                break;
            case"BackgroundSound":
                AudioSrc.PlayOneShot(BackgroundSound);
                break;
        }
    }
}
