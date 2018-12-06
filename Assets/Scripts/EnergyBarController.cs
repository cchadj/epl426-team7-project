using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class EnergyBarController : MonoBehaviour
{

    private Slider _slider;
    public SharedStatCounter sharedStatCounter;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = sharedStatCounter.GetEnergyPercentage();
    }

    public void UpdateEnergyBar()
    {
        _slider.value = sharedStatCounter.GetEnergyPercentage();
    }
}

