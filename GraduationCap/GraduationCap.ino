#include <FastLED.h>

FASTLED_USING_NAMESPACE

#define COLUMNS    16
#define ROWS        8
#define BRIGHTNESS  5 // 0 - 255 
#define MAX_AMPS    2

#define NUM_LEDS    COLUMNS * ROWS
#define DATA_PIN    3
#define LED_TYPE    WS2812
#define COLOR_ORDER RGB
#define FRAMES_PER_SECOND  120
#define ARRAY_SIZE(A) (sizeof(A) / sizeof((A)[0]))

CRGB leds[NUM_LEDS];
byte pixels[][3] = {
  { 0, 0, 0 }, 
  { 21, 2, 3 }, 
  { 250, 21, 34 }, 
  { 249, 14, 36 }, 
  { 45, 1, 6 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 66, 5, 6 }, 
  { 248, 17, 36 }, 
  { 228, 5, 33 }, 
  { 32, 2, 5 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 43, 4, 6 }, 
  { 72, 5, 7 }, 
  { 208, 12, 20 }, 
  { 252, 12, 42 }, 
  { 48, 1, 7 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 2, 0, 0 }, 
  { 0, 0, 0 }, 
  { 108, 7, 11 }, 
  { 113, 4, 12 }, 
  { 65, 2, 8 }, 
  { 5, 1, 1 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 71, 4, 7 }, 
  { 54, 4, 5 }, 
  { 17, 2, 2 }, 
  { 253, 22, 40 }, 
  { 246, 9, 36 }, 
  { 31, 1, 4 }, 
  { 21, 2, 3 }, 
  { 234, 16, 28 }, 
  { 240, 17, 28 }, 
  { 237, 17, 28 }, 
  { 200, 13, 19 }, 
  { 61, 3, 6 }, 
  { 12, 1, 3 }, 
  { 3, 1, 1 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 45, 3, 4 }, 
  { 95, 5, 8 }, 
  { 6, 2, 2 }, 
  { 53, 5, 5 }, 
  { 238, 13, 29 }, 
  { 226, 4, 30 }, 
  { 217, 4, 31 }, 
  { 249, 5, 39 }, 
  { 251, 9, 37 }, 
  { 255, 22, 37 }, 
  { 254, 17, 43 }, 
  { 247, 6, 37 }, 
  { 183, 4, 21 }, 
  { 7, 1, 2 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 12, 1, 2 }, 
  { 68, 5, 8 }, 
  { 10, 1, 2 }, 
  { 184, 11, 18 }, 
  { 249, 11, 37 }, 
  { 245, 4, 39 }, 
  { 246, 4, 40 }, 
  { 243, 4, 39 }, 
  { 244, 3, 40 }, 
  { 250, 9, 38 }, 
  { 250, 10, 37 }, 
  { 243, 3, 39 }, 
  { 248, 6, 45 }, 
  { 59, 3, 9 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 26, 3, 4 }, 
  { 242, 18, 29 }, 
  { 252, 9, 42 }, 
  { 242, 3, 36 }, 
  { 245, 4, 38 }, 
  { 233, 4, 34 }, 
  { 159, 4, 19 }, 
  { 169, 4, 20 }, 
  { 238, 4, 36 }, 
  { 252, 9, 38 }, 
  { 227, 4, 31 }, 
  { 198, 4, 24 }, 
  { 43, 2, 6 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 75, 5, 9 }, 
  { 247, 15, 31 }, 
  { 246, 5, 37 }, 
  { 243, 4, 36 }, 
  { 241, 4, 38 }, 
  { 87, 4, 12 }, 
  { 22, 9, 9 }, 
  { 21, 0, 2 }, 
  { 100, 3, 12 }, 
  { 250, 7, 44 }, 
  { 208, 4, 27 }, 
  { 21, 4, 6 }, 
  { 13, 5, 5 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 100, 7, 10 }, 
  { 247, 8, 34 }, 
  { 237, 2, 30 }, 
  { 238, 0, 28 }, 
  { 223, 0, 19 }, 
  { 162, 14, 29 }, 
  { 188, 172, 144 }, 
  { 61, 68, 51 }, 
  { 15, 4, 4 }, 
  { 234, 3, 32 }, 
  { 237, 1, 29 }, 
  { 151, 62, 64 }, 
  { 157, 140, 115 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 3, 1, 1 }, 
  { 184, 11, 18 }, 
  { 173, 24, 36 }, 
  { 255, 241, 235 }, 
  { 255, 221, 220 }, 
  { 252, 77, 111 }, 
  { 238, 1, 28 }, 
  { 214, 22, 49 }, 
  { 209, 71, 85 }, 
  { 14, 4, 4 }, 
  { 202, 4, 24 }, 
  { 250, 4, 42 }, 
  { 165, 8, 24 }, 
  { 33, 31, 25 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 3, 0, 1 }, 
  { 0, 1, 0 }, 
  { 247, 238, 223 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 235, 230 }, 
  { 245, 22, 55 }, 
  { 242, 0, 24 }, 
  { 142, 3, 17 }, 
  { 111, 3, 13 }, 
  { 249, 4, 42 }, 
  { 238, 2, 33 }, 
  { 21, 0, 2 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 80, 59, 51 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 252 }, 
  { 248, 36, 72 }, 
  { 230, 0, 20 }, 
  { 131, 0, 11 }, 
  { 224, 10, 39 }, 
  { 208, 31, 51 }, 
  { 100, 5, 14 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 144, 111, 95 }, 
  { 253, 238, 226 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 250 }, 
  { 255, 254, 248 }, 
  { 255, 251, 245 }, 
  { 255, 212, 215 }, 
  { 250, 43, 80 }, 
  { 95, 0, 7 }, 
  { 1, 5, 3 }, 
  { 82, 0, 6 }, 
  { 39, 19, 22 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 1, 0, 0 }, 
  { 245, 162, 162 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 248, 235, 219 }, 
  { 39, 31, 26 }, 
  { 72, 62, 51 }, 
  { 226, 212, 190 }, 
  { 255, 253, 248 }, 
  { 253, 177, 183 }, 
  { 224, 198, 175 }, 
  { 253, 197, 194 }, 
  { 41, 25, 26 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 250, 151, 160 }, 
  { 255, 241, 235 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 254 }, 
  { 255, 253, 246 }, 
  { 74, 58, 49 }, 
  { 0, 0, 0 }, 
  { 87, 74, 61 }, 
  { 217, 198, 175 }, 
  { 153, 121, 102 }, 
  { 131, 111, 92 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 219, 18, 43 }, 
  { 250, 87, 115 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 253, 247 }, 
  { 237, 218, 199 }, 
  { 250, 237, 223 }, 
  { 104, 79, 68 }, 
  { 142, 109, 93 }, 
  { 82, 66, 55 }, 
  { 62, 48, 42 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }, 
  { 3, 0, 1 }, 
  { 104, 0, 7 }, 
  { 208, 28, 50 }, 
  { 255, 255, 254 }, 
  { 255, 255, 255 }, 
  { 255, 255, 255 }, 
  { 255, 255, 252 }, 
  { 178, 151, 127 }, 
  { 203, 175, 151 }, 
  { 213, 187, 165 }, 
  { 195, 167, 144 }, 
  { 121, 93, 79 }, 
  { 0, 0, 0 }, 
  { 0, 0, 0 }
};

int toLinearGrid(int a) // 31 <==> 16
{
  int row = a / COLUMNS;
  if (row & 1) return (COLUMNS - ((a % COLUMNS) + 1)) + (row * COLUMNS);
  
  return a;
}

void setup() {
  delay(3000);
  FastLED.addLeds<LED_TYPE,DATA_PIN,COLOR_ORDER>(leds, NUM_LEDS).setCorrection(TypicalLEDStrip);
  FastLED.setMaxPowerInVoltsAndMilliamps(5, MAX_AMPS * 1000); 
  FastLED.setBrightness(BRIGHTNESS);
}


// List of patterns to cycle through.  Each is defined as a separate function below.
typedef void (*SimplePatternList[])();
SimplePatternList gPatterns = { image };//, rainbow, rainbowWithGlitter, confetti, sinelon, juggle, bpm };

uint8_t gCurrentPatternNumber = 0;
uint8_t gHue = 0;
  
void loop()
{
  // Call the current pattern function once, updating the 'leds' array
  gPatterns[gCurrentPatternNumber]();

  // send the 'leds' array out to the actual LED strip
  FastLED.show();
  FastLED.delay(1000/FRAMES_PER_SECOND); 

  // do some periodic updates
  EVERY_N_MILLISECONDS( 20 ) { gHue++; } // slowly cycle the "base color" through the rainbow
  EVERY_N_SECONDS( 10 ) { nextPattern(); } // change patterns periodically
}

void nextPattern()
{
  // add one to the current pattern number, and wrap around at the end
  gCurrentPatternNumber = (gCurrentPatternNumber + 1) % ARRAY_SIZE( gPatterns);
}

void image()
{
  int sz = 16 * 16;
  int offset = 16 * 4;
  for (int i = 0; i < NUM_LEDS; i++)
  {
    int px = i + offset;
    byte r = pixels[toLinearGrid(px)][1];
    byte g = pixels[toLinearGrid(px)][0];
    byte b = pixels[toLinearGrid(px)][2];
    leds[i].setRGB(r, g, b);
  }
}

void rainbow() 
{
  // FastLED's built-in rainbow generator
  fill_rainbow( leds, NUM_LEDS, gHue, 7);
}

void rainbowWithGlitter() 
{
  // built-in FastLED rainbow, plus some random sparkly glitter
  rainbow();
  addGlitter(80);
}

void addGlitter( fract8 chanceOfGlitter) 
{
  if( random8() < chanceOfGlitter) {
    leds[ random16(NUM_LEDS) ] += CRGB::White;
  }
}

void confetti() 
{
  // random colored speckles that blink in and fade smoothly
  fadeToBlackBy( leds, NUM_LEDS, 10);
  int pos = random16(NUM_LEDS);
  leds[pos] += CHSV( gHue + random8(64), 200, 255);
}

void sinelon()
{
  // a colored dot sweeping back and forth, with fading trails
  fadeToBlackBy( leds, NUM_LEDS, 20);
  int pos = beatsin16( 13, 0, NUM_LEDS-1 );
  leds[pos] += CHSV( gHue, 255, 192);
}

void bpm()
{
  // colored stripes pulsing at a defined Beats-Per-Minute (BPM)
  uint8_t BeatsPerMinute = 62;
  CRGBPalette16 palette = PartyColors_p;
  uint8_t beat = beatsin8( BeatsPerMinute, 64, 255);
  for( int i = 0; i < NUM_LEDS; i++) { //9948
    leds[i] = ColorFromPalette(palette, gHue+(i*2), beat-gHue+(i*10));
  }
}

void juggle() {
  // eight colored dots, weaving in and out of sync with each other
  fadeToBlackBy( leds, NUM_LEDS, 20);
  byte dothue = 0;
  for( int i = 0; i < 8; i++) {
    leds[beatsin16( i+7, 0, NUM_LEDS-1 )] |= CHSV(dothue, 200, 255);
    dothue += 32;
  }
}
