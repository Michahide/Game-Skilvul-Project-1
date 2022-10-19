using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderScriptBGM : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private TextMeshProUGUI _sliderText;


    // Start is called before the first frame update
    void Start()
    {
        _slider.onValueChanged.AddListener((v) => {
            _sliderText.text = v.ToString("0");
        });
    }
    public void SliderBGMVal(){
        Debug.Log("Nilai BGM " + ((int)_slider.value));
    }
}
