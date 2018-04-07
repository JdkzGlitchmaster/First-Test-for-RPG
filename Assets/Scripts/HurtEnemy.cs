using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive;
    public GameObject particle;

    private SFXManager sfxMan;

    // Use this for initialization
    void Start () {
        sfxMan = FindObjectOfType<SFXManager>();
    }
	
	// Update is called once per frame
	void Update () {

		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            sfxMan.enemyDead.Play();
            Instantiate(particle, transform.position, transform.rotation);

            if(EnemyCounter.instance.enemyCount < EnemyCounter.instance.maxEnemyCount)
            {
                EnemyCounter.instance.enemyCount++;
            }
                
            else
            {
                EnemyCounter.instance.extraEnemyCount++;
            }

        }

        if (other.gameObject.tag == "Boss")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            Instantiate(particle, transform.position, transform.rotation);
            sfxMan.slimeHit.Play();
        }
    }
}
