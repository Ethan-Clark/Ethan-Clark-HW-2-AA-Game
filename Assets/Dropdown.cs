
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;



public class DropDownSelect : MonoBehaviour

{

  
    public Dropdown MyDropDown;

    public Text MyChoice;

    public void ShowChoice()

    {

        switch (MyDropDown.value)

        {

            case 1:

                MyChoice.text = "Intro";

                break;

            case 2:

                MyChoice.text = "AA Game";

                break;

          

            

        }

    }

}