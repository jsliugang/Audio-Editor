#pragma once

static int delayMilliseconds;
static int delaySamples;
static float decay;

extern "C" __declspec(dllexport) void ReverbInit(int delay, float _decay) {
	delayMilliseconds = delay;
	decay = _decay;
	delaySamples = (int)((float)delayMilliseconds * 44.1f); //44100 Hz sample rate
}

extern "C" __declspec(dllexport) void ReverbProcess(float * tab, int lengt, int begin_index, int end_index) {

	for (int i = begin_index; i < end_index - delaySamples; i++) {

		tab[i] += tab[i];
		tab[i + delaySamples] += tab[i] * decay;
	}

}

