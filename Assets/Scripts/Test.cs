using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public float rotateSpeed = 40f;
	Color color = new Color();

	public float timer = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (timer >= 2)
		{
			color = new Color(Random.value, Random.value, Random.value, 1f);
			gameObject.GetComponent<Renderer>().material.color = color;
			timer = 0;
		}
		

		transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
	}
}
