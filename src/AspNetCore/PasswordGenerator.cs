/*
 * PasswordGenerator.cs
 *
 *   Created: 2022-12-31-06:39:48
 *   Modified: 2022-12-31-06:39:49
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Identity;

using Microsoft.Extensions.Options;

public interface IPasswordGenerator
{
    string GeneratePassword();
}

public class PassphraseGeneratorOptions
{
    public int Length { get; set; } = 16;
    public int WordCount { get; set; } = 4;
    public int WordLength { get; set; } = 4;
    public string WordList { get; set; } = "https://raw.githubusercontent.com/The-Backroom/Passwords/main/wordlist.txt?token=GHSAT0AAAAAAB3V6HWPCDTXLEUOIWFY65TMY5QGDQQ";
}

public class PasswordGenerator : IPasswordGenerator
{
    private readonly PassphraseGeneratorOptions _options;

    public PasswordGenerator(IOptions<PassphraseGeneratorOptions> options)
    {
        _options = options.Value;
    }

    public string GeneratePassword()
    {
        var words = GetWords();
        var password = string.Join(" ", words);
        return password;
    }

    private string[] GetWords()
    {
        var words = new List<string>();
        var wordList = GetWordList();
        for (var i = 0; i < _options.WordCount; i++)
        {
            var index = Randoms.NextInt32(0, wordList.Length);
            var word = wordList[index];
            words.Add(word);
        }

        return words.ToArray();
    }

    private string[] GetWordList()
    {
        var client = new HttpClient();
        var response = client.GetAsync(_options.WordList).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        var wordList = content.Split(Environment.NewLine);
        return wordList;
    }

    private string GetRandomWord()
    {
        var wordList = GetWordList();
        var index = Randoms.NextInt32(0, wordList.Length);
        var word = wordList[index];
        return word;
    }

    const string Chars = "😀😃😄😁😆😅🤣😂🙂🙃🫠😉😊😇🥰😍🤩😘😗☺️😚😙🥲😋😛😜🤪😝🤑🤗🤭🫢🫣🤫🤔🫡🤐🤨😐😑😶🫥😶😏😒🙄😬😮🤥😌😔😪🤤😴😷🤒🤕🤢🤮🤧🥵🥶🥴😵😵🤯🤠🥳🥸😎🤓🧐😕🫤😟🙁☹️😮😯😲😳🥺🥹😦😧😨😰😥😢😭😱😖😣😞😓😩😫🥱😤😡😠🤬😈👿💀☠️💩🤡👹👺👻👽👾🤖😺😸😹😻😼😽🙀😿😾💋👋🤚🖐✋ 🖖🫱🫲🫳🫴👌🤌🤏✌️🤞🫰🤟🤘🤙👈👉👆🖕👇☝️🫵👍👎✊ 👊🤛🤜👏🙌🫶👐🤲🤝🙏✍️💅🤳💪🦾🦿🦵🦶👂🦻👃🧠🫀🫁🦷🦴👀👁👅👄🫦👶🧒👦👧🧑👱👨🧔👨👨👨👨👩👩🧑👩🧑👩🧑👩🧑👱👱🧓👴👵🙍🙍🙍🙎🙎🙎🙅🙅🙅🙆🙆🙆💁💁💁🙋🙋🙋🧏🧏🧏🙇🙇🙇🤦🤦🤦🤷🤷🤷🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩👮👮👮🕵🕵🕵💂💂💂🥷👷👷👷🫅🤴👸👳👳👳👲🧕🤵🤵🤵👰👰👰🤰🫃🫄🤱👩👨🧑👼🎅🤶🧑🦸🦸🦸🦹🦹🦹🧙🧙🧙🧚🧚🧚🧛🧛🧛🧜🧜🧜🧝🧝🧝🧞🧞🧞🧟🧟🧟🧌💆💆💆💇💇💇🚶🚶🚶🧍🧍🧍🧎🧎🧎🧑👨👩🧑👨👩🧑👨👩🏃🏃🏃💃🕺🕴👯👯👯🧖🧖🧖🧘🧑👭👫👬💏👩👨👩💑👩👨👩👪👨👨👨👨👨👨👨👨👨👨👩👩👩👩👩👨👨👨👨👨👩👩👩👩👩🗣👤👥🫂👣🧳🌂☂️🎃🧵🧶👓🕶🥽🥼🦺👔👕👖🧣🧤🧥🧦👗👘🥻🩱🩲🩳👙👚👛👜👝🎒🩴👞👟🥾🥿👠👡🩰👢👑👒🎩🎓🧢🪖⛑️💄💍💼🩸🙈🙉🙊💥💫💦💨🐵🐒🦍🦧🐶🐕🦮🐕🐩🐺🦊🦝🐱🐈🐈🦁🐯🐅🐆🐴🐎🦄🦓🦌🦬🐮🐂🐃🐄🐷🐖🐗🐽🐏🐑🐐🐪🐫🦙🦒🐘🦣🦏🦛🐭🐁🐀🐹🐰🐇🐿🦫🦔🦇🐻🐻🐨🐼🦥🦦🦨🦘🦡🐾🦃🐔🐓🐣🐤🐥🐦🐧🕊🦅🦆🦢🦉🦤🪶🦩🦚🦜🐸🐊🐢🦎🐍🐲🐉🦕🦖🐳🐋🐬🦭🐟🐠🐡🦈🐙🐚🪸🐌🦋🐛🐜🐝🪲🐞🦗🪳🕷🕸🦂🦟🪰🪱🦠💐🌸💮🪷🏵🌹🥀🌺🌻🌼🌷🌱🪴🌲🌳🌴🌵🌾🌿☘️🍀🍁🍂🍃🪹🪺🍄🌰🦀🦞🦐🦑🌍🌎🌏🌐🪨🌑🌒🌓🌔🌕🌖🌗🌘🌙🌚🌛🌜☀️🌝🌞⭐ 🌟🌠☁️⛅ ⛈️🌤🌥🌦🌧🌨🌩🌪🌫🌬🌈☂️☔ ⚡ ❄️☃️⛄ ☄️🔥💧🌊🎄✨ 🎋🎍🫧🍇🍈🍉🍊🍋🍌🍍🥭🍎🍏🍐🍑🍒🍓🫐🥝🍅🫒🥥🥑🍆🥔🥕🌽🌶🫑🥒🥬🥦🧄🧅🍄🥜🫘🌰🍞🥐🥖🫓🥨🥯🥞🧇🧀🍖🍗🥩🥓🍔🍟🍕🌭🥪🌮🌯🫔🥙🧆🥚🍳🥘🍲🫕🥣🥗🍿🧈🧂🥫🍱🍘🍙🍚🍛🍜🍝🍠🍢🍣🍤🍥🥮🍡🥟🥠🥡🦪🍦🍧🍨🍩🍪🎂🍰🧁🥧🍫🍬🍭🍮🍯🍼🥛☕ 🫖🍵🍶🍾🍷🍸🍹🍺🍻🥂🥃🫗🥤🧋🧃🧉🧊🥢🍽🍴🥄🫙🕴🧗🧗🧗🤺🏇⛷️🏂🏌🏌🏌🏄🏄🏄🚣🚣🚣🏊🏊🏊⛹️⛹️⛹️🏋🏋🏋🚴🚴🚴🚵🚵🚵🤸🤸🤸🤼🤼🤼🤽🤽🤽🤾🤾🤾🤹🤹🤹🧘🧘🧘🎪🛹🛼🛶🎗🎟🎫🎖🏆🏅🥇🥈🥉⚽ ⚾ 🥎🏀🏐🏈🏉🎾🥏🎳🏏🏑🏒🥍🏓🏸🥊🥋🥅⛳ ⛸️🎣🎽🎿🛷🥌🎯🎱🎮🎰🎲🧩🪩♟️🎭🎨🧵🧶🎼🎤🎧🎷🪗🎸🎹🎺🎻🥁🪘🎬🏹🚣🗾🏔⛰️🌋🗻🏕🏖🏜🏝🏞🏟🏛🏗🛖🏘🏚🏠🏡🏢🏣🏤🏥🏦🏨🏩🏪🏫🏬🏭🏯🏰💒🗼🗽⛪ 🕌🛕🕍⛩️🕋⛲ ⛺ 🌁🌃🏙🌄🌅🌆🌇🌉🎠🛝🎡🎢🚂🚃🚄🚅🚆🚇🚈🚉🚊🚝🚞🚋🚌🚍🚎🚐🚑🚒🚓🚔🚕🚖🚗🚘🚙🛻🚚🚛🚜🏎🏍🛵🛺🚲🛴🚏🛣🛤⛽ 🛞🚨🚥🚦🚧⚓ 🛟⛵ 🚤🛳⛴️🛥🚢✈️🛩🛫🛬🪂💺🚁🚟🚠🚡🛰🚀🛸🪐🌠🌌⛱️🎆🎇🎑💴💵💶💷🗿🛂🛃🛄🛅💌🕳💣🛀🛌🔪🏺🗺🧭🧱💈🦽🦼🛢🛎🧳⌛ ⏳ ⌚ ⏰ ⏱️⏲️🕰🌡⛱️🧨🎈🎉🎊🎎🎏🎐🧧🎀🎁🤿🪀🪁🔮🪄🧿🪬🕹🧸🪅🪆🖼🧵🪡🧶🪢🛍📿💎📯🎙🎚🎛📻🪕📱📲☎️📞📟📠🔋🔌💻🖥🖨⌨️🖱🖲💽💾💿📀🧮🎥🎞📽📺📷📸📹📼🔍🔎🕯💡🔦🏮🪔📔📕📖📗📘📙📚📓📒📃📜📄📰🗞📑🔖🏷💰🪙💴💵💶💷💸💳🧾✉️📧📨📩📤📥📦📫📪📬📭📮🗳✏️✒️🖋🖊🖌🖍📝📁📂🗂📅📆🗒🗓📇📈📉📊📋📌📍📎🖇📏📐✂️🗃🗄🗑🔒🔓🔏🔐🔑🗝🔨🪓⛏️⚒️🛠🗡⚔️🔫🪃🛡🪚🔧🪛🔩⚙️🗜⚖️🦯🔗⛓️🪝🧰🧲🪜⚗️🧪🧫🧬🔬🔭📡💉🩸💊🩹🩼🩺🚪🪞🪟🛏🛋🪑🚽🪠🚿🛁🪤🪒🧴🧷🧹🧺🧻🪣🧼🪥🧽🧯🛒🚬⚰️🪦⚱️🗿🪧🪪🚰💘💝💖💗💓💞💕💟❣️💔❤️❤️❤️🧡💛💚💙💜🤎🖤🤍💯💢💬👁🗨🗯💭💤💮♨️💈🛑🕛🕧🕐🕜🕑🕝🕒🕞🕓🕟🕔🕠🕕🕡🕖🕢🕗🕣🕘🕤🕙🕥🕚🕦🌀♠️♥️♦️♣️🃏🀄🎴🔇🔈🔉🔊📢📣📯🔔🔕🎵🎶💹🛗🏧🚮🚰♿ 🚹🚺🚻🚼🚾⚠️🚸⛔ 🚫🚳🚭🚯🚱🚷📵🔞☢️☣️⬆️↗️➡️↘️⬇️↙️⬅️↖️↕️↔️↩️↪️⤴️⤵️🔃🔄🔙🔚🔛🔜🔝🛐⚛️🕉✡️☸️☯️✝️☦️☪️☮️🕎🔯♈ ♉ ♊ ♋ ♌ ♍ ♎ ♏ ♐ ♑ ♒ ♓ ⛎ 🔀🔁🔂▶️⏩ ⏭️⏯️◀️⏪ ⏮️🔼⏫ 🔽⏬ ⏸️⏹️⏺️⏏️🎦🔅🔆📶📳📴♀️♂️✖️➕ ➖ ➗ 🟰♾️‼️⁉️❓ ❔ ❕ ❗ 〰️💱💲⚕️♻️⚜️🔱📛🔰⭕ ✅ ☑️✔️❌ ❎ ➰ ➿ 〽️✳️✴️❇️©️®️™️#️*️0️1️2️3️4️5️6️7️8️9️🔟🔠🔡🔢🔣🔤🅰🆎🅱🆑🆒🆓ℹ️🆔Ⓜ️🆕🆖🅾🆗🅿🆘🆙🆚🈁🈂🈷🈶🈯🉐🈹🈚🈲🉑🈸🈴🈳㊗️㊙️🈺🈵🔴🟠🟡🟢🔵🟣🟤⚫ ⚪ 🟥🟧🟨🟩🟦🟪🟫⬛ ⬜ ◼️◻️◾ ◽ ▪️▫️🔶🔷🔸🔹🔺🔻💠🔘🔳🔲🏁🚩🎌🏴🏳️ 🏳️‍🏳️‍🏴‍☠🇦🇨🇦🇩🇦🇪🇦🇫🇦🇬🇦🇮🇦🇱🇦🇲🇦🇴🇦🇶🇦🇷🇦🇸🇦🇹🇦🇺🇦🇼🇦🇽🇦🇿🇧🇦🇧🇧🇧🇩🇧🇪🇧🇫🇧🇬🇧🇭🇧🇮🇧🇯🇧🇱🇧🇲🇧🇳🇧🇴🇧🇶🇧🇷🇧🇸🇧🇹🇧🇻🇧🇼🇧🇾🇧🇿🇨🇦🇨🇨🇨🇩🇨🇫🇨🇬🇨🇭🇨🇮🇨🇰🇨🇱🇨🇲🇨🇳🇨🇴🇨🇵🇨🇷🇨🇺🇨🇻🇨🇼🇨🇽🇨🇾🇨🇿🇩🇪🇩🇬🇩🇯🇩🇰🇩🇲🇩🇴🇩🇿🇪🇦🇪🇨🇪🇪🇪🇬🇪🇭🇪🇷🇪🇸🇪🇹🇪🇺🇫🇮🇫🇯🇫🇰🇫🇲🇫🇴🇫🇷🇬🇦🇬🇧🇬🇩🇬🇪🇬🇫🇬🇬🇬🇭🇬🇮🇬🇱🇬🇲🇬🇳🇬🇵🇬🇶🇬🇷🇬🇸🇬🇹🇬🇺🇬🇼🇬🇾🇭🇰🇭🇲🇭🇳🇭🇷🇭🇹🇭🇺🇮🇨🇮🇩🇮🇪🇮🇱🇮🇲🇮🇳🇮🇴🇮🇶🇮🇷🇮🇸🇮🇹🇯🇪🇯🇲🇯🇴🇯🇵🇰🇪🇰🇬🇰🇭🇰🇮🇰🇲🇰🇳🇰🇵🇰🇷🇰🇼🇰🇾🇰🇿🇱🇦🇱🇧🇱🇨🇱🇮🇱🇰🇱🇷🇱🇸🇱🇹🇱🇺🇱🇻🇱🇾🇲🇦🇲🇨🇲🇩🇲🇪🇲🇫🇲🇬🇲🇭🇲🇰🇲🇱🇲🇲🇲🇳🇲🇴🇲🇵🇲🇶🇲🇷🇲🇸🇲🇹🇲🇺🇲🇻🇲🇼🇲🇽🇲🇾🇲🇿🇳🇦🇳🇨🇳🇪🇳🇫🇳🇬🇳🇮🇳🇱🇳🇴🇳🇵🇳🇷🇳🇺🇳🇿🇴🇲🇵🇦🇵🇪🇵🇫🇵🇬🇵🇭🇵🇰🇵🇱🇵🇲🇵🇳🇵🇷🇵🇸🇵🇹🇵🇼🇵🇾🇶🇦🇷🇪🇷🇴🇷🇸🇷🇺🇷🇼🇸🇦🇸🇧🇸🇨🇸🇩🇸🇪🇸🇬🇸🇭🇸🇮🇸🇯🇸🇰🇸🇱🇸🇲🇸🇳🇸🇴🇸🇷🇸🇸🇸🇹🇸🇻🇸🇽🇸🇾🇸🇿🇹🇦🇹🇨🇹🇩🇹🇫🇹🇬🇹🇭🇹🇯🇹🇰🇹🇱🇹🇲🇹🇳🇹🇴🇹🇷🇹🇹🇹🇻🇹🇼🇹🇿🇺🇦🇺🇬🇺🇲🇺🇳🇺🇸🇺🇾🇺🇿🇻🇦🇻🇨🇻🇪🇻🇬🇻🇮🇻🇳🇻🇺🇼🇫🇼🇸🇽🇰🇾🇪🇾🇹🇿🇦🇿🇲🇿🇼";

    private string GenerateRandomEmojiString(int length, string chars = Chars)
    {
        var result = new string(
            Enumerable.Repeat(chars, length)
                .Select(s => s[Randoms.NextInt32(0, s.Length)])
                .ToArray());
        return result;
    }
}
