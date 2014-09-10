using UnityEngine;
using System.Collections;

public class ColliderState : MonoBehaviour
{
    // Pon = PreviousObjectName
    // Pos = PreviousObjectSelected
    string Pon = "";
    GameObject ConfirmButton;

    void Start()
    {
        ConfirmButton = GameObject.Find("Validate_button");
        if (ConfirmButton)
            NGUITools.SetActive(ConfirmButton, false);
    }

    public void CountrySelected()
    {
        Debug.Log("Country selected : " + Pon);
    }

    void Update()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5f;
        Vector2 vect = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D[] col = Physics2D.OverlapPointAll(vect);
        if (Input.GetMouseButtonDown(0))
        {
            // Désactive la surbrillance du dernier object selectionné
            

            if (col.Length > 0)
            {
                GameObject selected = col[0].collider2D.gameObject;
                GameObject Pos = GameObject.Find(Pon);

                if (Pos)
                    Pos.renderer.enabled = false;

                selected.renderer.enabled = true;
                var color = selected.GetComponent<TweenColor>();

                if (color)
                    color.Toggle();

                if (ConfirmButton)
                    NGUITools.SetActive(ConfirmButton, true);

                Pon = selected.name;
            }
        }
    }

}
