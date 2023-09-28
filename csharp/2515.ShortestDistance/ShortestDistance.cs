using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCConsoleApp._2515.ShortestDistance
{
    internal class ShortestDistance
    {
        public static void Test()
        {
            //Console.WriteLine(ClosetTarget(new string[] { "hello", "i", "am", "leetcode", "hello" }, "hello", 1));
            //Console.WriteLine(ClosetTarget(new string[] { "a", "b", "leetcode" }, "leetcode", 0));
            //Console.WriteLine(ClosetTarget(new string[] { "i", "eat", "leetcode", "leetcode", "hello" }, "ate", 0));


            Console.WriteLine(ClosetTarget(new string[] { "lwgdugypkmsvxwhwbrccrbtemvudwhctnaaonednsbodptendi", "lumylagwxpmmivpujfawgvdbtxpluwekdpeakrqelpvrflnsnr", "lngqwiijizfzzhlvvszaownnachqunlktsnhgsjeluvcpmavuj", "nabbqiyarxmzleesxrfaynypfxonyhvwhebfjsxyinepggxnns", "oiqghjtvrhpgvsjlzmrwbwpmomqqliqytdzawhkwematskflgf", "dtiwjpdgcsmhaiwxrgligxlibfmvclobjjhljrqlvpuiufskix", "svqgvooghuqszkrmcrayqclotygdqnxfetdrfrfvbypgiizzdk", "qzrmfzdiodkdbhwifsinmamljlztwqtaoivufkcyeydsvpmdzw", "ihaekjyxvnmhvtanysybyqvrtmffpkgmnxisgmmhkhbtonlwgo", "ucrvwdlifpckbimcvevgsniepuewjqpakwnxksumgvrnmhmtuk", "lngqwiijizfzzhlvvszaownnachqunlktsnhgsjeluvcpmavuj", "lngqwiijizfzzhlvvszaownnachqunlktsnhgsjeluvcpmavuj", "vdtvcclyyraevotgikgojlbefpfmlzypychxehnglgettackoz", "qxspwpzxfxyxalrjuliwtbyllamkifbknnhzyfeabavwvvdkzk", "vdtvcclyyraevotgikgojlbefpfmlzypychxehnglgettackoz", "ucrvwdlifpckbimcvevgsniepuewjqpakwnxksumgvrnmhmtuk", "dtiwjpdgcsmhaiwxrgligxlibfmvclobjjhljrqlvpuiufskix", "vtbfahotrkxwcfwzlijfoqdkrvdmavpllbcfvibrqeuntsmrcs", "mfhqksxfeeltpiupaijavavbpphjxyuzqlqehirxnmviiaqnfv", "oowbnwbktlmsawtbilyvksqkbuohhjxqbepxgklkrwpjzcvipe", "mpnnvwuqbczvmrwhzvsmtuumwjczqehuumjvfbpgoxlurjbckq", "byaschxhjcgnnodazzpisqriyszffaqqiwljbuigdvzzobrlmc", "dmctcimgeztojrvqwyygmnzfwtsrmmbgednmytsludnrpjjjvk", "qxspwpzxfxyxalrjuliwtbyllamkifbknnhzyfeabavwvvdkzk", "cawzflwjjopbemxqazpsrsrlxljwqlvzpvjbjarqeqgythrsou", "ydqjqvalipkkrcbdprgjjangclswdjpaajiwhxeupidxirlith", "lwgdugypkmsvxwhwbrccrbtemvudwhctnaaonednsbodptendi", "ejtkmbyqtwrlhwynnqggpjaaaydjqnczhtyphfgugpbardzlvj", "cawzflwjjopbemxqazpsrsrlxljwqlvzpvjbjarqeqgythrsou", "oowbnwbktlmsawtbilyvksqkbuohhjxqbepxgklkrwpjzcvipe", "khhwlijglujhgimvfvuwgggigppichzscdtsiklalgqeqsencq", "khhwlijglujhgimvfvuwgggigppichzscdtsiklalgqeqsencq", "lngqwiijizfzzhlvvszaownnachqunlktsnhgsjeluvcpmavuj", "frdsoraagsllmgtatzybegxotrtgsuwfzpzxkpegggvpodnhrr", "ynuartuisymsqxxdqwndonpqhczqpuekwbayfidfisjpriqogx", "shmpixycafoqskoegqfvsrvboiegqwlbrkiuoeetncdxqlqsov", "oiqghjtvrhpgvsjlzmrwbwpmomqqliqytdzawhkwematskflgf", "xjtatoefvpwwgsvmepltadmzngxtnahqypfxgjppbqsmqnjvxm", "vtbfahotrkxwcfwzlijfoqdkrvdmavpllbcfvibrqeuntsmrcs", "dmctcimgeztojrvqwyygmnzfwtsrmmbgednmytsludnrpjjjvk", "dsohnrdxdqrbwdjhqpphwvlzfyizqyoedckthdlhmkxjxewubc", "qriythowwswwwucgwmezpqqneatemdxfqzpeytlozzojguywby", "lyhmqyjnztwzqotqkpmvpueyzjfroousgkkerqvmwjnjtmlkuf", "qzrmfzdiodkdbhwifsinmamljlztwqtaoivufkcyeydsvpmdzw", "qzrmfzdiodkdbhwifsinmamljlztwqtaoivufkcyeydsvpmdzw", "gxrtwoayoosijaddrlbvxqsvbbvaziqemcpxgljlnexvjnnakk", "mjftbskulmuztejkopyftjsdeoyuvhvqragbkqlfhgqqkafvau", "mjftbskulmuztejkopyftjsdeoyuvhvqragbkqlfhgqqkafvau", "qzrmfzdiodkdbhwifsinmamljlztwqtaoivufkcyeydsvpmdzw", "qxspwpzxfxyxalrjuliwtbyllamkifbknnhzyfeabavwvvdkzk" }, "ydqjqvalipkkrcbdprgjjangclswdjpaajiwhxeupidxirlith", 0));
        }

        public static int ClosetTarget(string[] words, string target, int startIndex)
        {
            for (int i = 0; i < words.Length / 2 + 1; i++)
            {
                var fwdIdx = (startIndex + i) % words.Length;
                var bkwdIdx = (startIndex - i + words.Length) % words.Length;
                if (words[fwdIdx] == target || words[bkwdIdx] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
