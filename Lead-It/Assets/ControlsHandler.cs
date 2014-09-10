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

        list = PopupListTaxes.GetComponent<UIPopupList>().items;

        foreach (string str in list)
        {
            TaxesValues.Add(str, 0.0f);
        }
    }

    void Update()
    {

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

        if (AidValues[val] != null)
            AidSlider.GetComponent<UISlider>().value = AidValues[val];
    }

    public void SliderAidChanged()
    {
        string val = PopupListAid.GetComponent<UIPopupList>().value;

        AidValues[val] = AidSlider.GetComponent<UISlider>().value;
    }

    public void PopupListTaxesChanged()
    {
        string val = PopupListTaxes.GetComponent<UIPopupList>().value;

        if (TaxesValues[val] != null)
        TaxesSlider.GetComponent<UISlider>().value = TaxesValues[val];
    }

    public void SliderTaxesChanged()
    {
        string val = PopupListTaxes.GetComponent<UIPopupList>().value;

        TaxesValues[val] = TaxesSlider.GetComponent<UISlider>().value;
    }
}
