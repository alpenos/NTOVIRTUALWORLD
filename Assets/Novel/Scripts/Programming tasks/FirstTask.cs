using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTask : MonoBehaviour
{
    public GameObject[] blocks;
    public GameObject gonext;
    public void Check()
    {
        if(blocks[0].transform.position.y != blocks[1].transform.position.y && blocks[2].transform.position.y < Mathf.Min(blocks[0].transform.position.y, blocks[1].transform.position.y) &&
            blocks[5].transform.position.y < blocks[3].transform.position.y && blocks[6].transform.position.y < blocks[4].transform.position.y)
        {
            gonext.SetActive(true);
        }
        else
        {
            gonext.SetActive(false);
        }
    }
}
