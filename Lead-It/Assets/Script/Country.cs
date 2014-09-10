using UnityEngine;
using System.Collections;

public class Country : MonoBehaviour
{

    private string	CountryName;
    private uint	Budget;
    private float	DayRatio;
    private uint	Profit;
    private uint	Expense;
    private bool	IsDead;
    private float	NextUpdate;
	private int		Popularity;
    public uint 	ExpenseInc;
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
    }

    // Get all the aid / taxes / invest values to calc the result of the week
    void UpdateCountry()
    {
        uint profit = this.Profit;
        uint expense = this.Expense;
        uint budget = this.Budget;

		GameObject[]	list = GameObject.FindGameObjectsWithTag("CElem");
		foreach(GameObject CElem in list)
        {
			CountryElem elem = CElem.GetComponent<CountryElem>();
			if (elem)
			{
            	profit += elem.ProfitBonus;
            	expense += elem.ExpenseMalus;
            	profit += (this.Budget * elem.ProfitPercent / 100);
            	expense += (this.Budget * elem.ExpensePercent / 100);
				this.Popularity += elem.Popularity;
			}
        }

        budget = budget + profit - expense;
        // Check budget > this.Budget -> End of Game
        if (budget > this.Budget || this.Popularity <= 0) this.IsDead = true;

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

    uint getBudget()
    {
        return this.Budget;
    }

    void setBudget(uint val)
    {
        this.Budget = val;
    }

    uint getProfit()
    {
        return this.Profit;
    }

    void setProfit(uint val)
    {
        this.Profit = val;
    }

    uint getExpense()
    {
        return this.Expense;
    }

    void setExpense(uint val)
    {
        this.Expense = val;
    }

    bool IsCountryDead()
    {
        return this.IsDead;
    }
}