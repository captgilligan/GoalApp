using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfo : MonoBehaviour
{
    [SerializeField]
    public string userName;

    public bool rememberMe;

    [SerializeField]
    public List<Goal> userGoals = new List<Goal>();
    [SerializeField]
    public List<Cheat> userCheats = new List<Cheat>();
}
