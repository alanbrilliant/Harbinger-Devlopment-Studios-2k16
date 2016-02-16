using UnityEngine;
using System.Collections;

public class LaunchWebpage : MonoBehaviour {

	void Start() {
		//Application.OpenURL("http://www.bart.gov/stations/elevators");
	}
	public void openWebpage(){
		Application.OpenURL("http://www.bart.gov/stations/elevators");
	}
	public void openWebpage2(){
		Application.OpenURL("http://www.bart.gov/stations/escalators");
	}
}

