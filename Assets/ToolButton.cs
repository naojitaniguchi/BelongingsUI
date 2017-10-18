using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolButton : MonoBehaviour {
    public string toolName;
    public GameObject belongingsDialogObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toolButtonPushed()
    {
        belongingsDialogObject.SetActive(false);
    }

}
