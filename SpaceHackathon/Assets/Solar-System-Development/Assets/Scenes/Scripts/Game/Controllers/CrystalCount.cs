using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalCount : MonoBehaviour
{
    public int crystalCount=0;
	public Text crystalText;

	private void OnCollisionEnter (Collision col)  
 	{ 
        if (col.gameObject.CompareTag("1")) 
    	{ 
            print("eruyerueruerureurrrg");
            Destroy(gameObject);
			crystalCount++;
			crystalText.text = crystalCount.ToString()+"/8";
        } 
  
 	}
}
