using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEnd : MonoBehaviour {

    public GameObject endSquare;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (EnemyCounter.instance.enemyCount == EnemyCounter.instance.maxEnemyCount && EnemyCounter.instance.bossKilled)
        {
            endSquare.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (EnemyCounter.instance.enemyCount == EnemyCounter.instance.maxEnemyCount && EnemyCounter.instance.bossKilled)
        {
            if (other.gameObject.name == "Temp")
            {
                SceneManager.LoadScene("End");
                EnemyCounter.DontDestroyOnLoad(gameObject);
            }
        }
    }
}
