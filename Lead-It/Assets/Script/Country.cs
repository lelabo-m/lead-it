﻿using UnityEngine;
using System.Collections;
using System;

public class Country : MonoBehaviour
{
	public GameObject	RatioLab;
	public GameObject	PopLab;
	public GameObject	BudgetLab;
	public GameObject	DayLab;
	public GameObject	LeadButton;

	// VISIBLE
    private string		CountryName;
    private decimal		Budget;
    private float		DayRatio;
	private decimal		Popularity;
	private decimal		DayPast;
	// INVISIBLE
    private bool		IsDead;
    private float		NextUpdate;
	private decimal		Profit;
	private decimal		Expense;
	// PUBLIC
    public decimal 		ExpenseInc;
    public float		UpdateTime;

    // Use this for initialization
    void Start()
    {
        this.CountryName = "";

        this.Budget = 0;
        this.DayRatio = 0.0f;
        this.Profit = 0;
        this.Expense = 0;
        this.IsDead = false;
		this.NextUpdate = 0.0f;
		this.Popularity = 0;
		this.DayPast = 0;
    }

    // Get all the aid / taxes / invest values to calc the result of the week
    void UpdateCountry()
    {
        decimal profit = this.Profit;
        decimal expense = this.Expense;
        decimal budget = this.Budget;

		CountryElem[] list = transform.GetComponentsInChildren<CountryElem> ();
		foreach(CountryElem elem in list)
        {
			if (elem)
			{
            	profit += elem.ProfitBonus * (elem.SliderVal / 10);
            	expense += elem.ExpenseMalus * (elem.SliderVal / 10);
            	profit += (this.Budget * (elem.ProfitPercent * (elem.SliderVal / 10)) / 100);
            	expense += (this.Budget * (elem.ExpensePercent * (elem.SliderVal / 10)) / 100);
				this.Popularity += (elem.Popularity * (elem.SliderVal / 10));
				this.Budget += (elem.Budget * (elem.SliderVal / 10));
			}
        }

		Debug.Log ("Expense .: " + expense + " Profit :" + profit);
        
		// Fix popularity level
		if (this.Popularity > 100) this.Popularity = 100;

		budget = budget + profit - expense;
        // Check budget > this.Budget -> End of Game
        if (budget > this.Budget || this.Popularity <= 0) {
						this.IsDead = true;
						this.Budget = 1;

				}

		// Taux de croissance
        //this.DayRatio = ((budget - this.Budget) * 100) / this.Budget;
		decimal tmp = (profit - expense) * 100;
		this.DayRatio = (float)Math.Round(Convert.ToDouble(tmp / expense), 2);

        this.Budget = budget;
		this.Expense += this.ExpenseInc;
    }

    // Update is called once per frame
    void Update()
    {
		if (LeadButton == null)
			this.NextUpdate += Time.deltaTime;
        if (this.NextUpdate > this.UpdateTime)
        {
			this.DayPast += 7;
            UpdateCountry();
			this.NextUpdate = 0.0f;
			DayLab.GetComponent<UILabel>().text = "Day: " + this.DayPast.ToString();
			DayLab.GetComponent<UILabel>().UpdateNGUIText();
			PopLab.GetComponent<UILabel>().text = this.Popularity.ToString() + "%";
			PopLab.GetComponent<UILabel>().UpdateNGUIText();
			RatioLab.GetComponent<UILabel>().text = this.DayRatio.ToString() + "%";
			RatioLab.GetComponent<UILabel>().UpdateNGUIText();
			BudgetLab.GetComponent<UILabel>().text = this.Budget.ToString() + "$";
			BudgetLab.GetComponent<UILabel>().UpdateNGUIText();
		}
    }

	public void UpdateSliderVal(string name, decimal val)
	{
		GameObject child = this.transform.FindChild (name).gameObject;
		CountryElem elem = child.GetComponent<CountryElem> ();
		elem.SliderVal = val;
	}

	public decimal GetSliderVal(string name)
	{
		GameObject child = this.transform.FindChild (name).gameObject;
		CountryElem elem = child.GetComponent<CountryElem> ();
		return elem.SliderVal;
	}

    // Getter / Setter
	public string getName()
    {
        return this.CountryName;
    }

	public void setName(string name)
    {
        this.CountryName = name;
    }

	public float getDayRatio()
    {
        return this.DayRatio;
    }

	public void setDayRatio(float val)
    {
        this.DayRatio = val;
    }

	public decimal getBudget()
	{
		return this.Budget;
	}
	
	public void setBudget(decimal val)
	{
		this.Budget = val;
	}

	public decimal getPopularity()
	{
		return this.Popularity;
	}
	
	public void setPopularity(decimal val)
	{
		this.Popularity = val;
	}

	public decimal getProfit()
    {
        return this.Profit;
    }

	public void setProfit(decimal val)
    {
        this.Profit = val;
    }

	public decimal getExpense()
    {
        return this.Expense;
    }

	public void setExpense(decimal val)
    {
        this.Expense = val;
    }

	public bool IsCountryDead()
    {
        return this.IsDead;
    }
}