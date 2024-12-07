using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommSend : MonoBehaviour
{
    [SerializeField] GameObject[] commisions;
    void Start()
    {
        if (NextLeveLPolice.commisionDone == 0)
        {
            commisions[0].SetActive(true);
        }
        if (NextLeveLPolice.commisionDone == 1)
        {
            commisions[1].SetActive(true);
        }
        if (NextLeveLPolice.commisionDone == 2)
        {
            commisions[2].SetActive(true);
        }
        if (NextLeveLPolice.commisionDone >= 3)
        {
            commisions[3].SetActive(true);
        }
    }

    
}
