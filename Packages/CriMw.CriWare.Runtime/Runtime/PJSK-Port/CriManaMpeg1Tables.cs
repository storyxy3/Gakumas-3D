// MPEG-1 VLC table representation adapted from PL_MPEG (MIT, Dominic Szablewski).
// See CriManaMpeg1.LICENSE.txt. Numeric IDCT tables come from the original JP 7.0.0 library.
using System;

namespace CriWare.CriMana
{
    internal sealed partial class CriManaMpeg1Decoder
    {
        private static readonly int[] ZigZag = {
            0, 1, 8, 16, 9, 2, 3, 10, 17, 24, 32, 25, 18, 11, 4, 5,
            12, 19, 26, 33, 40, 48, 41, 34, 27, 20, 13, 6, 7, 14, 21, 28,
            35, 42, 49, 56, 57, 50, 43, 36, 29, 22, 15, 23, 30, 37, 44, 51,
            58, 59, 52, 45, 38, 31, 39, 46, 53, 60, 61, 54, 47, 55, 62, 63,
        };
        private static readonly int[] IdctScale = {
            16384, 22725, 21407, 19266, 16384, 12873, 8867, 4520, 22725, 31521, 29692, 26722, 22725, 17855, 12299, 6270,
            21407, 29692, 27969, 25172, 21407, 16819, 11585, 5906, 19266, 26722, 25172, 22654, 19266, 15137, 10426, 5315,
            16384, 22725, 21407, 19266, 16384, 12873, 8867, 4520, 12873, 17855, 16819, 15137, 12873, 10114, 6967, 3552,
            8867, 12299, 11585, 10426, 8867, 6967, 4799, 2446, 4520, 6270, 5906, 5315, 4520, 3552, 2446, 1247,
        };
        private static readonly byte[] DefaultIntraMatrix = {
            8, 16, 19, 22, 26, 27, 29, 34, 16, 16, 22, 24, 27, 29, 34, 37,
            19, 22, 26, 27, 29, 34, 34, 38, 22, 22, 26, 27, 29, 34, 37, 40,
            22, 26, 27, 29, 32, 35, 40, 48, 26, 27, 29, 32, 35, 40, 48, 58,
            26, 27, 29, 34, 38, 46, 56, 69, 27, 29, 35, 38, 46, 56, 69, 83,
        };
        private static readonly int[] MacroblockAddress = {
            2, 0, 0, 1, 4, 0, 6, 0, 8, 0, 10, 0, 0, 3, 0, 2,
            12, 0, 14, 0, 0, 5, 0, 4, 16, 0, 18, 0, 0, 7, 0, 6,
            20, 0, 22, 0, 24, 0, 26, 0, 28, 0, 30, 0, 32, 0, 34, 0,
            36, 0, 38, 0, 0, 9, 0, 8, -1, 0, 40, 0, -1, 0, 42, 0,
            44, 0, 46, 0, 0, 15, 0, 14, 0, 13, 0, 12, 0, 11, 0, 10,
            48, 0, 50, 0, 52, 0, 54, 0, 56, 0, 58, 0, 60, 0, 62, 0,
            64, 0, -1, 0, -1, 0, 66, 0, 68, 0, 70, 0, 72, 0, 74, 0,
            76, 0, 78, 0, 0, 21, 0, 20, 0, 19, 0, 18, 0, 17, 0, 16,
            0, 35, -1, 0, -1, 0, 0, 34, 0, 33, 0, 32, 0, 31, 0, 30,
            0, 29, 0, 28, 0, 27, 0, 26, 0, 25, 0, 24, 0, 23, 0, 22,
        };
        private static readonly int[] MacroblockIntra = {
            2, 0, 0, 1, -1, 0, 0, 17,
        };
        private static readonly int[] MacroblockPredictive = {
            2, 0, 0, 10, 4, 0, 0, 2, 6, 0, 0, 8, 8, 0, 10, 0,
            12, 0, 0, 18, 0, 26, 0, 1, -1, 0, 0, 17,
        };
        private static readonly int[] MacroblockB = {
            2, 0, 4, 0, 6, 0, 8, 0, 0, 12, 0, 14, 10, 0, 12, 0,
            0, 4, 0, 6, 14, 0, 16, 0, 0, 8, 0, 10, 18, 0, 20, 0,
            0, 30, 0, 1, -1, 0, 0, 17, 0, 22, 0, 26,
        };
        private static readonly int[] CodedBlockPattern = {
            2, 0, 4, 0, 6, 0, 8, 0, 10, 0, 12, 0, 14, 0, 16, 0,
            18, 0, 20, 0, 22, 0, 24, 0, 26, 0, 0, 60, 28, 0, 30, 0,
            32, 0, 34, 0, 36, 0, 38, 0, 40, 0, 42, 0, 44, 0, 46, 0,
            0, 32, 0, 16, 0, 8, 0, 4, 48, 0, 50, 0, 52, 0, 54, 0,
            56, 0, 58, 0, 60, 0, 62, 0, 0, 62, 0, 2, 0, 61, 0, 1,
            0, 56, 0, 52, 0, 44, 0, 28, 0, 40, 0, 20, 0, 48, 0, 12,
            64, 0, 66, 0, 68, 0, 70, 0, 72, 0, 74, 0, 76, 0, 78, 0,
            80, 0, 82, 0, 84, 0, 86, 0, 0, 63, 0, 3, 0, 36, 0, 24,
            88, 0, 90, 0, 92, 0, 94, 0, 96, 0, 98, 0, 100, 0, 102, 0,
            104, 0, 106, 0, 108, 0, 110, 0, 112, 0, 114, 0, 116, 0, 118, 0,
            0, 34, 0, 18, 0, 10, 0, 6, 0, 33, 0, 17, 0, 9, 0, 5,
            -1, 0, 120, 0, 122, 0, 124, 0, 0, 58, 0, 54, 0, 46, 0, 30,
            0, 57, 0, 53, 0, 45, 0, 29, 0, 38, 0, 26, 0, 37, 0, 25,
            0, 43, 0, 23, 0, 51, 0, 15, 0, 42, 0, 22, 0, 50, 0, 14,
            0, 41, 0, 21, 0, 49, 0, 13, 0, 35, 0, 19, 0, 11, 0, 7,
            0, 39, 0, 27, 0, 59, 0, 55, 0, 47, 0, 31,
        };
        private static readonly int[] MotionCode = {
            2, 0, 0, 0, 4, 0, 6, 0, 8, 0, 10, 0, 0, 1, 0, -1,
            12, 0, 14, 0, 0, 2, 0, -2, 16, 0, 18, 0, 0, 3, 0, -3,
            20, 0, 22, 0, 24, 0, 26, 0, -1, 0, 28, 0, 30, 0, 32, 0,
            34, 0, 36, 0, 0, 4, 0, -4, -1, 0, 38, 0, 40, 0, 42, 0,
            0, 7, 0, -7, 0, 6, 0, -6, 0, 5, 0, -5, 44, 0, 46, 0,
            48, 0, 50, 0, 52, 0, 54, 0, 56, 0, 58, 0, 60, 0, 62, 0,
            64, 0, 66, 0, 0, 10, 0, -10, 0, 9, 0, -9, 0, 8, 0, -8,
            0, 16, 0, -16, 0, 15, 0, -15, 0, 14, 0, -14, 0, 13, 0, -13,
            0, 12, 0, -12, 0, 11, 0, -11,
        };
        private static readonly int[] DcLuminance = {
            2, 0, 4, 0, 0, 1, 0, 2, 6, 0, 8, 0, 0, 0, 0, 3,
            0, 4, 10, 0, 0, 5, 12, 0, 0, 6, 14, 0, 0, 7, 16, 0,
            0, 8, 18, 0, 0, 9, 20, 0, 0, 10, 0, 11,
        };
        private static readonly int[] DcChrominance = {
            2, 0, 4, 0, 0, 0, 0, 1, 0, 2, 6, 0, 0, 3, 8, 0,
            0, 4, 10, 0, 0, 5, 12, 0, 0, 6, 14, 0, 0, 7, 16, 0,
            0, 8, 18, 0, 0, 9, 20, 0, 0, 10, 0, 11,
        };
        private static readonly int[] DctCoefficient = {
            2, 0, 0, 1, 4, 0, 6, 0, 8, 0, 10, 0, 12, 0, 0, 257,
            14, 0, 16, 0, 18, 0, 20, 0, 0, 2, 0, 513, 22, 0, 24, 0,
            26, 0, 28, 0, 30, 0, 0, 3, 0, 1025, 0, 769, 32, 0, 0, 65535,
            34, 0, 36, 0, 0, 1793, 0, 1537, 0, 258, 0, 1281, 38, 0, 40, 0,
            42, 0, 44, 0, 0, 514, 0, 2305, 0, 4, 0, 2049, 46, 0, 48, 0,
            50, 0, 52, 0, 54, 0, 56, 0, 58, 0, 60, 0, 0, 3329, 0, 6,
            0, 3073, 0, 2817, 0, 770, 0, 259, 0, 5, 0, 2561, 62, 0, 64, 0,
            66, 0, 68, 0, 70, 0, 72, 0, 74, 0, 76, 0, 78, 0, 80, 0,
            82, 0, 84, 0, 86, 0, 88, 0, 90, 0, 92, 0, 0, 4097, 0, 1282,
            0, 7, 0, 515, 0, 260, 0, 3841, 0, 3585, 0, 1026, 94, 0, 96, 0,
            98, 0, 100, 0, 102, 0, 104, 0, 106, 0, 108, 0, 110, 0, 112, 0,
            114, 0, 116, 0, 118, 0, 120, 0, 122, 0, 124, 0, -1, 0, 126, 0,
            128, 0, 130, 0, 132, 0, 134, 0, 136, 0, 138, 0, 140, 0, 142, 0,
            144, 0, 146, 0, 148, 0, 150, 0, 152, 0, 154, 0, 0, 11, 0, 2050,
            0, 1027, 0, 10, 0, 516, 0, 1794, 0, 5377, 0, 5121, 0, 9, 0, 4865,
            0, 4609, 0, 261, 0, 771, 0, 8, 0, 1538, 0, 4353, 156, 0, 158, 0,
            160, 0, 162, 0, 164, 0, 166, 0, 168, 0, 170, 0, 172, 0, 174, 0,
            176, 0, 178, 0, 180, 0, 182, 0, 0, 2562, 0, 2306, 0, 1283, 0, 772,
            0, 517, 0, 263, 0, 262, 0, 15, 0, 14, 0, 13, 0, 12, 0, 6657,
            0, 6401, 0, 6145, 0, 5889, 0, 5633, 184, 0, 186, 0, 188, 0, 190, 0,
            192, 0, 194, 0, 196, 0, 198, 0, 200, 0, 202, 0, 204, 0, 206, 0,
            0, 31, 0, 30, 0, 29, 0, 28, 0, 27, 0, 26, 0, 25, 0, 24,
            0, 23, 0, 22, 0, 21, 0, 20, 0, 19, 0, 18, 0, 17, 0, 16,
            208, 0, 210, 0, 212, 0, 214, 0, 216, 0, 218, 0, 220, 0, 222, 0,
            0, 40, 0, 39, 0, 38, 0, 37, 0, 36, 0, 35, 0, 34, 0, 33,
            0, 32, 0, 270, 0, 269, 0, 268, 0, 267, 0, 266, 0, 265, 0, 264,
            0, 274, 0, 273, 0, 272, 0, 271, 0, 1539, 0, 4098, 0, 3842, 0, 3586,
            0, 3330, 0, 3074, 0, 2818, 0, 7937, 0, 7681, 0, 7425, 0, 7169, 0, 6913,
        };
        private static readonly short[] SingleIdct = ReadSingleIdct(
            "IAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAA" +
            "IAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIADg/+X/7v/6/wYAEgAbACAA4P/l/+7/+v8GABIAGwAgAOD/5f/u//r/BgASABsAIADg/+X/" +
            "7v/6/wYAEgAbACAA4P/l/+7/+v8GABIAGwAgAOD/5f/u//r/BgASABsAIADg/+X/7v/6/wYAEgAbACAA4P/l/+7/+v8GABIAGwAgACAADQDz/+D/4P/z/w0A" +
            "IAAgAA0A8//g/+D/8/8NACAAIAANAPP/4P/g//P/DQAgACAADQDz/+D/4P/z/w0AIAAgAA0A8//g/+D/8/8NACAAIAANAPP/4P/g//P/DQAgACAADQDz/+D/" +
            "4P/z/w0AIAAgAA0A8//g/+D/8/8NACAA4P8IACYAFQDr/9r/+P8gAOD/CAAmABUA6//a//j/IADg/wgAJgAVAOv/2v/4/yAA4P8IACYAFQDr/9r/+P8gAOD/" +
            "CAAmABUA6//a//j/IADg/wgAJgAVAOv/2v/4/yAA4P8IACYAFQDr/9r/+P8gAOD/CAAmABUA6//a//j/IAAgAOD/4P8gACAA4P/g/yAAIADg/+D/IAAgAOD/" +
            "4P8gACAA4P/g/yAAIADg/+D/IAAgAOD/4P8gACAA4P/g/yAAIADg/+D/IAAgAOD/4P8gACAA4P/g/yAAIADg/+D/IAAgAOD/4P8gACAA4P/g/yAAIADg/+D/" +
            "IAAgAOD/4P8gAOD/OAD1/9D/MAALAMj/IADg/zgA9f/Q/zAACwDI/yAA4P84APX/0P8wAAsAyP8gAOD/OAD1/9D/MAALAMj/IADg/zgA9f/Q/zAACwDI/yAA" +
            "4P84APX/0P8wAAsAyP8gAOD/OAD1/9D/MAALAMj/IADg/zgA9f/Q/zAACwDI/yAAIACz/00A4P/g/00As/8gACAAs/9NAOD/4P9NALP/IAAgALP/TQDg/+D/" +
            "TQCz/yAAIACz/00A4P/g/00As/8gACAAs/9NAOD/4P9NALP/IAAgALP/TQDg/+D/TQCz/yAAIACz/00A4P/g/00As/8gACAAs/9NAOD/4P9NALP/IADg/1sA" +
            "eP+hAF//iACl/yAA4P9bAHj/oQBf/4gApf8gAOD/WwB4/6EAX/+IAKX/IADg/1sAeP+hAF//iACl/yAA4P9bAHj/oQBf/4gApf8gAOD/WwB4/6EAX/+IAKX/" +
            "IADg/1sAeP+hAF//iACl/yAA4P9bAHj/oQBf/4gApf8gAOD/4P/g/+D/4P/g/+D/4P/l/+X/5f/l/+X/5f/l/+X/7v/u/+7/7v/u/+7/7v/u//r/+v/6//r/" +
            "+v/6//r/+v8GAAYABgAGAAYABgAGAAYAEgASABIAEgASABIAEgASABsAGwAbABsAGwAbABsAGwAgACAAIAAgACAAIAAgACAAIAAbABIABgD6/+7/5f/g/xsA" +
            "FwAPAAUA+//x/+n/5f8SAA8ACgAEAPz/9v/x/+7/BgAFAAQAAQD///z/+//6//r/+//8////AQAEAAUABgDu//H/9v/8/wQACgAPABIA5f/p//H/+/8FAA8A" +
            "FwAbAOD/5f/u//r/BgASABsAIADg//P/DQAgACAADQDz/+D/5f/1/wsAGwAbAAsA9f/l/+7/+P8IABIAEgAIAPj/7v/6//3/AwAGAAYAAwD9//r/BgADAP3/" +
            "+v/6//3/AwAGABIACAD4/+7/7v/4/wgAEgAbAAsA9f/l/+X/9f8LABsAIAANAPP/4P/g//P/DQAgACAA+P/a/+v/FQAmAAgA4P8bAPr/4P/u/xIAIAAGAOX/" +
            "EgD8/+v/9P8MABUABADu/wYA///4//z/BAAIAAEA+v/6/wEACAAEAPz/+P///wYA7v8EABUADAD0/+v//P8SAOX/BgAgABIA7v/g//r/GwDg/wgAJgAVAOv/" +
            "2v/4/yAA4P8gACAA4P/g/yAAIADg/+X/GwAbAOX/5f8bABsA5f/u/xIAEgDu/+7/EgASAO7/+v8GAAYA+v/6/wYABgD6/wYA+v/6/wYABgD6//r/BgASAO7/" +
            "7v8SABIA7v/u/xIAGwDl/+X/GwAbAOX/5f8bACAA4P/g/yAAIADg/+D/IAAgAMj/CwAwAND/9f84AOD/GwDQ/woAKQDX//b/MADl/xIA4P8GABsA5f/6/yAA" +
            "7v8GAPX/AgAKAPb//v8LAPr/+v8LAP7/9v8KAAIA9f8GAO7/IAD6/+X/GwAGAOD/EgDl/zAA9v/X/ykACgDQ/xsA4P84APX/0P8wAAsAyP8gAOD/TQCz/yAA" +
            "IACz/00A4P/l/0EAv/8bABsAv/9BAOX/7v8sANT/EgASANT/LADu//r/DwDx/wYABgDx/w8A+v8GAPH/DwD6//r/DwDx/wYAEgDU/ywA7v/u/ywA1P8SABsA" +
            "v/9BAOX/5f9BAL//GwAgALP/TQDg/+D/TQCz/yAAIACl/4gAX/+hAHj/WwDg/xsAs/90AHj/iACM/00A5f8SAMz/TQCl/1sAs/80AO7/BgDu/xsA4P8gAOX/" +
            "EgD6//r/EgDl/yAA4P8bAO7/BgDu/zQAs/9bAKX/TQDM/xIA5f9NAIz/iAB4/3QAs/8bAOD/WwB4/6EAX/+IAKX/IAAgACAAIAAgACAAIAAgACAADQANAA0A" +
            "DQANAA0ADQANAPP/8//z//P/8//z//P/8//g/+D/4P/g/+D/4P/g/+D/4P/g/+D/4P/g/+D/4P/g//P/8//z//P/8//z//P/8/8NAA0ADQANAA0ADQANAA0A" +
            "IAAgACAAIAAgACAAIAAgAOD/5f/u//r/BgASABsAIADz//X/+P/9/wMACAALAA0ADQALAAgAAwD9//j/9f/z/yAAGwASAAYA+v/u/+X/4P8gABsAEgAGAPr/" +
            "7v/l/+D/DQALAAgAAwD9//j/9f/z//P/9f/4//3/AwAIAAsADQDg/+X/7v/6/wYAEgAbACAAIAANAPP/4P/g//P/DQAgAA0ABQD7//P/8//7/wUADQDz//v/" +
            "BQANAA0ABQD7//P/4P/z/w0AIAAgAA0A8//g/+D/8/8NACAAIAANAPP/4P/z//v/BQANAA0ABQD7//P/DQAFAPv/8//z//v/BQANACAADQDz/+D/4P/z/w0A" +
            "IADg/wgAJgAVAOv/2v/4/yAA8/8DABAACQD3//D//f8NAA0A/f/w//f/CQAQAAMA8/8gAPj/2v/r/xUAJgAIAOD/IAD4/9r/6/8VACYACADg/w0A/f/w//f/" +
            "CQAQAAMA8//z/wMAEAAJAPf/8P/9/w0A4P8IACYAFQDr/9r/+P8gACAA4P/g/yAAIADg/+D/IAANAPP/8/8NAA0A8//z/w0A8/8NAA0A8//z/w0ADQDz/+D/" +
            "IAAgAOD/4P8gACAA4P/g/yAAIADg/+D/IAAgAOD/8/8NAA0A8//z/w0ADQDz/w0A8//z/w0ADQDz//P/DQAgAOD/4P8gACAA4P/g/yAA4P84APX/0P8wAAsA" +
            "yP8gAPP/FwD7/+z/FAAFAOn/DQANAOn/BQAUAOz/+/8XAPP/IADI/wsAMADQ//X/OADg/yAAyP8LADAA0P/1/zgA4P8NAOn/BQAUAOz/+/8XAPP/8/8XAPv/" +
            "7P8UAAUA6f8NAOD/OAD1/9D/MAALAMj/IAAgALP/TQDg/+D/TQCz/yAADQDg/yAA8//z/yAA4P8NAPP/IADg/w0ADQDg/yAA8//g/00As/8gACAAs/9NAOD/" +
            "4P9NALP/IAAgALP/TQDg//P/IADg/w0ADQDg/yAA8/8NAOD/IADz//P/IADg/w0AIACz/00A4P/g/00As/8gAOD/WwB4/6EAX/+IAKX/IADz/yYAyP9DAL3/" +
            "OADa/w0ADQDa/zgAvf9DAMj/JgDz/yAApf+IAF//oQB4/1sA4P8gAKX/iABf/6EAeP9bAOD/DQDa/zgAvf9DAMj/JgDz//P/JgDI/0MAvf84ANr/DQDg/1sA" +
            "eP+hAF//iACl/yAA4P/g/+D/4P/g/+D/4P/g/wgACAAIAAgACAAIAAgACAAmACYAJgAmACYAJgAmACYAFQAVABUAFQAVABUAFQAVAOv/6//r/+v/6//r/+v/" +
            "6//a/9r/2v/a/9r/2v/a/9r/+P/4//j/+P/4//j/+P/4/yAAIAAgACAAIAAgACAAIAAgABsAEgAGAPr/7v/l/+D/+P/6//z///8BAAQABgAIANr/4P/r//j/" +
            "CAAVACAAJgDr/+7/9P/8/wQADAASABUAFQASAAwABAD8//T/7v/r/yYAIAAVAAgA+P/r/+D/2v8IAAYABAABAP///P/6//j/4P/l/+7/+v8GABIAGwAgAOD/" +
            "8/8NACAAIAANAPP/4P8IAAMA/f/4//j//f8DAAgAJgAQAPD/2v/a//D/EAAmABUACQD3/+v/6//3/wkAFQDr//f/CQAVABUACQD3/+v/2v/w/xAAJgAmABAA" +
            "8P/a//j//f8DAAgACAADAP3/+P8gAA0A8//g/+D/8/8NACAAIAD4/9r/6/8VACYACADg//j/AgAJAAUA+//3//7/CADa/wkALQAZAOf/0//3/yYA6/8FABkA" +
            "DgDy/+f/+/8VABUA+//n//L/DgAZAAUA6/8mAPf/0//n/xkALQAJANr/CAD+//f/+/8FAAkAAgD4/+D/CAAmABUA6//a//j/IADg/yAAIADg/+D/IAAgAOD/" +
            "CAD4//j/CAAIAPj/+P8IACYA2v/a/yYAJgDa/9r/JgAVAOv/6/8VABUA6//r/xUA6/8VABUA6//r/xUAFQDr/9r/JgAmANr/2v8mACYA2v/4/wgACAD4//j/" +
            "CAAIAPj/IADg/+D/IAAgAOD/4P8gACAAyP8LADAA0P/1/zgA4P/4/w0A/f/1/wsAAwDz/wgA2v9DAPP/yP84AA0Avf8mAOv/JgD4/+D/IAAIANr/FQAVANr/" +
            "CAAgAOD/+P8mAOv/JgC9/w0AOADI//P/QwDa/wgA8/8DAAsA9f/9/w0A+P/g/zgA9f/Q/zAACwDI/yAA4P9NALP/IAAgALP/TQDg/wgA7v8SAPj/+P8SAO7/" +
            "CAAmAKX/WwDa/9r/WwCl/yYAFQDM/zQA6//r/zQAzP8VAOv/NADM/xUAFQDM/zQA6//a/1sApf8mACYApf9bANr/+P8SAO7/CAAIAO7/EgD4/yAAs/9NAOD/" +
            "4P9NALP/IAAgAKX/iABf/6EAeP9bAOD/+P8VAOD/JgDa/yAA6/8IANr/bABf/74AQv+hAJT/JgDr/z0Apf9sAJT/WwDD/xUAFQDD/1sAlP9sAKX/PQDr/yYA" +
            "lP+hAEL/vgBf/2wA2v8IAOv/IADa/yYA4P8VAPj/4P9bAHj/oQBf/4gApf8gACAAIAAgACAAIAAgACAAIADg/+D/4P/g/+D/4P/g/+D/4P/g/+D/4P/g/+D/" +
            "4P/g/yAAIAAgACAAIAAgACAAIAAgACAAIAAgACAAIAAgACAA4P/g/+D/4P/g/+D/4P/g/+D/4P/g/+D/4P/g/+D/4P8gACAAIAAgACAAIAAgACAA4P/l/+7/" +
            "+v8GABIAGwAgACAAGwASAAYA+v/u/+X/4P8gABsAEgAGAPr/7v/l/+D/4P/l/+7/+v8GABIAGwAgAOD/5f/u//r/BgASABsAIAAgABsAEgAGAPr/7v/l/+D/" +
            "IAAbABIABgD6/+7/5f/g/+D/5f/u//r/BgASABsAIAAgAA0A8//g/+D/8/8NACAA4P/z/w0AIAAgAA0A8//g/+D/8/8NACAAIAANAPP/4P8gAA0A8//g/+D/" +
            "8/8NACAAIAANAPP/4P/g//P/DQAgAOD/8/8NACAAIAANAPP/4P/g//P/DQAgACAADQDz/+D/IAANAPP/4P/g//P/DQAgAOD/CAAmABUA6//a//j/IAAgAPj/" +
            "2v/r/xUAJgAIAOD/IAD4/9r/6/8VACYACADg/+D/CAAmABUA6//a//j/IADg/wgAJgAVAOv/2v/4/yAAIAD4/9r/6/8VACYACADg/yAA+P/a/+v/FQAmAAgA" +
            "4P/g/wgAJgAVAOv/2v/4/yAAIADg/+D/IAAgAOD/4P8gAOD/IAAgAOD/4P8gACAA4P/g/yAAIADg/+D/IAAgAOD/IADg/+D/IAAgAOD/4P8gACAA4P/g/yAA" +
            "IADg/+D/IADg/yAAIADg/+D/IAAgAOD/4P8gACAA4P/g/yAAIADg/yAA4P/g/yAAIADg/+D/IADg/zgA9f/Q/zAACwDI/yAAIADI/wsAMADQ//X/OADg/yAA" +
            "yP8LADAA0P/1/zgA4P/g/zgA9f/Q/zAACwDI/yAA4P84APX/0P8wAAsAyP8gACAAyP8LADAA0P/1/zgA4P8gAMj/CwAwAND/9f84AOD/4P84APX/0P8wAAsA" +
            "yP8gACAAs/9NAOD/4P9NALP/IADg/00As/8gACAAs/9NAOD/4P9NALP/IAAgALP/TQDg/yAAs/9NAOD/4P9NALP/IAAgALP/TQDg/+D/TQCz/yAA4P9NALP/" +
            "IAAgALP/TQDg/+D/TQCz/yAAIACz/00A4P8gALP/TQDg/+D/TQCz/yAA4P9bAHj/oQBf/4gApf8gACAApf+IAF//oQB4/1sA4P8gAKX/iABf/6EAeP9bAOD/" +
            "4P9bAHj/oQBf/4gApf8gAOD/WwB4/6EAX/+IAKX/IAAgAKX/iABf/6EAeP9bAOD/IACl/4gAX/+hAHj/WwDg/+D/WwB4/6EAX/+IAKX/IADg/+D/4P/g/+D/" +
            "4P/g/+D/OAA4ADgAOAA4ADgAOAA4APX/9f/1//X/9f/1//X/9f/Q/9D/0P/Q/9D/0P/Q/9D/MAAwADAAMAAwADAAMAAwAAsACwALAAsACwALAAsACwDI/8j/" +
            "yP/I/8j/yP/I/8j/IAAgACAAIAAgACAAIAAgACAAGwASAAYA+v/u/+X/4P/I/9D/4P/1/wsAIAAwADgACwAKAAYAAgD+//r/9v/1/zAAKQAbAAoA9v/l/9f/" +
            "0P/Q/9f/5f/2/woAGwApADAA9f/2//r//v8CAAYACgALADgAMAAgAAsA9f/g/9D/yP/g/+X/7v/6/wYAEgAbACAA4P/z/w0AIAAgAA0A8//g/zgAFwDp/8j/" +
            "yP/p/xcAOAD1//v/BQALAAsABQD7//X/0P/s/xQAMAAwABQA7P/Q/zAAFADs/9D/0P/s/xQAMAALAAUA+//1//X/+/8FAAsAyP/p/xcAOAA4ABcA6f/I/yAA" +
            "DQDz/+D/4P/z/w0AIAAgAPj/2v/r/xUAJgAIAOD/yP8NAEMAJgDa/73/8/84AAsA/f/z//j/CAANAAMA9f8wAPX/yP/g/yAAOAALAND/0P8LADgAIADg/8j/" +
            "9f8wAPX/AwANAAgA+P/z//3/CwA4APP/vf/a/yYAQwANAMj/4P8IACYAFQDr/9r/+P8gAOD/IAAgAOD/4P8gACAA4P84AMj/yP84ADgAyP/I/zgA9f8LAAsA" +
            "9f/1/wsACwD1/9D/MAAwAND/0P8wADAA0P8wAND/0P8wADAA0P/Q/zAACwD1//X/CwALAPX/9f8LAMj/OAA4AMj/yP84ADgAyP8gAOD/4P8gACAA4P/g/yAA" +
            "IADI/wsAMADQ//X/OADg/8j/ZADs/6v/VQAUAJz/OAALAOz/BAARAO///P8UAPX/MACr/xEASAC4/+//VQDQ/9D/VQDv/7j/SAARAKv/MAD1/xQA/P/v/xEA" +
            "BADs/wsAOACc/xQAVQCr/+z/ZADI/+D/OAD1/9D/MAALAMj/IADg/00As/8gACAAs/9NAOD/OAB4/4gAyP/I/4gAeP84APX/GwDl/wsACwDl/xsA9f/Q/3QA" +
            "jP8wADAAjP90AND/MACM/3QA0P/Q/3QAjP8wAAsA5f8bAPX/9f8bAOX/CwDI/4gAeP84ADgAeP+IAMj/IACz/00A4P/g/00As/8gACAApf+IAF//oQB4/1sA" +
            "4P/I/6EAD/8cAeT+8QBf/zgACwDg/zAAyP84AND/IAD1/zAAeP/MAA//8QA0/4gA0P/Q/4gANP/xAA//zAB4/zAA9f8gAND/OADI/zAA4P8LADgAX//xAOT+" +
            "HAEP/6EAyP/g/1sAeP+hAF//iACl/yAAIAAgACAAIAAgACAAIAAgALP/s/+z/7P/s/+z/7P/s/9NAE0ATQBNAE0ATQBNAE0A4P/g/+D/4P/g/+D/4P/g/+D/" +
            "4P/g/+D/4P/g/+D/4P9NAE0ATQBNAE0ATQBNAE0As/+z/7P/s/+z/7P/s/+z/yAAIAAgACAAIAAgACAAIADg/+X/7v/6/wYAEgAbACAATQBBACwADwDx/9T/" +
            "v/+z/7P/v//U//H/DwAsAEEATQAgABsAEgAGAPr/7v/l/+D/IAAbABIABgD6/+7/5f/g/7P/v//U//H/DwAsAEEATQBNAEEALAAPAPH/1P+//7P/4P/l/+7/" +
            "+v8GABIAGwAgACAADQDz/+D/4P/z/w0AIACz/+D/IABNAE0AIADg/7P/TQAgAOD/s/+z/+D/IABNAOD/8/8NACAAIAANAPP/4P/g//P/DQAgACAADQDz/+D/" +
            "TQAgAOD/s/+z/+D/IABNALP/4P8gAE0ATQAgAOD/s/8gAA0A8//g/+D/8/8NACAA4P8IACYAFQDr/9r/+P8gAE0A7v+l/8z/NABbABIAs/+z/xIAWwA0AMz/" +
            "pf/u/00AIAD4/9r/6/8VACYACADg/yAA+P/a/+v/FQAmAAgA4P+z/xIAWwA0AMz/pf/u/00ATQDu/6X/zP80AFsAEgCz/+D/CAAmABUA6//a//j/IAAgAOD/" +
            "4P8gACAA4P/g/yAAs/9NAE0As/+z/00ATQCz/00As/+z/00ATQCz/7P/TQDg/yAAIADg/+D/IAAgAOD/4P8gACAA4P/g/yAAIADg/00As/+z/00ATQCz/7P/" +
            "TQCz/00ATQCz/7P/TQBNALP/IADg/+D/IAAgAOD/4P8gAOD/OAD1/9D/MAALAMj/IABNAHj/GwB0AIz/5f+IALP/s/+IAOX/jP90ABsAeP9NACAAyP8LADAA" +
            "0P/1/zgA4P8gAMj/CwAwAND/9f84AOD/s/+IAOX/jP90ABsAeP9NAE0AeP8bAHQAjP/l/4gAs//g/zgA9f/Q/zAACwDI/yAAIACz/00A4P/g/00As/8gALP/" +
            "uwBF/00ATQBF/7sAs/9NAEX/uwCz/7P/uwBF/00A4P9NALP/IAAgALP/TQDg/+D/TQCz/yAAIACz/00A4P9NAEX/uwCz/7P/uwBF/00As/+7AEX/TQBNAEX/" +
            "uwCz/yAAs/9NAOD/4P9NALP/IADg/1sAeP+hAF//iACl/yAATQAk/0kBfP6EAbf+3ACz/7P/3AC3/oQBfP5JAST/TQAgAKX/iABf/6EAeP9bAOD/IACl/4gA" +
            "X/+hAHj/WwDg/7P/3AC3/oQBfP5JAST/TQBNACT/SQF8/oQBt/7cALP/4P9bAHj/oQBf/4gApf8gAOD/4P/g/+D/4P/g/+D/4P9bAFsAWwBbAFsAWwBbAFsA" +
            "eP94/3j/eP94/3j/eP94/6EAoQChAKEAoQChAKEAoQBf/1//X/9f/1//X/9f/1//iACIAIgAiACIAIgAiACIAKX/pf+l/6X/pf+l/6X/pf8gACAAIAAgACAA" +
            "IAAgACAAIAAbABIABgD6/+7/5f/g/6X/s//M/+7/EgA0AE0AWwCIAHQATQAbAOX/s/+M/3j/X/94/6X/4P8gAFsAiAChAKEAiABbACAA4P+l/3j/X/94/4z/" +
            "s//l/xsATQB0AIgAWwBNADQAEgDu/8z/s/+l/+D/5f/u//r/BgASABsAIADg//P/DQAgACAADQDz/+D/WwAmANr/pf+l/9r/JgBbAHj/yP84AIgAiAA4AMj/" +
            "eP+hAEMAvf9f/1//vf9DAKEAX/+9/0MAoQChAEMAvf9f/4gAOADI/3j/eP/I/zgAiACl/9r/JgBbAFsAJgDa/6X/IAANAPP/4P/g//P/DQAgACAA+P/a/+v/" +
            "FQAmAAgA4P+l/xUAbAA9AMP/lP/r/1sAiADg/1//pf9bAKEAIAB4/1//JgC+AGwAlP9C/9r/oQChANr/Qv+U/2wAvgAmAF//eP8gAKEAWwCl/1//4P+IAFsA" +
            "6/+U/8P/PQBsABUApf/g/wgAJgAVAOv/2v/4/yAA4P8gACAA4P/g/yAAIADg/1sApf+l/1sAWwCl/6X/WwB4/4gAiAB4/3j/iACIAHj/oQBf/1//oQChAF//" +
            "X/+hAF//oQChAF//X/+hAKEAX/+IAHj/eP+IAIgAeP94/4gApf9bAFsApf+l/1sAWwCl/yAA4P/g/yAAIADg/+D/IAAgAMj/CwAwAND/9f84AOD/pf+hAOD/" +
            "eP+IACAAX/9bAIgAD/8wAMwANP/Q//EAeP9f/xwByP8P//EAOADk/qEAoQDk/jgA8QAP/8j/HAFf/3j/8QDQ/zT/zAAwAA//iABbAF//IACIAHj/4P+hAKX/" +
            "4P84APX/0P8wAAsAyP8gAOD/TQCz/yAAIACz/00A4P9bACT/3ACl/6X/3AAk/1sAeP9JAbf+iACIALf+SQF4/6EAfP6EAV//X/+EAXz+oQBf/4QBfP6hAKEA" +
            "fP6EAV//iAC3/kkBeP94/0kBt/6IAKX/3AAk/1sAWwAk/9wApf8gALP/TQDg/+D/TQCz/yAAIACl/4gAX/+hAHj/WwDg/6X/BAF8/soBNv6EAfz+WwCIAHz+" +
            "RQJS/a4Cu/2EAXj/X//KAVL9KQPX/K4CNv6hAKEANv6uAtf8KQNS/coBX/94/4QBu/2uAlL9RQJ8/ogAWwD8/oQBNv7KAXz+BAGl/+D/WwB4/6EAX/+IAKX/" +
            "IAA=");

        private static short[] ReadSingleIdct(string encoded)
        {
            byte[] bytes = Convert.FromBase64String(encoded);
            var values = new short[bytes.Length / 2];
            for (int i = 0; i < values.Length; i++)
                values[i] = (short)(bytes[2 * i] | (bytes[2 * i + 1] << 8));
            return values;
        }
    }
}
