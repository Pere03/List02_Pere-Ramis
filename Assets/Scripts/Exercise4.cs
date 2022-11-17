using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise4 : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject ResultMenu;
    public GameObject Success_image;
    public GameObject Failed_image;

    private int currentQuestion;
    private int RoundSuccess; 
    public int Choser;
    public int Round;

    public TextMeshProUGUI successTxt; 
    public TextMeshProUGUI failedTxt;
    public TextMeshProUGUI RoundTxt;

    void Start()
    {
        ResultMenu.SetActive(false);
        Success_image.SetActive(false);
        Failed_image.SetActive(false);
    }

    public void Choose_Option(int R)
    {
        Round++;
        RoundTxt.text = Round.ToString();

        //This means that if the random value and the button value match, a value will be added to the correct answers
        if (R == Choser) 
        {
            RoundSuccess++;
        }

        //If the total value of the "round" is less than 10, the elections will continue to be made
        if (currentQuestion < 10)
        {
            currentQuestion++;
            ChoserRandom();
        }

        //If the total value of the "round" is greater than 10, the questions will disappear and the results will be displayed
        if (currentQuestion >= 10) 
        {
            ResultMenu.SetActive(true);
            OptionsMenu.SetActive(false);

            successTxt.text = RoundSuccess.ToString();
            failedTxt.text = (10 - RoundSuccess).ToString();

            if (RoundSuccess >= 5)
            {
                Success_image.SetActive(true);
            } else if (RoundSuccess < 5)
            {

                Failed_image.SetActive(true);
            }
        }

    }

    public void ChoserRandom()
    {
        Choser = Random.Range(0, 1);
    }
}
