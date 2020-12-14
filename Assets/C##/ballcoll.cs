using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcoll : MonoBehaviour
{
    public Vector3 VV, AA, FF, gG;
    public float MM, RR, alpha1;

    [Range(-360, 360)]
    public float theangecoll, THEAMGNI;
    bool touch = false;
    float cha, chb;
    void Start()
    {
        RR *= transform.localScale.y;
    }


    void Update()
    {

        float dtt = Time.deltaTime;




        AA = FF / MM + gG;
        VV += AA * dtt;


        if (transform.position.y - RR < 0 && !touch)
        {
            touch = true;

            Vector3 tVV = VV.normalized;

            float ca = tVV.x;
            float sa = tVV.y;
            /*ca *= -1;
            sa *= -1;*/

            cha = Vector2.SignedAngle(new Vector2(1, 0), new Vector2(ca, sa));


            float taa = Mathf.Abs(tVV.x);
            float tbb = Mathf.Abs(tVV.y);

            float cb = Mathf.Cos(theangecoll * Mathf.PI / 180);
            float sb = Mathf.Sin(theangecoll * Mathf.PI / 180);

            chb = Vector2.SignedAngle(new Vector2(1, 0), new Vector2(cb, sb));
/*
            float L1 = Mathf.Sqrt((ca - cb) * (ca - cb) + (sa - sb) * (sa - sb));
            float L2 = Mathf.Sqrt((ca + cb) * (ca + cb) + (sa + sb) * (sa + sb));

           

            float T = cb * cb + sb * sb;
            float Q = 2 * sb * cb;

            tVV.x = T * ca + Q * sa;
            tVV.y = Q * ca - T * sa;z*/



            float aa = Mathf.Abs(VV.x);
            float bb = Mathf.Abs(VV.y);

            float OUTangle = 2 * chb - cha;
            float scale = (aa + bb) / (taa + tbb);

            VV.x = Mathf.Cos(OUTangle*Mathf.PI/180)*scale ;
            VV.y = Mathf.Sin(OUTangle * Mathf.PI / 180)*scale;


            
            VV *= 0.95f;

        }
        if (transform.position.y - RR > 0)
        {
            touch = false;
        }

        transform.position += VV * dtt;


    }
}
