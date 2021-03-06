﻿using UnityEngine;
using System.Collections;

public class ListChecker : MonoBehaviour {
	BuildingLister buildinglister;
	NPCLister npclister;
	// Use this for initialization
	void Start () {
		buildinglister = GameObject.FindGameObjectWithTag("Blister").GetComponent<BuildingLister> ();
		npclister = GameObject.FindGameObjectWithTag ("NPCLister").GetComponent<NPCLister> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("number of buildings: "+buildinglister.BuildingNum ());
		Debug.Log ("number of NPC's: " + npclister.totalListed ());
		if (npclister.totalListed () == 0 && buildinglister.BuildingNum () == 0) {
			Application.LoadLevel ("pls");
		}
	}
}
