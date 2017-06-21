using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public AudioSource playerFxSource;
    public AudioSource musicSource;
    public static SoundManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void PlayerPlaySingle(AudioClip clip)
    {
        playerFxSource.clip = clip;
        playerFxSource.Play();
    }

    public void PlayerPlayDelayed(AudioClip clip, float delay)
    {
        playerFxSource.clip = clip;
        playerFxSource.PlayDelayed(delay);
    }
}