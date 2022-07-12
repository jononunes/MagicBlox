using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public Text score;
    public Text result;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score.Equals("10/10"))
        {
            result.text = "RESULTS! CONGRATULATIONS YOU'VE EARNED THE SKILL OF KICKING OUT THE GROUCH AND TURNED ALL THE BLOCKS GREEN!YOU KNOW HOW TO KICK OUT THE GROUCH!";
        }
        else
        {
            result.text = "RESULTS! TRY AGAIN AND TRY TURN ALL THE BLOCKS GREEN!";
        }
    }
}
