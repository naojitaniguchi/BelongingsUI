using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelongingsButton : MonoBehaviour {
    public GameObject belongingsDialogObject;
    public GameObject toolManagerObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showBelongingsDialog()
    {
        toolManagerObject.GetComponent<ToolManager>().setCountToTools();
        belongingsDialogObject.SetActive(true);
    }
}
