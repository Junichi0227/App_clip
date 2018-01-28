using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerPosition : MonoBehaviour {

    public GameObject LHam,RHam,LHand,RHand;
	
	// Update is called once per frame
	void Update () {
        LHand.transform.position = LHam.transform.position;
        RHand.transform.position = RHam.transform.position;
	}
}
