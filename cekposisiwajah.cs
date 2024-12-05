using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class cekposisiwajah : MonoBehaviour
{
    public ARFaceManager manajerWajah;
    public Text teksPosisi;

    private void Start()
    {
        
    }

    void Update()
    {
        if (manajerWajah.trackables.count > 0)
        {
            foreach (var wajah in manajerWajah.trackables)
            {
                Vector3 posisiWajah = wajah.transform.position;
                Vector3 posisiLayar = Camera.main.WorldToScreenPoint(posisiWajah);

                if (posisiLayar.x < Screen.width / 3)
                {
                    teksPosisi.text = "Wajah berada di kiri";
                }
                else if (posisiLayar.x > 2 * Screen.width / 3)
                {
                    teksPosisi.text = "Wajah berada di kanan";
                }
                else
                {
                    teksPosisi.text = "Wajah di tengah";
                }
            }
        }
        else
        {
            teksPosisi.text = "Wajah tidak terdeteksi";
        }
    }
}
