using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    
    private Sprite soundOnImage;
    private bool isOn = true;

    public Sprite soundOffImage;
    public Button button;
    public AudioSource audioSource;

    private void Start()
    {
        soundOnImage = button.image.sprite;
    }

    public void SoundButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            audioSource.mute = false;
        }
    }

}
