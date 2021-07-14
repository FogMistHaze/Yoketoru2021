using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinyAudio : MonoBehaviour
{
    public static TinyAudio Instance;

    public enum SE
    {
        Attack_niku,
        Attack_tomato,
        Cancel,
        Kettei,
        Menu_ugoki,
        Menu_UP
    }

    public enum BGM
    {
        Clear,
        Gameover
    }

    [Tooltip("効果音のAudio Clipを、SEの列挙子と同じ順番で設定してください。"), SerializeField]
    AudioClip[] seList;

    [Tooltip("BGM音源"), SerializeField]
    AudioClip[] bgmList;

    AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

 
    public static void PlaySE(SE se)
    {
        Instance.audioSource.PlayOneShot(Instance.seList[(int)se]);
    }

    public static void StopBGM()
    {
        Instance.audioSource.Stop();
    }

    public static void PlayBGM(BGM bgm)
    {
        StopBGM();
        Instance.audioSource.clip = Instance.bgmList[(int)bgm];
        Instance.audioSource.Play();            
    }

}
