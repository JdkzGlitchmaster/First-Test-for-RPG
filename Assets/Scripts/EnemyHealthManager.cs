using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHealth;

    private SFXManager sfxMan;



    // Use this for initialization
    void Start () {
        CurrentHealth = MaxHealth;
        sfxMan = FindObjectOfType<SFXManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (CurrentHealth <= 0)
        {
            

            Destroy(gameObject);

            sfxMan.pop.Play();

            EnemyCounter.instance.bossKilled = true;

        }
     
    
        
    }
    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;

      


       
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
