using NUnit.Framework;
using static AcronymTDD.Acronym;

namespace Tests
{
    public class AcronymTests
    {

        [Test]
        [TestCase("", "", TestName = "Acronym_EmptyString", Description = "Acronym of empty string is empty string")]
        [TestCase("Don't repeat yourself", "DRY", TestName = "Acronym_CommonSentence", Description = "Acronym of Don't repeat yourself is DRY")]
        [TestCase("Rythm and blues", "R&B", TestName = "Acronym_SentenceContainsAND", Description = "AND in acronym is replaced by &")]
        [TestCase("Complementary metal-oxide semiconductor", "CMOS", TestName = "Acronym_CompoundWord", Description = "Compound word is splited in acronym")]
        [TestCase("National Association of Securities Dealers Automated Quotations", "NASDAQ", TestName = "Acronym_IgnorePrepositions", Description = "Prepositions in sentence are ignored")]
        public void AcronymTest(string sentence, string acronym)
        {
            Assert.AreEqual(GetAccronym(sentence), acronym);
        }
    }
}