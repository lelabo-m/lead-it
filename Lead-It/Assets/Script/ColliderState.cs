using UnityEngine;
using System.Collections;

public class ColliderState : MonoBehaviour
{
    // Pon = PreviousObjectName
    // Pos = PreviousObjectSelected
    string Pon = "";
    GameObject pos;

    void Update()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5f;
        Vector2 vect = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D[] col = Physics2D.OverlapPointAll(vect);
        if (Input.GetMouseButtonDown(0))
        {
            // Désactive la surbrillance du dernier object selectionné
            GameObject Pos = GameObject.Find(Pon);
            if (Pos)
            {
                Pos.renderer.enabled = false;
            }

            if (col.Length > 0)
            {
                GameObject selected = col[0].collider2D.gameObject;

                selected.renderer.enabled = true;
                var color = selected.GetComponent<TweenColor>();

<<<<<<< HEAD
            if (color)
                color.Toggle();
=======
                if (color)
                    color.Toggle();

                Pon = selected.name;
            }
>>>>>>> b582adc8a9b32f77d070520872ece532a96483ed
        }
    }

}
