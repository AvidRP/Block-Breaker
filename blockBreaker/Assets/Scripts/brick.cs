using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {
	
	public int maximumHits;
	private int currentHits;
	
	// Use this for initialization
	void Start () {
		currentHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		currentHits++;
		if (currentHits == maximumHits) {Destroy(gameObject);}
		
	}
}
