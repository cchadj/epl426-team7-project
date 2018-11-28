using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class EnergyText : MonoBehaviour {
    public SharedStatCounter statCounter;
    private Text _text;
    private string _prefix;

    private void Start()
    {
        _text = GetComponent<Text>();
        _prefix = _text.text;
    }

    public void UpdateEnergy()
    {

        statCounter.GetEnergyPercentage();
        _text.text = _prefix + " " + statCounter.GetEnergyPercentage() * 100 + "%" ;
    }
}
