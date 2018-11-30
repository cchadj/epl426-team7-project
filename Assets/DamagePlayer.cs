using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    public EnemyType enemyType;
    [Tooltip("The general event to be raised whenever player gets damaged")]
    public GameEvent onPlayerDamageEvent;
    [Tooltip("Event to be raised should be specific on the type of the enemy")]
    public GameEvent onPlayerSpecificDamageEvent;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hubert hits someone " + other.ToString());
        PlayerInteractor playerInteractor = other.GetComponent<PlayerInteractor>();
        if(playerInteractor != null)
        {
            Debug.Log("Hubert interacts with player");
            //TODO send the right time 
            playerInteractor.Interract(enemyType, 0f);
            onPlayerDamageEvent.Raise();
            onPlayerSpecificDamageEvent.Raise();
        }
    }
}
