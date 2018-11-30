using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CoinCollectedDisplayController : MonoBehaviour {

    public SharedStatCounter statCounter;
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
        _text.text = statCounter.CoinsCollected.ToString();
    }
    public void UpdateCoinsCollected()
    {
        _text.text = statCounter.CoinsCollected.ToString();
    }
}
