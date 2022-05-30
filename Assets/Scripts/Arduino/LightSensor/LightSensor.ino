int cds = 0;

void setup() 
{
  Serial.begin(9600);
}

void loop() 
{
  cds = analogRead(A0);

  Serial.println(cds);
  delay(200);
}
