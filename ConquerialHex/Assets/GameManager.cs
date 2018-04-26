using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameManager Singleton;
	// Use this for initialization
	void Start () {
        Singleton = this;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
public static class Owners
{
    public static GameObject player1;
    public static GameObject ai1;
}
