﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo0enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z-0.5f);
	}
}
