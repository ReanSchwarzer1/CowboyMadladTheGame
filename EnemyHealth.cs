using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private int startingHealth = 100;
    public int currentHealth;
    public Image damageImage;
    public AudioClip deathClip;
    bool isDead;
    bool damaged;

    Animator anim;
    AudioSource playerAudio;
    //EnemyMovement enemyMovement;

    void Start()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        //enemyAudio = GetComponent<AudioSource>();
        //enemyMovement = GetComponent<PlayerMovement>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }
   

}







