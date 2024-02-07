using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelSpawns : MonoBehaviour
{
    [SerializeField]
    private GameObject[] model;

    [SerializeField]
    private GameObject goal;

    private GameObject temp1, temp2;

    public int level = 1, addOn = 7;
    float i = 0;

    private void Awake()
    {
        if (level > 9)
        {
            addOn = 0;
        }
        for (i = 0; i > -level - addOn; i -= 0.5f)
        {

            if (level <= 20)
            {
                temp1 = Instantiate(model[Random.Range(0, 2)]);
            }

            if (level >20 && level <=50)
            {
                temp1 = Instantiate(model[Random.Range(1, 3)]);
            }

            if (level > 50 && level <= 100)
            {
                temp1 = Instantiate(model[Random.Range(1, 3)]);
            }

            if (level > 100)
            {
                temp1 = Instantiate(model[Random.Range(3, 4)]);
            }

            temp1.transform.position = new Vector3(0, i - 0.01f, 0);
            temp1.transform.eulerAngles = new Vector3(0, i*8, 0);

        }
        temp2 = Instantiate(goal);
        temp2.transform.position = new Vector3(0, i-5f, 0);
    }

   

}
