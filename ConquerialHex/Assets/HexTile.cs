using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTile : MonoBehaviour {
    public int X;
    public int Y;
    public Owners owner;
	// Use this for initialization
	void Start () {
        owner = 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Init(int x, int y)

    {
        X = x;
        Y = y;
    }
}
