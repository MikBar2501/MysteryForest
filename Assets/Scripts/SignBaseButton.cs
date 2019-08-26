using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SignBaseButton : Sign
{
    bool use;
    
    void Start() {
         GetComponent<Button>().onClick.AddListener(delegate {Click();});
         foreach(string identificator in GameManager.gameManager.foundSign) {
             if(identificator == id) {
                 use = true;
                 ColorButton();
             }
         }
    }

    void Click() {
        use = !use;

        if(use) {
            GameManager.gameManager.foundSign.Add(id);
            ColorButton();
        } else {
            GameManager.gameManager.foundSign.Remove(id);
            ColorButton();
        }
    }

    void ColorButton() {
        if(use) {
            GetComponent<Image>().color = new Color(0.3f,0,0.5f,1f);
        } else {
            GetComponent<Image>().color = new Color(0.854902f,1f,0.5058824f,1f);
        }
    }
    
}
