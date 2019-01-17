int LOCK = 13;
int MOTOR=12;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LOCK,OUTPUT);
  pinMode(MOTOR,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  char data = Serial.read();
  switch(data)
  {
    case 'A':
      digitalWrite(LOCK, HIGH);
      digitalWrite(MOTOR,HIGH);
      delay(2000);
      digitalWrite(LOCK, LOW);
      digitalWrite(MOTOR, LOW);
      break;

      case 'B':
        digitalWrite(LOCK, LOW);
        
        break;
  }
}
