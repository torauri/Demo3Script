using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creater : MonoBehaviour {
	public GameObject enemyPrefab;
	public int interval;
	private int frame;
	private float Espeed;
	private float Eposy;
	// Use this for initialization
	void Start () {
		interval = 0;
		frame = 0;
		Espeed = 0.3f;
		Eposy = 0.5f;
	}

	// Update is called once per frame
	void FixedUpdate () {
		interval-=1;

		if(Input.GetKey("return") && interval <= 0){
			Debug.Log("gene");
			float r=Eposy;
			GameObject enemy = Instantiate(enemyPrefab,new Vector3(transform.position.x,transform.position.y+r,transform.position.z),transform.rotation);
            enemy.GetComponent<Demo2enemy>().speed =Espeed;
			interval = 30;
		}

		//速さの調整
		if(Input.GetKey("q")){
			Espeed = 0.6f;
		}
		if(Input.GetKey("w")){
			Espeed = 0.45f;
		}
		if(Input.GetKey("e")){
			Espeed = 0.3f;
		}

		//高さの調整
		if(Input.GetKey("a")){
			Eposy = 1.3f;
		}
		if(Input.GetKey("s")){
			Eposy = 0.5f;
		}
		if(Input.GetKey("d")){
			Eposy = 0.9f;
		}

	}
}
