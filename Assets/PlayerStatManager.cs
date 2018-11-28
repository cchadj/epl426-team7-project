using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatManager : MonoBehaviour {
    public SharedStatCounter statCounter;

    public void IncrementCoin()
    {
        statCounter.AddOneCoin();
    }

    public void IncrementEnergy()
    {
        statCounter.AddOneEnergy();
    }
	
}
