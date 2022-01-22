using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionSlider : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] private Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("BGM");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void setSound(float volume)
    {
        PlayerPrefs.SetFloat("BGM", volume);
        audioSource.volume = PlayerPrefs.GetFloat("BGM");
    }
}
