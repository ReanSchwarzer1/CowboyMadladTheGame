using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;     
    public int attackDamage = 1;
    //Commented out some lines of code for purpose of working with limited assets.

    Animator anim;                              
    GameObject player;                          
    PlayerHealth playerHealth;                  
    EnemyHealth enemyHealth;                    
    bool playerInRange;                         
    float timer;
   



    void Awake()
    {
        // Setting up the references.
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject.tag == "Player")
        {
            // ... the player is in range.
            playerInRange = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Attack();
        //0.5 delay for attack 
    }


    void OnTriggerExit(Collider other)
    {
        // If the exiting collider is the player...
        if (other.gameObject.tag == "Player")
        {
            // ... the player is no longer in range.
            playerInRange = false;
        }
    }


    void Update()
    {
        // Add the time since Update was last called to the timer.
         // Initialize the original timer value.
        timer += Time.deltaTime;

        // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
        if (timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            // ... attack.
            Attack();
        }
       
        // If the player has zero or less health...
        if (playerHealth.currentHealth <= 0)
        {
            // ... tell the animator the player is dead.
           // anim.SetTrigger("PlayerDead");
        }
    }


    void Attack()
    {
        // Reset the timer.
        timer = 0f;

        // If the player has health to lose...
        if (playerHealth.currentHealth > 0)
        {
            // ... damage the player.
            playerHealth.TakeDamage(attackDamage);
        }
    }
}
