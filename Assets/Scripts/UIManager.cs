using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    
    public Slider healthBar;
    public Text HPtext;
    public PlayerHealthManager playerHealth;
    public Text gameOverText;
    public Text enemyCountText;
    public Text bossKilledText;

    public static UIManager instance;

    public bool isReadyToRestart = false;

    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    public void restartGame()
    {
        StartCoroutine(restartGameCoroutine());
    }

    IEnumerator restartGameCoroutine()
    {
        yield return new WaitForSeconds(1);
        isReadyToRestart = true;

    }


    // Update is called once per frame
    void Update()
    {

        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        HPtext.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
        enemyCountText.text = "Enemies killed: " + EnemyCounter.instance.enemyCount + "/" + EnemyCounter.instance.maxEnemyCount;
        
        if (EnemyCounter.instance.bossKilled)
        {
            bossKilledText.text = "BOSS DEFEATED";
        }
        else
        {
            bossKilledText.text = "Need to defeat boss";
        }

        if (Input.anyKeyDown && isReadyToRestart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}

