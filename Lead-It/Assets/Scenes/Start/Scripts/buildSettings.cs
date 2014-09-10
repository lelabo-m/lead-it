using UnityEngine;
using System.Collections;

public class buildSettings : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Screen rotation, Windows doesn't care about it so no preprocessing needed =)
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.orientation = ScreenOrientation.AutoRotation;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToPortrait = false;

        // Cursor image, only for Windows
#if (UNITY_STANDALONE_WIN || UNITY_EDITOR)

#endif
    }
}
