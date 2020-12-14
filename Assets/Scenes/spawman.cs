using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawman : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject sppa,stat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(sppa, new Vector3(Camera.main.transform.position.x+Random.Range(-10,10), Camera.main.transform.position.y + Random.Range(10, 15), 0), Quaternion.identity);
        }
        //Instantiate(sppa, new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y+10, 0), Quaternion.identity);

        if (Input.GetKey(KeyCode.Return))
        {
            GameObject aaa=Instantiate(stat, new Vector3(Camera.main.transform.position.x + Random.Range(-10, 10), Camera.main.transform.position.y + Random.Range(-10, 10), 0), Quaternion.identity);

            aaa.transform.localScale *= Random.Range(4f, 25f);
        }
    }
}
