using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public static App instance { get; private set; }

    public UserInfo thisUser;

    private void Awake()
    {
        #region Setup singleton
        if (instance !=null && instance != this)
        {
            Destroy(this);
        }

        else
        {
            instance = this;
        }

        #endregion

        thisUser = GetComponentInChildren<UserInfo>();
    }

    private void Start()
    {
        
    }
}
