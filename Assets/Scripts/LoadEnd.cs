using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadEnd : MonoBehaviour {

    public GameObject endSquare;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (EnemyCounter.instance.enemyCount == EnemyCounter.instance.maxEnemyCount)
        {
            endSquare.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (EnemyCounter.instance.enemyCount == EnemyCounter.instance.maxEnemyCount)
        {
            if (other.gameObject.name == "Temp")
            {
                Application.LoadLevel("End");
            }
        }
    }
}
