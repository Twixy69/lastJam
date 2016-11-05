﻿using UnityEngine;
using System.Collections;

/*@Brief Teleport entered object to target location, need trigger to work*/

public class TeleportTo : DefaultBlock {

    [SerializeField]
    private Vector3 target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void activateOnWalk(GameObject player)
    {
        gameObject.transform.position = target;
        player.GetComponent<Transform>().position = target;
    }
}
