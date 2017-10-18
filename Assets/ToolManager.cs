using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolManager : MonoBehaviour {
    public int swordNum;
    public int bombNum;

    public GameObject SwordObject;
    public GameObject SwordCountObject;
    public GameObject BombObject;
    public GameObject BombCountObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setCountToTools()
    {
        if (swordNum == 0)
        {
            SwordObject.SetActive(false);
        }
        else
        {
            SwordObject.SetActive(true);
            SwordCountObject.GetComponent<Text>().text = swordNum.ToString();

        }
        if (bombNum == 0)
        {
            BombObject.SetActive(false);
        }
        else
        {
            BombObject.SetActive(true);
            BombCountObject.GetComponent<Text>().text = bombNum.ToString();
        }
    }
}
