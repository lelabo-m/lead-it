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

	// Use this for initialization
	void Start () {
		this.SliderVal = 0;
		this.ProfitBonus = 0;
		this.ProfitPercent = 0;
		this.ExpenseMalus = 0;
		this.ExpensePercent = 0;
	}
	
	// Update is called once per frame
	void Update () {
	// Update sliderval
	}
}
