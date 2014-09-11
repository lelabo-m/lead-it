using UnityEngine;
using System.Collections;

public class SentenceLabel : MonoBehaviour
{
    public LastScoreCompo scores;

    void Start()
    {
        if (scores.GetDie() == 0)
        {
            this.gameObject.GetComponent<UILabel>().text = "Your country has been sold";
        }
        else
        {
            this.gameObject.GetComponent<UILabel>().text = "You've been killed by your people";
        }
    }
}
