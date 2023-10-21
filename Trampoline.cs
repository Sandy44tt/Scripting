using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider Other)
	{
		Other.GetComponent<Jump>().jumpStrength = 10;
	}

    // Update is called once per frame
    void OnTriggerExit(Collider Other)
	{
		Other.GetComponent<Jump>().jumpStrength = 2;
	}
}
