using UnityEngine;
using System.Collections;

public class CountryElem : MonoBehaviour {

	public enum ElemType
	{
		Aid,
		Taxe,
		Invest
	}

	public ElemType	Etype;
	public string	Ename;
	public uint		SliderVal;
	public uint		ProfitBonus;
	public uint		ExpenseMalus;
	public uint		ProfitPercent;
	public uint		ExpensePercent;
	public int		Popularity;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	// Update sliderval
	}
}
