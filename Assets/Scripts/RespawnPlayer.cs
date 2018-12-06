using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour {
    public GameObject playerToRespawn;
    public GameEvent onPlayerRespawnEvent;
    private PlayerDeath _playerDeathScript;

    private void Start()
    {
        _playerDeathScript = playerToRespawn.GetComponent<PlayerDeath> ();
        if (_playerDeathScript == null)
            Debug.LogError("No player death script found on assigned player");
    }

    public void Respawn()
    {
        onPlayerRespawnEvent.Raise();
        _playerDeathScript.Respawn();
    }
}
