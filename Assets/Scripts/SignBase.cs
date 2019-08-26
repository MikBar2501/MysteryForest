using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignBase : ListElement
{
    public string [] usingColors = {"RED", "GREEN", "BLUE", "YELLOW", "PINK", "WHITE", "ORANGE"};
    public Text colorText;
    int usingColor;




    void OnEnable() {
        //LoadElements(GameManager.gameManager.baseSign);
        usingColor = 0;
        colorText.text = "Czerwony";
        colorText.color = new Color(1f,0,0.056f,1f);
        LoadElements(GameManager.gameManager.colorsList.ChooseColor(usingColors[usingColor]));
    }

    public void ChangeColor() {
        foreach (Transform child in grid.transform) {
            Destroy(child.gameObject);
        }
        usingColor = (usingColor + 1) % usingColors.Length;
        LoadElements(GameManager.gameManager.colorsList.ChooseColor(usingColors[usingColor]));
        switch(usingColor) {
            case 0:
                colorText.text = "Czerwony";
                colorText.color = new Color(1f,0,0.056f,1f);
                break;
            case 1:
                colorText.text = "Zielony";
                colorText.color = new Color(0.266f,1f,0.063f,1f);
                break;
            case 2:
                colorText.text = "Niebieski";
                colorText.color = new Color(0f,0.5439873f,1f,1f);
                break;
            case 3:
                colorText.text = "Żółty";
                colorText.color = new Color(1f,0.8874891f,0,1f);
                break;
            case 4:
                colorText.text = "Różowy";
                colorText.color = new Color(1f,0,0.449203f,1f);
                break;
            case 5:
                colorText.text = "Biały";
                colorText.color = new Color(1f,1f,1f,1f);
                break;
            case 6:
                colorText.text = "Pomarańczowy";
                colorText.color = new Color(1f,0.4184411f,0,1f);
                break;
        }

    }



    
}
