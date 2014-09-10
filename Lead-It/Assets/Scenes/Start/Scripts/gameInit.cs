using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameInit : MonoBehaviour {

    public List<string> country;
    public List<string> continentName;
    public Dictionary<string, string> continent = new Dictionary<string, string>();

	// Use this for initialization
	void Start () {
        // Screen rotation, Windows doesn't care about it so no preprocessing needed =)
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.orientation = ScreenOrientation.AutoRotation;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToPortrait = false;

        //
        //Needed data
        //

        // Country list
        string[] country_ = { "Canada",
                           "USA",
                           "Central America",
                           "South America",
                           "West Europe",
                           "East Europe",
                           "Russia",
                           "Maghreb",
                           "Central Africa",
                           "Middle East",
                           "China",
                           "India",
                           "South-East Asia",
                           "North Korea",
                           "South Korea",
                           "Japan",
                           "Australia"};
        this.country = new List<string>(country_);
        // Continent list
        string[] continentName_ = { "America",
                                  "Europe",
                                  "Africa",
                                  "Asia",
                                  "Oceania"};
        this.continentName = new List<string>(continentName_);
        // Dictionary<Country, Continent>
        this.continent.Add(this.country[0], this.continentName[0]);
        this.continent.Add(this.country[1], this.continentName[0]);
        this.continent.Add(this.country[2], this.continentName[0]);
        this.continent.Add(this.country[3], this.continentName[0]);
        this.continent.Add(this.country[4], this.continentName[1]);
        this.continent.Add(this.country[5], this.continentName[1]);
        this.continent.Add(this.country[6], this.continentName[1]);
        this.continent.Add(this.country[7], this.continentName[2]);
        this.continent.Add(this.country[8], this.continentName[2]);
        this.continent.Add(this.country[9], this.continentName[3]);
        this.continent.Add(this.country[10], this.continentName[3]);
        this.continent.Add(this.country[11], this.continentName[3]);
        this.continent.Add(this.country[12], this.continentName[3]);
        this.continent.Add(this.country[13], this.continentName[3]);
        this.continent.Add(this.country[14], this.continentName[3]);
        this.continent.Add(this.country[15], this.continentName[3]);
        this.continent.Add(this.country[16], this.continentName[4]);
    }
}
