using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBarController : MonoBehaviour {

    private Slider _slider;
    public SharedStatCounter sharedStatCounter;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = sharedStatCounter.GetHealthPercentage();
    }

    public void UpdateHealthBar()
    {
        _slider.value = sharedStatCounter.GetHealthPercentage();
    }
}
