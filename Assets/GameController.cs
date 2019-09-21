using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region MonoBehaviour

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    #endregion
}
