using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombineButtonScript : Sign
{
    public GameObject combine;


    private void Start() {
        combine = GameObject.FindWithTag("Combination");
        GetComponent<Button>().onClick.AddListener(delegate {combine.GetComponent<Combine>().SetSlot(id);});
    }
    
}
