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
using Telegram.Bot.Requests;

public interface IPasswordGenerator
{
    string GeneratePassword();
}

public class PassphraseGeneratorOptions
{
    public int WordCount { get; set; } = 4;
    public int EmojiCount { get; set; } = 2;
    public string[] WordList { get; set; }
}

public class PasswordGenerator : IPasswordGenerator
{
    private static readonly Random Random = new Random(Guid.NewGuid().GetHashCode());
    private readonly PassphraseGeneratorOptions _options;
    private readonly string[] _wordList;
    const string Emoji = "😀😃😄😁😆😅🤣😂🙂🙃🫠😉😊😇🥰😍🤩😘😗☺️😚😙🥲😋😛😜🤪😝🤑🤗🤭🫢🫣🤫🤔🫡🤐🤨😐😑😶🫥😶😏😒🙄😬😮🤥😌😔😪🤤😴😷🤒🤕🤢🤮🤧🥵🥶🥴😵😵🤯🤠🥳🥸😎🤓🧐😕🫤😟🙁☹️😮😯😲😳🥺🥹😦😧😨😰😥😢😭😱😖😣😞😓😩😫🥱😤😡😠🤬😈👿💀☠️💩🤡👹👺👻👽👾🤖😺😸😹😻😼😽🙀😿😾💋👋🤚🖐✋ 🖖🫱🫲🫳🫴👌🤌🤏✌️🤞🫰🤟🤘🤙👈👉👆🖕👇☝️🫵👍👎✊ 👊🤛🤜👏🙌🫶👐🤲🤝🙏✍️💅🤳💪🦾🦿🦵🦶👂🦻👃🧠🫀🫁🦷🦴👀👁👅👄🫦👶🧒👦👧🧑👱👨🧔👨👨👨👨👩👩🧑👩🧑👩🧑👩🧑👱👱🧓👴👵🙍🙍🙍🙎🙎🙎🙅🙅🙅🙆🙆🙆💁💁💁🙋🙋🙋🧏🧏🧏🙇🙇🙇🤦🤦🤦🤷🤷🤷🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩🧑👨👩👮👮👮🕵🕵🕵💂💂💂🥷👷👷👷🫅🤴👸👳👳👳👲🧕🤵🤵🤵👰👰👰🤰🫃🫄🤱👩👨🧑👼🎅🤶🧑🦸🦸🦸🦹🦹🦹🧙🧙🧙🧚🧚🧚🧛🧛🧛🧜🧜🧜🧝🧝🧝🧞🧞🧞🧟🧟🧟🧌💆💆💆💇💇💇🚶🚶🚶🧍🧍🧍🧎🧎🧎🧑👨👩🧑👨👩🧑👨👩🏃🏃🏃💃🕺🕴👯👯👯🧖🧖🧖🧘🧑👭👫👬💏👩👨👩💑👩👨👩👪👨👨👨👨👨👨👨👨👨👨👩👩👩👩👩👨👨👨👨👨👩👩👩👩👩🗣👤👥🫂👣🧳🌂☂️🎃🧵🧶👓🕶🥽🥼🦺👔👕👖🧣🧤🧥🧦👗👘🥻🩱🩲🩳👙👚👛👜👝🎒🩴👞👟🥾🥿👠👡🩰👢👑👒🎩🎓🧢🪖⛑️💄💍💼🩸🙈🙉🙊💥💫💦💨🐵🐒🦍🦧🐶🐕🦮🐕🐩🐺🦊🦝🐱🐈🐈🦁🐯🐅🐆🐴🐎🦄🦓🦌🦬🐮🐂🐃🐄🐷🐖🐗🐽🐏🐑🐐🐪🐫🦙🦒🐘🦣🦏🦛🐭🐁🐀🐹🐰🐇🐿🦫🦔🦇🐻🐻🐨🐼🦥🦦🦨🦘🦡🐾🦃🐔🐓🐣🐤🐥🐦🐧🕊🦅🦆🦢🦉🦤🪶🦩🦚🦜🐸🐊🐢🦎🐍🐲🐉🦕🦖🐳🐋🐬🦭🐟🐠🐡🦈🐙🐚🪸🐌🦋🐛🐜🐝🪲🐞🦗🪳🕷🕸🦂🦟🪰🪱🦠💐🌸💮🪷🏵🌹🥀🌺🌻🌼🌷🌱🪴🌲🌳🌴🌵🌾🌿☘️🍀🍁🍂🍃🪹🪺🍄🌰🦀🦞🦐🦑🌍🌎🌏🌐🪨🌑🌒🌓🌔🌕🌖🌗🌘🌙🌚🌛🌜☀️🌝🌞⭐ 🌟🌠☁️⛅ ⛈️🌤🌥🌦🌧🌨🌩🌪🌫🌬🌈☂️☔ ⚡ ❄️☃️⛄ ☄️🔥💧🌊🎄✨ 🎋🎍🫧🍇🍈🍉🍊🍋🍌🍍🥭🍎🍏🍐🍑🍒🍓🫐🥝🍅🫒🥥🥑🍆🥔🥕🌽🌶🫑🥒🥬🥦🧄🧅🍄🥜🫘🌰🍞🥐🥖🫓🥨🥯🥞🧇🧀🍖🍗🥩🥓🍔🍟🍕🌭🥪🌮🌯🫔🥙🧆🥚🍳🥘🍲🫕🥣🥗🍿🧈🧂🥫🍱🍘🍙🍚🍛🍜🍝🍠🍢🍣🍤🍥🥮🍡🥟🥠🥡🦪🍦🍧🍨🍩🍪🎂🍰🧁🥧🍫🍬🍭🍮🍯🍼🥛☕ 🫖🍵🍶🍾🍷🍸🍹🍺🍻🥂🥃🫗🥤🧋🧃🧉🧊🥢🍽🍴🥄🫙🕴🧗🧗🧗🤺🏇⛷️🏂🏌🏌🏌🏄🏄🏄🚣🚣🚣🏊🏊🏊⛹️⛹️⛹️🏋🏋🏋🚴🚴🚴🚵🚵🚵🤸🤸🤸🤼🤼🤼🤽🤽🤽🤾🤾🤾🤹🤹🤹🧘🧘🧘🎪🛹🛼🛶🎗🎟🎫🎖🏆🏅🥇🥈🥉⚽ ⚾ 🥎🏀🏐🏈🏉🎾🥏🎳🏏🏑🏒🥍🏓🏸🥊🥋🥅⛳ ⛸️🎣🎽🎿🛷🥌🎯🎱🎮🎰🎲🧩🪩♟️🎭🎨🧵🧶🎼🎤🎧🎷🪗🎸🎹🎺🎻🥁🪘🎬🏹🚣🗾🏔⛰️🌋🗻🏕🏖🏜🏝🏞🏟🏛🏗🛖🏘🏚🏠🏡🏢🏣🏤🏥🏦🏨🏩🏪🏫🏬🏭🏯🏰💒🗼🗽⛪ 🕌🛕🕍⛩️🕋⛲ ⛺ 🌁🌃🏙🌄🌅🌆🌇🌉🎠🛝🎡🎢🚂🚃🚄🚅🚆🚇🚈🚉🚊🚝🚞🚋🚌🚍🚎🚐🚑🚒🚓🚔🚕🚖🚗🚘🚙🛻🚚🚛🚜🏎🏍🛵🛺🚲🛴🚏🛣🛤⛽ 🛞🚨🚥🚦🚧⚓ 🛟⛵ 🚤🛳⛴️🛥🚢✈️🛩🛫🛬🪂💺🚁🚟🚠🚡🛰🚀🛸🪐🌠🌌⛱️🎆🎇🎑💴💵💶💷🗿🛂🛃🛄🛅💌🕳💣🛀🛌🔪🏺🗺🧭🧱💈🦽🦼🛢🛎🧳⌛ ⏳ ⌚ ⏰ ⏱️⏲️🕰🌡⛱️🧨🎈🎉🎊🎎🎏🎐🧧🎀🎁🤿🪀🪁🔮🪄🧿🪬🕹🧸🪅🪆🖼🧵🪡🧶🪢🛍📿💎📯🎙🎚🎛📻🪕📱📲☎️📞📟📠🔋🔌💻🖥🖨⌨️🖱🖲💽💾💿📀🧮🎥🎞📽📺📷📸📹📼🔍🔎🕯💡🔦🏮🪔📔📕📖📗📘📙📚📓📒📃📜📄📰🗞📑🔖🏷💰🪙💴💵💶💷💸💳🧾✉️📧📨📩📤📥📦📫📪📬📭📮🗳✏️✒️🖋🖊🖌🖍📝📁📂🗂📅📆🗒🗓📇📈📉📊📋📌📍📎🖇📏📐✂️🗃🗄🗑🔒🔓🔏🔐🔑🗝🔨🪓⛏️⚒️🛠🗡⚔️🔫🪃🛡🪚🔧🪛🔩⚙️🗜⚖️🦯🔗⛓️🪝🧰🧲🪜⚗️🧪🧫🧬🔬🔭📡💉🩸💊🩹🩼🩺🚪🪞🪟🛏🛋🪑🚽🪠🚿🛁🪤🪒🧴🧷🧹🧺🧻🪣🧼🪥🧽🧯🛒🚬⚰️🪦⚱️🗿🪧🪪🚰💘💝💖💗💓💞💕💟❣️💔❤️❤️❤️🧡💛💚💙💜🤎🖤🤍💯💢💬👁🗨🗯💭💤💮♨️💈🛑🕛🕧🕐🕜🕑🕝🕒🕞🕓🕟🕔🕠🕕🕡🕖🕢🕗🕣🕘🕤🕙🕥🕚🕦🌀♠️♥️♦️♣️🃏🀄🎴🔇🔈🔉🔊📢📣📯🔔🔕🎵🎶💹🛗🏧🚮🚰♿ 🚹🚺🚻🚼🚾⚠️🚸⛔ 🚫🚳🚭🚯🚱🚷📵🔞☢️☣️⬆️↗️➡️↘️⬇️↙️⬅️↖️↕️↔️↩️↪️⤴️⤵️🔃🔄🔙🔚🔛🔜🔝🛐⚛️🕉✡️☸️☯️✝️☦️☪️☮️🕎🔯♈ ♉ ♊ ♋ ♌ ♍ ♎ ♏ ♐ ♑ ♒ ♓ ⛎ 🔀🔁🔂▶️⏩ ⏭️⏯️◀️⏪ ⏮️🔼⏫ 🔽⏬ ⏸️⏹️⏺️⏏️🎦🔅🔆📶📳📴♀️♂️✖️➕ ➖ ➗ 🟰♾️‼️⁉️❓ ❔ ❕ ❗ 〰️💱💲⚕️♻️⚜️🔱📛🔰⭕ ✅ ☑️✔️❌ ❎ ➰ ➿ 〽️✳️✴️❇️©️®️™️#️*️0️1️2️3️4️5️6️7️8️9️🔟🔠🔡🔢🔣🔤🅰🆎🅱🆑🆒🆓ℹ️🆔Ⓜ️🆕🆖🅾🆗🅿🆘🆙🆚🈁🈂🈷🈶🈯🉐🈹🈚🈲🉑🈸🈴🈳㊗️㊙️🈺🈵🔴🟠🟡🟢🔵🟣🟤⚫ ⚪ 🟥🟧🟨🟩🟦🟪🟫⬛ ⬜ ◼️◻️◾ ◽ ▪️▫️🔶🔷🔸🔹🔺🔻💠🔘🔳🔲🏁🚩🎌🏴🏳️ 🏳️‍🏳️‍🏴‍☠🇦🇨🇦🇩🇦🇪🇦🇫🇦🇬🇦🇮🇦🇱🇦🇲🇦🇴🇦🇶🇦🇷🇦🇸🇦🇹🇦🇺🇦🇼🇦🇽🇦🇿🇧🇦🇧🇧🇧🇩🇧🇪🇧🇫🇧🇬🇧🇭🇧🇮🇧🇯🇧🇱🇧🇲🇧🇳🇧🇴🇧🇶🇧🇷🇧🇸🇧🇹🇧🇻🇧🇼🇧🇾🇧🇿🇨🇦🇨🇨🇨🇩🇨🇫🇨🇬🇨🇭🇨🇮🇨🇰🇨🇱🇨🇲🇨🇳🇨🇴🇨🇵🇨🇷🇨🇺🇨🇻🇨🇼🇨🇽🇨🇾🇨🇿🇩🇪🇩🇬🇩🇯🇩🇰🇩🇲🇩🇴🇩🇿🇪🇦🇪🇨🇪🇪🇪🇬🇪🇭🇪🇷🇪🇸🇪🇹🇪🇺🇫🇮🇫🇯🇫🇰🇫🇲🇫🇴🇫🇷🇬🇦🇬🇧🇬🇩🇬🇪🇬🇫🇬🇬🇬🇭🇬🇮🇬🇱🇬🇲🇬🇳🇬🇵🇬🇶🇬🇷🇬🇸🇬🇹🇬🇺🇬🇼🇬🇾🇭🇰🇭🇲🇭🇳🇭🇷🇭🇹🇭🇺🇮🇨🇮🇩🇮🇪🇮🇱🇮🇲🇮🇳🇮🇴🇮🇶🇮🇷🇮🇸🇮🇹🇯🇪🇯🇲🇯🇴🇯🇵🇰🇪🇰🇬🇰🇭🇰🇮🇰🇲🇰🇳🇰🇵🇰🇷🇰🇼🇰🇾🇰🇿🇱🇦🇱🇧🇱🇨🇱🇮🇱🇰🇱🇷🇱🇸🇱🇹🇱🇺🇱🇻🇱🇾🇲🇦🇲🇨🇲🇩🇲🇪🇲🇫🇲🇬🇲🇭🇲🇰🇲🇱🇲🇲🇲🇳🇲🇴🇲🇵🇲🇶🇲🇷🇲🇸🇲🇹🇲🇺🇲🇻🇲🇼🇲🇽🇲🇾🇲🇿🇳🇦🇳🇨🇳🇪🇳🇫🇳🇬🇳🇮🇳🇱🇳🇴🇳🇵🇳🇷🇳🇺🇳🇿🇴🇲🇵🇦🇵🇪🇵🇫🇵🇬🇵🇭🇵🇰🇵🇱🇵🇲🇵🇳🇵🇷🇵🇸🇵🇹🇵🇼🇵🇾🇶🇦🇷🇪🇷🇴🇷🇸🇷🇺🇷🇼🇸🇦🇸🇧🇸🇨🇸🇩🇸🇪🇸🇬🇸🇭🇸🇮🇸🇯🇸🇰🇸🇱🇸🇲🇸🇳🇸🇴🇸🇷🇸🇸🇸🇹🇸🇻🇸🇽🇸🇾🇸🇿🇹🇦🇹🇨🇹🇩🇹🇫🇹🇬🇹🇭🇹🇯🇹🇰🇹🇱🇹🇲🇹🇳🇹🇴🇹🇷🇹🇹🇹🇻🇹🇼🇹🇿🇺🇦🇺🇬🇺🇲🇺🇳🇺🇸🇺🇾🇺🇿🇻🇦🇻🇨🇻🇪🇻🇬🇻🇮🇻🇳🇻🇺🇼🇫🇼🇸🇽🇰🇾🇪🇾🇹🇿🇦🇿🇲🇿🇼";

    public PasswordGenerator(IOptions<PassphraseGeneratorOptions> options)
    {
        _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
        _wordList = _options.WordList;
    }

    public string GeneratePassword()
    {
        var words = GetWords();
        var password = Join('-', words);
        return password;
    }

    private string[] GetWords()
    {
        var words = new List<string>();
        var wordList = _wordList;
        return Enumerable.Repeat(wordList, _options.WordCount)
            .Select(words => words[Random.Next(0, words.Length)])
            .ToArray();
    }

    private string GetRandomWord()
    {
        var wordList = _wordList;
        var index = Random.Next(0, wordList.Length);
        var word = wordList[index];
        return word;
    }

    private static string GetEmojus()
    {
        var random = Random.Next(0, Emoji.Length);
        if(random % 2 != 0)
            random++;
        return Emoji.Substring(random, 2);
    }

    private static string GenerateRandomEmojiString(int length, string chars = Emoji)
    {
        var result = Join("",
            Enumerable.Repeat(chars, length)
                .Select(s => GetEmojus())
                .ToArray()
        );
        return result;
    }
}
