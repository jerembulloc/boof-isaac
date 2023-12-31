using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    public static Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        setNumberText(slider.value);
    }

    public void setNumberText(float value)
    {
        numberText.text = value.ToString();
        AudioListener.volume = value / 100;
    }

}
