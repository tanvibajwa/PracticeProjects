using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class Test_ReverseCase
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public static void reverseCase()
        {
            var result = StringHelpers.reverse_case("hAPPY bIRTHDAY");
            var expected_output = "Happy Birthday";
            Assert.That(result, Is.EqualTo(expected_output));

            result = StringHelpers.reverse_case("MANY THANKS");
            expected_output = "many thanks";
            Assert.That(result, Is.EqualTo(expected_output));

            result = StringHelpers.reverse_case("sPoNtAnEoUs");
            expected_output = "SpOnTaNeOuS";
            Assert.That(result, Is.EqualTo(expected_output));
        }

        [Test]
        public void result_should_be_empty_if_input_is_null()
        {
            var result = StringHelpers.reverse_case(null);
            var expected_output = string.Empty;
            Assert.That(result, Is.EqualTo(expected_output));
        }

        [Test]
        public void string_should_be_filtered()
        {
            object[] first_collection = new object[] { 1, 2, "ss", ".nc1" };
            var result = StringHelpers.filter_string(first_collection);
            int[] expected_result = new int[] { 1, 2 };
            Assert.That(result, Is.EqualTo(expected_result));

            first_collection = new object[] { 1, "a", "b", 0, 15 };
            result = StringHelpers.filter_string(first_collection);
            expected_result = new int[] { 1, 0, 15 };
            Assert.That(result, Is.EqualTo(expected_result));

            first_collection = new object[] { 1, 2, "aasf", "1", "123", 123 };
            result = StringHelpers.filter_string(first_collection);
            expected_result = new int[] { 1, 2, 123 };
            Assert.That(result, Is.EqualTo(expected_result));
        }

        [Test]
        [TestCase("Algorism", ExpectedResult = true)]
        [TestCase("lol", ExpectedResult = false)]
        [TestCase("Cat", ExpectedResult = true)]
        [TestCase("Consecutive", ExpectedResult = false)]
        [TestCase("PasSword", ExpectedResult = false)]
        public bool should_be_true_if_word_is_isogram(string word)
        {
            return StringHelpers.is_isogram(word);
        }

        [Test]
        [TestCase("ratio", "orator", ExpectedResult = true)]
        [TestCase("sparkling", "groups", ExpectedResult = true)]
        [TestCase("a", "a", ExpectedResult = true)]
        [TestCase("a", "b", ExpectedResult = false)]
        [TestCase("5556", "65", ExpectedResult = true)]
        [TestCase("&!", "!&", ExpectedResult = true)]
        [TestCase("", "", ExpectedResult = true)]
        [TestCase("", "abc", ExpectedResult = false)]
        public bool should_be_true_if_strange_pair(string A, string B)
        {
            return StringHelpers.is_strange(A, B);
        }

        [Test]
        [TestCase(1000, ExpectedResult = "1,000")]
        [TestCase(1200300, ExpectedResult = "1,200,300")]
        [TestCase(20, ExpectedResult = "20")]
        [TestCase(0, ExpectedResult = "0")]
        [TestCase(123, ExpectedResult = "123")]
        public string should_return_formatted_string(int input)
        {
            return StringHelpers.comma_separated_thousands(input);
        }

        [Test]
        [TestCase("(a23) 456-7890", ExpectedResult = false)]
        [TestCase("(123) 456-7890", ExpectedResult = true)]
        [TestCase("(123) 456-7890", ExpectedResult = true)]
        [TestCase("(1111)555 2345", ExpectedResult = false)]
        [TestCase("(098) 123 4567", ExpectedResult = false)]
        [TestCase("(123)456-7890", ExpectedResult = false)]
        [TestCase("abc(123)456-7890", ExpectedResult = false)]
        [TestCase("(123)456-7890abc", ExpectedResult = false)]
        [TestCase("abc(123)456-7890abc", ExpectedResult = false)]
        [TestCase("abc(123) 456-7890", ExpectedResult = false)]
        [TestCase("(123) 456-7890abc", ExpectedResult = false)]
        [TestCase("abc(123) 456-7890abc", ExpectedResult = false)]
        [TestCase("(123)_456-7890", ExpectedResult = false)]
        [TestCase("(123)_456-7890", ExpectedResult = false)]
        [TestCase("-123) 456-7890", ExpectedResult = false)]
        [TestCase("(519) 505-6498", ExpectedResult = true)]
        public static bool should_return_true_if_valid_phone_number(string input)
        {
            return StringHelpers.Is_phone_number(input);
        }

        [Test]
        [TestCase(1756, ExpectedResult = "18th century")]
        [TestCase(1555, ExpectedResult = "16th century")]
        [TestCase(1000, ExpectedResult = "10th century")]
        [TestCase(1001, ExpectedResult = "11th century")]
        [TestCase(2005, ExpectedResult = "21st century")]
        [TestCase(1789, ExpectedResult = "18th century")]
        [TestCase(1510, ExpectedResult = "16th century")]
        [TestCase(1615, ExpectedResult = "17th century")]
        [TestCase(2000, ExpectedResult = "20th century")]
        [TestCase(1997, ExpectedResult = "20th century")]
        public string should_return_correct_century(int input)
        {
            return StringHelpers.get_century(input);
        }

        [Test]
        [TestCase("What went wrong?????????", ExpectedResult = "What went wrong?")]
        [TestCase("Oh my goodness!!!", ExpectedResult = "Oh my goodness!")]
        [TestCase("WHAT!", ExpectedResult = "WHAT!")]
        [TestCase("WHAT?", ExpectedResult = "WHAT?")]
        [TestCase("Oh my goodness!", ExpectedResult = "Oh my goodness!")]
        [TestCase("I just cannot believe it.", ExpectedResult = "I just cannot believe it.")]
        [TestCase("I just!!! can!!! not!!! believe!!! it!!!", ExpectedResult = "I just!!! can!!! not!!! believe!!! it!")]
        [TestCase("That's a ton!! of cheese!!!!", ExpectedResult = "That's a ton!! of cheese!")]
        public string should_return_string_no_yelling(string input)
        {
            return StringHelpers.no_yelling(input);
        }

        [Test]
        [TestCase("banana", ExpectedResult = "ananab")]
        public string should_return_reverse_string(string input)
        {
            return StringHelpers.reverse_string(input);
        }

        [Test]
        [TestCase("karaca", ExpectedResult = "0c0r0kaca")]
        [TestCase("burak", ExpectedResult = "k0r3baca")]
        [TestCase("alpaca", ExpectedResult = "0c0pl0aca")]
        [TestCase("banana", ExpectedResult = "0n0n0baca")]
        [TestCase("hello", ExpectedResult = "2ll1haca")]
        public string should_return_encripted_string(string input)
        {
            return StringHelpers.encrpyt_using_karaca_algo(input);
        }

        [Test]
        [TestCase("The quick brown fox!", ExpectedResult = "The quick brown fox")]
        [TestCase("%fd76$fd(-)6GvKlO.", ExpectedResult = "fd76fd-6GvKlO")]
        [TestCase("D0n$c sed 0di0 du1", ExpectedResult = "D0nc sed 0di0 du1")]
        [TestCase("cat_pic.jpeg", ExpectedResult = "cat_picjpeg")]
        [TestCase("519-555-8093", ExpectedResult = "519-555-8093")]
        [TestCase("h-d+=rf[]_{}<>.,`~!@#$%^&*(|)", ExpectedResult = "h-drf_")]
        [TestCase("Etiam#!!!!!,,, [`po%rta ~sem!] {male*su-ada} (ma*gna) mo^llis... eui$smod???", ExpectedResult = "Etiam porta sem malesu-ada magna mollis euismod")]
        public string should_return_string_without_special_chars(string input)
        {
            return StringHelpers.remove_special_characters(input);
        }

        [Test]
        [TestCase("@edabit.com", ExpectedResult = false)]
        [TestCase("@edabit", ExpectedResult = false)]
        [TestCase("matt@edabit.com", ExpectedResult = true)]
        [TestCase("", ExpectedResult = false)]
        [TestCase("hello.gmail@com", ExpectedResult = false)]
        [TestCase("bill.gates@microsoft.com", ExpectedResult = true)]
        [TestCase("hello@email", ExpectedResult = false)]
        [TestCase("%^%$#%^%", ExpectedResult = false)]
        [TestCase("www.email.com", ExpectedResult = false)]
        [TestCase("email", ExpectedResult = false)]
        public bool should_return_true_if_email_is_valid(string input)
        {
            return StringHelpers.Is_valid_email(input);
        }

        [Test]
        [TestCase(null, ExpectedResult = null)]
        [TestCase("", ExpectedResult = "")]
        [TestCase("I am a title", ExpectedResult = "I Am A Title")]
        [TestCase("I AM A TITLE", ExpectedResult = "I AM A TITLE")]
        [TestCase("i aM a tITLE", ExpectedResult = "I AM A TITLE")]
        [TestCase("the first letter of every word is capitalized", ExpectedResult = "The First Letter Of Every Word Is Capitalized")]
        [TestCase("I Like Pizza", ExpectedResult = "I Like Pizza")]
        [TestCase("Don't count your ChiCKens BeFore They HatCh", ExpectedResult = "Don't Count Your ChiCKens BeFore They HatCh")]
        [TestCase("All generalizations are false, including this one", ExpectedResult = "All Generalizations Are False, Including This One")]
        [TestCase("Me and my wife lived happily for twenty years and then we met.", ExpectedResult = "Me And My Wife Lived Happily For Twenty Years And Then We Met.")]
        [TestCase("There are no stupid questions, just stupid people.", ExpectedResult = "There Are No Stupid Questions, Just Stupid People.")]
        [TestCase("1f you c4n r34d 7h15, you r34lly n33d 2 g37 l41d", ExpectedResult = "1f You C4n R34d 7h15, You R34lly N33d 2 G37 L41d")]
        public string should_return_capitalized_first_letters(string input)
        {
            return StringHelpers.capitalize_first_letter(input);
        }

        [Test]
        [TestCase("abcd", ExpectedResult = "abbcccdddd")]
        public string should_return_compounded_letters(string input)
        {
            return StringHelpers.compound_letters(input);
        }

        [Test]
        [TestCase("abcd", ExpectedResult = "A-Bb-Ccc-Dddd")]
        public string should_return_dash_separated_words_with_capitalised_first_letters(string input)
        {
            return StringHelpers.compunding_and_capitalising_dash_separated_letters(input);
        }

        [Test]
        [TestCase("Reverse", ExpectedResult = "esreveR")]
        [TestCase("This is a typical sentence.", ExpectedResult = "This is a lacipyt .ecnetnes")]
        [TestCase("The dog is big.", ExpectedResult = "The dog is big.")]
        [TestCase("Reverse the order of every word greater than or equal to five characters.", ExpectedResult = "esreveR the redro of yreve word retaerg than or lauqe to five .sretcarahc")]
        [TestCase("Lets all be unique together until we realise we are all the same.", ExpectedResult = "Lets all be euqinu rehtegot litnu we esilaer we are all the .emas")]
        [TestCase("The old apple revels in its authority.", ExpectedResult = "The old elppa slever in its .ytirohtua")]
        [TestCase("The shooter says goodbye to his love.", ExpectedResult = "The retoohs says eybdoog to his .evol")]
        [TestCase("Please wait outside of the house.", ExpectedResult = "esaelP wait edistuo of the .esuoh")]
        [TestCase("Two seats were vacant.", ExpectedResult = "Two staes were .tnacav")]
        [TestCase("Sixty-Four comes asking for bread.", ExpectedResult = "ruoF-ytxiS semoc gniksa for .daerb")]
        public static string should_return_string_with_words_reversed_if_length_more_than_five(string input)
        {
            return StringHelpers.reverse_if_greater_than_five(input);
        }

        [Test]
        [TestCase(null, ExpectedResult = "Incompatible.")]
        [TestCase("Cat, dog, and mouse.", ExpectedResult = ".at, dog, and mouseC")]
        [TestCase("Anna, Banana", ExpectedResult = "anna, BananA")]
        [TestCase("[]", ExpectedResult = "][")]
        [TestCase("", ExpectedResult = "Incompatible.")]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = "Incompatible.")]
        [TestCase("dfdkf49824fdfdfjhd", ExpectedResult = "Two's a pair.")]
        [TestCase("#343473847#", ExpectedResult = "Two's a pair.")]
        public string should_return_switcharoo(object input)
        {
            return StringHelpers.switcharoo(input);
        }


        [Test]
        [TestCase("cristian", "Cristina", ExpectedResult = true)]
        [TestCase("Dave Barry", "Ray Adverb", ExpectedResult = true)]
        [TestCase("Nope", "Note", ExpectedResult = false)]
        [TestCase("Apple", "Appeal", ExpectedResult = false)]
        [TestCase("Dormitory", "Dirty room", ExpectedResult = true)]
        [TestCase("Listen", "Sielnt", ExpectedResult = true)]
        [TestCase("kuch bhi", "hanjiyuy", ExpectedResult = false)]
        public static bool should_return_true_if_anagram(string str1, string str2)
        {
            return StringHelpers.is_anagrams(str1, str2);
        }

        [Test]
        [TestCase("alternating caps", ExpectedResult = "AlTeRnAtInG cApS")]
        [TestCase("What is your name?", ExpectedResult = "WhAt Is YoUr NaMe?")]
        [TestCase("Lorem ipsum dolor sit amet consectetur adipisicing elit.", ExpectedResult = "LoReM iPsUm DoLoR sIt AmEt CoNsEcTeTuR aDiPiSiCiNg ElIt.")]
        [TestCase("OMG this website is awesome!", ExpectedResult = "OmG tHiS wEbSiTe Is AwEsOmE!")]
        [TestCase("The quick brown fox jumps over the lazy dog", ExpectedResult = "ThE qUiCk BrOwN fOx JuMpS oVeR tHe LaZy DoG")]
        [TestCase("The intent is to provide players with a sense of pride and accomplishment for unlocking different heroes.", ExpectedResult = "ThE iNtEnT iS tO pRoViDe PlAyErS wItH a SeNsE oF pRiDe AnD aCcOmPlIsHmEnT fOr UnLoCkInG dIfFeReNt HeRoEs.")]
        public string should_return_alternating_caps(string input)
        {
            return StringHelpers.alternating_caps(input);
        }

        [Test]
        // [TestCase(new string[] { "seema", "gita" }, ExpectedResult = new string[] { "Seema", "Gita" })]
        public void should_return_capitalized_names()
        {
            var output = StringHelpers.caps_names(new string[] { "seema", "gita" });
            string[] expected_output = new string[] { "Seema", "Gita" };
            Assert.That(expected_output, Is.EqualTo(output));
        }

        [Test]
        [TestCase("Marta appreciated deep perpendicular right trapezoids", ExpectedResult = true)]
        [TestCase("Someone is outside the doorway", ExpectedResult = false)]
        [TestCase("She eats super righteously", ExpectedResult = true)]
        [TestCase("Ben naps so often", ExpectedResult = true)]
        [TestCase("Cute triangles are cute", ExpectedResult = false)]
        [TestCase("Mad dislikes sharp pointy yoyos", ExpectedResult = true)]
        [TestCase("Rita asks Sam mean numbered dilemmas", ExpectedResult = true)]
        [TestCase("Marigold daffodils streaming happily.", ExpectedResult = false)]
        [TestCase("Simply wonderful laughing.", ExpectedResult = false)]
        public bool should_return_true_if_smooth(string sentence)
        {
            return StringHelpers.is_smooth(sentence);
        }

        [Test]
        [TestCase(123, ExpectedResult = "321123")]
        [TestCase(123456789, ExpectedResult = "987654321123456789")]
        public string should_return_reversed_and_not(int input)
        {
            return StringHelpers.reverse_and_not(input);
        }

        [Test]
        [TestCase(null, ExpectedResult = false)]
        [TestCase("#CD5C5C", ExpectedResult = true)]
        [TestCase("#EAECEE", ExpectedResult = true)]
        [TestCase("#eaecee", ExpectedResult = true)]
        [TestCase("#CD5C58C", ExpectedResult = false, Description = "Length exceeds 6.")]
        [TestCase("#CD5C5Z", ExpectedResult = false, Description = "Alphabetic characters not in A-F.")]
        [TestCase("#CD5C&C", ExpectedResult = false, Description = "Unacceptable character.")]
        [TestCase("CD5C5C", ExpectedResult = false, Description = "Does not start with #.")]
        [TestCase("#123CCCD", ExpectedResult = false, Description = "Length exceeds 6.")]
        [TestCase("#123456", ExpectedResult = true)]
        [TestCase("#987654", ExpectedResult = true)]
        [TestCase("#9876543", ExpectedResult = false, Description = "Length exceeds 6.")]
        [TestCase("#CCCCCC", ExpectedResult = true)]
        [TestCase("#ZCCZCC", ExpectedResult = false, Description = "Not acceptable alphabetic characters.")]
        [TestCase("#Z88Z99", ExpectedResult = false, Description = "Not acceptable alphabetic characters.")]
        [TestCase("#Z88!99", ExpectedResult = false, Description = "Unacceptable character.")]
        public bool should_return_true_if_valid_hex_code(string str)
        {
            return StringHelpers.is_valid_hex_code(str);
        }

        [Test]
        [TestCase("(a*(b-c)     )", ExpectedResult = true)]
        [TestCase(" ) (a-b-45/7*(a-34))", ExpectedResult = false)]
        [TestCase("sin(90       )+      cos1)", ExpectedResult = false)]
        [TestCase(" (...). .%_.(.... )", ExpectedResult = true)]
        [TestCase(" (...)...(..(...).... )  ", ExpectedResult = true)]
        [TestCase(") .. .() (        ).. . (", ExpectedResult = false)]
        [TestCase(")))(((", ExpectedResult = false)]
        [TestCase("  (...).!.)...(", ExpectedResult = false)]
        [TestCase("a+b", ExpectedResult = true)]
        [TestCase("", ExpectedResult = true)]
        [TestCase("(a+f).`!£=.)...) ", ExpectedResult = false)]
        public  bool should_return_true_if_brackets_are_in_right_order(string n)
        {
            return StringHelpers.check_brackets(n);
        }
    }
}
