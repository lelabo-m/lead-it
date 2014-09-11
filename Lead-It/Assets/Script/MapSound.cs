using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class MapSound : MonoBehaviour {

    public GameObject slider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        UISlider slide = slider.GetComponent<UISlider>();
        audio.volume = slide.value;
	}
}
