using UnityEngine;
using System.Collections;

public class Country : MonoBehaviour {

	private string		CountryName;
	private uint		Budget;
	private float		DayRatio;
	private uint		Profit;
	private uint		Expense;

	// Use this for initialization
	void Start () {
		this.CountryName = "";
		this.Budget = 0;
		this.DayRatio = 0.0f;
		this.Profit = 0;
		this.Expense = 0;
	}

	// Get all the aid / taxes / invest values to calc the result of the week
	void UpdateCountry() {
	}

	// Update is called once per frame
	void Update () {
	
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
}