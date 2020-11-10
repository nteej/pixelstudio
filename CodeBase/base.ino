//#define FASTLED_ESP8266_NODEMCU_PIN_ORDER //Uncomment for ESP-12E Boards
#include "FastLED.h"


#define NUM_LEDS 200
#define DATA_PIN 3
#define BRIGHTNESS  255

CRGB leds[NUM_LEDS];

byte mainarray[8][25][3];
byte a8x25[8][25][3];

int DELAY;

//pattern_01;

void setup() {
  delay(2000);
  FastLED.setBrightness( BRIGHTNESS );
  DELAY = 110;
  FastLED.addLeds<WS2811, DATA_PIN, RGB>(leds, NUM_LEDS);
}
void loop() 
{

//In step by step designs, say the function as abc(x,y); [x - DELAY, y - Repeats]
//In array functions, after mentioning the function, put pt8x25(z, x); [z - direction as 0 - up, 1 - down, 2 - left, 3 - right]

  for (int u = 0; u < 2; u++) {
   //pattern_1;
   pt8x25(2,DELAY);
  }
  shiftsteps8x25(2,DELAY,25);
}