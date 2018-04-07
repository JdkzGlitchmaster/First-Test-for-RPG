using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour {

    public static EnemyCounter instance;
    public int enemyCount = 0;
    public int maxEnemyCount;
    public bool bossKilled = false;
    public int extraEnemyCount;

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
        DontDestroyOnLoad(gameObject);
	}
}
