using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndResults : MonoBehaviour {

    public Text enemyCountText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(EnemyCounter.instance.extraEnemyCount == 30)
        {
            enemyCountText.text = "Enemies killed: " + (EnemyCounter.instance.enemyCount += EnemyCounter.instance.extraEnemyCount) + "/50" + System.Environment.NewLine + "S RANK";
        }
        else if (EnemyCounter.instance.extraEnemyCount >= 20)
        {
            enemyCountText.text = "Enemies killed: " + (EnemyCounter.instance.enemyCount += EnemyCounter.instance.extraEnemyCount) + "/50" + System.Environment.NewLine + "A RANK";
        }
        else if (EnemyCounter.instance.extraEnemyCount >= 10)
        {
            enemyCountText.text = "Enemies killed: " + (EnemyCounter.instance.enemyCount += EnemyCounter.instance.extraEnemyCount) + "/50" + System.Environment.NewLine + "B RANK";
        }
        else
        {
            enemyCountText.text = "Enemies killed: " + (EnemyCounter.instance.enemyCount += EnemyCounter.instance.extraEnemyCount) + "/50" + System.Environment.NewLine + "C RANK";
        }
    }
}
