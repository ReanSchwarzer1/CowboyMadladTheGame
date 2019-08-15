using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public Transform spawnPoint;
    public float minDistance;
    public Transform enemy1;
    PlayerHealth currentHealth;
    [SerializeField]
    private int enemyCounter = 5;
    [SerializeField]
    private float lastTime;

    private void Start()
    {
        lastTime = Time.time;
    }
    private void Update()
    {
            if (Time.time - lastTime > 5f )
            {
                WaveCall();
                lastTime = Time.time;
            }               
    }

    void WaveCall()
    {
        
        for (int i = 0; i < enemyCounter; i++)
        {
            if (Time.time -lastTime>1f)
                Instantiate(enemy1, spawnPoint.transform.position, Quaternion.identity);
            lastTime = Time.time;
            
        }

    }















}
















