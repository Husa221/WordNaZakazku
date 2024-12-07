using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviewShower : MonoBehaviour
{
    [SerializeField] GameObject[] reviews;


    // Update is called once per frame
    void Start()
    {
        if((NextLeveLPolice.commisionDone - 1) < reviews.Length)
        {
            reviews[NextLeveLPolice.commisionDone - 1].SetActive(true);
        }
        else
        {
            reviews[reviews.Length - 1].SetActive(true);
        }
    }
}
