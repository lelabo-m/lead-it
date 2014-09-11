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
	public int		SliderVal;
	public int		Popularity;
	public float		ProfitBonus;
	public float		ExpenseMalus;
	public int		ProfitPercent;
	public int		ExpensePercent;
	public int		Budget;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	// Update sliderval
	}
	
}
