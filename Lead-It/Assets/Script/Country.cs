using UnityEngine;
using System.Collections;

public class Country : MonoBehaviour {

	private string		CountryName;
	private uint		Budget;
	private float		DayRatio;
	private uint		Profit;
	private uint		Expense;
	private bool		IsDead;
	private float		NextUpdate;
	public uint			ExpenseInc;
	public float		UpdateTime;

	// Use this for initialization
	void Start () {
		this.CountryName = "";
		this.Budget = 0;
		this.DayRatio = 0.0f;
		this.Profit = 0;
		this.Expense = 0;
		this.IsDead = false;
		this.NextUpdate = Time.time + this.UpdateTime;
	}

	// Get all the aid / taxes / invest values to calc the result of the week
	void UpdateCountry() {
		uint profit = this.Profit;
		uint expense = this.Expense;
		uint budget = this.Budget;
 
		foreach (CountryElem elem in FindObjectsOfType(typeof(CountryElem)) as GameObject[])
		{
			profit += elem.ProfitBonus;
			expense += elem.ExpenseMalus;
			profit += (this.Budget * elem.ProfitPercent / 100);
			expense += (this.Budget * elem.ExpensePercent / 100);
		}

		budget = budget + profit - expense;
		// Check budget > this.Budget -> End of Game
		if (budget > this.Budget) this.IsDead = true;

		this.DayRatio = ((budget - this.Budget) * 100) / this.Budget;
		this.Budget = budget;
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > this.NextUpdate) {
			UpdateCountry();
			this.NextUpdate = Time.deltaTime + this.UpdateTime;
			}
	}

	// Getter / Setter
	string getName() {
		return this.CountryName;
	}

	void setName(string name) {
			this.CountryName = name;
	}

	float getDayRatio() {
		return this.DayRatio;
	}

	void setDayRatio(float val) {
		this.DayRatio = val;
	}

	uint setBudget() {
		return this.Budget;
	}
	
	void getBudget(uint val) {
		this.Budget = val;
	}

	uint setProfit() {
		return this.Profit;
	}	

	void getProfit(uint val) {
		this.Profit = val;
	}

	uint setExpense() {
		return this.Expense;
	}
	
	void getExpense(uint val) {
		this.Expense = val;
	}	

	bool IsCountryDead() {
		return this.IsDead;
	}
}