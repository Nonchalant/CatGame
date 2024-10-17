using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public Sprite[] CatSprites;
    static public int nextID;

    void Start()
    {
        Change();
    }

    public void Change()
    {
        nextID = Random.Range(0, CatSprites.Length);
        GetComponent<SpriteRenderer>().sprite = CatSprites[nextID];
    }
}
