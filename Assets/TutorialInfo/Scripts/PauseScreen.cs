using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.Instance.musicSource.Pause();
        }
        else if(Input.GetKeyDown(KeyCode.U))
        {
            SoundManager.Instance.musicSource.UnPause();
        }
        
    }
}
