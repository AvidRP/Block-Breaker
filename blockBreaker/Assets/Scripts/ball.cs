using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	public paddle paddle;
	
	private Vector3 paddleToBallVector;
	
	private bool gameStarted = false;
	
	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!gameStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			if(Input.GetMouseButtonDown(0)) {
				print ("Mouse Clicked");
				gameStarted = true;
				this.rigidbody2D.velocity = new Vector2 (10f, 5f);
			}
		
		}
	}
}
