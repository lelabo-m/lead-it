using UnityEngine;
using System.Collections;

public class Indestructible : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	
	}

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
