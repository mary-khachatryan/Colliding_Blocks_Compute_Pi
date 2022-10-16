using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class computePi : MonoBehaviour
{
    public float digits;
    int collisions = 0;


    public float  m1, m2;   /// 2 is always large than 1 
    public float  v1, v2;
    
    public GameObject largeSqr, smallSqr;
    bool info;
    int test;
    Vector2 startPoint;
    Text collision; 
    
    // Start is called before the first frame update
    void Start()
        
    {

        startPoint = new Vector2(0, -5);
        
        digits = SceneChange.version;
        Debug.Log("vers" + test);
        smallSqr = GameObject.Find("SmallSqr");
        largeSqr = GameObject.Find("LargeSqr");
        largeSqr.transform.localScale = largeSqr.transform.localScale * digits;
        largeSqr.transform.position = startPoint + new Vector2(digits / 2, digits/2 );
        collision = GameObject.Find("Collisions").GetComponent<Text>();
        m1 = 1;
        m2 = Mathf.Pow(100, digits - 1);    //1000;
        v1 = 0;
        v2 = 1;
        
       
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("vers" + test);
        // largeSqr.transform.position += new Vector3(-v2* Time.deltaTime,0,0);
        float posSmallSqr = smallSqr.transform.position.x;
        float posLargeSqr = largeSqr.transform.position.x;


        if (posSmallSqr - smallSqr.transform.localScale.x / 2 <= transform.position.x - transform.localScale.x / 2)
        {


            Debug.Log(v1);
            v1 = -v1;
            collisions++;
            
        }
        

        if (posSmallSqr + smallSqr.transform.localScale.x / 2 >= posLargeSqr - largeSqr.transform.localScale.x / 2)
        {


            float oldv1 = v1;
            v1 = (v1 - v1 * m2 + 2 * v2 * m2) / (m2 + m1);
            v2 = (2 *oldv1+ v2*m2 - v2 )/ (m2 + m1);
           // Debug.Log("v2" + v2);
           
           // Debug.Log("v1" + v1);
            collisions++;

        }
        smallSqr.transform.position += new Vector3( -v1 * Time.deltaTime, 0, 0);
        largeSqr.transform.position += new Vector3( -v2 * Time.deltaTime, 0, 0);
        collision.text = "Number of Collision: "  + collisions;
        Debug.Log(collisions);
        



    }



}
