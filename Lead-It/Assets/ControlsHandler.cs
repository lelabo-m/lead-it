using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ControlsHandler : MonoBehaviour
{
    public GameObject PopupListAid;
    public GameObject AidSlider;

    public GameObject PopupListTaxes;
    public GameObject TaxesSlider;

    public Country CountryScript;

    public Dictionary<string, float> TaxesValues;
    public Dictionary<string, float> AidValues;

    void Start()
    {
        TaxesValues = new Dictionary<string, float>();
        AidValues = new Dictionary<string, float>();

        List<string> list = PopupListAid.GetComponent<UIPopupList>().items;

        foreach (string str in list)
        {
            AidValues.Add(str, 0.0f);
        }
        PopupListAidChanged();

        list = PopupListTaxes.GetComponent<UIPopupList>().items;

        foreach (string str in list)
        {
            TaxesValues.Add(str, 0.0f);
        }
        PopupListTaxesChanged();
    }

    public void SetAllValues(Dictionary<string, uint> taxesValues
                            , Dictionary<string, uint> aidValues)
    {
        //TaxesValues = taxesValues;
        //AidValues = aidValues;
    }

    public void PopupListAidChanged()
    {
        string val = PopupListAid.GetComponent<UIPopupList>().value;

        if (AidValues != null && AidValues.ContainsKey(val) == true)
        {
            if (AidSlider.GetComponent<UISlider>() != null)
                AidSlider.GetComponent<UISlider>().value = AidValues[val];
        }
    }

    public void SliderAidChanged()
    {
        string val = PopupListAid.GetComponent<UIPopupList>().value;

        AidValues[val] = AidSlider.GetComponent<UISlider>().value;

        CountryScript.UpdateSliderVal("A-" + val, Convert.ToInt32(AidValues[val] * 100));
    }

    public void PopupListTaxesChanged()
    {
        string val = PopupListTaxes.GetComponent<UIPopupList>().value;

        if (TaxesValues != null && TaxesValues.ContainsKey(val) == true)
        {
            if (TaxesSlider.GetComponent<UISlider>() != null)
                TaxesSlider.GetComponent<UISlider>().value = TaxesValues[val];
        }
    }

    public void SliderTaxesChanged()
    {
        string val = PopupListTaxes.GetComponent<UIPopupList>().value;

        TaxesValues[val] = TaxesSlider.GetComponent<UISlider>().value;

        CountryScript.UpdateSliderVal("T-" + val, Convert.ToInt32(TaxesValues[val] * 100));
    }
}
