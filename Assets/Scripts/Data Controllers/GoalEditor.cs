using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Used to update a goal
/// </summary>

public class GoalEditor : MonoBehaviour
{

    public TMP_InputField titleInput;
    public TMP_InputField descriptionInput;
    public TMP_InputField unitInput;
    public TMP_InputField amountInput;

    public Button submitButton;

    public void CreateGoal()
    {
        //if any of the fields are empty
        if(string.IsNullOrEmpty(titleInput.text) || string.IsNullOrEmpty(descriptionInput.text) || string.IsNullOrEmpty(unitInput.text) || string.IsNullOrEmpty(amountInput.text))
        {
            EmptyGoal();
            return;
        }

        //can create new goal
        else
        {
            Debug.Log("create goal!");
        }
    }

    private void EmptyGoal()
    {
        Debug.Log("Missing field entry to create goal");
    }

    public void LoadGoal(string goalID)
    {
        Debug.Log("loading goal");
    }


    public void CheckInput()
    {
        if (string.IsNullOrEmpty(titleInput.text) || string.IsNullOrEmpty(descriptionInput.text) || string.IsNullOrEmpty(unitInput.text) || string.IsNullOrEmpty(amountInput.text))
        {
            submitButton.interactable = false;
            return;
        }

        else
        {
            submitButton.interactable = true;
        }
    }
}
