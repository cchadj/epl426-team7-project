using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectable : MonoBehaviour, ICollectable
{
    public GameEvent onBeingCollectedEvent;
    
    public void Collect()
    {
        onBeingCollectedEvent.Raise();
       
    }
}
