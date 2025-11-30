using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class GraphDllCrypto
{
	public const string string_0 = "graph.dll";

	public const int int_0 = 83968;

	public const int int_1 = 346112;

	public const int int_2 = 608256;

	public const int int_3 = 883939;

	public static byte[] byte_0 = new byte[256];

	public static byte[] byte_1 = new byte[256];

	public static byte[] byte_2 = new byte[256];

	public static void smethod_0()
	{
		byte_1[0] = 180;
		byte_1[1] = 136;
		byte_1[2] = 148;
		byte_1[3] = 74;
		byte_1[4] = 77;
		byte_1[5] = 198;
		byte_1[6] = 3;
		byte_1[7] = 194;
		byte_1[8] = 208;
		byte_1[9] = 181;
		byte_1[10] = 11;
		byte_1[11] = 105;
		byte_1[12] = 220;
		byte_1[13] = 202;
		byte_1[14] = 95;
		byte_1[15] = 246;
		byte_1[16] = 223;
		byte_1[17] = 14;
		byte_1[18] = 243;
		byte_1[19] = 93;
		byte_1[20] = 134;
		byte_1[21] = 196;
		byte_1[22] = 13;
		byte_1[23] = 151;
		byte_1[24] = 119;
		byte_1[25] = 76;
		byte_1[26] = 159;
		byte_1[27] = 165;
		byte_1[28] = 67;
		byte_1[29] = 71;
		byte_1[30] = 212;
		byte_1[31] = 211;
		byte_1[32] = 150;
		byte_1[33] = 252;
		byte_1[34] = 233;
		byte_1[35] = 58;
		byte_1[36] = 177;
		byte_1[37] = 250;
		byte_1[38] = 62;
		byte_1[39] = 27;
		byte_1[40] = byte.MaxValue;
		byte_1[41] = 173;
		byte_1[42] = 4;
		byte_1[43] = 147;
		byte_1[44] = 25;
		byte_1[45] = 26;
		byte_1[46] = 204;
		byte_1[47] = 72;
		byte_1[48] = 75;
		byte_1[49] = 97;
		byte_1[50] = 242;
		byte_1[51] = 102;
		byte_1[52] = 41;
		byte_1[53] = 104;
		byte_1[54] = 182;
		byte_1[55] = 83;
		byte_1[56] = 162;
		byte_1[57] = 53;
		byte_1[58] = 47;
		byte_1[59] = 149;
		byte_1[60] = 20;
		byte_1[61] = 117;
		byte_1[62] = 231;
		byte_1[63] = 66;
		byte_1[64] = 201;
		byte_1[65] = 96;
		byte_1[66] = 235;
		byte_1[67] = 161;
		byte_1[68] = 160;
		byte_1[69] = 109;
		byte_1[70] = 143;
		byte_1[71] = 213;
		byte_1[72] = 5;
		byte_1[73] = 139;
		byte_1[74] = 234;
		byte_1[75] = 110;
		byte_1[76] = 128;
		byte_1[77] = 131;
		byte_1[78] = 118;
		byte_1[79] = 90;
		byte_1[80] = 103;
		byte_1[81] = 69;
		byte_1[82] = 15;
		byte_1[83] = 99;
		byte_1[84] = 125;
		byte_1[85] = 39;
		byte_1[86] = 121;
		byte_1[87] = 65;
		byte_1[88] = 138;
		byte_1[89] = 40;
		byte_1[90] = 240;
		byte_1[91] = 167;
		byte_1[92] = 129;
		byte_1[93] = 200;
		byte_1[94] = 192;
		byte_1[95] = 152;
		byte_1[96] = 18;
		byte_1[97] = 84;
		byte_1[98] = 32;
		byte_1[99] = 0;
		byte_1[100] = 137;
		byte_1[101] = 168;
		byte_1[102] = 49;
		byte_1[103] = 116;
		byte_1[104] = 91;
		byte_1[105] = 38;
		byte_1[106] = 237;
		byte_1[107] = 135;
		byte_1[108] = 22;
		byte_1[109] = 193;
		byte_1[110] = 24;
		byte_1[111] = 43;
		byte_1[112] = 113;
		byte_1[113] = 172;
		byte_1[114] = 23;
		byte_1[115] = 7;
		byte_1[116] = 82;
		byte_1[117] = 60;
		byte_1[118] = 123;
		byte_1[119] = 87;
		byte_1[120] = 52;
		byte_1[121] = 221;
		byte_1[122] = 245;
		byte_1[123] = 29;
		byte_1[124] = 236;
		byte_1[125] = 158;
		byte_1[126] = 89;
		byte_1[127] = 122;
		byte_1[128] = 56;
		byte_1[129] = 254;
		byte_1[130] = 33;
		byte_1[131] = 88;
		byte_1[132] = 140;
		byte_1[133] = 216;
		byte_1[134] = 184;
		byte_1[135] = 86;
		byte_1[136] = 126;
		byte_1[137] = 45;
		byte_1[138] = 108;
		byte_1[139] = 130;
		byte_1[140] = 174;
		byte_1[141] = 226;
		byte_1[142] = 94;
		byte_1[143] = 57;
		byte_1[144] = 224;
		byte_1[145] = 48;
		byte_1[146] = 175;
		byte_1[147] = 191;
		byte_1[148] = 157;
		byte_1[149] = 206;
		byte_1[150] = 51;
		byte_1[151] = 244;
		byte_1[152] = 16;
		byte_1[153] = 203;
		byte_1[154] = 30;
		byte_1[155] = 44;
		byte_1[156] = 12;
		byte_1[157] = 55;
		byte_1[158] = 190;
		byte_1[159] = 70;
		byte_1[160] = 205;
		byte_1[161] = 178;
		byte_1[162] = 106;
		byte_1[163] = 188;
		byte_1[164] = 241;
		byte_1[165] = 31;
		byte_1[166] = 19;
		byte_1[167] = 249;
		byte_1[168] = 101;
		byte_1[169] = 35;
		byte_1[170] = 132;
		byte_1[171] = 247;
		byte_1[172] = 142;
		byte_1[173] = 232;
		byte_1[174] = 112;
		byte_1[175] = 179;
		byte_1[176] = 127;
		byte_1[177] = 42;
		byte_1[178] = 164;
		byte_1[179] = 217;
		byte_1[180] = 229;
		byte_1[181] = 197;
		byte_1[182] = 114;
		byte_1[183] = 156;
		byte_1[184] = 238;
		byte_1[185] = 222;
		byte_1[186] = 215;
		byte_1[187] = 207;
		byte_1[188] = 189;
		byte_1[189] = 79;
		byte_1[190] = 251;
		byte_1[191] = 153;
		byte_1[192] = 28;
		byte_1[193] = 230;
		byte_1[194] = 59;
		byte_1[195] = 50;
		byte_1[196] = 46;
		byte_1[197] = 253;
		byte_1[198] = 120;
		byte_1[199] = 1;
		byte_1[200] = 73;
		byte_1[201] = 228;
		byte_1[202] = 210;
		byte_1[203] = 2;
		byte_1[204] = 186;
		byte_1[205] = 37;
		byte_1[206] = 85;
		byte_1[207] = 115;
		byte_1[208] = 144;
		byte_1[209] = 146;
		byte_1[210] = 214;
		byte_1[211] = 185;
		byte_1[212] = 170;
		byte_1[213] = 227;
		byte_1[214] = 155;
		byte_1[215] = 68;
		byte_1[216] = 219;
		byte_1[217] = 107;
		byte_1[218] = 199;
		byte_1[219] = 10;
		byte_1[220] = 154;
		byte_1[221] = 187;
		byte_1[222] = 9;
		byte_1[223] = 169;
		byte_1[224] = 80;
		byte_1[225] = 195;
		byte_1[226] = 166;
		byte_1[227] = 17;
		byte_1[228] = 63;
		byte_1[229] = 209;
		byte_1[230] = 78;
		byte_1[231] = 141;
		byte_1[232] = 124;
		byte_1[233] = 111;
		byte_1[234] = 218;
		byte_1[235] = 81;
		byte_1[236] = 34;
		byte_1[237] = 183;
		byte_1[238] = 248;
		byte_1[239] = 8;
		byte_1[240] = 54;
		byte_1[241] = 61;
		byte_1[242] = 64;
		byte_1[243] = 145;
		byte_1[244] = 100;
		byte_1[245] = 133;
		byte_1[246] = 21;
		byte_1[247] = 225;
		byte_1[248] = 98;
		byte_1[249] = 92;
		byte_1[250] = 171;
		byte_1[251] = 176;
		byte_1[252] = 36;
		byte_1[253] = 239;
		byte_1[254] = 6;
		byte_1[255] = 163;
		int num = 0;
		do
		{
			byte_2[byte_1[num]] = (byte)num;
			num++;
		}
		while (num <= 255);
	}

	public static void smethod_1()
	{
		byte_0[0] = 0;
		byte_0[1] = 16;
		byte_0[2] = 32;
		byte_0[3] = 48;
		byte_0[4] = 1;
		byte_0[5] = 17;
		byte_0[6] = 33;
		byte_0[7] = 49;
		byte_0[8] = 2;
		byte_0[9] = 18;
		byte_0[10] = 34;
		byte_0[11] = 50;
		byte_0[12] = 3;
		byte_0[13] = 19;
		byte_0[14] = 35;
		byte_0[15] = 51;
		byte_0[16] = 64;
		byte_0[17] = 80;
		byte_0[18] = 96;
		byte_0[19] = 112;
		byte_0[20] = 65;
		byte_0[21] = 81;
		byte_0[22] = 97;
		byte_0[23] = 113;
		byte_0[24] = 66;
		byte_0[25] = 82;
		byte_0[26] = 98;
		byte_0[27] = 114;
		byte_0[28] = 67;
		byte_0[29] = 83;
		byte_0[30] = 99;
		byte_0[31] = 115;
		byte_0[32] = 128;
		byte_0[33] = 144;
		byte_0[34] = 160;
		byte_0[35] = 176;
		byte_0[36] = 129;
		byte_0[37] = 145;
		byte_0[38] = 161;
		byte_0[39] = 177;
		byte_0[40] = 130;
		byte_0[41] = 146;
		byte_0[42] = 162;
		byte_0[43] = 178;
		byte_0[44] = 131;
		byte_0[45] = 147;
		byte_0[46] = 163;
		byte_0[47] = 179;
		byte_0[48] = 192;
		byte_0[49] = 208;
		byte_0[50] = 224;
		byte_0[51] = 240;
		byte_0[52] = 193;
		byte_0[53] = 209;
		byte_0[54] = 225;
		byte_0[55] = 241;
		byte_0[56] = 194;
		byte_0[57] = 210;
		byte_0[58] = 226;
		byte_0[59] = 242;
		byte_0[60] = 195;
		byte_0[61] = 211;
		byte_0[62] = 227;
		byte_0[63] = 243;
		byte_0[64] = 4;
		byte_0[65] = 20;
		byte_0[66] = 36;
		byte_0[67] = 52;
		byte_0[68] = 5;
		byte_0[69] = 21;
		byte_0[70] = 37;
		byte_0[71] = 53;
		byte_0[72] = 6;
		byte_0[73] = 22;
		byte_0[74] = 38;
		byte_0[75] = 54;
		byte_0[76] = 7;
		byte_0[77] = 23;
		byte_0[78] = 39;
		byte_0[79] = 55;
		byte_0[80] = 68;
		byte_0[81] = 84;
		byte_0[82] = 100;
		byte_0[83] = 116;
		byte_0[84] = 69;
		byte_0[85] = 85;
		byte_0[86] = 101;
		byte_0[87] = 117;
		byte_0[88] = 70;
		byte_0[89] = 86;
		byte_0[90] = 102;
		byte_0[91] = 118;
		byte_0[92] = 71;
		byte_0[93] = 87;
		byte_0[94] = 103;
		byte_0[95] = 119;
		byte_0[96] = 132;
		byte_0[97] = 148;
		byte_0[98] = 164;
		byte_0[99] = 180;
		byte_0[100] = 133;
		byte_0[101] = 149;
		byte_0[102] = 165;
		byte_0[103] = 181;
		byte_0[104] = 134;
		byte_0[105] = 150;
		byte_0[106] = 166;
		byte_0[107] = 182;
		byte_0[108] = 135;
		byte_0[109] = 151;
		byte_0[110] = 167;
		byte_0[111] = 183;
		byte_0[112] = 196;
		byte_0[113] = 212;
		byte_0[114] = 228;
		byte_0[115] = 244;
		byte_0[116] = 197;
		byte_0[117] = 213;
		byte_0[118] = 229;
		byte_0[119] = 245;
		byte_0[120] = 198;
		byte_0[121] = 214;
		byte_0[122] = 230;
		byte_0[123] = 246;
		byte_0[124] = 199;
		byte_0[125] = 215;
		byte_0[126] = 231;
		byte_0[127] = 247;
		byte_0[128] = 8;
		byte_0[129] = 24;
		byte_0[130] = 40;
		byte_0[131] = 56;
		byte_0[132] = 9;
		byte_0[133] = 25;
		byte_0[134] = 41;
		byte_0[135] = 57;
		byte_0[136] = 10;
		byte_0[137] = 26;
		byte_0[138] = 42;
		byte_0[139] = 58;
		byte_0[140] = 11;
		byte_0[141] = 27;
		byte_0[142] = 43;
		byte_0[143] = 59;
		byte_0[144] = 72;
		byte_0[145] = 88;
		byte_0[146] = 104;
		byte_0[147] = 120;
		byte_0[148] = 73;
		byte_0[149] = 89;
		byte_0[150] = 105;
		byte_0[151] = 121;
		byte_0[152] = 74;
		byte_0[153] = 90;
		byte_0[154] = 106;
		byte_0[155] = 122;
		byte_0[156] = 75;
		byte_0[157] = 91;
		byte_0[158] = 107;
		byte_0[159] = 123;
		byte_0[160] = 136;
		byte_0[161] = 152;
		byte_0[162] = 168;
		byte_0[163] = 184;
		byte_0[164] = 137;
		byte_0[165] = 153;
		byte_0[166] = 169;
		byte_0[167] = 185;
		byte_0[168] = 138;
		byte_0[169] = 154;
		byte_0[170] = 170;
		byte_0[171] = 186;
		byte_0[172] = 139;
		byte_0[173] = 155;
		byte_0[174] = 171;
		byte_0[175] = 187;
		byte_0[176] = 200;
		byte_0[177] = 216;
		byte_0[178] = 232;
		byte_0[179] = 248;
		byte_0[180] = 201;
		byte_0[181] = 217;
		byte_0[182] = 233;
		byte_0[183] = 249;
		byte_0[184] = 202;
		byte_0[185] = 218;
		byte_0[186] = 234;
		byte_0[187] = 250;
		byte_0[188] = 203;
		byte_0[189] = 219;
		byte_0[190] = 235;
		byte_0[191] = 251;
		byte_0[192] = 12;
		byte_0[193] = 28;
		byte_0[194] = 44;
		byte_0[195] = 60;
		byte_0[196] = 13;
		byte_0[197] = 29;
		byte_0[198] = 45;
		byte_0[199] = 61;
		byte_0[200] = 14;
		byte_0[201] = 30;
		byte_0[202] = 46;
		byte_0[203] = 62;
		byte_0[204] = 15;
		byte_0[205] = 31;
		byte_0[206] = 47;
		byte_0[207] = 63;
		byte_0[208] = 76;
		byte_0[209] = 92;
		byte_0[210] = 108;
		byte_0[211] = 124;
		byte_0[212] = 77;
		byte_0[213] = 93;
		byte_0[214] = 109;
		byte_0[215] = 125;
		byte_0[216] = 78;
		byte_0[217] = 94;
		byte_0[218] = 110;
		byte_0[219] = 126;
		byte_0[220] = 79;
		byte_0[221] = 95;
		byte_0[222] = 111;
		byte_0[223] = 127;
		byte_0[224] = 140;
		byte_0[225] = 156;
		byte_0[226] = 172;
		byte_0[227] = 188;
		byte_0[228] = 141;
		byte_0[229] = 157;
		byte_0[230] = 173;
		byte_0[231] = 189;
		byte_0[232] = 142;
		byte_0[233] = 158;
		byte_0[234] = 174;
		byte_0[235] = 190;
		byte_0[236] = 143;
		byte_0[237] = 159;
		byte_0[238] = 175;
		byte_0[239] = 191;
		byte_0[240] = 204;
		byte_0[241] = 220;
		byte_0[242] = 236;
		byte_0[243] = 252;
		byte_0[244] = 205;
		byte_0[245] = 221;
		byte_0[246] = 237;
		byte_0[247] = 253;
		byte_0[248] = 206;
		byte_0[249] = 222;
		byte_0[250] = 238;
		byte_0[251] = 254;
		byte_0[252] = 207;
		byte_0[253] = 223;
		byte_0[254] = 239;
		byte_0[255] = byte.MaxValue;
	}

	public static void smethod_2()
	{
		byte_0[0] = 0;
		byte_0[1] = 4;
		byte_0[2] = 8;
		byte_0[3] = 12;
		byte_0[4] = 64;
		byte_0[5] = 68;
		byte_0[6] = 72;
		byte_0[7] = 76;
		byte_0[8] = 128;
		byte_0[9] = 132;
		byte_0[10] = 136;
		byte_0[11] = 140;
		byte_0[12] = 192;
		byte_0[13] = 196;
		byte_0[14] = 200;
		byte_0[15] = 204;
		byte_0[16] = 1;
		byte_0[17] = 5;
		byte_0[18] = 9;
		byte_0[19] = 13;
		byte_0[20] = 65;
		byte_0[21] = 69;
		byte_0[22] = 73;
		byte_0[23] = 77;
		byte_0[24] = 129;
		byte_0[25] = 133;
		byte_0[26] = 137;
		byte_0[27] = 141;
		byte_0[28] = 193;
		byte_0[29] = 197;
		byte_0[30] = 201;
		byte_0[31] = 205;
		byte_0[32] = 2;
		byte_0[33] = 6;
		byte_0[34] = 10;
		byte_0[35] = 14;
		byte_0[36] = 66;
		byte_0[37] = 70;
		byte_0[38] = 74;
		byte_0[39] = 78;
		byte_0[40] = 130;
		byte_0[41] = 134;
		byte_0[42] = 138;
		byte_0[43] = 142;
		byte_0[44] = 194;
		byte_0[45] = 198;
		byte_0[46] = 202;
		byte_0[47] = 206;
		byte_0[48] = 3;
		byte_0[49] = 7;
		byte_0[50] = 11;
		byte_0[51] = 15;
		byte_0[52] = 67;
		byte_0[53] = 71;
		byte_0[54] = 75;
		byte_0[55] = 79;
		byte_0[56] = 131;
		byte_0[57] = 135;
		byte_0[58] = 139;
		byte_0[59] = 143;
		byte_0[60] = 195;
		byte_0[61] = 199;
		byte_0[62] = 203;
		byte_0[63] = 207;
		byte_0[64] = 16;
		byte_0[65] = 20;
		byte_0[66] = 24;
		byte_0[67] = 28;
		byte_0[68] = 80;
		byte_0[69] = 84;
		byte_0[70] = 88;
		byte_0[71] = 92;
		byte_0[72] = 144;
		byte_0[73] = 148;
		byte_0[74] = 152;
		byte_0[75] = 156;
		byte_0[76] = 208;
		byte_0[77] = 212;
		byte_0[78] = 216;
		byte_0[79] = 220;
		byte_0[80] = 17;
		byte_0[81] = 21;
		byte_0[82] = 25;
		byte_0[83] = 29;
		byte_0[84] = 81;
		byte_0[85] = 85;
		byte_0[86] = 89;
		byte_0[87] = 93;
		byte_0[88] = 145;
		byte_0[89] = 149;
		byte_0[90] = 153;
		byte_0[91] = 157;
		byte_0[92] = 209;
		byte_0[93] = 213;
		byte_0[94] = 217;
		byte_0[95] = 221;
		byte_0[96] = 18;
		byte_0[97] = 22;
		byte_0[98] = 26;
		byte_0[99] = 30;
		byte_0[100] = 82;
		byte_0[101] = 86;
		byte_0[102] = 90;
		byte_0[103] = 94;
		byte_0[104] = 146;
		byte_0[105] = 150;
		byte_0[106] = 154;
		byte_0[107] = 158;
		byte_0[108] = 210;
		byte_0[109] = 214;
		byte_0[110] = 218;
		byte_0[111] = 222;
		byte_0[112] = 19;
		byte_0[113] = 23;
		byte_0[114] = 27;
		byte_0[115] = 31;
		byte_0[116] = 83;
		byte_0[117] = 87;
		byte_0[118] = 91;
		byte_0[119] = 95;
		byte_0[120] = 147;
		byte_0[121] = 151;
		byte_0[122] = 155;
		byte_0[123] = 159;
		byte_0[124] = 211;
		byte_0[125] = 215;
		byte_0[126] = 219;
		byte_0[127] = 223;
		byte_0[128] = 32;
		byte_0[129] = 36;
		byte_0[130] = 40;
		byte_0[131] = 44;
		byte_0[132] = 96;
		byte_0[133] = 100;
		byte_0[134] = 104;
		byte_0[135] = 108;
		byte_0[136] = 160;
		byte_0[137] = 164;
		byte_0[138] = 168;
		byte_0[139] = 172;
		byte_0[140] = 224;
		byte_0[141] = 228;
		byte_0[142] = 232;
		byte_0[143] = 236;
		byte_0[144] = 33;
		byte_0[145] = 37;
		byte_0[146] = 41;
		byte_0[147] = 45;
		byte_0[148] = 97;
		byte_0[149] = 101;
		byte_0[150] = 105;
		byte_0[151] = 109;
		byte_0[152] = 161;
		byte_0[153] = 165;
		byte_0[154] = 169;
		byte_0[155] = 173;
		byte_0[156] = 225;
		byte_0[157] = 229;
		byte_0[158] = 233;
		byte_0[159] = 237;
		byte_0[160] = 34;
		byte_0[161] = 38;
		byte_0[162] = 42;
		byte_0[163] = 46;
		byte_0[164] = 98;
		byte_0[165] = 102;
		byte_0[166] = 106;
		byte_0[167] = 110;
		byte_0[168] = 162;
		byte_0[169] = 166;
		byte_0[170] = 170;
		byte_0[171] = 174;
		byte_0[172] = 226;
		byte_0[173] = 230;
		byte_0[174] = 234;
		byte_0[175] = 238;
		byte_0[176] = 35;
		byte_0[177] = 39;
		byte_0[178] = 43;
		byte_0[179] = 47;
		byte_0[180] = 99;
		byte_0[181] = 103;
		byte_0[182] = 107;
		byte_0[183] = 111;
		byte_0[184] = 163;
		byte_0[185] = 167;
		byte_0[186] = 171;
		byte_0[187] = 175;
		byte_0[188] = 227;
		byte_0[189] = 231;
		byte_0[190] = 235;
		byte_0[191] = 239;
		byte_0[192] = 48;
		byte_0[193] = 52;
		byte_0[194] = 56;
		byte_0[195] = 60;
		byte_0[196] = 112;
		byte_0[197] = 116;
		byte_0[198] = 120;
		byte_0[199] = 124;
		byte_0[200] = 176;
		byte_0[201] = 180;
		byte_0[202] = 184;
		byte_0[203] = 188;
		byte_0[204] = 240;
		byte_0[205] = 244;
		byte_0[206] = 248;
		byte_0[207] = 252;
		byte_0[208] = 49;
		byte_0[209] = 53;
		byte_0[210] = 57;
		byte_0[211] = 61;
		byte_0[212] = 113;
		byte_0[213] = 117;
		byte_0[214] = 121;
		byte_0[215] = 125;
		byte_0[216] = 177;
		byte_0[217] = 181;
		byte_0[218] = 185;
		byte_0[219] = 189;
		byte_0[220] = 241;
		byte_0[221] = 245;
		byte_0[222] = 249;
		byte_0[223] = 253;
		byte_0[224] = 50;
		byte_0[225] = 54;
		byte_0[226] = 58;
		byte_0[227] = 62;
		byte_0[228] = 114;
		byte_0[229] = 118;
		byte_0[230] = 122;
		byte_0[231] = 126;
		byte_0[232] = 178;
		byte_0[233] = 182;
		byte_0[234] = 186;
		byte_0[235] = 190;
		byte_0[236] = 242;
		byte_0[237] = 246;
		byte_0[238] = 250;
		byte_0[239] = 254;
		byte_0[240] = 51;
		byte_0[241] = 55;
		byte_0[242] = 59;
		byte_0[243] = 63;
		byte_0[244] = 115;
		byte_0[245] = 119;
		byte_0[246] = 123;
		byte_0[247] = 127;
		byte_0[248] = 179;
		byte_0[249] = 183;
		byte_0[250] = 187;
		byte_0[251] = 191;
		byte_0[252] = 243;
		byte_0[253] = 247;
		byte_0[254] = 251;
		byte_0[255] = byte.MaxValue;
	}

	public static void utmuBufTB(ref byte[] byte_3, ref byte[] byte_4, ref byte[] byte_5, int int_4)
	{
		int num = int_4 - 1;
		for (int i = 0; i <= num; i++)
		{
			byte b = (byte)((byte)(byte_3[i] << 4) & 0x30);
			byte b2 = (byte)((byte)((uint)byte_3[i] >> 2) & 3);
			byte b3 = (byte)((byte)(byte_3[i] << 2) & 0xC0);
			byte b4 = (byte)((byte)((uint)byte_3[i] >> 4) & 0xC);
			byte_5[i] = (byte)((b4 | b3 | b2 | b) ^ byte_4[i]);
		}
	}

	public static void smethod_3(byte[] byte_3, byte[] byte_4, byte[] byte_5, int int_4)
	{
		int num = int_4 - 1;
		for (int i = 0; i <= num; i++)
		{
			byte b = (byte)(byte_3[i] ^ byte_4[i]);
			byte b2 = (byte)((byte)((uint)b >> 4) & 3);
			byte b3 = (byte)((byte)(b << 2) & 0xC);
			byte b4 = (byte)((byte)((uint)b >> 2) & 0x30);
			byte b5 = (byte)((byte)(b << 4) & 0xC0);
			byte_5[i] = (byte)(b5 | b4 | b3 | b2);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static long smethod_4(string string_1, string string_2, ref string string_3, int int_4, long long_0 = 0L, long long_1 = -1L)
	{
		string_3 = "";
		string pathName = Application.StartupPath + "\\graph.dll";
		if (Operators.CompareString(FileSystem.Dir(string_1), "", false) == 0)
		{
			string_3 = "Input File not found";
			return -1L;
		}
		if (Operators.CompareString(FileSystem.Dir(pathName), "", false) == 0)
		{
			string_3 = "File graph.dll not found on the application path";
			return -1L;
		}
		long num = FileSystem.FileLen(string_1);
		if (FileSystem.FileLen(pathName) < num)
		{
			string_3 = "Error File size";
			return -1L;
		}
		if (long_1 == -1L)
		{
			long_1 = num;
		}
		long num2 = long_0;
		byte[] array = new byte[int_4 + 1];
		smethod_1();
		smethod_0();
		int i;
		while (true)
		{
			if (num2 < long_1)
			{
				byte[] array2 = FirmwareUtilities.smethod_35(string_1, num2, int_4);
				byte[] array3 = FirmwareUtilities.smethod_35(pathName, 83968L + num2, int_4);
				int num3 = int_4 - 1;
				for (i = 0; i <= num3; i++)
				{
					array[i] = (byte)(byte_0[array2[i]] ^ byte_2[array3[i]]);
				}
				string @string = ToolboxUtilities.smethod_5(ref array);
				i = Strings.InStr(1, @string, string_2, CompareMethod.Text);
				if (i != 0)
				{
					break;
				}
				num2 += int_4;
				continue;
			}
			return -1L;
		}
		return (long)Math.Round((double)num2 + (double)(i - 1) / 2.0);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static byte[] smethod_5(string string_1, long long_0, int int_4, bool bool_0, ref string string_2)
	{
		string text = Application.StartupPath + "\\graph.dll";
		string_2 = "";
		if (Operators.CompareString(FileSystem.Dir(string_1), "", false) == 0)
		{
			string_2 = "Input File not found";
			return new byte[1];
		}
		if (Operators.CompareString(FileSystem.Dir(text), "", false) == 0)
		{
			string_2 = "File graph.dll not found on the application path";
			return new byte[1];
		}
		long num = FileSystem.FileLen(string_1);
		if (FileSystem.FileLen(text) < num)
		{
			string_2 = "Error File size";
			return new byte[1];
		}
		byte[] array = new byte[int_4 - 1 + 1];
		FileStream fileStream = new FileStream(string_1, FileMode.Open);
		fileStream.Seek(long_0, SeekOrigin.Begin);
		fileStream.Read(array, 0, int_4);
		fileStream.Close();
		if (bool_0)
		{
			byte[] array2 = new byte[int_4 - 1 + 1];
			FileStream fileStream2 = new FileStream(text, FileMode.Open);
			fileStream2.Seek(83968L + long_0, SeekOrigin.Begin);
			fileStream2.Read(array2, 0, int_4);
			fileStream2.Close();
			smethod_1();
			smethod_0();
			byte[] array3 = new byte[int_4 - 1 + 1];
			int num2 = int_4 - 1;
			for (int i = 0; i <= num2; i++)
			{
				array3[i] = (byte)(byte_0[array[i]] ^ byte_2[array2[i]]);
			}
			return array3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_6(string string_1, long long_0, int int_4, bool bool_0, ref string string_2, byte[] byte_3)
	{
		byte[] array = new byte[int_4 - 1 + 1];
		byte[] array2 = new byte[int_4 - 1 + 1];
		string text = Application.StartupPath + "\\graph.dll";
		string_2 = "";
		if (Operators.CompareString(FileSystem.Dir(string_1), "", false) == 0)
		{
			string_2 = "Input File not found";
			return false;
		}
		if (Operators.CompareString(FileSystem.Dir(text), "", false) == 0)
		{
			string_2 = "File graph.dll not found on the application path";
			return false;
		}
		long num = FileSystem.FileLen(string_1);
		if (FileSystem.FileLen(text) < num)
		{
			string_2 = "Error File size";
			return false;
		}
		if (bool_0)
		{
			FileStream fileStream = new FileStream(text, FileMode.Open);
			fileStream.Seek(83968L + long_0, SeekOrigin.Begin);
			fileStream.Read(array, 0, int_4);
			fileStream.Close();
			smethod_2();
			smethod_0();
			int num2 = int_4 - 1;
			for (int i = 0; i <= num2; i++)
			{
				array2[i] = (byte)(byte_3[i] ^ byte_2[array[i]]);
				array2[i] = byte_0[array2[i]];
			}
		}
		else
		{
			array2 = byte_3;
		}
		FileStream fileStream2 = new FileStream(string_1, FileMode.Open);
		fileStream2.Seek(long_0, SeekOrigin.Begin);
		fileStream2.Write(array2, 0, int_4);
		fileStream2.Close();
		return true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static long smethod_7(string string_1, string string_2, ref string string_3, int int_4, long long_0 = 0L, long long_1 = -1L)
	{
		string_3 = "";
		string pathName = Application.StartupPath + "\\graph.dll";
		if (Operators.CompareString(FileSystem.Dir(string_1), "", false) == 0)
		{
			string_3 = "Input File not found";
			return -1L;
		}
		if (Operators.CompareString(FileSystem.Dir(pathName), "", false) == 0)
		{
			string_3 = "File graph.dll not found on the application path";
			return -1L;
		}
		long num = FileSystem.FileLen(string_1);
		if (FileSystem.FileLen(pathName) < num)
		{
			string_3 = "Error File size";
			return -1L;
		}
		if (long_1 == -1L)
		{
			long_1 = num;
		}
		long num2 = long_0;
		byte[] array = new byte[int_4 + 1];
		smethod_1();
		smethod_0();
		int i;
		while (true)
		{
			if (num2 < long_1)
			{
				byte[] array2 = FirmwareUtilities.smethod_35(string_1, num2, int_4);
				byte[] array3 = FirmwareUtilities.smethod_35(pathName, 346112L + num2, int_4);
				int num3 = int_4 - 1;
				for (i = 0; i <= num3; i++)
				{
					array[i] = (byte)(byte_0[array2[i]] ^ byte_2[array3[i]]);
				}
				string @string = ToolboxUtilities.smethod_5(ref array);
				i = Strings.InStr(1, @string, string_2, CompareMethod.Text);
				if (i != 0)
				{
					break;
				}
				num2 += int_4;
				continue;
			}
			return -1L;
		}
		return (long)Math.Round((double)num2 + (double)(i - 1) / 2.0);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static byte[] smethod_8(string string_1, long long_0, int int_4, bool bool_0, ref string string_2)
	{
		string text = Application.StartupPath + "\\graph.dll";
		string_2 = "";
		if (Operators.CompareString(FileSystem.Dir(string_1), "", false) == 0)
		{
			string_2 = "Input File not found";
			return new byte[1];
		}
		if (Operators.CompareString(FileSystem.Dir(text), "", false) == 0)
		{
			string_2 = "File graph.dll not found on the application path";
			return new byte[1];
		}
		long num = FileSystem.FileLen(string_1);
		if (FileSystem.FileLen(text) < num)
		{
			string_2 = "Error File size";
			return new byte[1];
		}
		byte[] array = new byte[int_4 - 1 + 1];
		FileStream fileStream = new FileStream(string_1, FileMode.Open);
		fileStream.Seek(long_0, SeekOrigin.Begin);
		fileStream.Read(array, 0, int_4);
		fileStream.Close();
		if (bool_0)
		{
			byte[] array2 = new byte[int_4 - 1 + 1];
			FileStream fileStream2 = new FileStream(text, FileMode.Open);
			fileStream2.Seek(346112L + long_0, SeekOrigin.Begin);
			fileStream2.Read(array2, 0, int_4);
			fileStream2.Close();
			smethod_1();
			smethod_0();
			byte[] array3 = new byte[int_4 - 1 + 1];
			int num2 = int_4 - 1;
			for (int i = 0; i <= num2; i++)
			{
				array3[i] = (byte)(byte_0[array[i]] ^ byte_2[array2[i]]);
			}
			return array3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_9(string string_1, long long_0, int int_4, bool bool_0, ref string string_2, byte[] byte_3)
	{
		byte[] array = new byte[int_4 - 1 + 1];
		byte[] array2 = new byte[int_4 - 1 + 1];
		string text = Application.StartupPath + "\\graph.dll";
		string_2 = "";
		if (Operators.CompareString(FileSystem.Dir(string_1), "", false) == 0)
		{
			string_2 = "Input File not found";
			return false;
		}
		if (Operators.CompareString(FileSystem.Dir(text), "", false) == 0)
		{
			string_2 = "File graph.dll not found on the application path";
			return false;
		}
		long num = FileSystem.FileLen(string_1);
		if (FileSystem.FileLen(text) < num)
		{
			string_2 = "Error File size";
			return false;
		}
		if (bool_0)
		{
			FileStream fileStream = new FileStream(text, FileMode.Open);
			fileStream.Seek(346112L + long_0, SeekOrigin.Begin);
			fileStream.Read(array, 0, int_4);
			fileStream.Close();
			smethod_2();
			smethod_0();
			int num2 = int_4 - 1;
			for (int i = 0; i <= num2; i++)
			{
				array2[i] = (byte)(byte_3[i] ^ byte_2[array[i]]);
				array2[i] = byte_0[array2[i]];
			}
		}
		else
		{
			array2 = byte_3;
		}
		FileStream fileStream2 = new FileStream(string_1, FileMode.Open);
		fileStream2.Seek(long_0, SeekOrigin.Begin);
		fileStream2.Write(array2, 0, int_4);
		fileStream2.Close();
		return true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static long smethod_10(string string_1, string string_2, ref string string_3, int int_4, long long_0 = 0L, long long_1 = -1L)
	{
		string_3 = "";
		string pathName = Application.StartupPath + "\\graph.dll";
		if (Operators.CompareString(FileSystem.Dir(string_1), "", false) == 0)
		{
			string_3 = "Input File not found";
			return -1L;
		}
		if (Operators.CompareString(FileSystem.Dir(pathName), "", false) == 0)
		{
			string_3 = "Error found";
			return -1L;
		}
		long num = FileSystem.FileLen(string_1);
		if (FileSystem.FileLen(pathName) < num)
		{
			string_3 = "Error File size";
			return -1L;
		}
		if (long_1 == -1L)
		{
			long_1 = num;
		}
		long num2 = long_0;
		byte[] array = new byte[int_4 + 1];
		smethod_1();
		smethod_0();
		int i;
		while (true)
		{
			if (num2 < long_1)
			{
				byte[] array2 = FirmwareUtilities.smethod_35(string_1, num2, int_4);
				byte[] array3 = FirmwareUtilities.smethod_35(pathName, 608256L + num2, int_4);
				int num3 = int_4 - 1;
				for (i = 0; i <= num3; i++)
				{
					array[i] = (byte)(byte_0[array2[i]] ^ byte_2[array3[i]]);
				}
				string @string = ToolboxUtilities.smethod_5(ref array);
				i = Strings.InStr(1, @string, string_2, CompareMethod.Text);
				if (i != 0)
				{
					break;
				}
				num2 += int_4;
				continue;
			}
			return -1L;
		}
		return (long)Math.Round((double)num2 + (double)(i - 1) / 2.0);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static byte[] smethod_11(string string_1, long long_0, int int_4, bool bool_0, ref string string_2)
	{
		string text = Application.StartupPath + "\\graph.dll";
		string_2 = "";
		if (Operators.CompareString(FileSystem.Dir(string_1), "", false) == 0)
		{
			string_2 = "Input File not found";
			return new byte[1];
		}
		if (Operators.CompareString(FileSystem.Dir(text), "", false) == 0)
		{
			string_2 = "File graph.dll not found on the application path";
			return new byte[1];
		}
		long num = FileSystem.FileLen(string_1);
		if (FileSystem.FileLen(text) < num)
		{
			string_2 = "Error File size";
			return new byte[1];
		}
		byte[] array = new byte[int_4 - 1 + 1];
		FileStream fileStream = new FileStream(string_1, FileMode.Open);
		fileStream.Seek(long_0, SeekOrigin.Begin);
		fileStream.Read(array, 0, int_4);
		fileStream.Close();
		if (bool_0)
		{
			byte[] array2 = new byte[int_4 - 1 + 1];
			FileStream fileStream2 = new FileStream(text, FileMode.Open);
			fileStream2.Seek(608256L + long_0, SeekOrigin.Begin);
			fileStream2.Read(array2, 0, int_4);
			fileStream2.Close();
			smethod_1();
			smethod_0();
			byte[] array3 = new byte[int_4 - 1 + 1];
			int num2 = int_4 - 1;
			for (int i = 0; i <= num2; i++)
			{
				array3[i] = (byte)(byte_0[array[i]] ^ byte_2[array2[i]]);
			}
			return array3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_12(string string_1, long long_0, int int_4, bool bool_0, ref string string_2, byte[] byte_3)
	{
		byte[] array = new byte[int_4 - 1 + 1];
		byte[] array2 = new byte[int_4 - 1 + 1];
		string text = Application.StartupPath + "\\graph.dll";
		string_2 = "";
		if (Operators.CompareString(FileSystem.Dir(string_1), "", false) == 0)
		{
			string_2 = "Input File not found";
			return false;
		}
		if (Operators.CompareString(FileSystem.Dir(text), "", false) == 0)
		{
			string_2 = "File graph.dll not found on the application path";
			return false;
		}
		long num = FileSystem.FileLen(string_1);
		if (FileSystem.FileLen(text) < num)
		{
			string_2 = "Error File size";
			return false;
		}
		if (bool_0)
		{
			FileStream fileStream = new FileStream(text, FileMode.Open);
			fileStream.Seek(608256L + long_0, SeekOrigin.Begin);
			fileStream.Read(array, 0, int_4);
			fileStream.Close();
			smethod_2();
			smethod_0();
			int num2 = int_4 - 1;
			for (int i = 0; i <= num2; i++)
			{
				array2[i] = (byte)(byte_3[i] ^ byte_2[array[i]]);
				array2[i] = byte_0[array2[i]];
			}
		}
		else
		{
			array2 = byte_3;
		}
		FileStream fileStream2 = new FileStream(string_1, FileMode.Open);
		fileStream2.Seek(long_0, SeekOrigin.Begin);
		fileStream2.Write(array2, 0, int_4);
		fileStream2.Close();
		return true;
	}
}
