using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomposition : MonoBehaviour
{
    public GameObject meme1;
    public GameObject meme2;
    public GameObject meme3;
    public GameObject meme4;
    public GameObject meme5;
    public GameObject meme6;
    public GameObject meme7;
    public GameObject meme8;
    public GameObject meme9;
    public GameObject meme10;
    
    // Use this for initialization
    void Start()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(1, 476);
        y = 5;
        z = Random.Range(3, 500);
        pos = new Vector3(x, y, z);
        meme1.transform.position = pos;

      
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    
}
