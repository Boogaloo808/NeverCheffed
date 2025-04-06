using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class settings : MonoBehaviour
{
    [Header("sound settings")]
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider SoundSlider;
    [SerializeField] AudioMixer musicMixer;
    [SerializeField] AudioMixer soundMixer;

    public TMP_Text MusVol;
    public TMP_Text SonVol;
    public AudioSource bgMusic;
    public AudioSource SoundEffect;

    public bool isSoundPlaying = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Awake()
    {
        SetSoundVolume(PlayerPrefs.GetFloat("savedsoundVolume", 100));
        SetMusicVolume(PlayerPrefs.GetFloat("savedMusicVolume", 100));
    }

    // volume slider settings for music

    public void SetSoundVolume(float SoundValue)
    {
        if (SoundValue < 1f)
        {
            SoundValue = .001f;
        }

        RefreshSoundVolume(SoundValue);
        PlayerPrefs.SetFloat("savedsoundVolume", SoundValue);
        soundMixer.SetFloat("soundVolume", Mathf.Log10(SoundValue / 100) * 20f);
    }
    public void SetVolumeFromSoundSlider()
    {
        SetSoundVolume(SoundSlider.value);

    }

    public void RefreshSoundVolume(float SoundValue)
    {
        SoundSlider.value = SoundValue;
        SonVol.text = SoundValue.ToString() + "%";

        if (SoundValue < 1f)
        {
            SonVol.SetText("0%");
        }
    }

    public void SetMusicVolume(float MusicValue)
    {
        if (MusicValue < 1f)
        {
            MusicValue = .001f;
        }

        RefreshMusicVolume(MusicValue);
        PlayerPrefs.SetFloat("savedMusicVolume", MusicValue);
        musicMixer.SetFloat("MusicVolume", Mathf.Log10(MusicValue / 100) * 20f);
    }
    public void SetVolumeFromMusicSlider()
    {
        SetMusicVolume(MusicSlider.value);

    }

    public void RefreshMusicVolume(float MusicValue)
    {
        MusicSlider.value = MusicValue;
        MusVol.text = MusicValue.ToString() + "%";

        if (MusicValue < 1f)
        {
            MusVol.SetText("0%");
        }
    }
    public void playMusic()
    {
        if (!bgMusic.isPlaying)
        {
            bgMusic.Play();
        }
    }

    public void playsound()
    {
        if (!isSoundPlaying)
        {
            SoundEffect.Play();
            isSoundPlaying = true;
        }
        else
        {
            SoundEffect.Pause();
            isSoundPlaying = false;
        }
    }
}
