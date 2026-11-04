using System;

namespace CriWare
{
    // JP7 libcri 314dec23...: 0x12B428, 0x12BD9C, 0x12BE24 and 0x12B48C.
    // Native uses a truncated 12-bit fixed-point increment, including the drift
    // this introduces at sample-rate ratios that cannot be represented exactly.
    internal sealed class CriAtomResampler
    {
        private readonly float[][] history;
        private int step = 4096, position, reservedOutput;

        internal CriAtomResampler(int channels)
        {
            if (channels < 1 || channels > 16) throw new ArgumentOutOfRangeException(nameof(channels));
            history = new float[channels][];
            for (int channel = 0; channel < channels; channel++) history[channel] = new float[9];
        }

        internal bool IsActive => step != 4096;
        internal int Step => step;
        internal int Position => position;

        internal void SetRates(int sourceRate, int destinationRate)
        {
            int source = Math.Max(sourceRate, 1), destination = Math.Max(destinationRate, 1);
            source = Math.Min(source, 8 * destination);
            step = Math.Max((source << 12) / destination, 1);
            reservedOutput = step < 4096 ? 4096 / step : 0;
            if (step == 4096) Reset();
        }

        internal void Reset()
        {
            position = 0;
            foreach (float[] channel in history) Array.Clear(channel, 0, channel.Length);
        }

        internal int GetRequiredInput(int outputCount)
        {
            if (outputCount < 0) throw new ArgumentOutOfRangeException(nameof(outputCount));
            return step == 4096 ? outputCount : (position + step * outputCount + 32768) >> 12;
        }

        // Input is the complete native source block selected by GetRequiredInput.
        // A successful call consumes inputCount and retains its final eight frames.
        // Return zero leaves the resampler unchanged, as the native leaf does.
        internal int Process(float[][] input, int inputOffset, int inputCount,
            float[][] output, int outputOffset, int outputCount)
        {
            Validate(input, inputOffset, inputCount);
            Validate(output, outputOffset, outputCount);
            int count = Math.Min(outputCount, ((inputCount << 12) - position) / step - reservedOutput);
            if (count <= 0) return 0;
            for (int channel = 0; channel < history.Length; channel++) history[channel][8] = input[channel][inputOffset];
            int cursor = position;
            int frame = 0;
            for (; frame < count && cursor < 0; frame++, cursor += step)
            {
                int index = (cursor + 32768) >> 12;
                float fraction = (cursor + 32768) & 4095;
                for (int channel = 0; channel < history.Length; channel++)
                {
                    float first = history[channel][index], delta = (float)(history[channel][index + 1] - first);
                    output[channel][outputOffset + frame] = history.Length == 1
                        ? (float)(first + (float)((float)(delta * fraction) * (1f / 4096f)))
                        : (float)(first + (float)((float)(fraction * (1f / 4096f)) * delta));
                }
            }
            int vectorEnd = frame + ((count - frame) & ~3);
            for (; frame < count; frame++, cursor += step)
            {
                int index = inputOffset + (cursor >> 12);
                float fraction = cursor & 4095;
                for (int channel = 0; channel < history.Length; channel++)
                {
                    float first = input[channel][index], delta = (float)(input[channel][index + 1] - first);
                    output[channel][outputOffset + frame] = history.Length == 1 && frame >= vectorEnd
                        ? (float)(first + (float)((float)(delta * fraction) * (1f / 4096f)))
                        : (float)(first + (float)((float)(fraction * (1f / 4096f)) * delta));
                }
            }
            for (int channel = 0; channel < history.Length; channel++)
            {
                if (inputCount < 8) Array.Copy(history[channel], inputCount, history[channel], 0, 8 - inputCount);
                int retained = Math.Min(inputCount, 8);
                Array.Copy(input[channel], inputOffset + inputCount - retained, history[channel], 8 - retained, retained);
            }
            position = cursor - (inputCount << 12);
            return count;
        }

        private void Validate(float[][] buffers, int offset, int count)
        {
            if (buffers == null || buffers.Length != history.Length)
                throw new ArgumentException("PCM channel count does not match the resampler.", nameof(buffers));
            if (offset < 0 || count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            foreach (float[] channel in buffers)
                if (channel == null || offset > channel.Length - count)
                    throw new ArgumentException("PCM buffer is shorter than the requested window.", nameof(buffers));
        }
    }
}
