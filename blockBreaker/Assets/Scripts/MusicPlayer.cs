using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	// Use this for initialization
	
	void Awake () {
		Debug.Log ("Music Player Awake " + GetInstanceID());
	}
	void Start () {
		Debug.Log ("Music Player Start " + GetInstanceID());
		
		if(instance != null) {
			Destroy(gameObject);
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
