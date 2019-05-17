#include <AcceleroMMA7361.h>
AcceleroMMA7361 accelero;
int pin1 =7;
int x;
int y;
int z;
void setup(){
 Serial.begin(9600);
 accelero.begin(13, 12, 11, 10, A0, A1, A2);
 accelero.setARefVoltage(5);
 accelero.setSensitivity(false);
 accelero.calibrate();
 pinMode(pin1, INPUT);
}
void loop(){
 z = accelero.getZAccel();
 Serial.println(z);
 delay(1000);
 if(digitalRead(pin1) == HIGH){
    Serial.write(9);
    Serial.flush();
 }
}
