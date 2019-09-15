using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{ 
    public static int Highscore = 0;
    public Text text;
   

    void Update()
        {
            text.text = Highscore.ToString();

        }
    }