using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    
        public void SetMusicVolume(float volume) {
        Debug.Log(volume);
        audioMixer.SetFloat("Music Volume", volume);
    }
    
    public void SetSFXVolume(float volume) {
        Debug.Log(volume);
        audioMixer.SetFloat("SFX Volume", volume);
    }
}
