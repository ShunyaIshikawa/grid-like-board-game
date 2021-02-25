using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    [SerializeField] GameObject widthInputField;
    [SerializeField] GameObject heightInputField;

    private InputField w_IF;
    private InputField h_IF;

    void Start()
    {
        w_IF = widthInputField.GetComponent<InputField>();
        h_IF = heightInputField.GetComponent<InputField>();
    }

    void Update()
    {
        int num;

        if(int.TryParse(w_IF.text, out num))
            BoardGenerator.SetWidth(num);

        if(int.TryParse(h_IF.text, out num))
            BoardGenerator.SetHeight(num);
    }
}
