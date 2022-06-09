bool lightOn = false;

void setup() 
{
  Serial.begin(9600);             // Serial Controller 스크립트 상의 Baud Rate와 통일 시킬 것
  pinMode(LED_BUILTIN, OUTPUT);   // 13번핀
}

void loop() 
{
  if(Serial.available())
  {
    char c = Serial.read();
    if(c)
    {
      if( c == '1')
      {
        lightOn = true;
      }
      else if(c == '0')
      {
        lightOn = false;
      }
    }
  }
  if(lightOn)
  {
    digitalWrite(LED_BUILTIN, HIGH);
    Serial.println('1');
  }
  else
  {
    digitalWrite(LED_BUILTIN, LOW);
    Serial.println('0');
  }
  delay(500);
}
