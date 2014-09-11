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
	public decimal		SliderVal;
	public decimal		Popularity;
	public decimal		ProfitBonus;
	public decimal		ExpenseMalus;
	public decimal		ProfitPercent;
	public decimal		ExpensePercent;
	public decimal		Budget;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	// Update sliderval
	}
	
}
