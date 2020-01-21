using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character2d : MonoBehaviour {

    [SerializeField]
	float movespeed
    
    void Update()
    {
        GameplaySystem.TMovementDelta(transform, movespeed);
    }

}
