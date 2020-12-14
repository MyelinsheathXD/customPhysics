using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stoscall : MonoBehaviour
{
    public Vector3 VV, AA, FF, gG;
    public float MM, RR;

    [Range(-360, 360)]
    public float theangecoll;


    public GameObject[] Sball;
    bool touch = false;
    bool touchcount = false;
    float disbbch;
    float cha, chb;

    Vector3 rupside;
    void Start()
    {
        RR *= transform.localScale.y;
        Sball = GameObject.FindGameObjectsWithTag("Water");
    }


    void Update()
    {
        Sball = GameObject.FindGameObjectsWithTag("Water");

        float dtt = Time.deltaTime;




        AA = FF / MM + gG;
        VV += AA * dtt;


        for (int i = 0; i < Sball.Length; i++)
        {
            float drrrr = Sball[i].transform.localScale.x;

            float dissbal = (transform.position - Sball[i].transform.position).magnitude - (RR + drrrr * 0.1f);
            disbbch = dissbal;

            if (dissbal < 0)
            {
                touch = true;
                rupside = (transform.position - Sball[i].transform.position).normalized;
                rupside = new Vector3(rupside.y, -rupside.x, 0);
                goto hererr;
            }
            else
            {
                touch = false;
            }

        }

       

        hererr:
        if (touch&&!touchcount)
        {
            touchcount = true;

            Vector3 tVV = VV.normalized;

            float ca = tVV.x;
            float sa = tVV.y;
            

            cha = Vector2.SignedAngle(new Vector2(1, 0), new Vector2(ca, sa));


            float taa = Mathf.Abs(tVV.x);
            float tbb = Mathf.Abs(tVV.y);

            float cb = rupside.x;
            float sb = rupside.y;

            chb = Vector2.SignedAngle(new Vector2(1, 0), new Vector2(cb, sb));
           
            float aa = Mathf.Abs(VV.x);
            float bb = Mathf.Abs(VV.y);

            float OUTangle = 2 * chb - cha;
            float scale = (aa + bb) / (taa + tbb);

            VV.x = Mathf.Cos(OUTangle * Mathf.PI / 180) * scale;
            VV.y = Mathf.Sin(OUTangle * Mathf.PI / 180) * scale;



            VV *= 0.95f;

        }
        if (disbbch> 0)
        {
            touchcount = false;
        }

        transform.position += VV * dtt;

        if (transform.position.y<-100)
        {
            Destroy(gameObject);
        }
    }
}
