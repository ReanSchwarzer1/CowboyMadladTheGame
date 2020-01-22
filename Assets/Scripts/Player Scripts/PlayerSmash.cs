using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSmash : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 50;
     int health = 100;
    public Animation anim;
    

    GameObject player;
    int i = 0;
    private void Start()
    {
        anim = GetComponent<Animation>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(++i);

       if  (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Attack done by weapon!");
           if (health > 0)
            {
                health -= attackDamage; 
            }
            if (health <= 0)
            {
                Destroy(this);
            }
        }
    }
    
}



















    
