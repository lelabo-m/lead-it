using UnityEngine;
using System.Collections;

public class LastScoreCompo : MonoBehaviour
{
    private decimal DayScore;
    private string Country;
    private int WhichDie;

    // Use this for initialization
    void Awake()
    {
        DayScore = 0;
        Country = "";
        WhichDie = 0;
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Getter/Setter
    public void SetDay(decimal val)
    {
        DayScore = val;
    }

    public decimal GetDay()
    {
        return DayScore;
    }

    public void SetCountry(string val)
    {
        Country = val;
    }

    public string GetCountry()
    {
        return Country;
    }

    public void SetDie(int val)
    {
        WhichDie = val;
    }

    public int GetDie()
    {
        return WhichDie;
    }
}
