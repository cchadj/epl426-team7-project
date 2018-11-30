using UnityEngine;

public class PlayerStatManager : MonoBehaviour
{

    public SharedStatCounter statCounter;
    public GameEvent onDeathEvent;

    void Start()
    {

        statCounter.EnergyCollected = 0;
        statCounter.CoinsCollected = 0;
        Debug.Log("ENERGY COLLECTED IS ");
    }

    public void IncrementCoin()
    {
        statCounter.CoinsCollected++;
    }

    public void IncrementEnergy()
    {
        statCounter.EnergyCollected++;
    }

    /// <summary>
    /// Add a positive or negative amount of life to the player.
    /// Health is clamped between 0 and statCounter.MaxHealth. <see cref="statCounter"/>
    /// If health reaches 0 <see cref="onDeathEvent"/> is raised. 
    /// </summary>
    /// <param name="ammnt"></param>
    public void AddHealth(int ammnt)
    {
        statCounter.Health += ammnt;
        if (statCounter.Health == 0)
        {
            Debug.Log("I DIE");
            onDeathEvent.Raise();
        }
    }

    public void FullHealth()
    {
        statCounter.Health = statCounter.MaxHealth;
    }

    public void SetHealthAt(int val)
    {
        statCounter.Health = val;
    }

}

