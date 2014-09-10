using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof (AudioSource))]

public class backgroundvideo : MonoBehaviour {
	#if UNITY_EDITOR
		public MovieTexture movie;
		public GameObject font;
	#endif

	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR
		try
		{
			renderer.material.mainTexture = movie as MovieTexture;
			audio.clip = movie.audioClip;
			movie.loop = true;
			font.renderer.enabled = false;
			movie.Play ();
			audio.Play ();
		}
		catch (Exception e)
		{
			font.renderer.enabled = true;
		}
		#else
		Handheld.PlayFullScreenMovie ("gen-lead.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		#endif
	}
	
	// Update is called once per frame
	void Update () {
	}
}
