using UnityEngine;
using System.Collections;

public class ColliderState : MonoBehaviour {

    Renderer renderer;
    ///GameObject scriptTweenColor;

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
            //gameObject.animation.Play("")
            if (col.Length > 0)
                foreach(Collider2D c in col)
                {
                    Debug.Log("Collided with " + c.collider2D.gameObject.name);
                    TweenColor.Begin(c.collider2D.gameObject, 0.5f, Color.grey);
                }
        }
	}

}
