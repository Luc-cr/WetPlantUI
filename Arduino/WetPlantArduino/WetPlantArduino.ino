#include <DHT.h>
#include <DHT_U.h>
#include <Adafruit_Sensor.h>
#define LAMP 9
#define BOM 10
#define VENT 11
#define LDR A1
#define sensHum A0
#define DHTTYPE DHT22
#define lampState states[0]
#define bomState states[1]
#define ventState states[2]
#define lightThresh 400
#define humThresh 50
#define tempThresh 30
const int DHTPin = 8;
unsigned long previousMillis = 0, currentMillis;
const long interval = 1000, PrintInterval = 200;
DHT dht(DHTPin, DHTTYPE);
//int temp, humVal, humPrcnt, LIGHT;
int vals[3];
int threshs[3] = {lightThresh, humThresh, tempThresh};
int states[3];
void setup() {
  Serial.begin(9600);
  dht.begin();
  pinMode(LDR, INPUT);
  pinMode(sensHum, INPUT);
  pinMode(LAMP, OUTPUT);
  pinMode(BOM, OUTPUT);
  pinMode(VENT, OUTPUT);
  digitalWrite(BOM, LOW);
  digitalWrite(VENT, LOW);
  digitalWrite(LAMP, LOW);
  //delay(15000);
}
void loop() {
  currentMillis = millis();
  vals[0] = analogRead(LDR); // Luz
  vals[1] = map(analogRead(sensHum),1023,0,0,100); // Humedad
  vals[2] = round(dht.readTemperature()); // Temp
  if (isnan(vals[2]))
  {
    Serial.println("Failed to read from DHT sensor!");
    delay(500);
    return;
  }
  if(currentMillis - previousMillis >= PrintInterval)
  {
    Serial.print(vals[0]);
    Serial.print(" ");
    Serial.print(vals[1]);
    Serial.print(" ");
    Serial.print(vals[2]);
    Serial.print(" ");
    Serial.print(states[2])
    Serial.print(" ");
    Serial.print(states[0])
    Serial.print(" ");
    Serial.println(states[1]) 
  }
  for (int i = 0; i<3; i++)
  {
    if (vals[i] >= threshs[i]) 
    {
      states[i] = HIGH;
    }
    if (states[i] == HIGH && currentMillis - previousMillis >= interval && vals[i] < threshs[i])
    {
      previousMillis = currentMillis;
      states[i] = LOW;
    }
  }
  digitalWrite(BOM, bomState);
  digitalWrite(VENT, ventState);
  digitalWrite(LAMP, lampState);
}
