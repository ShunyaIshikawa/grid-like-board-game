using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceManager : MonoBehaviour
{
    [SerializeField] GameObject diceUI;

    void Start()
    {
        diceUI.GetComponent<Text>().text = "0";

        // set a seed value for random numbers
        Random.InitState(System.DateTime.Now.Millisecond);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            diceUI.GetComponent<Text>().text = Random.Range(1, 7).ToString();
        }
    }
}
