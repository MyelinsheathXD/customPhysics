using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheball : MonoBehaviour
{  
    public Vector3 inveloc, colldvector, outveloc;
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
        Vector3 invv = VV.normalized;
        Vector3 colvv = colldvector.normalized;

        Sball = GameObject.FindGameObjectsWithTag("Water");

        float dtt = Time.deltaTime;




        AA = FF / MM + gG;
        VV += (gG) * dtt;


        for (int i = 0; i < Sball.Length; i++)
        {
            float drrrr = Sball[i].transform.localScale.x;

            float dissbal = (transform.position - Sball[i].transform.position).magnitude - (RR + drrrr * 0.5f);
            disbbch = dissbal;

            if (dissbal < 0)
            {
                touch = true;
                rupside = (transform.position - Sball[i].transform.position).normalized;
                //rupside = new Vector3(rupside.y, -rupside.x, rupside.z);

                colvv = (VV.normalized-rupside).normalized*-1;

                ///
                goto hererr;
            }
            else
            {
                touch = false;
            }

        }



    hererr:
        if (touch && !touchcount)
        {
            touchcount = true;
            //float scaleVV = Mathf.Sqrt( VV.magnitude);
            Vector3 normaa = VV.normalized;
            //Debug.Log(VV.magnitude + "maggnitude");
            float scaleVV = VV.magnitude / normaa.magnitude;
            //Debug.Log(scaleVV+"scalee");
            float bangle = Vector3.Angle(invv, colvv);
            ///Debug.Log(bangle);
            if (bangle == 90)
            {

                VV = VV.normalized * -1;


            }

            if (bangle < 90)
            {
                float lengf = Mathf.Sqrt(2 - 2 * Mathf.Cos((180 - 2 * bangle) * Mathf.PI / 180));
                Vector3 vv2 = new Vector3(colvv.x * lengf, colvv.y * lengf, colvv.z * lengf);
                Vector3 v33 = invv * -1 + vv2;
                VV = v33;

                //VV *= scaleVV;
            }

            if (bangle > 90)
            {
                bangle = Vector3.Angle(invv, colvv * -1);


                float lengf = Mathf.Sqrt(2 - 2 * Mathf.Cos((180 - 2 * bangle) * Mathf.PI / 180));
                Vector3 vv2 = new Vector3(colvv.x * lengf, colvv.y * lengf, colvv.z * lengf);
                Vector3 v33 = invv * -1 + vv2;
                VV = v33;

               // VV *= scaleVV;
            }
            //Debug.Log("beee" +VV.magnitude);
            VV=VV.normalized;
            VV *= scaleVV;
            //Debug.Log("affff" + VV.magnitude);
            //VV *= 0.7f;

        }
        if (disbbch > 0)
        {
            touchcount = false;
        }

        transform.position += VV * dtt;

        if (transform.position.y < -100)
        {
            Destroy(gameObject);
        }
    }
}
