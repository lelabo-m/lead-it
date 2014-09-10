using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof (AudioSource))]

public class backgroundvideo : MonoBehaviour {
	#if (UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_WINRT)
		public MovieTexture movie;
		public GameObject font;
	#endif
	public GameObject slider;

	// Use this for initialization
	void Start() {
		#if (UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_WINRT)
		try
		{
            renderer.material.mainTexture = movie;
            audio.clip = movie.audioClip;
            movie.loop = true;
			font.renderer.enabled = false;
            movie.Play();
			audio.Play();
		}
		catch (Exception)
		{
            font.renderer.enabled = true;
		}
		#else
		Handheld.PlayFullScreenMovie("gen-lead.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		#endif
	}
	
	// Update is called once per frame
	void Update() {
		UISlider plop = slider.GetComponent<UISlider> ();
		audio.volume = plop.value;
	}
}