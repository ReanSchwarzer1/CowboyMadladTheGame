using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner2 : MonoBehaviour
{

    public Transform spawnPoint;
    public float minDistance;
    public Transform enemy2;
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
        if (Time.time - lastTime > 5f)
        {
            WaveCall();
            lastTime = Time.time;
        }
    }

    void WaveCall()
    {
       
        
            if (Time.time - lastTime > 1f)
                Instantiate(enemy2, spawnPoint.transform.position, Quaternion.identity);
            lastTime = Time.time;
        
    }
























}
