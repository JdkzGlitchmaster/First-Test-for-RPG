using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    public Slider healthBar;
    public Text HPtext;
    public PlayerHealthManager playerHealth;
    public Text gameOverText;
    public Text enemyCountText;

    public static UIManager instance;

    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        HPtext.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
        enemyCountText.text = "Enemies killed: " + EnemyCounter.instance.enemyCount + "/" + EnemyCounter.instance.maxEnemyCount;

    }
}

