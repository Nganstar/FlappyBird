﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllwe : MonoBehaviour {
    public GameObject obs1;
    public GameObject obs2;
    public GameObject obs3;
    public GameObject obs4;
    public GameObject PositionofNewObstacle;
    int counter = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        counter = Random.Range(1, 5);
        if (collision.gameObject.tag == "Obstacle1")
        {
            if (counter == 1)
            {
                Instantiate(obs1, new Vector2(PositionofNewObstacle.transform.position.x, obs1.transform.position.y), Quaternion.identity);
            }
            else if (counter == 2)
            {
                Instantiate(obs2, new Vector2(PositionofNewObstacle.transform.position.x, obs2.transform.position.y), Quaternion.identity);
            }
            else if (counter == 3)
            {
                Instantiate(obs3, new Vector2(PositionofNewObstacle.transform.position.x, obs3.transform.position.y), Quaternion.identity);
            }
            else if (counter == 4)
            {
                Instantiate(obs4, new Vector2(PositionofNewObstacle.transform.position.x, obs4.transform.position.y), Quaternion.identity);
            }
            Destroy(collision.gameObject);
        }
    }
}
