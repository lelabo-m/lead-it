using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class backgroundvideo : MonoBehaviour {
	#if UNITY_EDITOR
		public MovieTexture movie;
	#endif

	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR
			renderer.material.mainTexture = movie as MovieTexture;
			audio.clip = movie.audioClip;
			movie.loop = true;
			movie.Play ();
			audio.Play ();
		#else
			Handheld.PlayFullScreenMovie ("StreamingAssests/gen-lead.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		#endif
	}
	
	// Update is called once per frame
	void Update () {
	}
}
