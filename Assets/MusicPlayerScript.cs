using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour
{
    AudioSource audioSourse;

    void Start()
    {
        DontDestroyOnLoad(this);
        audioSourse = GetComponent<AudioSource>();
        audioSourse.volume = PlayerPrefsController.GetMasterVolume();
    }

    public void SetVolume(float volume)
    {
        audioSourse.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
