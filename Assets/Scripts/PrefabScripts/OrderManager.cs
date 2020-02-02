using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    #region ATTEMPT_AT_SINGLETON
    public static OrderManager _ORDER_MANAGER;
    #endregion
    //variabile che tiene traccia del numero della mossa da compiere
    public int order = 1;

    public int lifes = 4;


    private void Awake()
    {
        _ORDER_MANAGER = this;    
    }

    //script chiamata dopo ogni mossa corretta
    public void Procede()
    {
        order++;
        if(order == 8)
        {
            //VICTORY
        }
    }

    public void Error()
    {
        lifes--;
        if(lifes == 0)
        {
            //GAMEOVER
        }
    }
}
