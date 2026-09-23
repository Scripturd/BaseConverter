namespace BaseConverter.Common;

public static class NumberTextMap
{
    private static readonly Dictionary<int, string> TextMap = new()
    {
        [0] = "zero",
        [1] = "one",
        [2] = "two",
        [3] = "three",
        [4] = "four",
        [5] = "five",
        [6] = "six",
        [7] = "seven",
        [8] = "eight",
        [9] = "nine",
        [10] = "ten",
        [11] = "eleven",
        [12] = "twelve",
        [13] = "thirteen",
        [14] = "fourteen",
        [15] = "fifteen",
        [16] = "sixteen",
        [17] = "seventeen",
        [18] = "eighteen",
        [19] = "nineteen",
        [20] = "twenty",
        [21] = "twenty-one",
        [22] = "twenty-two",
        [23] = "twenty-three",
        [24] = "twenty-four",
        [25] = "twenty-five",
        [26] = "twenty-six",
        [27] = "twenty-seven",
        [28] = "twenty-eight",
        [29] = "twenty-nine",
        [30] = "thirty",
        [31] = "thirty-one",
        [32] = "thirty-two",
        [33] = "thirty-three",
        [34] = "thirty-four",
        [35] = "thirty-five",
        [36] = "thirty-six",
        [37] = "thirty-seven",
        [38] = "thirty-eight",
        [39] = "thirty-nine",
        [40] = "forty",
    };
    private static readonly Dictionary<int, string> SmallTextMap = new()
    {
        [0] = "ᴢᴇʀᴏ",
        [1] = "ᴏɴᴇ",
        [2] = "ᴛᴡᴏ",
        [3] = "ᴛʜʀᴇᴇ",
        [4] = "ꜰᴏᴜʀ",
        [5] = "ꜰɪᴠᴇ",
        [6] = "ꜱɪx",
        [7] = "ꜱᴇᴠᴇɴ",
        [8] = "ᴇɪɢʜᴛ",
        [9] = "ɴɪɴᴇ",
        [10] = "ᴛᴇɴ",
        [11] = "ᴇʟᴇᴠᴇɴ",
        [12] = "ᴛᴡᴇʟᴠᴇ",
        [13] = "ᴛʜɪʀᴛᴇᴇɴ",
        [14] = "ꜰᴏᴜʀᴛᴇᴇɴ",
        [15] = "ꜰɪꜰᴛᴇᴇɴ",
        [16] = "ꜱɪxᴛᴇᴇɴ",
        [17] = "ꜱᴇᴠᴇɴᴛᴇᴇɴ",
        [18] = "ᴇɪɢʜᴛᴇᴇɴ",
        [19] = "ɴɪɴᴇᴛᴇᴇɴ",
        [20] = "ᴛᴡᴇɴᴛʏ",
        [21] = "ᴛᴡᴇɴᴛʏ-ᴏɴᴇ",
        [22] = "ᴛᴡᴇɴᴛʏ-ᴛᴡᴏ",
        [23] = "ᴛᴡᴇɴᴛʏ-ᴛʜʀᴇᴇ",
        [24] = "ᴛᴡᴇɴᴛʏ-ꜰᴏᴜʀ",
        [25] = "ᴛᴡᴇɴᴛʏ-ꜰɪᴠᴇ",
        [26] = "ᴛᴡᴇɴᴛʏ-ꜱɪx",
        [27] = "ᴛᴡᴇɴᴛʏ-ꜱᴇᴠᴇɴ",
        [28] = "ᴛᴡᴇɴᴛʏ-ᴇɪɢʜᴛ",
        [29] = "ᴛᴡᴇɴᴛʏ-ɴɪɴᴇ",
        [30] = "ᴛʜɪʀᴛʏ",
        [31] = "ᴛʜɪʀᴛʏ-ᴏɴᴇ",
        [32] = "ᴛʜɪʀᴛʏ-ᴛᴡᴏ",
        [33] = "ᴛʜɪʀᴛʏ-ᴛʜʀᴇᴇ",
        [34] = "ᴛʜɪʀᴛʏ-ꜰᴏᴜʀ",
        [35] = "ᴛʜɪʀᴛʏ-ꜰɪᴠᴇ",
        [36] = "ᴛʜɪʀᴛʏ-ꜱɪx",
        [37] = "ᴛʜɪʀᴛʏ-ꜱᴇᴠᴇɴ",
        [38] = "ᴛʜɪʀᴛʏ-ᴇɪɢʜᴛ",
        [39] = "ᴛʜɪʀᴛʏ-ɴɪɴᴇ",
        [40] = "ꜰᴏʀᴛʏ",
    };

    public static string ToText(int source)
    {
        if (TextMap.TryGetValue(source, out string text))
            return text;

        return $"|?{source}?|";
    }
    public static string ToSmallText(int source)
    {
        if (SmallTextMap.TryGetValue(source, out string text))
            return text;

        return $"|?{source}?|";
    }
}