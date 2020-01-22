using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{

    public Transform player;
    public float Espeed = 10f;
    public float minDist = 1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(player.transform.position, gameObject.transform.position) > minDist)
            transform.Translate(new Vector2(-1f,0f) * Espeed * Time.deltaTime);
    }
}
