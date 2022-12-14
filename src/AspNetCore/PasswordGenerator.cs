/*
 * PasswordGenerator.cs
 *
 *   Created: 2022-12-31-06:39:48
 *   Modified: 2022-12-31-06:39:49
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright ยฉ 2022-2023 Justin Chase, All Rights Reserved
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
    const string Emoji = "๐๐๐๐๐๐๐คฃ๐๐๐๐ซ ๐๐๐๐ฅฐ๐๐คฉ๐๐โบ๏ธ๐๐๐ฅฒ๐๐๐๐คช๐๐ค๐ค๐คญ๐ซข๐ซฃ๐คซ๐ค๐ซก๐ค๐คจ๐๐๐ถ๐ซฅ๐ถ๐๐๐๐ฌ๐ฎ๐คฅ๐๐๐ช๐คค๐ด๐ท๐ค๐ค๐คข๐คฎ๐คง๐ฅต๐ฅถ๐ฅด๐ต๐ต๐คฏ๐ค ๐ฅณ๐ฅธ๐๐ค๐ง๐๐ซค๐๐โน๏ธ๐ฎ๐ฏ๐ฒ๐ณ๐ฅบ๐ฅน๐ฆ๐ง๐จ๐ฐ๐ฅ๐ข๐ญ๐ฑ๐๐ฃ๐๐๐ฉ๐ซ๐ฅฑ๐ค๐ก๐ ๐คฌ๐๐ฟ๐โ ๏ธ๐ฉ๐คก๐น๐บ๐ป๐ฝ๐พ๐ค๐บ๐ธ๐น๐ป๐ผ๐ฝ๐๐ฟ๐พ๐๐๐ค๐โ ๐๐ซฑ๐ซฒ๐ซณ๐ซด๐๐ค๐คโ๏ธ๐ค๐ซฐ๐ค๐ค๐ค๐๐๐๐๐โ๏ธ๐ซต๐๐โ ๐๐ค๐ค๐๐๐ซถ๐๐คฒ๐ค๐โ๏ธ๐๐คณ๐ช๐ฆพ๐ฆฟ๐ฆต๐ฆถ๐๐ฆป๐๐ง ๐ซ๐ซ๐ฆท๐ฆด๐๐๐๐๐ซฆ๐ถ๐ง๐ฆ๐ง๐ง๐ฑ๐จ๐ง๐จ๐จ๐จ๐จ๐ฉ๐ฉ๐ง๐ฉ๐ง๐ฉ๐ง๐ฉ๐ง๐ฑ๐ฑ๐ง๐ด๐ต๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐ง๐ง๐ง๐๐๐๐คฆ๐คฆ๐คฆ๐คท๐คท๐คท๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ฎ๐ฎ๐ฎ๐ต๐ต๐ต๐๐๐๐ฅท๐ท๐ท๐ท๐ซ๐คด๐ธ๐ณ๐ณ๐ณ๐ฒ๐ง๐คต๐คต๐คต๐ฐ๐ฐ๐ฐ๐คฐ๐ซ๐ซ๐คฑ๐ฉ๐จ๐ง๐ผ๐๐คถ๐ง๐ฆธ๐ฆธ๐ฆธ๐ฆน๐ฆน๐ฆน๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐๐๐๐๐๐๐ถ๐ถ๐ถ๐ง๐ง๐ง๐ง๐ง๐ง๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐ง๐จ๐ฉ๐๐๐๐๐บ๐ด๐ฏ๐ฏ๐ฏ๐ง๐ง๐ง๐ง๐ง๐ญ๐ซ๐ฌ๐๐ฉ๐จ๐ฉ๐๐ฉ๐จ๐ฉ๐ช๐จ๐จ๐จ๐จ๐จ๐จ๐จ๐จ๐จ๐จ๐ฉ๐ฉ๐ฉ๐ฉ๐ฉ๐จ๐จ๐จ๐จ๐จ๐ฉ๐ฉ๐ฉ๐ฉ๐ฉ๐ฃ๐ค๐ฅ๐ซ๐ฃ๐งณ๐โ๏ธ๐๐งต๐งถ๐๐ถ๐ฅฝ๐ฅผ๐ฆบ๐๐๐๐งฃ๐งค๐งฅ๐งฆ๐๐๐ฅป๐ฉฑ๐ฉฒ๐ฉณ๐๐๐๐๐๐๐ฉด๐๐๐ฅพ๐ฅฟ๐ ๐ก๐ฉฐ๐ข๐๐๐ฉ๐๐งข๐ชโ๏ธ๐๐๐ผ๐ฉธ๐๐๐๐ฅ๐ซ๐ฆ๐จ๐ต๐๐ฆ๐ฆง๐ถ๐๐ฆฎ๐๐ฉ๐บ๐ฆ๐ฆ๐ฑ๐๐๐ฆ๐ฏ๐๐๐ด๐๐ฆ๐ฆ๐ฆ๐ฆฌ๐ฎ๐๐๐๐ท๐๐๐ฝ๐๐๐๐ช๐ซ๐ฆ๐ฆ๐๐ฆฃ๐ฆ๐ฆ๐ญ๐๐๐น๐ฐ๐๐ฟ๐ฆซ๐ฆ๐ฆ๐ป๐ป๐จ๐ผ๐ฆฅ๐ฆฆ๐ฆจ๐ฆ๐ฆก๐พ๐ฆ๐๐๐ฃ๐ค๐ฅ๐ฆ๐ง๐๐ฆ๐ฆ๐ฆข๐ฆ๐ฆค๐ชถ๐ฆฉ๐ฆ๐ฆ๐ธ๐๐ข๐ฆ๐๐ฒ๐๐ฆ๐ฆ๐ณ๐๐ฌ๐ฆญ๐๐ ๐ก๐ฆ๐๐๐ชธ๐๐ฆ๐๐๐๐ชฒ๐๐ฆ๐ชณ๐ท๐ธ๐ฆ๐ฆ๐ชฐ๐ชฑ๐ฆ ๐๐ธ๐ฎ๐ชท๐ต๐น๐ฅ๐บ๐ป๐ผ๐ท๐ฑ๐ชด๐ฒ๐ณ๐ด๐ต๐พ๐ฟโ๏ธ๐๐๐๐๐ชน๐ชบ๐๐ฐ๐ฆ๐ฆ๐ฆ๐ฆ๐๐๐๐๐ชจ๐๐๐๐๐๐๐๐๐๐๐๐โ๏ธ๐๐โญ ๐๐ โ๏ธโ โ๏ธ๐ค๐ฅ๐ฆ๐ง๐จ๐ฉ๐ช๐ซ๐ฌ๐โ๏ธโ โก โ๏ธโ๏ธโ โ๏ธ๐ฅ๐ง๐๐โจ ๐๐๐ซง๐๐๐๐๐๐๐๐ฅญ๐๐๐๐๐๐๐ซ๐ฅ๐๐ซ๐ฅฅ๐ฅ๐๐ฅ๐ฅ๐ฝ๐ถ๐ซ๐ฅ๐ฅฌ๐ฅฆ๐ง๐ง๐๐ฅ๐ซ๐ฐ๐๐ฅ๐ฅ๐ซ๐ฅจ๐ฅฏ๐ฅ๐ง๐ง๐๐๐ฅฉ๐ฅ๐๐๐๐ญ๐ฅช๐ฎ๐ฏ๐ซ๐ฅ๐ง๐ฅ๐ณ๐ฅ๐ฒ๐ซ๐ฅฃ๐ฅ๐ฟ๐ง๐ง๐ฅซ๐ฑ๐๐๐๐๐๐๐ ๐ข๐ฃ๐ค๐ฅ๐ฅฎ๐ก๐ฅ๐ฅ ๐ฅก๐ฆช๐ฆ๐ง๐จ๐ฉ๐ช๐๐ฐ๐ง๐ฅง๐ซ๐ฌ๐ญ๐ฎ๐ฏ๐ผ๐ฅโ ๐ซ๐ต๐ถ๐พ๐ท๐ธ๐น๐บ๐ป๐ฅ๐ฅ๐ซ๐ฅค๐ง๐ง๐ง๐ง๐ฅข๐ฝ๐ด๐ฅ๐ซ๐ด๐ง๐ง๐ง๐คบ๐โท๏ธ๐๐๐๐๐๐๐๐ฃ๐ฃ๐ฃ๐๐๐โน๏ธโน๏ธโน๏ธ๐๐๐๐ด๐ด๐ด๐ต๐ต๐ต๐คธ๐คธ๐คธ๐คผ๐คผ๐คผ๐คฝ๐คฝ๐คฝ๐คพ๐คพ๐คพ๐คน๐คน๐คน๐ง๐ง๐ง๐ช๐น๐ผ๐ถ๐๐๐ซ๐๐๐๐ฅ๐ฅ๐ฅโฝ โพ ๐ฅ๐๐๐๐๐พ๐ฅ๐ณ๐๐๐๐ฅ๐๐ธ๐ฅ๐ฅ๐ฅโณ โธ๏ธ๐ฃ๐ฝ๐ฟ๐ท๐ฅ๐ฏ๐ฑ๐ฎ๐ฐ๐ฒ๐งฉ๐ชฉโ๏ธ๐ญ๐จ๐งต๐งถ๐ผ๐ค๐ง๐ท๐ช๐ธ๐น๐บ๐ป๐ฅ๐ช๐ฌ๐น๐ฃ๐พ๐โฐ๏ธ๐๐ป๐๐๐๐๐๐๐๐๐๐๐๐ ๐ก๐ข๐ฃ๐ค๐ฅ๐ฆ๐จ๐ฉ๐ช๐ซ๐ฌ๐ญ๐ฏ๐ฐ๐๐ผ๐ฝโช ๐๐๐โฉ๏ธ๐โฒ โบ ๐๐๐๐๐๐๐๐๐ ๐๐ก๐ข๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐ป๐๐๐๐๐๐ต๐บ๐ฒ๐ด๐๐ฃ๐คโฝ ๐๐จ๐ฅ๐ฆ๐งโ ๐โต ๐ค๐ณโด๏ธ๐ฅ๐ขโ๏ธ๐ฉ๐ซ๐ฌ๐ช๐บ๐๐๐ ๐ก๐ฐ๐๐ธ๐ช๐ ๐โฑ๏ธ๐๐๐๐ด๐ต๐ถ๐ท๐ฟ๐๐๐๐๐๐ณ๐ฃ๐๐๐ช๐บ๐บ๐งญ๐งฑ๐๐ฆฝ๐ฆผ๐ข๐๐งณโ โณ โ โฐ โฑ๏ธโฒ๏ธ๐ฐ๐กโฑ๏ธ๐งจ๐๐๐๐๐๐๐งง๐๐๐คฟ๐ช๐ช๐ฎ๐ช๐งฟ๐ชฌ๐น๐งธ๐ช๐ช๐ผ๐งต๐ชก๐งถ๐ชข๐๐ฟ๐๐ฏ๐๐๐๐ป๐ช๐ฑ๐ฒโ๏ธ๐๐๐ ๐๐๐ป๐ฅ๐จโจ๏ธ๐ฑ๐ฒ๐ฝ๐พ๐ฟ๐๐งฎ๐ฅ๐๐ฝ๐บ๐ท๐ธ๐น๐ผ๐๐๐ฏ๐ก๐ฆ๐ฎ๐ช๐๐๐๐๐๐๐๐๐๐๐๐๐ฐ๐๐๐๐ท๐ฐ๐ช๐ด๐ต๐ถ๐ท๐ธ๐ณ๐งพโ๏ธ๐ง๐จ๐ฉ๐ค๐ฅ๐ฆ๐ซ๐ช๐ฌ๐ญ๐ฎ๐ณโ๏ธโ๏ธ๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐๐โ๏ธ๐๐๐๐๐๐๐๐๐๐จ๐ชโ๏ธโ๏ธ๐ ๐กโ๏ธ๐ซ๐ช๐ก๐ช๐ง๐ช๐ฉโ๏ธ๐โ๏ธ๐ฆฏ๐โ๏ธ๐ช๐งฐ๐งฒ๐ชโ๏ธ๐งช๐งซ๐งฌ๐ฌ๐ญ๐ก๐๐ฉธ๐๐ฉน๐ฉผ๐ฉบ๐ช๐ช๐ช๐๐๐ช๐ฝ๐ช ๐ฟ๐๐ชค๐ช๐งด๐งท๐งน๐งบ๐งป๐ชฃ๐งผ๐ชฅ๐งฝ๐งฏ๐๐ฌโฐ๏ธ๐ชฆโฑ๏ธ๐ฟ๐ชง๐ชช๐ฐ๐๐๐๐๐๐๐๐โฃ๏ธ๐โค๏ธโค๏ธโค๏ธ๐งก๐๐๐๐๐ค๐ค๐ค๐ฏ๐ข๐ฌ๐๐จ๐ฏ๐ญ๐ค๐ฎโจ๏ธ๐๐๐๐ง๐๐๐๐๐๐๐๐๐๐ ๐๐ก๐๐ข๐๐ฃ๐๐ค๐๐ฅ๐๐ฆ๐โ ๏ธโฅ๏ธโฆ๏ธโฃ๏ธ๐๐๐ด๐๐๐๐๐ข๐ฃ๐ฏ๐๐๐ต๐ถ๐น๐๐ง๐ฎ๐ฐโฟ ๐น๐บ๐ป๐ผ๐พโ ๏ธ๐ธโ ๐ซ๐ณ๐ญ๐ฏ๐ฑ๐ท๐ต๐โข๏ธโฃ๏ธโฌ๏ธโ๏ธโก๏ธโ๏ธโฌ๏ธโ๏ธโฌ๏ธโ๏ธโ๏ธโ๏ธโฉ๏ธโช๏ธโคด๏ธโคต๏ธ๐๐๐๐๐๐๐๐โ๏ธ๐โก๏ธโธ๏ธโฏ๏ธโ๏ธโฆ๏ธโช๏ธโฎ๏ธ๐๐ฏโ โ โ โ โ โ โ โ โ โ โ โ โ ๐๐๐โถ๏ธโฉ โญ๏ธโฏ๏ธโ๏ธโช โฎ๏ธ๐ผโซ ๐ฝโฌ โธ๏ธโน๏ธโบ๏ธโ๏ธ๐ฆ๐๐๐ถ๐ณ๐ดโ๏ธโ๏ธโ๏ธโ โ โ ๐ฐโพ๏ธโผ๏ธโ๏ธโ โ โ โ ใฐ๏ธ๐ฑ๐ฒโ๏ธโป๏ธโ๏ธ๐ฑ๐๐ฐโญ โ โ๏ธโ๏ธโ โ โฐ โฟ ใฝ๏ธโณ๏ธโด๏ธโ๏ธยฉ๏ธยฎ๏ธโข๏ธ#๏ธ*๏ธ0๏ธ1๏ธ2๏ธ3๏ธ4๏ธ5๏ธ6๏ธ7๏ธ8๏ธ9๏ธ๐๐ ๐ก๐ข๐ฃ๐ค๐ฐ๐๐ฑ๐๐๐โน๏ธ๐โ๏ธ๐๐๐พ๐๐ฟ๐๐๐๐๐๐ท๐ถ๐ฏ๐๐น๐๐ฒ๐๐ธ๐ด๐ณใ๏ธใ๏ธ๐บ๐ต๐ด๐ ๐ก๐ข๐ต๐ฃ๐คโซ โช ๐ฅ๐ง๐จ๐ฉ๐ฆ๐ช๐ซโฌ โฌ โผ๏ธโป๏ธโพ โฝ โช๏ธโซ๏ธ๐ถ๐ท๐ธ๐น๐บ๐ป๐ ๐๐ณ๐ฒ๐๐ฉ๐๐ด๐ณ๏ธ ๐ณ๏ธโ๐ณ๏ธโ๐ดโโ ๐ฆ๐จ๐ฆ๐ฉ๐ฆ๐ช๐ฆ๐ซ๐ฆ๐ฌ๐ฆ๐ฎ๐ฆ๐ฑ๐ฆ๐ฒ๐ฆ๐ด๐ฆ๐ถ๐ฆ๐ท๐ฆ๐ธ๐ฆ๐น๐ฆ๐บ๐ฆ๐ผ๐ฆ๐ฝ๐ฆ๐ฟ๐ง๐ฆ๐ง๐ง๐ง๐ฉ๐ง๐ช๐ง๐ซ๐ง๐ฌ๐ง๐ญ๐ง๐ฎ๐ง๐ฏ๐ง๐ฑ๐ง๐ฒ๐ง๐ณ๐ง๐ด๐ง๐ถ๐ง๐ท๐ง๐ธ๐ง๐น๐ง๐ป๐ง๐ผ๐ง๐พ๐ง๐ฟ๐จ๐ฆ๐จ๐จ๐จ๐ฉ๐จ๐ซ๐จ๐ฌ๐จ๐ญ๐จ๐ฎ๐จ๐ฐ๐จ๐ฑ๐จ๐ฒ๐จ๐ณ๐จ๐ด๐จ๐ต๐จ๐ท๐จ๐บ๐จ๐ป๐จ๐ผ๐จ๐ฝ๐จ๐พ๐จ๐ฟ๐ฉ๐ช๐ฉ๐ฌ๐ฉ๐ฏ๐ฉ๐ฐ๐ฉ๐ฒ๐ฉ๐ด๐ฉ๐ฟ๐ช๐ฆ๐ช๐จ๐ช๐ช๐ช๐ฌ๐ช๐ญ๐ช๐ท๐ช๐ธ๐ช๐น๐ช๐บ๐ซ๐ฎ๐ซ๐ฏ๐ซ๐ฐ๐ซ๐ฒ๐ซ๐ด๐ซ๐ท๐ฌ๐ฆ๐ฌ๐ง๐ฌ๐ฉ๐ฌ๐ช๐ฌ๐ซ๐ฌ๐ฌ๐ฌ๐ญ๐ฌ๐ฎ๐ฌ๐ฑ๐ฌ๐ฒ๐ฌ๐ณ๐ฌ๐ต๐ฌ๐ถ๐ฌ๐ท๐ฌ๐ธ๐ฌ๐น๐ฌ๐บ๐ฌ๐ผ๐ฌ๐พ๐ญ๐ฐ๐ญ๐ฒ๐ญ๐ณ๐ญ๐ท๐ญ๐น๐ญ๐บ๐ฎ๐จ๐ฎ๐ฉ๐ฎ๐ช๐ฎ๐ฑ๐ฎ๐ฒ๐ฎ๐ณ๐ฎ๐ด๐ฎ๐ถ๐ฎ๐ท๐ฎ๐ธ๐ฎ๐น๐ฏ๐ช๐ฏ๐ฒ๐ฏ๐ด๐ฏ๐ต๐ฐ๐ช๐ฐ๐ฌ๐ฐ๐ญ๐ฐ๐ฎ๐ฐ๐ฒ๐ฐ๐ณ๐ฐ๐ต๐ฐ๐ท๐ฐ๐ผ๐ฐ๐พ๐ฐ๐ฟ๐ฑ๐ฆ๐ฑ๐ง๐ฑ๐จ๐ฑ๐ฎ๐ฑ๐ฐ๐ฑ๐ท๐ฑ๐ธ๐ฑ๐น๐ฑ๐บ๐ฑ๐ป๐ฑ๐พ๐ฒ๐ฆ๐ฒ๐จ๐ฒ๐ฉ๐ฒ๐ช๐ฒ๐ซ๐ฒ๐ฌ๐ฒ๐ญ๐ฒ๐ฐ๐ฒ๐ฑ๐ฒ๐ฒ๐ฒ๐ณ๐ฒ๐ด๐ฒ๐ต๐ฒ๐ถ๐ฒ๐ท๐ฒ๐ธ๐ฒ๐น๐ฒ๐บ๐ฒ๐ป๐ฒ๐ผ๐ฒ๐ฝ๐ฒ๐พ๐ฒ๐ฟ๐ณ๐ฆ๐ณ๐จ๐ณ๐ช๐ณ๐ซ๐ณ๐ฌ๐ณ๐ฎ๐ณ๐ฑ๐ณ๐ด๐ณ๐ต๐ณ๐ท๐ณ๐บ๐ณ๐ฟ๐ด๐ฒ๐ต๐ฆ๐ต๐ช๐ต๐ซ๐ต๐ฌ๐ต๐ญ๐ต๐ฐ๐ต๐ฑ๐ต๐ฒ๐ต๐ณ๐ต๐ท๐ต๐ธ๐ต๐น๐ต๐ผ๐ต๐พ๐ถ๐ฆ๐ท๐ช๐ท๐ด๐ท๐ธ๐ท๐บ๐ท๐ผ๐ธ๐ฆ๐ธ๐ง๐ธ๐จ๐ธ๐ฉ๐ธ๐ช๐ธ๐ฌ๐ธ๐ญ๐ธ๐ฎ๐ธ๐ฏ๐ธ๐ฐ๐ธ๐ฑ๐ธ๐ฒ๐ธ๐ณ๐ธ๐ด๐ธ๐ท๐ธ๐ธ๐ธ๐น๐ธ๐ป๐ธ๐ฝ๐ธ๐พ๐ธ๐ฟ๐น๐ฆ๐น๐จ๐น๐ฉ๐น๐ซ๐น๐ฌ๐น๐ญ๐น๐ฏ๐น๐ฐ๐น๐ฑ๐น๐ฒ๐น๐ณ๐น๐ด๐น๐ท๐น๐น๐น๐ป๐น๐ผ๐น๐ฟ๐บ๐ฆ๐บ๐ฌ๐บ๐ฒ๐บ๐ณ๐บ๐ธ๐บ๐พ๐บ๐ฟ๐ป๐ฆ๐ป๐จ๐ป๐ช๐ป๐ฌ๐ป๐ฎ๐ป๐ณ๐ป๐บ๐ผ๐ซ๐ผ๐ธ๐ฝ๐ฐ๐พ๐ช๐พ๐น๐ฟ๐ฆ๐ฟ๐ฒ๐ฟ๐ผ";

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
