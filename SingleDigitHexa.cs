public static class SingleDigitHexa
    {
        private static Dictionary<byte, char> singlefieldHexa = new Dictionary<byte, char>();
        /// <summary>
        /// Other characters if needed is at the end
        /// </summary>
        static SingleDigitHexa()
        {
            singlefieldHexa[0x00] = '\'';
            singlefieldHexa[0x01] = '-';
            singlefieldHexa[0x02] = '­';
            singlefieldHexa[0x03] = '!';
            singlefieldHexa[0x04] = '#';
            singlefieldHexa[0x05] = '$';
            singlefieldHexa[0x06] = '%';
            singlefieldHexa[0x07] = '&';
            singlefieldHexa[0x08] = '(';
            singlefieldHexa[0x09] = ')';
            singlefieldHexa[0x0A] = '*';
            singlefieldHexa[0x0B] = ',';
            singlefieldHexa[0x0C] = '.';
            singlefieldHexa[0x0D] = '/';
            singlefieldHexa[0x0E] = ':';
            singlefieldHexa[0x0F] = ';';
            singlefieldHexa[0x10] = '?';
            singlefieldHexa[0x11] = '@';
            singlefieldHexa[0x12] = '[';
            singlefieldHexa[0x13] = '\\';
            singlefieldHexa[0x14] = ']';
            singlefieldHexa[0x15] = '^';
            singlefieldHexa[0x16] = '_';
            singlefieldHexa[0x17] = '`';
            singlefieldHexa[0x18] = '{';
            singlefieldHexa[0x19] = '|';
            singlefieldHexa[0x1A] = '}';
            singlefieldHexa[0x1B] = '~';
            singlefieldHexa[0x1C] = '¡';
            singlefieldHexa[0x1D] = '¦';
            singlefieldHexa[0x1E] = '¨';
            singlefieldHexa[0x1F] = '¯';
            singlefieldHexa[0x20] = '´';
            singlefieldHexa[0x21] = '¸';
            singlefieldHexa[0x22] = '¿';
            singlefieldHexa[0x23] = 'ǃ';
            singlefieldHexa[0x24] = '+';
            singlefieldHexa[0x25] = '<';
            singlefieldHexa[0x26] = '=';
            singlefieldHexa[0x27] = '>';
            singlefieldHexa[0x28] = '±';
            singlefieldHexa[0x29] = '«';
            singlefieldHexa[0x2A] = '»';
            singlefieldHexa[0x2B] = '×';
            singlefieldHexa[0x2C] = '÷';
            singlefieldHexa[0x2D] = 'ǀ';
            singlefieldHexa[0x2E] = 'ǁ';
            singlefieldHexa[0x2F] = 'ǂ';
            singlefieldHexa[0x30] = '¢';
            singlefieldHexa[0x31] = '£';
            singlefieldHexa[0x32] = '¤';
            singlefieldHexa[0x33] = '¥';
            singlefieldHexa[0x34] = '§';
            singlefieldHexa[0x35] = '©';
            singlefieldHexa[0x36] = '¬';
            singlefieldHexa[0x37] = '®';
            singlefieldHexa[0x38] = '°';
            singlefieldHexa[0x39] = 'µ';
            singlefieldHexa[0x3A] = '¶';
            singlefieldHexa[0x3B] = '·';
            singlefieldHexa[0x3C] = '0';
            singlefieldHexa[0x3D] = '¼';
            singlefieldHexa[0x3E] = '½';
            singlefieldHexa[0x3F] = '¾';
            singlefieldHexa[0x40] = '¹';
            singlefieldHexa[0x41] = '2';
            singlefieldHexa[0x42] = '3';
            singlefieldHexa[0x43] = '4';
            singlefieldHexa[0x44] = '5';
            singlefieldHexa[0x45] = '6';
            singlefieldHexa[0x46] = '7';
            singlefieldHexa[0x47] = '8';
            singlefieldHexa[0x48] = '9';
            singlefieldHexa[0x49] = 'a';
            singlefieldHexa[0x4A] = 'ª';
            singlefieldHexa[0x4B] = 'á';
            singlefieldHexa[0x4C] = 'à';
            singlefieldHexa[0x4D] = 'â';
            singlefieldHexa[0x4E] = 'ä';
            singlefieldHexa[0x4F] = 'ǎ';
            singlefieldHexa[0x50] = 'ă';
            singlefieldHexa[0x51] = 'ā';
            singlefieldHexa[0x52] = 'ã';
            singlefieldHexa[0x53] = 'å';
            singlefieldHexa[0x54] = 'ą';
            singlefieldHexa[0x55] = 'æ';
            singlefieldHexa[0x56] = 'ǣ';
            singlefieldHexa[0x57] = 'b';
            singlefieldHexa[0x58] = 'ƀ';
            singlefieldHexa[0x59] = 'ɓ';
            singlefieldHexa[0x5A] = 'ƃ';
            singlefieldHexa[0x5B] = 'ƅ';
            singlefieldHexa[0x5C] = 'c';
            singlefieldHexa[0x5D] = 'ć';
            singlefieldHexa[0x5E] = 'ċ';
            singlefieldHexa[0x5F] = 'ĉ';
            singlefieldHexa[0x60] = 'č';
            singlefieldHexa[0x61] = 'ç';
            singlefieldHexa[0x62] = 'ƈ';
            singlefieldHexa[0x63] = 'ɔ';
            singlefieldHexa[0x64] = 'd';
            singlefieldHexa[0x65] = 'ď';
            singlefieldHexa[0x66] = 'ƌ';
            singlefieldHexa[0x67] = 'ɗ';
            singlefieldHexa[0x68] = 'ɖ';
            singlefieldHexa[0x69] = 'ð';
            singlefieldHexa[0x6A] = 'ƍ';
            singlefieldHexa[0x6B] = 'ǆ';
            singlefieldHexa[0x6C] = 'e';
            singlefieldHexa[0x6D] = 'é';
            singlefieldHexa[0x6E] = 'è';
            singlefieldHexa[0x6F] = 'ė';
            singlefieldHexa[0x70] = 'ê';
            singlefieldHexa[0x71] = 'ë';
            singlefieldHexa[0x72] = 'ě';
            singlefieldHexa[0x73] = 'ĕ';
            singlefieldHexa[0x74] = 'ē';
            singlefieldHexa[0x75] = 'ę';
            singlefieldHexa[0x76] = 'ɛ';
            singlefieldHexa[0x77] = 'ʃ';
            singlefieldHexa[0x78] = 'ǝ';
            singlefieldHexa[0x79] = 'ə';
            singlefieldHexa[0x7A] = 'f';
            singlefieldHexa[0x7B] = 'ƒ';
            singlefieldHexa[0x7C] = 'g';
            singlefieldHexa[0x7D] = 'ġ';
            singlefieldHexa[0x7E] = 'ĝ';
            singlefieldHexa[0x7F] = 'ğ';
            singlefieldHexa[0x80] = 'ģ';
            singlefieldHexa[0x81] = 'ɠ';
            singlefieldHexa[0x82] = 'ɣ';
            singlefieldHexa[0x83] = 'h';
            singlefieldHexa[0x84] = 'ĥ';
            singlefieldHexa[0x85] = 'ħ';
            singlefieldHexa[0x86] = 'ƕ';
            singlefieldHexa[0x87] = 'i';
            singlefieldHexa[0x88] = 'ı';
            singlefieldHexa[0x89] = 'í';
            singlefieldHexa[0x8A] = 'ì';
            singlefieldHexa[0x8B] = 'î';
            singlefieldHexa[0x8C] = 'ï';
            singlefieldHexa[0x8D] = 'ǐ';
            singlefieldHexa[0x8E] = 'ĭ';
            singlefieldHexa[0x8F] = 'ī';
            singlefieldHexa[0x90] = 'ĩ';
            singlefieldHexa[0x91] = 'į';
            singlefieldHexa[0x92] = 'ɨ';
            singlefieldHexa[0x93] = 'ɩ';
            singlefieldHexa[0x94] = 'ĳ';
            singlefieldHexa[0x95] = 'j';
            singlefieldHexa[0x96] = 'ĵ';
            singlefieldHexa[0x97] = 'k';
            singlefieldHexa[0x98] = 'ĸ';
            singlefieldHexa[0x99] = 'ķ';
            singlefieldHexa[0x9A] = 'ƙ';
            singlefieldHexa[0x9B] = 'l';
            singlefieldHexa[0x9C] = 'ĺ';
            singlefieldHexa[0x9D] = 'ŀ';
            singlefieldHexa[0x9E] = 'ľ';
            singlefieldHexa[0x9F] = 'ļ';
            singlefieldHexa[0xA0] = 'ƚ';
            singlefieldHexa[0xA1] = 'ł';
            singlefieldHexa[0xA2] = 'ƛ';
            singlefieldHexa[0xA3] = 'ǉ';
            singlefieldHexa[0xA4] = 'm';
            singlefieldHexa[0xA5] = 'ɯ';
            singlefieldHexa[0xA6] = 'n';
            singlefieldHexa[0xA7] = 'ń';
            singlefieldHexa[0xA8] = 'ň';
            singlefieldHexa[0xA9] = 'ñ';
            singlefieldHexa[0xAA] = 'ņ';
            singlefieldHexa[0xAB] = 'ɲ';
            singlefieldHexa[0xAC] = 'ŉ';
            singlefieldHexa[0xAD] = 'ƞ';
            singlefieldHexa[0xAE] = 'ǌ';
            singlefieldHexa[0xAF] = 'ŋ';
            singlefieldHexa[0xB0] = 'o';
            singlefieldHexa[0xB1] = 'º';
            singlefieldHexa[0xB2] = 'ó';
            singlefieldHexa[0xB3] = 'ò';
            singlefieldHexa[0xB4] = 'ô';
            singlefieldHexa[0xB5] = 'ö';
            singlefieldHexa[0xB6] = 'ǒ';
            singlefieldHexa[0xB7] = 'ŏ';
            singlefieldHexa[0xB8] = 'ō';
            singlefieldHexa[0xB9] = 'õ';
            singlefieldHexa[0xBA] = 'ő';
            singlefieldHexa[0xBB] = 'ɵ';
            singlefieldHexa[0xBC] = 'ø';
            singlefieldHexa[0xBD] = 'ơ';
            singlefieldHexa[0xBE] = 'ƣ';
            singlefieldHexa[0xBF] = 'œ';
            singlefieldHexa[0xC0] = 'p';
            singlefieldHexa[0xC1] = 'ƥ';
            singlefieldHexa[0xC2] = 'q';
            singlefieldHexa[0xC3] = 'r';
            singlefieldHexa[0xC4] = 'ŕ';
            singlefieldHexa[0xC5] = 'ř';
            singlefieldHexa[0xC6] = 'ŗ';
            singlefieldHexa[0xC7] = 's';
            singlefieldHexa[0xC8] = 'ś';
            singlefieldHexa[0xC9] = 'ŝ';
            singlefieldHexa[0xCA] = 'š';
            singlefieldHexa[0xCB] = 'ş';
            singlefieldHexa[0xCC] = 'ƪ';
            singlefieldHexa[0xCD] = 'ƨ';
            singlefieldHexa[0xCE] = 'ß';
            singlefieldHexa[0xCF] = 'ſ';
            singlefieldHexa[0xD0] = 't';
            singlefieldHexa[0xD1] = 'ť';
            singlefieldHexa[0xD2] = 'ţ';
            singlefieldHexa[0xD3] = 'ƭ';
            singlefieldHexa[0xD4] = 'ƫ';
            singlefieldHexa[0xD5] = 'ʈ';
            singlefieldHexa[0xD6] = 'þ';
            singlefieldHexa[0xD7] = 'ŧ';
            singlefieldHexa[0xD8] = 'u';
            singlefieldHexa[0xD9] = 'ú';
            singlefieldHexa[0xDA] = 'ù';
            singlefieldHexa[0xDB] = 'û';
            singlefieldHexa[0xDC] = 'ü';
            singlefieldHexa[0xDD] = 'ǔ';
            singlefieldHexa[0xDE] = 'ŭ';
            singlefieldHexa[0xDF] = 'ū';
            singlefieldHexa[0xE0] = 'ů';
            singlefieldHexa[0xE1] = 'ų';
            singlefieldHexa[0xE2] = 'ű';
            singlefieldHexa[0xE3] = 'ǖ';
            singlefieldHexa[0xE4] = 'ư';
            singlefieldHexa[0xE5] = 'ʊ';
            singlefieldHexa[0xE6] = 'v';
            singlefieldHexa[0xE7] = 'ʋ';
            singlefieldHexa[0xE8] = 'w';
            singlefieldHexa[0xE9] = 'ŵ';
            singlefieldHexa[0xEA] = 'ƿ';
            singlefieldHexa[0xEB] = 'x';
            singlefieldHexa[0xEC] = 'y';
            singlefieldHexa[0xED] = 'ý';
            singlefieldHexa[0xEE] = 'ŷ';
            singlefieldHexa[0xEF] = 'ÿ';
            singlefieldHexa[0xF0] = 'ƴ';
            singlefieldHexa[0xF1] = 'z';
            singlefieldHexa[0xF2] = 'ź';
            singlefieldHexa[0xF3] = 'ż';
            singlefieldHexa[0xF4] = 'ž';
            singlefieldHexa[0xF5] = 'ƶ';
            singlefieldHexa[0xF6] = 'ʒ';
            singlefieldHexa[0xF7] = 'ƹ';
            singlefieldHexa[0xF8] = 'ƺ';
            singlefieldHexa[0xF9] = 'ƾ';
            singlefieldHexa[0xFA] = 'ǘ';
            singlefieldHexa[0xFB] = 'ǚ';
            singlefieldHexa[0xFC] = 'ǜ';
            singlefieldHexa[0xFD] = 'ǟ';
            singlefieldHexa[0xFE] = 'ǡ';
            singlefieldHexa[0xFF] = 'ǥ';
        }
        public static string ToSingleCharHex(this byte[] bytes)
        {
            char[] c = new char[bytes.Length];

            for (int bx = 0; bx < bytes.Length; ++bx)
            {

                c[bx] = singlefieldHexa[bytes[bx]];
            }

            return new string(c);
        }
        #region Other Characters
        /*
        ǧ
        ǩ
        ǫ
        ǭ
        ǯ
        ǰ
        ǳ
        ǵ
        ǹ
        ǻ
        ǽ
        ǿ
        ȁ
        ȃ
        ȅ
        ȇ
        ȉ
        ȋ
        ȍ
        ȏ
        ȑ
        ȓ
        ȕ
        ȗ
        ș
        ț
        ȝ
        ȟ
        ȡ
        ȣ
        ȥ
        ȧ
        ȩ
        ȫ
        ȭ
        ȯ
        ȱ
        ȳ
        ȴ
        ȵ
        ȶ
        ȷ
        ȸ
        ȹ
        ⱥ
        ȼ
        ⱦ
        ȿ
        ɀ
        ɂ
        ʉ
        ʌ
        ɇ
        ɉ
        ɋ
        ɍ
        ɏ
        ɐ
        ɑ
        ɒ
        ɕ
        ɘ
        ɚ
        ɜ
        ɝ
        ɞ
        ɟ
        ɡ
        ɢ
        ɤ
        ɥ
        ɦ
        ɧ
        ɪ
        ɫ
        ɬ
        ɭ
        ɮ
        ɰ
        ɱ
        ɳ
        ɴ
        ɶ
        ɷ
        ɸ
        ɹ
        ɺ
        ɻ
        ɼ
        ɽ
        ɾ
        ɿ
        ʀ
        ʁ
        ʂ
        ʄ
        ʅ
        ʆ
        ʇ
        ʍ
        ʎ
        ʏ
        ʐ
        ʑ
        ʓ
        ʕ
        ʖ
        ʗ
        ʘ
        ʙ
        ʚ
        ʛ
        ʜ
        ʝ
        ʞ
        ʟ
        ʠ
        ʡ
        ʢ
        ʣ
        ʤ
        ʥ
        ʦ
        ʧ
        ʨ
        ʩ
        ʪ
        ʫ
        ʬ
        ʭ
        ʮ
        ʯ
        ʹ
        ʺ
        ʻ
        ʼ
        ʽ
        ʾ
        ʿ
        ˀ
        ˁ
        ˂
        ˃
        ˄
        ˅
        ˇ
        ˈ
        ˉ
        ˊ
        ˌ
        ˍ
        ˎ
        ˏ
        ː
        ˑ
        ˒
        ˓
        ˔
        ˕
        ˖
        ˗
        ˘
        ˙
        ˚
        ˛
        ˜
        ˝
        ˞
        ˟
        ˤ
        ˥
        ˦
        ˧
        ˨
        ˩
        ˪
        ˫
        ˬ
        ˭
        ˮ
        ˯
        ˰
        ˱
        ˲
        ˳
        ˴
        ˵
        ˶
        ˷
        ˸
        ˹
        ˺
        ˻
        ˼
        ˽
        ˿
        Ͱ
        Ͳ
        ͵
        Ͷ
        ͺ
        ͻ
        ͼ
        ͽ
        ΄
        ΅
        ά
        έ
        ή
        ί
        ό
        ύ
        ώ
        ΐ
        α
        β
        γ
        δ
        ε
        ζ
        η
        θ
        ι
        κ
        λ
        μ
        ν
        ξ
        ο
        π
        ρ
        σ
        τ
        υ
        φ
        χ
        ψ
        ω
        ϊ
        ϋ
        ΰ
        Ϗ
        ϐ
        ϑ
        ϕ
        ϖ
        Ϙ
        ϛ
        ϝ
        ϟ
        ϡ
        ϣ
        ϥ
        ϧ
        ϩ
        Ϸ
        Ϻ
        ϼ
        ѐ
        ё
        ђ
        ѓ
        є
        ѕ
        і
        ї
        ј
        љ
        њ
        ћ
        ќ
        ѝ
        ў
        џ
        а
        б
        в
        г
        д
        е
        ж
        з
        и
        й
        к
        л
        м
        н
        о
        п
        р
        с
        т
        у
        ф
        х
        ц
        ч
        ш
        щ
        ъ
        ы
        ь
        э
        ю
        я
        ѡ
        ѣ
        ѥ
        ѧ
        ѩ
        ѫ
        ѭ
        ѯ
        ѱ
        ѳ
        ѵ
        ѷ
        ѹ
        ѻ
        ѽ
        ѿ
        ҁ
        ҂
         ҈
         ҉
        ҋ
        ҍ
        ҏ
        ґ
        ғ
        ҕ
        җ
        ҙ
        қ
        ҝ
        ҟ
        ҡ
        ң
        ҥ
        ҧ
        ҩ
        ҫ
        ҭ
        ү
        ұ
        ҳ
        ҵ
        ҷ
        ҹ
        һ
        ҽ
        ҿ
        ӏ
        ӂ
        ӄ
        ӆ
        ӈ
        ӊ
        ӌ
        ӎ
        ӑ
        ӓ
        ӕ
        ӗ
        ә
        ӛ
        ӝ
        ӟ
        ӡ
        ӣ
        ӥ
        ӧ
        ө
        ӫ
        ӭ
        ӯ
        ӱ
        ӳ
        ӵ
        ӷ
        ӹ
        ӻ
        ӽ
        ӿ
        ԁ
        ԃ
        ԅ
        ԇ
        ԉ
        ԋ
        ԍ
        ԏ
        ԑ
        ԓ
        Ԕ
        Ԗ
        Ԙ
        Ԛ
        Ԝ
        Ԟ
        Ԡ
        Ԣ
        Ԧ
        ա
        բ
        գ
        դ
        ե
        զ
        է
        ը
        թ
        ժ
        ի
        լ
        խ
        ծ
        կ
        հ
        ձ
        ղ
        ճ
        մ
        յ
        ն
        շ
        ո
        չ
        պ
        ջ
        ռ
        ս
        վ
        տ
        ր
        ց
        ւ
        փ
        ք
        օ
        ֆ
        ՚
        ՛
        ՜
        ՝
        ՞
        ՟
        և
        ։
        ־
        ׀
         ׁ
         ׂ
        ׃
        ׆
        א
        ב
        ג
        ד
        ה
        ו
        ז
        ח
        ט
        י
        ך
        ל
        ם
        ן
        ס
        ע
        ף
        ץ
        ק
        ר
        ש
        ת
        װ
        ױ
        ײ
        ׳
        ״
        ؀
        ؁
        ؂
        ؃
        ؆
        ؇
        ؈
        ؉
        ؊
        ؋
        ،
        ؍
        ؎
        ؏
         ؐ
         ؑ
         ؒ
         ؓ
         ؔ
         ؕ
        ؛
        ؟
        ؠ
        ء
        آ
        ؤ
        ئ
        ب
        ة
        ت
        ث
        ج
        ح
        خ
        د
        ذ
        ر
        ز
        س
        ش
        ص
        ض
        ط
        ظ
        ع
        غ
        ػ
        ؼ
        ؽ
        ؾ
        ؿ
        ف
        ق
        ك
        ل
        م
        ن
        ه
        و
        ى
        ي
         ً
         ٌ
         ٍ
         َ
         ُ
         ِ
         ّ
         ْ
         ٓ
         ٔ
         ٕ
         ٖ
         ٗ
         ٘
         ٙ
         ٚ
         ٛ
         ٜ
         ٝ
         ٞ
        ٟ
        ٠
        ١
        ٢
        ٣
        ٤
        ٥
        ٦
        ٧
        ٨
        ٩
        ٪
        ٫
        ٬
        ٭
        ٮ
        ٯ
         ٰ
        ٱ
        ٲ
        ٳ
        ٴ
        ٵ
        ٶ
        ٷ
        ٸ
        ٹ
        ٺ
        ٻ
        ټ
        ٽ
        پ
        ٿ
        ڀ
        ځ
        ڂ
        ڃ
        ڄ
        څ
        چ
        ڇ
        ڈ
        ډ
        ڊ
        ڋ
        ڌ
        ڍ
        ڎ
        ڏ
        ڐ
        ڑ
        ڒ
        ړ
        ڔ
        ڕ
        ږ
        ڗ
        ژ
        ڙ
        ښ
        ڛ
        ڜ
        ڝ
        ڞ
        ڟ
        ڠ
        ڡ
        ڢ
        ڣ
        ڤ
        ڥ
        ڦ
        ڧ
        ڨ
        ک
        ڪ
        ګ
        ڬ
        ڭ
        ڮ
        گ
        ڰ
        ڱ
        ڲ
        ڳ
        ڴ
        ڵ
        ڶ
        ڷ
        ڸ
        ڹ
        ں
        ڻ
        ڼ
        ڽ
        ھ
        ڿ
        ۀ
        ہ
        ۂ
        ۃ
        ۄ
        ۅ
        ۆ
        ۇ
        ۈ
        ۉ
        ۊ
        ۋ
        ی
        ۍ
        ێ
        ۏ
        */
        #endregion
    }
