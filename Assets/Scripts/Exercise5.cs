using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise5 : MonoBehaviour
{
    public int Year;
    public int Animal_Year;
    public Sprite[] Animals_Sprite;
    public Image Animal;
    public TMP_InputField Text_field;

    //When you enter a number and press the button, it will calculate which animal matches that year/number and display it through the corresponding animal.
    public void Accept_Button()
    {
        if (Text_field.text != "")
        {
            Year = int.Parse(Text_field.text);
            Animal_Year = Year % 12;
            Animal.sprite = Animals_Sprite[Animal_Year];
        }
    }
}
