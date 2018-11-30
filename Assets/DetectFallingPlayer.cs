using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFallingPlayer : MonoBehaviour {
    public GameEvent onPlayerDeathEvent;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("First trigger on trigger");
        PlayerDeath sc = other.GetComponent<PlayerDeath>();
        if (sc != null)
        {
            onPlayerDeathEvent.Raise();
            //sc.Respawn();
        }
            
    }
}
