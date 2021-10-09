using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC {
    string FirstName;
    string LastName;
    string HomePlanet;
    string Bio;
    string Title;

	public string getTitle() {
		return this.Title;
	}

	public void setTitle(string Title) {
		this.Title = Title;
	}

	public string getFirstName() {
		return this.FirstName;
	}

	public void setFirstName(string FirstName) {
		this.FirstName = FirstName;
	}

	public string getLastName() {
		return this.LastName;
	}

	public void setLastName(string LastName) {
		this.LastName = LastName;
	}

	public string getHomePlanet() {
		return this.HomePlanet;
	}

	public void setHomePlanet(string HomePlanet) {
		this.HomePlanet = HomePlanet;
	}

	public string getBio() {
		return this.Bio;
	}

	public void setBio(string Bio) {
		this.Bio = Bio;
	}

    public string toString() {
        return FirstName + " " + Title;
    }

}
