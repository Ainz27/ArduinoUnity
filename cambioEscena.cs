using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.SceneManagement;
public class cambioEscena : MonoBehaviour {
	SerialPort puerto = new SerialPort("/dev/cu.usbmodemfa131" , 9600); 
	string valorPuroArduino=" "; 
	int valorConvert=0;
    public static int decision;
	void Start () {
		puerto.Open();
		puerto.ReadTimeout = 1;
	}
	void Update () {
		if (puerto.IsOpen){
			try {
				valorPuroArduino = puerto.ReadLine();
				print(valorPuroArduino);
				if (valorPuroArduino != null) {
					valorConvert = int.Parse (valorPuroArduino.Trim());
					pistola (valorConvert);
				}
			}
			catch (System.Exception){ 
			}
		}
	}
	void pistola(int pistola1){
		if (pistola1 >= 90 && pistola1 <= 110) {
            decision = 1;
		}
		if (pistola1 >= 185 && pistola1 <= 205) {
			decision = 2;
		}
		if (pistola1 >= 125 && pistola1 <= 140) {
			decision = 3;
		}
        if (pistola1 = 9) {
			decision = 4;
		}
	}
}	