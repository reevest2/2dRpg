using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuController : MonoBehaviour
{
    public TextMeshProUGUI[] menuOptions;
    private int currentOption = 0;
    public Color highlightColor = Color.black;
    public Color normalColor = Color.white;

    void Start()
    {
        SelectOption(currentOption);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveSelection(-1);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveSelection(1);
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            ExecuteOption(currentOption);
        }
    }

    void MoveSelection(int direction)
    {
        DeselectOption(currentOption);
        currentOption += direction;

        if (currentOption < 0)
        {
            currentOption = menuOptions.Length - 1;
        }
        else if (currentOption >= menuOptions.Length)
        {
            currentOption = 0;
        }

        SelectOption(currentOption);
    }

    void SelectOption(int option)
    {
        // Add code to highlight the selected option.
        menuOptions[option].color = highlightColor;
    }

    void DeselectOption(int option)
    {
        // Remove the highlight from the previous option.
        menuOptions[option].color = normalColor;
    }

    void ExecuteOption(int option)
    {
        switch (option)
        {
            case 0:
                // Option 1 (e.g. Fight) logic goes here
                Debug.Log("fite");
                break;
            case 1:
                // Option 2 (e.g. Heal) logic goes here
                Debug.Log("heel");
                break;
            case 2:
                // Option 3 (e.g. Run) logic goes here
                Debug.Log("ran");
                break;
        }
    }
}