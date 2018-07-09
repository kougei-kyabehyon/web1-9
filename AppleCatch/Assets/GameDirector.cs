using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour {


    GameObject timerText;
    GameDirector pointText;
    float time = 60.0f;
    int point = 0;

    public void GetApple()
    {
        this.point += 100;
    }

    public void GetBomb()
    {
        this.point /= 2;
    }

	// Use this for initialization
	void Start () {
        this.timerText = GameDirector.Find("Time");
        this.pointText = GameObject.Find("Point");
	}
	
	// Update is called once per frame
	void Update () {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text = this.point.ToString() + "point";

    }
}
