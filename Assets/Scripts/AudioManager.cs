using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource sfxSource;
    public AudioClip collectSound;

    private void Awake()
    {
        instance = this;
    }

    public void PlayCollectSound()
    {
        sfxSource.PlayOneShot(collectSound);
    }
}