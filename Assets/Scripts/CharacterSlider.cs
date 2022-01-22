using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSlider : MonoBehaviour
{
    [SerializeField] private Slider characterSlider;

    // Start is called before the first frame update
    void Start()
    {
        characterSlider.value = PlayerPrefs.GetFloat("Character");
    }

    public void setVolume(float volume)
    {
        PlayerPrefs.SetFloat("Character", volume);
    }
}
