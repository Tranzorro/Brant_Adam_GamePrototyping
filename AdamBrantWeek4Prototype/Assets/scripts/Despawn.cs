﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        //check collision name
        Debug.Log("collision name = " + col.gameObject.name);
        if(col.gameObject.name == "Floor")
        {
            scoreCounter.scoreValue += 1;
            Destroy(gameObject);
        }
        
    }
}
