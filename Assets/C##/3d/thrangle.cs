using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrangle : MonoBehaviour
{
    public Vector3 inveloc, colldvector, outveloc;

    public Vector3 VV, AA, FF, gG;
    public float MM, RR;

    [Range(-360, 360)]
    public float theangecoll;

    bool temp = true;
    
    
   
    float cha, chb;

    Vector3 rupside;
    void Start()
    {
        RR *= transform.localScale.y;
        
    }


    void Update()
    {
        Vector3 invv = VV.normalized;
        Vector3 colvv = colldvector.normalized;
        ///Vector3 outvv = outveloc.normalized;

        ///outangle 2b-a



        


        float dtt = Time.deltaTime;




        AA = FF / MM + gG;
        VV += AA * dtt;


        if (transform.position.y<0&&temp)
        {
            temp = false;
            float bangle = Vector3.Angle(invv, colvv);
            Debug.Log(bangle);
            if (bangle==90)
            {

                VV = VV * -1;


            }

            else if (bangle<90)
            {
                float lengf = Mathf.Sqrt(2 - 2 * Mathf.Cos((180 - 2 * bangle) * Mathf.PI / 180));
                Vector3 vv2 = new Vector3(colvv.x * lengf, colvv.y * lengf, colvv.z * lengf);
                Vector3 v33 = invv * -1 + vv2;
                VV = v33;

                VV *= 20;
            }

            else if (bangle > 90)
            {
                bangle = Vector3.Angle(invv, colvv*-1);


                float lengf = Mathf.Sqrt(2 - 2 * Mathf.Cos((180 - 2 * bangle) * Mathf.PI / 180));
                Vector3 vv2 = new Vector3(colvv.x * lengf, colvv.y * lengf, colvv.z * lengf);
                Vector3 v33 = invv * -1 + vv2;
                VV = v33;

                VV *= 20;
            }



        }
        transform.position += VV * dtt;





    }
}
