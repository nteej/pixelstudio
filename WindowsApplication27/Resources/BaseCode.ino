//#define FASTLED_ESP8266_NODEMCU_PIN_ORDER //Uncomment for ESP-12E Boards
#include "FastLED.h"


#define NUM_LEDS 200
#define DATA_PIN 3
#define BRIGHTNESS  255

CRGB leds[NUM_LEDS];

byte mainarray[8][25][3];
byte a8x25[8][25][3];

int DELAY;

void Lotus_1();
void Lotus_1();
//method_define

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
//In pattern shifing, we can define the way that the pattern to pattern shift happen at the end of each pattern. 
//Put shiftsteps8x25(z, x, i) at the end of patterns; [z - direction, x - DELAY, i - no of lines to shift in z direction]


  for (int u = 0; u < 2; u++) {

  Lotus_1();
 pt8x25(0, DELAY);
Lotus_1();
 pt8x25(0, DELAY);
//method_call
   
  }
  shiftsteps8x25(2,DELAY,25);
}

void Lotus_1() {
  cleara8x25();
}


void Lotus_1() {
  cleara8x25();
}


//pattern_1