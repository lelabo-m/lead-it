using UnityEngine;
using System.Collections;

public class CountryLabel : MonoBehaviour
{
    public LastScoreCompo scores;

    void Start()
    {
        this.gameObject.GetComponent<UILabel>().text = scores.GetCountry();
    }
}
