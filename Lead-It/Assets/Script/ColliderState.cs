using UnityEngine;
using System.Collections;

public class ColliderState : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5f;
        Vector2 vect = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D[] col = Physics2D.OverlapPointAll(vect);
        if (Input.GetMouseButtonDown(0) && col.Length > 0)
        {
            Debug.Log("Collided with : " + col[0].collider2D.gameObject.name);
        }
	}

}
