using UnityEngine;
using System.Collections;

public class Country : MonoBehaviour
{
	public GameObject	RatioLab;
	public GameObject	PopLab;
	public GameObject	BudgetLab;
	public GameObject	DayLab;
	public GameObject	LeadButton;

	// VISIBLE
    private string	CountryName;
    private int		Budget;
    private float	DayRatio;
	private int		Popularity;
	private int		DayPast;
	// INVISIBLE
    private bool	IsDead;
    private float	NextUpdate;
	private int		Profit;
	private int		Expense;
	// PUBLIC
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
		this.DayPast = 0;
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
            	profit += elem.ProfitBonus * elem.SliderVal;
            	expense += elem.ExpenseMalus * elem.SliderVal;
            	profit += (this.Budget * (elem.ProfitPercent * elem.SliderVal) / 100);
            	expense += (this.Budget * (elem.ExpensePercent * elem.SliderVal) / 100);
				this.Popularity += (elem.Popularity * elem.SliderVal);
				this.Budget += (elem.Budget * elem.SliderVal);
			}
        }
		Debug.Log ("Expense .: " + expense + " Profit :" + profit);
        budget = budget + profit - expense;
        // Check budget > this.Budget -> End of Game
        if (budget > this.Budget || this.Popularity <= 0) {
						this.IsDead = true;
						this.Budget = 1;
				}
		// Taux de croissance
        //this.DayRatio = ((budget - this.Budget) * 100) / this.Budget;
		this.DayRatio = ((profit - expense) * 100) / expense;

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

	public void UpdateSliderVal(string name, int val)
	{
		GameObject child = this.transform.FindChild (name).gameObject;
		CountryElem elem = child.GetComponent<CountryElem> ();
		elem.SliderVal = val;
	}

	public int GetSliderVal(string name)
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

	public int getBudget()
	{
		return this.Budget;
	}
	
	public void setBudget(int val)
	{
		this.Budget = val;
	}

	public int getPopularity()
	{
		return this.Popularity;
	}
	
	public void setPopularity(int val)
	{
		this.Popularity = val;
	}

	public int getProfit()
    {
        return this.Profit;
    }

	public void setProfit(int val)
    {
        this.Profit = val;
    }

	public int getExpense()
    {
        return this.Expense;
    }

	public void setExpense(int val)
    {
        this.Expense = val;
    }

	public bool IsCountryDead()
    {
        return this.IsDead;
    }
}