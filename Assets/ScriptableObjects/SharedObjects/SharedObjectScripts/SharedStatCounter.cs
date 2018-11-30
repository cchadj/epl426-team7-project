using UnityEngine;

[CreateAssetMenu(fileName = "NewSharedStatCounter", menuName = @"SharedObjects/StatCounters", order = 2)]
public class SharedStatCounter : ScriptableObject {

    [SerializeField]
    private GameEvent onHealthChangedEvent;
    [SerializeField]
    private GameEvent onCoinsCollectedChangedEvent;
    [SerializeField]
    private GameEvent onEnergyChangedEvent;

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
            if (_coinsCollected < 0)
                _coinsCollected = 0;
            _coinsCollected = value;
            onCoinsCollectedChangedEvent.Raise();
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
        set
        {
            _energyCollected = value;
            _energyCollected = Mathf.Clamp(_energyCollected, 0, MaxEnergy);
            onEnergyChangedEvent.Raise();
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


    [SerializeField]
    private int _health= 100;
    /// <summary>
    /// Health is clamped beteen 0 and MaxHealth
    /// </summary>
    public int Health
    {
        get
        {
            return _health;
        }

        set
        {
            _health = value;
            _health = Mathf.Clamp(_health, 0, _maxHealth);
            onHealthChangedEvent.Raise();
        }
    }

    [SerializeField]
    private int _maxHealth;
    public int MaxHealth
    {
        get
        {
            return _maxHealth;
        }
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

    /// <summary>
    /// Get the percentage of the energy from 0 to 1 with 1 being MaxHealth and 0 the player is dead.
    /// </summary>
    /// <returns></returns>
    public float GetHealthPercentage()
    {
        return (float)_health / MaxHealth;
    }
}
