﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;
    int ratio;
    float speed = -0.03f;
	// Use this for initialization
    public void SetParameter(float span,float speed,int ratio)
    {
        this.span = span;
        this.speed = speed;
        this.ratio;
    }
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 11);
            if (dice <= this.span)
            {
                item = Instantiate(bombPrefab) as GameObject;

            }
            else
            {
                item = Instantiate(applePrefab) as GameObject;
            }
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            itcm.transform.positon = new Vector(x, 4, z);

            item.GetComponent<ItemGenerator>().dropSpeed = this.speed;
        }
    }
}
