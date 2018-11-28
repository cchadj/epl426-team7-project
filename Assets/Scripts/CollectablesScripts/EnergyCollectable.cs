using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCollectable : MonoBehaviour, ICollectable
{
    public Animator energyCollectedAnimator;
    public GameEvent onBeingCollectedEvent;

    private int _collectedAnimHash;
    
    private void Start()
    {
        _collectedAnimHash = Animator.StringToHash("Collected");
    }

    public void Collect()
    {
        onBeingCollectedEvent.Raise();
        energyCollectedAnimator.SetTrigger(_collectedAnimHash);
    }
    
    /// <summary>
    /// Destroys this collectable.
    /// Is called by the collection animation from an animation event.
    /// </summary>
    public void DestroyObject()
    {

        GameObject.Destroy(gameObject);
    }
}
