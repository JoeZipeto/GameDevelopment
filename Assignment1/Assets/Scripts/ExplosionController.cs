/*******************************************************************************************
*Source file name: ExplosionController
*Author’s name: Joe Zipeto
*Last Modified by: Joe Zipeto
*Date last Modified: October 22, 2016
*Program description: This destroys the explosion animation after it has finish player
*Revision History: 1.0 
**********************************************************************************************/

using UnityEngine;
using System.Collections;

public class ExplosionController : MonoBehaviour {

	void end(){
		// Destroy the explsoion controller when the animation finishes
		Destroy (gameObject);
	}
}
