using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justaag : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(-360, 360)]
    public float INangle, OUTangle, theangecoll;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OUTangle = 2 * theangecoll - INangle;
    }
}
