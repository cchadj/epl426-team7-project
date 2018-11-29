using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreDisplayController : MonoBehaviour {

    public SharedStatCounter statCounter;
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    public void UpdateScore()
    {
        _text.text = statCounter.CoinsCollected.ToString();
    }
}
