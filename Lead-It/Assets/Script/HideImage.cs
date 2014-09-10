using UnityEngine;
using System.Collections;

public class HideImage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR
		renderer.enabled = false;
		#endif
	}
	
	// Update is called once per frame
	void Update () {
	}
}
