using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStopper : MonoBehaviour {

    private MusicManager theMC;

    public int newTrack;

    public bool switchOnStart;

	// Use this for initialization
	void Start () {
        theMC = FindObjectOfType<MusicManager>();

        if (switchOnStart)
        {
            theMC.SwitchTrack(newTrack);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
