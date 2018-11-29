using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    public GameEvent onPlayerRespawnEvent;

    public GameObject effect;
    public GameObject playerParentFixed;
    public GameObject character;
    public GameObject camera;
    private CameraSplinePathFollower cameraSplinePaths;
    private SplinePathFollower splinePaths;
    private void Start()
    {
        splinePaths = playerParentFixed.GetComponent<SplinePathFollower>();
        cameraSplinePaths = camera.GetComponent<CameraSplinePathFollower>();
    }

    private Vector3 positionToRespawn = new Vector3(0f, 15f, 0f);
    private float _tPositionToRespawn = 0.01f;
    public void Respawn()
    {
        onPlayerRespawnEvent.Raise();
        Debug.Log("Respawing player");

        // Reposition player
        splinePaths.set_t(_tPositionToRespawn);
        character.transform.position = positionToRespawn;

        // Reposition camera
        cameraSplinePaths.set_t(_tPositionToRespawn);

        // Put particles around player
        // GameObject respawn_effect = (GameObject)Instantiate(respawnEffect);
        GameObject respawn_effect = Instantiate(effect, positionToRespawn, Quaternion.identity) as GameObject;
        respawn_effect.transform.parent = transform;
        Destroy(respawn_effect, 6f);
    }

}
