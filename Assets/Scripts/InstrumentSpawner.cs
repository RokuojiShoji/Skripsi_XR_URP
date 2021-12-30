using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentSpawner : MonoBehaviour
{
    [SerializeField] private GameObject instrument1;
    [SerializeField] private GameObject instrument2;
    [SerializeField] private GameObject instrument3;

    [SerializeField] private GameObject pemukul1;
    [SerializeField] private GameObject pemukul2;
    [SerializeField] private GameObject pemukul3;

    [SerializeField] private Quaternion deg1;
    [SerializeField] private Quaternion deg2;
    [SerializeField] private Quaternion deg3;

    [SerializeField] private Transform spawnPemukul;

    
    public void DestroyInstrument() {
         
         if (GameObject.Find(instrument1.name + "(Clone)")){
            Destroy(GameObject.Find(instrument1.name + "(Clone)"));
            Destroy(GameObject.Find(pemukul1.name + "(Clone)"));
        } else if(GameObject.Find(instrument2.name + "(Clone)")) {
            Destroy(GameObject.Find(instrument2.name + "(Clone)"));
            Destroy(GameObject.Find(pemukul2.name + "(Clone)"));
        } else if(GameObject.Find(instrument3.name + "(Clone)")) {
            Destroy(GameObject.Find(instrument3.name + "(Clone)"));
            Destroy(GameObject.Find(pemukul3.name + "(Clone)"));
        }

    }
    public void playInstrument1() {
        
        if (GameObject.Find(instrument1.name + "(Clone)")== null){
            Instantiate(instrument1, transform.position, deg1);
            Instantiate(pemukul1, spawnPemukul.transform);
        }

    }

    public void playInstrument2() {

        if (GameObject.Find(instrument2.name + "(Clone)")==null){
            Instantiate(instrument2, transform.position, deg2);
            Instantiate(pemukul2, spawnPemukul.transform);
        }

    }

     public void playInstrument3() {
        
        if (GameObject.Find(instrument3.name + "(Clone)")==null){
            Instantiate(instrument3, transform.position, deg3);
            Instantiate(pemukul3, spawnPemukul.transform);
        }

    }
}
   