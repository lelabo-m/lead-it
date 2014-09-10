using UnityEngine;
using System.Collections;

public class ColliderState : MonoBehaviour
{
    void Update()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5f;
        Vector2 vect = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D[] col = Physics2D.OverlapPointAll(vect);
        if (Input.GetMouseButtonDown(0) && col.Length > 0)
        {
            GameObject selected = col[0].collider2D.gameObject;

            var color = selected.GetComponent<TweenColor>();

            if (color)
                color.Toggle();

            Debug.Log("Collided with : " + col[0].collider2D.gameObject.name);
        }
    }

}
