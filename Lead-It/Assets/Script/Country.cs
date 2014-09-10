using UnityEngine;
using System.Collections;

public class Country : MonoBehaviour
{

    private string	CountryName;
    private int		Budget;
    private float	DayRatio;
    private int		Profit;
    private int		Expense;
    private bool	IsDead;
    private float	NextUpdate;
	private int		Popularity;
    public int 		ExpenseInc;
    public float	UpdateTime;

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

		// DEBUG
//		CountryElem[] list = transform.GetComponentsInChildren<CountryElem> ();
//		foreach (CountryElem elem in list) {
//			Debug.Log(elem.Etype);
//				}
    }

    // Get all the aid / taxes / invest values to calc the result of the week
    void UpdateCountry()
    {
        int profit = this.Profit;
        int expense = this.Expense;
        int budget = this.Budget;

		CountryElem[] list = transform.GetComponentsInChildren<CountryElem> ();
		foreach(CountryElem elem in list)
        {
			if (elem)
			{
            	profit += elem.ProfitBonus;
            	expense += elem.ExpenseMalus;
            	profit += (this.Budget * elem.ProfitPercent / 100);
            	expense += (this.Budget * elem.ExpensePercent / 100);
				this.Popularity += elem.Popularity;
				this.Budget += elem.Budget;
			}
        }

        budget = budget + profit - expense;
        // Check budget > this.Budget -> End of Game
        if (budget > this.Budget || this.Popularity <= 0) {
						this.IsDead = true;
						this.Budget = 1;
				}
        this.DayRatio = ((budget - this.Budget) * 100) / this.Budget;
        this.Budget = budget;
    }

    // Update is called once per frame
    void Update()
    {
		this.NextUpdate += Time.deltaTime;
        if (this.NextUpdate > this.UpdateTime)
        {
            UpdateCountry();
            this.NextUpdate = 0.0f;
        }
    }

	void UpdateSliderVal(string name, int val)
	{
		GameObject child = this.transform.FindChild (name).gameObject;
		CountryElem elem = child.GetComponent<CountryElem> ();
		elem.SliderVal = val;
	}

	int GetSliderVal(string name)
	{
		GameObject child = this.transform.FindChild (name).gameObject;
		CountryElem elem = child.GetComponent<CountryElem> ();
		return elem.SliderVal;
	}

    // Getter / Setter
    string getName()
    {
        return this.CountryName;
    }

    void setName(string name)
    {
        this.CountryName = name;
    }

    float getDayRatio()
    {
        return this.DayRatio;
    }

    void setDayRatio(float val)
    {
        this.DayRatio = val;
    }

    int getBudget()
    {
        return this.Budget;
    }

    void setBudget(int val)
    {
        this.Budget = val;
    }

    int getProfit()
    {
        return this.Profit;
    }

    void setProfit(int val)
    {
        this.Profit = val;
    }

    int getExpense()
    {
        return this.Expense;
    }

    void setExpense(int val)
    {
        this.Expense = val;
    }

    bool IsCountryDead()
    {
        return this.IsDead;
    }
}