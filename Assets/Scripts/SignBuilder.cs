using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignBuilder : MonoBehaviour
{
    
    List<SignObject> signObjects = new List<SignObject>();
    public GameObject signPrefab;
/*
    void Start()
    {
        CreateSigns();
        
    }

    public void CreateSigns(){
        for(int i = 0; i < 5; i++) {
            for(int j = 0; j < 2; j++) {
                for(int k = 0; k < 2; k++) {
                    for(int l = 0; l < 2; l++) {
                        for(int m = 0; m < 2; m++) {
                            for(int n = 0; n < 2; n++) {
                                for(int o = 0; o < 2; o++) {
                                    for(int q = 0; q < 2; q++) {
                                        string id = q.ToString() + "-" + o.ToString() + "-" + n.ToString() + "-" + m.ToString() + "-" + l.ToString() + "-" + k.ToString()+ "-"+ j.ToString() + "-";
                                        switch(i) {
                                            case 0:
                                                id = id+"RED";
                                                break;
                                            case 1:
                                                id = id+"BLUE";
                                                break;
                                            case 2:
                                                id = id+"GREEN";
                                                break;
                                            case 3:
                                                id = id+"YELLOW";
                                                break;
                                            case 4:
                                                id = id+"BLACK";
                                                break;
                                        }
                                        
                                        SignObject newSign = CreateInstance("SignObject");
                                        newSign.SetID(id);
                                        signObjects.Add(newSign);
            }
            }
            }
            }
            }
            } 
            }
        }
        InstantiateSigns();
    }

    public void InstantiateSigns() {
        int i = 0;
        foreach(SignObject sign in signObjects) {
            GameObject newSign = signPrefab;
            newSign.GetComponent<Sign>().CreateSign(sign);
            Instantiate(newSign, new Vector3(0 + i,0,0), Quaternion.identity);
            i = i + 5;
        }
    }*/

}
