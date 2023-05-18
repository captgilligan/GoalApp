using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalItem : MonoBehaviour
{
    public TextMeshProUGUI titleText;

    public string goalID;

    [SerializeField]
    private GoalEditor goalEditor;

    public void GoalSelected()
    {
        if(App.instance != null)
        {
            goalEditor.LoadGoal(goalID);
        }
    }
}
