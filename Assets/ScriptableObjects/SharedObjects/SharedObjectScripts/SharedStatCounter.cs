using UnityEngine;

[CreateAssetMenu(fileName = "NewSharedStatCounter", menuName = @"SharedObjects/StatCounters", order = 2)]
public class SharedStatCounter : ScriptableObject {

    [SerializeField]
    private int _coinsCollected;
    public int CoinsCollected
    {
        get
        {
            return _coinsCollected;
        }

        set
        {
            _coinsCollected = value;
        }
    }

    [SerializeField]
    private int _energyCollected;
    public int EnergyCollected
    {
        get
        {
            return _energyCollected;
        }
    }

    [SerializeField]
    private int _maxEnergy;
    public int MaxEnergy
    {
        get
        {
            return _maxEnergy;
        }

        set
        {
            _maxEnergy = value;
        }
    }



    /// <summary>
    /// Adds one coin to the counter
    /// </summary>
    /// <returns></returns>
    public int AddOneCoin()
    {
        _coinsCollected++;
        return _coinsCollected;
    }

    /// <summary>
    /// Used to add or lose coins. Coin counter can't go lower than 0 coins.
    /// </summary>
    /// <param name="num"></param>
    /// <returns> The ammount of coins currently collected </returns>
    public int AddCoins(int num)
    {
        _coinsCollected += num;
        if (_coinsCollected < 0)
            _coinsCollected = 0;
        return _coinsCollected;
    }

    /// <summary>
    /// Adds one energy. Energy is clamped between 0 and MaxEnergy.
    /// </summary>
    /// <returns> The energy percentage from 0 to 1. (1 being MaxEnergy being collected) </returns>
    public float AddOneEnergy()
    {
        _energyCollected ++;
        _energyCollected = Mathf.Clamp(_energyCollected, 0, MaxEnergy);

        return (float)_energyCollected / MaxEnergy;
    }

    /// <summary>
    /// Used to add or remove energy. Energy can go no more than MAX_ENERGY
    /// and no less than 0. 
    /// </summary>
    /// <returns> The percentage of the current energy collected from 0 to 1. (1 being MaxEnergy collected)</returns>
    public float AddEnergy(int energry)
    {
        _energyCollected += energry;
        _energyCollected = Mathf.Clamp(_energyCollected ,0, MaxEnergy);  

        return (float)_energyCollected / MaxEnergy;
    }

    /// <summary>
    /// Get the percentage of the energy from 0 to 1 with 1 being MaxEnergy being collected and 0
    /// with no energy collected.
    /// </summary>
    /// <returns></returns>
    public float GetEnergyPercentage()
    {
        return (float)_energyCollected / MaxEnergy;
    }
}
