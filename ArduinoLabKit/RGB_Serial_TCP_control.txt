int LED = LED_BUILTIN;
int RED_PIN = 3;
int GRN_PIN = 5;
int BLU_PIN = 9;
byte cmd[] = "";
int color[3] = {0,0,0};
int led_pow = 255;

void setup() {
  pinMode(LED, OUTPUT);
  pinMode(RED_PIN, OUTPUT);
  pinMode(GRN_PIN, OUTPUT);
  pinMode(BLU_PIN, OUTPUT);

  Serial.begin(9600);
}

void loop() {
  colorShow(color, led_pow);
}

void serialEvent(){
  //Serial.readString();
  
    Serial.readBytes(cmd, 4);   
    //color[i] = int(cmd[i]);
    //for(int i=0; i<data.length(); i++){
    //  Serial.println(data[i]);   
    //}
    
  //led_pow = int(cmd[3]);
  color[0] = int(cmd[0]);
  color[1] = int(cmd[1]);
  color[2] = int(cmd[2]);
  led_pow = int(cmd[3]);

  //colorShow(color, led_pow);
}

void colorShow(int RGB[3], int P){
  double p = P/255;
  int b = map(p, 0, 1, 0, 255);
  analogWrite(RED_PIN, RGB[0]*P/255);
  analogWrite(GRN_PIN, RGB[1]*P/255);
  analogWrite(BLU_PIN, RGB[2]*P/255);
  delay(100);
}

