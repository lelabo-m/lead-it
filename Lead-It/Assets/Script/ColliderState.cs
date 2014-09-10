using UnityEngine;
using System.Collections;

public class ColliderState : MonoBehaviour {

	// Use this for initialization
	void Start () {
        renderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5f;
        Vector2 vect = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D[] col = Physics2D.OverlapPointAll(vect);
        if (Input.GetMouseButtonDown(0))
        {
            if (col.Length == 1 && col[0].collider2D.gameObject.name == gameObject.name)
            {
                Debug.Log("Collided with : " + gameObject.name);
            }
        }
	}

}
