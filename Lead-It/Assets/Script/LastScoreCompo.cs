using UnityEngine;
using System.Collections;

public class LastScoreCompo : MonoBehaviour {

	private decimal	DayScore;
	private string	Country;
	private int		WhichDie;

	// Use this for initialization
	void Start () {
		DayScore = 0;
		Country = "";
		WhichDie = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
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
