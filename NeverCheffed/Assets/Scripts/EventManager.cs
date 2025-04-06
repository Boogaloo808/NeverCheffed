
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class EventManager : MonoBehaviour
{
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider SoundSlider;
    [SerializeField] AudioMixer musicMixer;
    [SerializeField] AudioMixer soundMixer;

    public TMP_Text MusVol;
    public TMP_Text SonVol;
    public AudioSource bgMusic;
    public AudioSource SoundEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Awake()
    {
        SetMusicVolume(PlayerPrefs.GetFloat("savedMusicVolume", 100));
        SetSoundVolume(PlayerPrefs.GetFloat("savedSoundVolume", 100));
    }

    [Header("music volume")]
    public void SetMusicVolume(float musicVal)
    {
        if (musicVal < 1f)
        {
            musicVal = .001f;
            MusVol.SetText("0");
        }

        RefreshMusicSlider(musicVal);
        PlayerPrefs.SetFloat("savedMusicVolume", musicVal);
        musicMixer.SetFloat("MusicVolume", Mathf.Log10(musicVal / 100) * 20f);
    }
    public void SetVolumeFromMusicSlider()
    {
        SetMusicVolume(MusicSlider.value);
       
    }

    public void RefreshMusicSlider(float musicValue)
    {
        MusicSlider.value = musicValue;
        MusVol.text = musicValue.ToString();

        if (musicValue < 1f)
        {
            MusVol.SetText("0");
        }
    }
    public void SetSoundVolume(float soundVal)
    {
        if (soundVal < 1f)
        {
            soundVal = .001f;
            SonVol.SetText("0");
        }

        RefreshSoundSlider(soundVal);
        PlayerPrefs.SetFloat("savedSoundVolume", soundVal);
        soundMixer.SetFloat("SoundVolume", Mathf.Log10(soundVal / 100) * 20f);
    }
    public void SetVolumeFromSoundSlider()
    {
        SetSoundVolume(SoundSlider.value);

    }

    public void RefreshSoundSlider(float soundvalue)
    {
        SoundSlider.value = soundvalue;
        SonVol.text = soundvalue.ToString();

        if (soundvalue < 1f)
        {
            SonVol.SetText("0");
        }
    }

    public void playMusic()
    {
        if (!bgMusic.isPlaying)
        {
            bgMusic.Play();
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartLevel()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadLevel(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
