using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance {  get; private set; }
    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioSource soundSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soundSource = GetComponent<AudioSource>();
        musicSource = transform.GetChild(0).GetComponent<AudioSource>();
        audioSource = GetComponent<AudioSource>();
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this && Instance != null) 
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public void playMusic(AudioClip clip) 
    {
        audioSource.Play();
        audioSource.clip = clip;
        audioSource.loop = true;
    }

    public void stopSound(AudioClip clip) 
    {
        audioSource.Stop();
        audioSource.loop = false;
        audioSource.clip = null;
    }

}
