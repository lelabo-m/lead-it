using UnityEngine;
using System.Collections;

public class HideControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Active() {
		renderer.enabled = true;
		}
}
