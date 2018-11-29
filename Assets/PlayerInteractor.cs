using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour {

    public EnemyType ghostTypeEnum;
    public EnemyType dragonTypeEnum;
    public EnemyType orcTypeEnum;

	// Use this for initialization
	void Start () {
		
	}
	
    /// <summary>
    /// How th player interracts with different enemieTypes.
    /// </summary>
    /// <param name="enemyType"> The type of the enemy </param>
    /// <param name="enemyTime"> The time of the enemy in  its spline </param>
    public void Interract(EnemyType enemyType, float enemyTime)
    {
        if(enemyType == ghostTypeEnum)
        {
            Debug.Log("I hit a ghost");
        }
        else if (enemyType == dragonTypeEnum)
        {

        }
        else if(enemyType == orcTypeEnum)
        {

        }
    }
}
