using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public Color playerColor;
    public GameObject BasePrefab;
    public Resources Player1Resources;
    public Text resourceText;
    public List<HexTile> PlayerHex;
    // Use this for initialization
    void Start () {
        Owners.player1 = gameObject;
        BaseInit();
        ResourceInit();
        ResourcePrint();
    }
	
	// Update is called once per frame
	void Update () {

    }
    void ResourcePrint()
    {
        resourceText.text = "Wood - " + Player1Resources.wood +
    "  gold - " + Player1Resources.gold + "  food - " +
    Player1Resources.food + "  metal - " + Player1Resources.metal;
    }
    void BaseInit()
    {
        transform.position = MapBuilder.homeBase.transform.position;
        var baseInstance = Instantiate(BasePrefab);
        baseInstance.transform.parent = gameObject.transform;
        baseInstance.transform.position = MapBuilder.homeBase.transform.position;
        baseInstance.GetComponent<Renderer>().material.color = playerColor;
    }
    void ResourceInit ()
    {
        Player1Resources = new Resources()
        {
            wood = 100,
            gold = 100,
            food = 100,
            metal = 100
        };
    }
}
