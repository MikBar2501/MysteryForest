using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sign", menuName = "MysteryForest/Sign", order = 0)]
public class SignObject : ScriptableObject {
    
    public string id;  

    public void SetID(string newId) {
        id = newId;
    }

    public SignObject(string newId) {
        id = newId;
    }

}
