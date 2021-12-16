using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentSpawner : MonoBehaviour
{
    public GameObject instrument1;
    public GameObject instrument2;
    public GameObject instrument3;

    public GameObject pemukul1;
    public GameObject pemukul2;
    public GameObject pemukul3;

    public Quaternion deg1;
    public Quaternion deg2;
    public Quaternion deg3;

    public void playInstrument1() {
        
        if (GameObject.Find(instrument1.name + "(Clone)")== null){
            Instantiate(instrument1, transform.position, deg1);
        }

        if (GameObject.Find(instrument2.name + "(Clone)") != null){
            Destroy(GameObject.Find(instrument2.name + "(Clone)"));
        } else if(GameObject.Find(instrument3.name + "(Clone)") != null) {
            Destroy(GameObject.Find(instrument3.name + "(Clone)"));
        }
        
    }

    public void playInstrument2() {
        if (GameObject.Find(instrument2.name + "(Clone)")==null){
            Instantiate(instrument2, transform.position, deg2);
        }

        if (GameObject.Find(instrument1.name + "(Clone)")){
            Destroy(GameObject.Find(instrument1.name + "(Clone)"));
        } else if(GameObject.Find(instrument3.name + "(Clone)")) {
            Destroy(GameObject.Find(instrument3.name + "(Clone)"));
        }
    }

     public void playInstrument3() {
        if (GameObject.Find(instrument3.name + "(Clone)")==null){
            Instantiate(instrument3, transform.position, deg3);
        }

        if (GameObject.Find(instrument1.name + "(Clone)")){
            Destroy(GameObject.Find(instrument1.name + "(Clone)"));
        } else if(GameObject.Find(instrument2.name + "(Clone)")) {
            Destroy(GameObject.Find(instrument2.name + "(Clone)"));
        }
    }
}
   