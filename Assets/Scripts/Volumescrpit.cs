using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Volumescrpit : MonoBehaviour
{
    [SerializeField] private Slider volumeslider = null;
    [SerializeField] private TMP_Text volumeTextUI = null;
    float volumeval = 3f;

    public void Start()
    {
        AudioListener.volume = 1;
       LoadValues();
    }

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("%0"); 
    }

    public void SaveVolumeButtom()
    {
        float volumevalue = volumeslider.value;
        PlayerPrefs.SetFloat("VolumeValue",volumevalue);
        LoadValues();
    }

    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeslider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
