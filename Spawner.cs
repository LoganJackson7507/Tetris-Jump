using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Spawner : MonoBehaviour
{
    public GameObject[] groups;
    

    public void ChangePos()
    {
        float num = Random.Range((float)-11.73, (float)11.2);
        transform.position = new Vector3(num, (float)5.37);


    }

    public void SpawnNext()
    {
        int i = Random.Range(0, groups.Length);

        Instantiate(groups[i],
                transform.position,
                (UnityEngine.Quaternion.identity));

    }

    void Start()
    {
        InvokeRepeating("SpawnNext", 0.0f, 1.0f);
        InvokeRepeating("ChangePos", 0.0f, 1.0f);

    }
}
    