using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rdspaw : MonoBehaviour
{

    public GameObject sppa, stat;


    GameObject chh;
    private void Start()
    {

        chh = new GameObject();

        chh.transform.SetParent(Camera.main.transform);
        chh.transform.localPosition = new Vector3(0, -8, 30);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 aaad = chh.transform.position + new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), Random.Range(-10, 10));

        if (Input.GetKey(KeyCode.Space))
        {
           // Vector3 aaad=chh.transform.position+ new Vector3( Random.Range(-10, 10),0,  Random.Range(-10, 10));
            GameObject kkk= Instantiate(sppa, aaad+new Vector3(0,5,0), Quaternion.identity);

            kkk.transform.localScale *= Random.Range(1f, 4f);
        }
        //Instantiate(sppa, new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y+10, 0), Quaternion.identity);

        if (Input.GetKey(KeyCode.T))
        {


            Vector3 lll = chh.transform.position + new Vector3(Random.Range(-15, 15), Random.Range(-10, 10), Random.Range(-15, 15));
            GameObject aaa = Instantiate(stat, lll, Quaternion.identity);

            aaa.transform.localScale *= Random.Range(2f, 5f);
        }
    }
}
