using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPagesController : MonoBehaviour
{
    public GameObject goalListPage;
    public GameObject goalCreatorPage;


    public void LoadListPage()
    {
        goalListPage.SetActive(true);
        goalCreatorPage.SetActive(false);
    }

    public void LoadCreatorPage()
    {
        goalListPage.SetActive(false);
        goalCreatorPage.SetActive(true);
    }
}
