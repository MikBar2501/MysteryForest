using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawSign : MonoBehaviour
{
    
    Color color;
    string [] usingColors = {"RED", "GREEN", "BLUE", "YELLOW", "PINK", "WHITE", "ORANGE"};
    public Text colorText;
    public int usingColor;

    public Image [] fragmentsButton = new Image[7];
    public Image [] fragmentsImages = new Image[7];
    public bool [] fragments = new bool[7];

    public void ChangeColor() {
        usingColor = (usingColor + 1) % usingColors.Length;
        switch(usingColor) {
            case 0:
                color = new Color(1f,0,0.056f,1f);
                colorText.color = new Color(1f,0,0.056f,1f);
                break;
            case 1:
                color = new Color(0.266f,1f,0.063f,1f);
                colorText.color = new Color(0.266f,1f,0.063f,1f);
                break;
            case 2:
                color = new Color(0f,0.5439873f,1f,1f);
                colorText.color = new Color(0f,0.5439873f,1f,1f);
                break;
            case 3:
                color = new Color(1f,0.8874891f,0,1f);
                colorText.color = new Color(1f,0.8874891f,0,1f);
                break;
            case 4:
                color = new Color(1f,0,0.449203f,1f);
                colorText.color = new Color(1f,0,0.449203f,1f);
                break;
            case 5:
                color = new Color(1f,1f,1f,1f);
                colorText.color = new Color(1f,1f,1f,1f);
                break;
            case 6:
                color = new Color(1f,0.4184411f,0,1f);
                colorText.color = new Color(1f,0.4184411f,0,1f);
                break;
        }

        for(int i = 0; i < fragmentsImages.Length; i++) {
            if(fragments[i]) {
                fragmentsImages[i].color = color;
            } 
        }
    }

    public void UseFragment(int fragment) {
        if(!fragments[fragment]) {
            fragmentsImages[fragment].color = color;
            fragments[fragment] = true;
            fragmentsButton[fragment].color = new Color(0.854902f,1f,0.5058824f,1f);
        } else {
            fragmentsImages[fragment].color = new Color(0,0,0,0);
            fragments[fragment] = false;
            fragmentsButton[fragment].color = new Color(1f,1f,1f,1f);
        }
    }

    public void CreateSign() {
        string id = "";
        foreach(bool fragment in fragments) {
            if(fragment) {
                id += "1-";
            } else {
                id += "0-";
            }
        }

        id += usingColors[usingColor];

        if(GameManager.gameManager.FoundSign(id) && CheckSign()) {
            GameManager.gameManager.foundSign.Add(id);
        }

        for(int i = 0; i < 7; i++) {
            fragmentsImages[i].color = new Color(0,0,0,0);
            fragments[i] = false;
            fragmentsButton[i].color = new Color(1f,1f,1f,1f);
        }
    }

    void OnEnable() {
        for(int i = 0; i < 7; i++) {
            fragmentsImages[i].color = new Color(0,0,0,0);
            fragments[i] = false;
            fragmentsButton[i].color = new Color(1f,1f,1f,1f);
        }
        usingColor = -1;
        ChangeColor();
    }

    bool CheckSign() {
        int check = 0;
        foreach(bool fragment in fragments) {
            if(fragment) {
                check++;
            }
        }

        if(check == 0) {
            return false;
        } else {
            return true;
        }
    }

    
}
